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

        public string UnavailableGenerationForVariant(DeviceVariantEnum variant, DeviceGenerationEnum generation) => $"Device variant '{variant.GetType().Name}' doesn't allow generation '{generation.GetType().Name}'.";
        public string UnknownDeviceVariant(DeviceVariantEnum variant) => $"Device variant '{variant.GetType().Name}' isn't configured yet.";
        public string UnknownDeviceGeneration(DeviceGenerationEnum generation) => $"Device generation '{generation.GetType().Name}' isn't configured yet.";
        public string IdRangeNotSet(DeviceTypeEnum deviceType) => $"Device type '{deviceType.GetType().Name}' hasn't set its Ids range yet.";
        public string IdRangeDepleted() => "The Id range is depleted.";
        public string ValueOutOfBounds(string lowerBound, string upperBound) => $"Value must be between '{lowerBound}' and '{upperBound}'.";
        public string ValueInvalidForStep(int step) => $"Value must be divisible by step ({step}).";
    }
}
