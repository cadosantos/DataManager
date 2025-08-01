using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model.Devices;

namespace DeviceManagerLib.Domain.Services
{
    public class DeviceFactory : IDeviceFactory
    {
        private readonly IDeviceTypeIdService _deviceTypeIdService;
        private readonly IDigitalDeviceStrategiesFactory _digitalDeviceStrategiesFactory;
        public DeviceFactory(IDeviceTypeIdService deviceTypeIdService, IDigitalDeviceStrategiesFactory digitalDeviceStrategiesFactory)
        {
            _deviceTypeIdService = deviceTypeIdService;
            _digitalDeviceStrategiesFactory = digitalDeviceStrategiesFactory;
        }

        public IDevice CreateDevice(int id, string name)
        {
            if (_deviceTypeIdService.IsAnalogDevice(id))
            {
                return new AnalogDevice(id, name);
            }
            
            if (_deviceTypeIdService.IsDigitalDevice(id))
            {
                var digitalDeviceStrategies = _digitalDeviceStrategiesFactory.GetStrategies(id);
                return new DigitalDevice(id, name, digitalDeviceStrategies.DescriptionStrategy, digitalDeviceStrategies.StatusStrategy);
            }

            throw new ArgumentException(ExceptionMessagesHelper.Instance.UnknownDeviceType(id));
        }
    }
}
