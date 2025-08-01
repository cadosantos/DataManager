using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Services
{
    public class DeviceIdService : IDeviceIdService
    {
        private readonly Dictionary<DeviceTypeEnum, IdRange> _deviceTypesIdRange = new Dictionary<DeviceTypeEnum, IdRange>
        {
            { DeviceTypeEnum.Analog, new IdRange(100, 9999) },
            { DeviceTypeEnum.Digital, new IdRange(10000, 19999) }
        };

        private bool IsIdInRange(int id, DeviceTypeEnum deviceType)
        {
            IdRange idRange = EnsureDeviceTypeHasRange(deviceType);
            return IsIdInRange(id, idRange);
        }

        private IdRange EnsureDeviceTypeHasRange(DeviceTypeEnum deviceType)
        {
            if (!_deviceTypesIdRange.TryGetValue(deviceType, out var idRange))
                throw new ArgumentException(ExceptionMessagesHelper.Instance.DeviceTypeIdRangeNotSet(deviceType));

            return idRange;
        }

        private bool IsIdInRange(int id, IdRange idRange)
        {
            return id >= idRange.InitialId && id <= idRange.FinalId;
        }

        public bool IsAnalogDevice(int id) => IsIdInRange(id, DeviceTypeEnum.Analog);
        public bool IsDigitalDevice(int id) => IsIdInRange(id, DeviceTypeEnum.Digital);

        public int GetNextId(DeviceTypeEnum deviceType)
        {
            IdRange idRange = EnsureDeviceTypeHasRange(deviceType);
            return idRange.NextId();
        }
    }
}
