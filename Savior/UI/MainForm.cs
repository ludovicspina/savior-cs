using System;
using System.Windows.Forms;
using MaintenanceToolGUI.Services;

namespace Savior.UI
{
    public partial class MainForm : Form
    {
        private readonly HardwareMonitorService _hardwareMonitor;
        private readonly SystemInfoService _systemInfo;
        private readonly BsodEventService _bsodService;

        public MainForm()
        {
            InitializeComponent();

            _hardwareMonitor = new HardwareMonitorService();
            _systemInfo = new SystemInfoService();
            _bsodService = new BsodEventService();

            LoadSystemInfo();
            RefreshTemperatures();

            var timer = new Timer
            {
                Interval = 5000
            };
            timer.Tick += (s, e) => RefreshTemperatures();
            timer.Start();
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
            panelGeneral.Visible = true;
            panelBSOD.Visible = false;
        }

        private void BtnBSOD_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = false;
            panelBSOD.Visible = true;

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
    }
}
