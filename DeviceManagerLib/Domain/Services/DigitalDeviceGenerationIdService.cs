using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Services
{
    public class DigitalDeviceGenerationIdService : IdRangeServiceBase<DeviceGenerationEnum>, IDigitalDeviceGenerationIdService
    {
        public DigitalDeviceGenerationIdService()
            : base(new Dictionary<DeviceGenerationEnum, IdRange>
            {
                { DeviceGenerationEnum.Gen1, new IdRange(10000, 14999) },
                { DeviceGenerationEnum.Gen2, new IdRange(15000, 19999) }
            })
        {
        }

        public bool IsGen1Device(int id) => IsIdInRange(id, DeviceGenerationEnum.Gen1);
        public bool IsGen2Device(int id) => IsIdInRange(id, DeviceGenerationEnum.Gen2);
    }
}
