using DeviceManagerLib.Domain.Enums;

namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDeviceFactory
    {
        public IDevice CreateAnalogDevice(string name);
        public IDevice CreateDigitalDeviceGen1(string name, DeviceVariantEnum deviceVariant);
        public IDevice CreateDigitalDeviceGen2(string name);
    }
}
