using System;
using System.Management;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;
using System.Diagnostics.Eventing.Reader;


namespace MaintenanceToolGUI
{
    public partial class Form1 : Form
    {
        private Computer computer;

        public Form1()
        {
            InitializeComponent();
            InitHardwareMonitor();
            LoadSystemInfo();
            RefreshTemperatures();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) => RefreshTemperatures();
            timer.Start();
        }

        private void InitHardwareMonitor()
        {
            computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true
            };
            computer.Open();
        }

        private void LoadSystemInfo()
        {
            // CPU
            var cpuSearcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (var item in cpuSearcher.Get())
            {
                labelCPUName.Text = "Processeur : " + item["Name"];
                labelCPUCores.Text = "Cœurs logiques : " + item["NumberOfLogicalProcessors"] +
                                     " | Cœurs physiques : " + item["NumberOfCores"];
            }

            // RAM
            var ramSearcher = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            foreach (var item in ramSearcher.Get())
            {
                double ram = Math.Round(Convert.ToDouble(item["TotalPhysicalMemory"]) / (1024 * 1024 * 1024), 2);
                labelRAM.Text = "RAM installée : " + ram + " Go";
            }

            // Disques
            string diskInfos = "";
            var diskSearcher = new ManagementObjectSearcher("select * from Win32_LogicalDisk where DriveType=3");
            foreach (var item in diskSearcher.Get())
            {
                string name = item["DeviceID"]?.ToString();
                double total = Math.Round(Convert.ToDouble(item["Size"]) / (1024 * 1024 * 1024), 2);
                double free = Math.Round(Convert.ToDouble(item["FreeSpace"]) / (1024 * 1024 * 1024), 2);
                diskInfos += $"[{name}] {free} Go libres / {total} Go\r\n";
            }
            labelDisk.Text = "Disques :\r\n" + diskInfos;

            // GPU
            var gpuSearcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (var item in gpuSearcher.Get())
            {
                double mem = Math.Round(Convert.ToDouble(item["AdapterRAM"]) / (1024 * 1024 * 1024), 2);
                labelGPU.Text = "Carte graphique : " + item["Name"] + $" ({mem} Go)";
            }
        }

        private void RefreshTemperatures()
        {
            // GPU
            string gpuTemp = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            gpuTemp += $"{sensor.Name}: {sensor.Value} °C  ";
                        }
                    }
                }
            }
            labelGpuTemp.Text = gpuTemp != "" ? gpuTemp : "Température GPU non disponible";

            // CPU
            string cpuTemp = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (sensor.Value.HasValue && sensor.Value.Value > 0)
                                cpuTemp += $"{sensor.Name}: {sensor.Value} °C  ";
                        }
                    }
                }
            }
            labelCpuTemp.Text = cpuTemp != "" ? cpuTemp : "Température CPU non disponible";
        }
        
        private void LoadBsodEvents()
        {
            listViewBSOD.Items.Clear();

            string query = "*[System[(Level=1 or Level=2) and (EventID=41 or EventID=1001)]]";
            EventLogQuery logQuery = new EventLogQuery("System", PathType.LogName, query);

            try
            {
                using (EventLogReader logReader = new EventLogReader(logQuery))
                {
                    EventRecord eventInstance;
                    int maxEvents = 20;
                    int count = 0;

                    while ((eventInstance = logReader.ReadEvent()) != null && count < maxEvents)
                    {
                        string date = eventInstance.TimeCreated?.ToString("g") ?? "N/A";
                        string source = eventInstance.ProviderName ?? "Inconnu";
                        string id = eventInstance.Id.ToString();
                        string msg = eventInstance.FormatDescription();

                        listViewBSOD.Items.Add(new ListViewItem(new[] { date, source, id, msg.Length > 80 ? msg.Substring(0, 80) + "..." : msg }));

                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lecture des BSOD : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadBsodEvents(); // <== Charge les derniers BSOD à chaque clic
        }

    }
}
