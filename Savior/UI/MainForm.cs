using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Savior.Models;
using Savior.Services;

namespace Savior.UI
{
    public partial class MainForm : Form
    {
        private HardwareMonitorService _hardwareMonitor;
        private SystemInfoService _systemInfo;
        private BsodEventService _bsodService;
        private ProcessScannerService _processScanner;

        public MainForm()
        {
            InitializeComponent();

            if (IsInDesignMode())
                return;

            // Configuration du ListView BSOD
            listViewBSOD.Columns.Add("Date", 150);
            listViewBSOD.Columns.Add("Source", 100);
            listViewBSOD.Columns.Add("ID", 70);
            listViewBSOD.Columns.Add("Message", 400);

            // Configuration du ListView Virus
            listViewVirus.Columns.Add("Nom", 150);
            listViewVirus.Columns.Add("PID", 70);
            listViewVirus.Columns.Add("Mémoire (MB)", 100);
            listViewVirus.Columns.Add("Signé", 70);
            listViewVirus.Columns.Add("Chemin", 400);

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (IsInDesignMode())
                return;

            InitializeServices();
            LoadSystemInfo();
            RefreshTemperatures();

            var timer = new System.Windows.Forms.Timer
            {
                Interval = 5000
            };
            timer.Tick += (s, ev) => RefreshTemperatures();
            timer.Start();
        }

        private void InitializeServices()
        {
            if (IsInDesignMode())
                return;

            _hardwareMonitor = new HardwareMonitorService();
            _systemInfo = new SystemInfoService();
            _bsodService = new BsodEventService();
            _processScanner = new ProcessScannerService();
        }

        private void LoadSystemInfo()
        {
            if (IsInDesignMode())
                return;

            var cpu = _systemInfo.GetCpuInfo();
            labelCPUName.Text = "Processeur : " + cpu.Name;
            labelCPUCores.Text = $"Cœurs logiques : {cpu.LogicalCores} | Cœurs physiques : {cpu.PhysicalCores}";

            labelRAM.Text = "RAM installée : " + _systemInfo.GetRamInfo() + " Go";
            labelDisk.Text = "Disques :\r\n" + _systemInfo.GetDiskInfo();
            labelGPU.Text = "Carte graphique : " + _systemInfo.GetGpuInfo();
        }

        private void RefreshTemperatures()
        {
            if (IsInDesignMode())
                return;

            var gpuTemps = _hardwareMonitor.GetGpuTemperatures();
            labelGpuTemp.Text = gpuTemps.Count > 0
                ? string.Join("  ", gpuTemps.Select(t => $"{t.Key}: {t.Value} °C"))
                : "Température GPU non disponible";

            var cpuTemps = _hardwareMonitor.GetCpuTemperatures();
            labelCpuTemp.Text = cpuTemps.Count > 0
                ? string.Join("  ", cpuTemps.Select(t => $"{t.Key}: {t.Value} °C"))
                : "Température CPU non disponible";
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = true;
            panelBSOD.Visible = false;
            panelVirus.Visible = false;
            panelSoftware.Visible = false;
        }

        private void BtnBSOD_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = true;
            panelVirus.Visible = false;
            panelSoftware.Visible = false;

            listViewBSOD.Items.Clear();
            var events = _bsodService.GetRecentBsodEvents();

            foreach (var ev in events)
            {
                SafeAddItem(listViewBSOD, new ListViewItem(new[]
                {
                    ev.Date,
                    ev.Source,
                    ev.EventId,
                    ev.ShortMessage
                }));
            }

            if (events.Count == 0)
            {
                var item = new ListViewItem(new[] { "", "", "", "Aucun événement BSOD trouvé" });
                SafeAddItem(listViewBSOD, item);
            }
        }

        private void BtnVirus_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = false;
            panelVirus.Visible = true;
            panelSoftware.Visible = false;

            listViewVirus.Items.Clear();
            var processes = _processScanner.ScanProcesses();

            foreach (var proc in processes)
            {
                var item = new ListViewItem(proc.Name);
                item.SubItems.Add(proc.Pid.ToString());
                item.SubItems.Add(proc.MemoryMB.ToString());
                item.SubItems.Add(proc.IsSigned ? "Oui" : "Non");
                item.SubItems.Add(proc.Path);
                item.Tag = proc;
                SafeAddItem(listViewVirus, item);
            }
        }

        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = false;
            panelVirus.Visible = false;
            panelSoftware.Visible = true;
        }

        private void BtnKillProcess_Click(object sender, EventArgs e)
        {
            if (listViewVirus.SelectedItems.Count > 0)
            {
                var selected = listViewVirus.SelectedItems[0];
                if (selected.Tag is ProcessInfo proc)
                {
                    _processScanner.KillProcess(proc.Pid);
                    MessageBox.Show($"Processus {proc.Name} (PID: {proc.Pid}) terminé.");
                    BtnVirus_Click(null, null); // Refresh
                }
            }
        }

        private void BtnInstallSoftware_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxSoftware.CheckedItems)
            {
                string softwareName = item.ToString().ToLower().Replace(" ", "");
                InstallSoftware(softwareName);
            }
        }

        private void InstallSoftware(string softwareName)
        {
            try
            {
                // Vérifier si Chocolatey est installé
                if (!IsChocolateyInstalled())
                {
                    var result = MessageBox.Show("Chocolatey n'est pas installé. Voulez-vous l'installer maintenant ?", "Installation de Chocolatey", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (!IsRunningAsAdmin())
                        {
                            RestartAsAdmin();
                            return;
                        }
                        InstallChocolatey();
                    }
                    else
                    {
                        return;
                    }
                }

                // Vérifier si le logiciel est déjà installé
                if (IsSoftwareInstalled(softwareName))
                {
                    MessageBox.Show($"{softwareName} est déjà installé.");
                    return;
                }

                // Installer le logiciel via Chocolatey
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-Command \"choco install {softwareName} -y\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                    MessageBox.Show($"{softwareName} a été installé avec succès.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'installation de {softwareName}: {ex.Message}");
            }
        }

        private bool IsChocolateyInstalled()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "choco",
                    Arguments = "--version",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                    return process.ExitCode == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool IsSoftwareInstalled(string softwareName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "choco",
                    Arguments = $"list --local-only --exact {softwareName}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                    return process.ExitCode == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void InstallChocolatey()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Chocolatey a été installé avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'installation de Chocolatey.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'installation de Chocolatey: {ex.Message}");
            }
        }

        private bool IsRunningAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void RestartAsAdmin()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(psi);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du redémarrage en tant qu'administrateur: {ex.Message}");
            }
        }

        private void SafeAddItem(ListView listView, ListViewItem item)
        {
            if (listView.InvokeRequired)
                listView.Invoke(() => listView.Items.Add(item));
            else
                listView.Items.Add(item);
        }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
        }
    }
}
