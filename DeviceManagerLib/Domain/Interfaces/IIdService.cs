using DeviceManagerLib.Domain.Enums;

namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IIdService
    {
        public int GetNextId(DeviceTypeEnum deviceType);
    }
}
