using System;
using System.ComponentModel;
using System.Linq;
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
        }

        private void BtnBSOD_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = true;
            panelVirus.Visible = false;

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
