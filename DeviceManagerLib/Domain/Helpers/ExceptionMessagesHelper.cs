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
        public string IdRangeNull(Type enumType) => $"'{enumType.Name}' cannot have an empty Ids range.";
        public string IdRangeNotSet(Enum @enum) => $"'{@enum.GetType().Name}' hasn't set its Ids range yet.";
        public string IdRangeDepleted() => "The Id range is depleted.";
    }
}
