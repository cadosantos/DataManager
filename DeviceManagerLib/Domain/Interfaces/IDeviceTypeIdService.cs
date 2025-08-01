using DeviceManagerLib.Domain.Enums;

namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDeviceTypeIdService
    {
        public bool IsAnalogDevice(int id);
        public bool IsDigitalDevice(int id);
        public int GetNextId(DeviceTypeEnum deviceType);
    }
}
