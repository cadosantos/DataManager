using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManager
{
    public class DeviceManager
    {
        private readonly IDeviceFactory _deviceFactory;
        public DeviceManager(IDeviceFactory deviceFactory)
        {
            _deviceFactory = deviceFactory;
        }

        public List<IDevice> GenerateData(int count)
        {
            List<IDevice> results = new List<IDevice>();

            const string deviceNamePrefix = "device";
            var sequencialNumber = 0;
            for (int i = 0; i < count; i++)
            {
                results.Add(_deviceFactory.CreateAnalogDevice($"{deviceNamePrefix} {sequencialNumber++}"));
                results.Add(_deviceFactory.CreateDigitalDeviceGen1($"{deviceNamePrefix} {sequencialNumber++}", DeviceVariantEnum.A));
                results.Add(_deviceFactory.CreateDigitalDeviceGen1($"{deviceNamePrefix} {sequencialNumber++}", DeviceVariantEnum.B));
                results.Add(_deviceFactory.CreateDigitalDeviceGen1($"{deviceNamePrefix} {sequencialNumber++}", DeviceVariantEnum.D));
                results.Add(_deviceFactory.CreateDigitalDeviceGen2($"{deviceNamePrefix} {sequencialNumber++}"));
            }

            return results;
        }

        public void ShowData(List<IDevice> devices)
        {
            foreach (var device in devices)
            {
                device.PrintInfo();
            }
        }
    }
}
