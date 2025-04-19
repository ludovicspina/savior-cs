using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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

            var timer = new System.Windows.Forms.Timer { Interval = 5000 };
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
            panelInstallation.Visible = false;
            panelWindows.Visible = false;
        }

        private void BtnBSOD_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = true;
            panelVirus.Visible = false;
            panelInstallation.Visible = false;
            panelWindows.Visible = false;

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
            panelInstallation.Visible = false;
            panelWindows.Visible = false;

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

        private void BtnInstallation_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = false;
            panelVirus.Visible = false;
            panelInstallation.Visible = true;
            panelWindows.Visible = false;
        }

        private void BtnWindows_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = false;
            panelVirus.Visible = false;
            panelInstallation.Visible = false;
            panelWindows.Visible = true;

            CheckWindowsActivationStatus();
        }

private void CheckWindowsActivationStatus()
{
    try
    {
        string version = Environment.OSVersion.VersionString;
        string activationStatus = "❓ Impossible de déterminer l’état d’activation";
        string licenseType = "❓ Inconnu";
        string productKeyLast5 = "❓";

        // PowerShell pour vérifier l’activation
        var checkActivation = new ProcessStartInfo
        {
            FileName = "powershell",
            Arguments = "-Command \"(Get-CimInstance -Class SoftwareLicensingProduct | Where-Object { $_.PartialProductKey } | Select-Object -First 1).LicenseStatus\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        string result;
        using (var proc = Process.Start(checkActivation))
        {
            result = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
        }

        result = result.Trim();
        switch (result)
        {
            case "1":
                activationStatus = "✅ Windows est activé.";
                break;
            case "0":
                activationStatus = "❌ Windows n’est pas activé.";
                break;
            default:
                activationStatus = "❓ Statut inconnu.";
                break;
        }

        // Récupérer le type de licence + les 5 derniers caractères de la clé
        var licenseInfo = new ProcessStartInfo
        {
            FileName = "powershell",
            Arguments = "-Command \"Get-CimInstance -Class SoftwareLicensingProduct | Where-Object { $_.PartialProductKey } | Select-Object -First 1 LicenseFamily,PartialProductKey\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        string licenseOutput;
        using (var proc = Process.Start(licenseInfo))
        {
            licenseOutput = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
        }

        foreach (var line in licenseOutput.Split('\n'))
        {
            if (line.Contains("OEM"))
                licenseType = "OEM";
            else if (line.Contains("Retail"))
                licenseType = "Retail";
            else if (line.Contains("Volume"))
                licenseType = "Volume";

            if (line.Trim().Length == 5)
                productKeyLast5 = line.Trim();
        }

        labelWindowsStatus.Text =
            $"{activationStatus}\n" +
            $"Version : {version}\n" +
            $"Type de licence : {licenseType}\n" +
            $"Clé produit : *****-*****-*****-*****-{productKeyLast5}";
    }
    catch (Exception ex)
    {
        labelWindowsStatus.Text = $"❌ Erreur lors de la vérification : {ex.Message}";
    }
}



        private void BtnActivateWindows_Click(object sender, EventArgs e)
        {
            try
            {
                // Chemin relatif vers le script MAS_AIO.cmd
                string masPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "MAS_AIO.cmd");

                // Vérifier si le fichier existe
                if (!File.Exists(masPath))
                {
                    MessageBox.Show("Le fichier MAS_AIO.cmd est introuvable. Chemin : " + masPath);
                    return;
                }

                // Configurer le processus pour exécuter le script
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = masPath,
                    UseShellExecute = true,
                    Verb = "runas" // Exécuter en tant qu'administrateur
                };

                // Exécuter le processus
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
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
                    BtnVirus_Click(null, null);
                }
            }
        }

        private void BtnOpenPowerShell_Click(object sender, EventArgs e)
        {
            try
            {
                string arguments = "-NoExit -Command \"";

                if (checkBoxVLC.Checked)
                    arguments +=
                        "winget install --id VideoLAN.VLC -e --silent --accept-package-agreements --accept-source-agreements;\n";
                if (checkBox7ZIP.Checked)
                    arguments += "winget install --id 7zip.7zip -e; ";
                if (checkBoxChrome.Checked)
                    arguments += "winget install --id Google.Chrome -e; ";
                if (checkBoxAdobeReader.Checked)
                    arguments += "winget install --id Adobe.Acrobat.Reader.64-bit -e; ";
                if (checkBoxSublimeText.Checked)
                    arguments += "winget install --id SublimeHQ.SublimeText -e; ";
                if (checkBoxLibreOffice.Checked)
                    arguments += "winget install --id TheDocumentFoundation.LibreOffice -e; ";
                if (checkBoxKaspersky.Checked)
                    arguments += "Start-Process 'https://www.kaspersky.fr/downloads/standard'; ";
                if (checkBoxBitdefender.Checked)
                    arguments += "winget install --id Bitdefender.Bitdefender -e; ";
                if (checkBoxSteam.Checked)
                    arguments += "winget install --id Valve.Steam -e; ";
                if (checkBoxDiscord.Checked)
                    arguments += "winget install --id Discord.Discord -e; ";

                arguments = arguments.TrimEnd(' ', ';');

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = arguments,
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur PowerShell: {ex.Message}");
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