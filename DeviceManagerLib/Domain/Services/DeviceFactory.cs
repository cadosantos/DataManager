using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model.Devices;

namespace DeviceManagerLib.Domain.Services
{
    public class DeviceFactory : IDeviceFactory
    {
        private readonly IDeviceIdService _deviceIdService;
        public DeviceFactory(IDeviceIdService deviceIdService)
        {
            _deviceIdService = deviceIdService;
        }

        public IDevice CreateDevice(int id, string name)
        {
            if (_deviceIdService.IsAnalogDevice(id))
            {
                return new AnalogDevice(id, name);
            }
            
            if (_deviceIdService.IsDigitalDevice(id))
            {
                return new DigitalDevice(id, name);
            }

            throw new ArgumentException(ExceptionMessagesHelper.Instance.UnknownDeviceType(id));
        }
    }
}
