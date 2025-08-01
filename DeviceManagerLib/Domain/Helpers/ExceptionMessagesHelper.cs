using DeviceManagerLib.Domain.Enums;

namespace DeviceManagerLib.Domain.Helpers
{
    internal class ExceptionMessagesHelper
    {
        private static ExceptionMessagesHelper? _instance;
        public static ExceptionMessagesHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExceptionMessagesHelper();
                }

                return _instance;
            }
        }

        private ExceptionMessagesHelper()
        {
        }

        public string UnknownDeviceType(int id) => $"There is no device type for id '{id}'.";
        public string DeviceTypeIdRangeNotSet(DeviceTypeEnum deviceType) => $"Device type '{deviceType}' hasn't set its Ids range yet.";
        public string IdRangeDepleted() => "The Id range is depleted.";
    }
}
