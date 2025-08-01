using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManager
{
    public class DeviceManager
    {
        private readonly IDeviceFactory _deviceFactory;
        private readonly IDeviceTypeIdService _deviceTypeIdService;
        public DeviceManager(IDeviceFactory deviceFactory, IDeviceTypeIdService deviceTypeIdService)
        {
            _deviceFactory = deviceFactory;
            _deviceTypeIdService = deviceTypeIdService;
        }

        public List<IDevice> GenerateData(int count)
        {
            List<IDevice> result = new List<IDevice>();

            int index = 0;
            while (index < count)
            {
                foreach (var deviceType in EnumsHelper.Instance.GetEnums<DeviceTypeEnum>())
                {
                    string deviceName = $"device {index}";
                    IDevice device = _deviceFactory.CreateDevice(_deviceTypeIdService.GetNextId(deviceType), deviceName);
                    result.Add(device);

                    index++;

                    if (index >= count)
                        break;
                }
            }

            return result;
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
