using DeviceManagerLib.Domain.Enums;

namespace DeviceManagerLib.Domain.Helpers
{
    internal static class ExceptionMessagesHelper
    {
        public static string UnavailableGenerationForVariant(DeviceVariantEnum variant, DeviceGenerationEnum generation) => $"Device variant '{variant.GetType().Name}' doesn't allow generation '{generation.GetType().Name}'.";
        public static string UnknownDeviceVariant(DeviceVariantEnum variant) => $"Device variant '{variant.GetType().Name}' isn't configured yet.";
        public static string UnknownDeviceGeneration(DeviceGenerationEnum generation) => $"Device generation '{generation.GetType().Name}' isn't configured yet.";
        public static string IdRangeNotSet(DeviceTypeEnum deviceType) => $"Device type '{deviceType.GetType().Name}' hasn't set its Ids range yet.";
        public static string IdRangeDepleted() => "The Id range is depleted.";
        public static string ValueOutOfBounds(string lowerBound, string upperBound) => $"Value must be between '{lowerBound}' and '{upperBound}'.";
        public static string ValueInvalidForStep(int step) => $"Value must be divisible by step ({step}).";
    }
}
