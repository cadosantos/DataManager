using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Services
{
    public class IdService : IIdService
    {
        private readonly Dictionary<DeviceTypeEnum, IdRange> _deviceTypeIdRange = new()
        {
            { DeviceTypeEnum.Analog, new IdRange(100, 9999) },
            { DeviceTypeEnum.DigitalGen1, new IdRange(10000, 14999) },
            { DeviceTypeEnum.DigitalGen2, new IdRange(15000, 19999) }
        };

        public int GetNextId(DeviceTypeEnum deviceTypeEnum)
        {
            if (!_deviceTypeIdRange.TryGetValue(deviceTypeEnum, out var idRange))
                throw new ArgumentException(nameof(deviceTypeEnum), ExceptionMessagesHelper.IdRangeNotSet(deviceTypeEnum));

            return idRange.NextId();
        }
    }
}
