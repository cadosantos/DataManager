using DeviceManagerLib.Domain.Model;

namespace DeviceManager
{
    public class DeviceManager
    {
        public void ShowData(List<Device> devices)
        {
            foreach (var device in devices)
            {
                device.PrintInfo();
            }
        }

        public List<Device> GenerateData(int count)
        {
            List<Device> result = new List<Device>();

            for (int current = 0; current < count; current++)
            {
                string deviceName = $"device {current}";
                string description = $"this is dev no {current}";

                var device = new Device(deviceName, description);
                result.Add(device);
            }

            return result;
        }
    }
}
