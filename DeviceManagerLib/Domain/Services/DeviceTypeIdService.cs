using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Services
{
    public class DeviceTypeIdService : IdRangeServiceBase<DeviceTypeEnum>, IDeviceTypeIdService
    {
        public DeviceTypeIdService()
            : base(new Dictionary<DeviceTypeEnum, IdRange>
            {
                { DeviceTypeEnum.Analog, new IdRange(100, 9999) },
                { DeviceTypeEnum.Digital, new IdRange(10000, 19999) }
            })
        {
        }

        public bool IsAnalogDevice(int id) => IsIdInRange(id, DeviceTypeEnum.Analog);
        public bool IsDigitalDevice(int id) => IsIdInRange(id, DeviceTypeEnum.Digital);
    }
}
