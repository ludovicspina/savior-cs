using LibreHardwareMonitor.Hardware;
using System.Collections.Generic;

namespace MaintenanceToolGUI.Services
{
    public class HardwareMonitorService
    {
        private readonly Computer computer;

        public HardwareMonitorService()
        {
            computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true
            };
            computer.Open();
        }

        public Dictionary<string, float?> GetCpuTemperatures()
        {
            var temps = new Dictionary<string, float?>();
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                        {
                            temps[sensor.Name] = sensor.Value;
                        }
                    }
                }
            }
            return temps;
        }

        public Dictionary<string, float?> GetGpuTemperatures()
        {
            var temps = new Dictionary<string, float?>();
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                        {
                            temps[sensor.Name] = sensor.Value;
                        }
                    }
                }
            }
            return temps;
        }
    }
}