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

            // Ajouter cette ligne ici pour être sûr qu'on ne déclenche rien au design
            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                this.Load += MainForm_Load;
        }


        private void MainForm_Load(object? sender, EventArgs e)
        {
            // Assurez-vous que l'application n'est pas en mode design
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode)
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
            _hardwareMonitor = new HardwareMonitorService();
            _systemInfo = new SystemInfoService();
            _bsodService = new BsodEventService();
            _processScanner = new ProcessScannerService();
        }

        private void LoadSystemInfo()
        {
            var cpu = _systemInfo.GetCpuInfo();
            labelCPUName.Text = "Processeur : " + cpu.Name;
            labelCPUCores.Text = $"Cœurs logiques : {cpu.LogicalCores} | Cœurs physiques : {cpu.PhysicalCores}";

            labelRAM.Text = "RAM installée : " + _systemInfo.GetRamInfo() + " Go";
            labelDisk.Text = "Disques :\r\n" + _systemInfo.GetDiskInfo();
            labelGPU.Text = "Carte graphique : " + _systemInfo.GetGpuInfo();
        }

        private void RefreshTemperatures()
        {
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
            if (panelGeneral.Parent != null)
            {
                panelGeneral.Visible = true;
            }
            if (panelBSOD.Parent != null)
            {
                panelBSOD.Visible = false;
            }
            if (panelVirus.Parent != null)
            {
                panelVirus.Visible = false;
            }

            panelGeneral.Visible = true;
            panelBSOD.Visible = false;
            panelVirus.Visible = false;
        }

        private void BtnBSOD_Click(object sender, EventArgs e)
        {
            if (panelGeneral.Parent != null)
            {
                panelGeneral.Visible = true;
            }
            if (panelBSOD.Parent != null)
            {
                panelBSOD.Visible = false;
            }
            if (panelVirus.Parent != null)
            {
                panelVirus.Visible = false;
            }

            panelGeneral.Visible = false;
            panelBSOD.Visible = true;
            panelVirus.Visible = false;

            listViewBSOD.Items.Clear();
            var events = _bsodService.GetRecentBsodEvents();

            foreach (var ev in events)
            {
                listViewBSOD.Items.Add(new ListViewItem(new[]
                {
                    ev.Date,
                    ev.Source,
                    ev.EventId,
                    ev.ShortMessage
                }));
            }
        }

        private void BtnVirus_Click(object sender, EventArgs e)
        {
            if (panelGeneral.Parent != null)
            {
                panelGeneral.Visible = true;
            }
            if (panelBSOD.Parent != null)
            {
                panelBSOD.Visible = false;
            }
            if (panelVirus.Parent != null)
            {
                panelVirus.Visible = false;
            }

            panelGeneral.Visible = false;
            panelBSOD.Visible = false;
            panelVirus.Visible = true;

            listViewVirus.Items.Clear();
            var processes = _processScanner.ScanProcesses();

            foreach (var proc in processes)
            {
                if (proc.IsSuspicious)
                {
                    var item = new ListViewItem(proc.Name);
                    item.SubItems.Add(proc.Pid.ToString());
                    item.SubItems.Add(proc.MemoryMB.ToString());
                    item.SubItems.Add(proc.IsSigned ? "Oui" : "Non");
                    item.SubItems.Add(proc.Path);
                    item.Tag = proc;
                    listViewVirus.Items.Add(item);
                }
            }
        }

        private void BtnKillProcess_Click(object sender, EventArgs e)
        {
            if (listViewVirus.SelectedItems.Count > 0)
            {
                var selected = listViewVirus.SelectedItems[0];
                if (selected.Tag is Process proc)
                {
                    _processScanner.KillProcess(proc.Pid);
                    MessageBox.Show($"Processus {proc.Name} (PID: {proc.Pid}) terminé.");
                    BtnVirus_Click(null, null); // Refresh
                }
            }
        }
    }
}