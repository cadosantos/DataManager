using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Services
{
    public abstract class IdRangeServiceBase<T> where T : Enum
    {
        protected IdRangeServiceBase(Dictionary<T, IdRange> idRange)
        {
            IdRange = idRange ?? throw new ArgumentException(ExceptionMessagesHelper.Instance.IdRangeNull(typeof(T)));
        }

        protected readonly Dictionary<T, IdRange> IdRange;

        protected bool IsIdInRange(int id, T @enum)
        {
            IdRange idRange = EnsureDeviceTypeHasRange(@enum);
            return IsIdInRange(id, idRange);
        }

        private IdRange EnsureDeviceTypeHasRange(T @enum)
        {
            if (!IdRange.TryGetValue(@enum, out var idRange))
                throw new ArgumentException(ExceptionMessagesHelper.Instance.IdRangeNotSet(@enum));

            return idRange;
        }

        private bool IsIdInRange(int id, IdRange idRange)
        {
            return id >= idRange.InitialId && id <= idRange.FinalId;
        }

        public int GetNextId(T deviceType)
        {
            IdRange idRange = EnsureDeviceTypeHasRange(deviceType);
            return idRange.NextId();
        }
    }
}
