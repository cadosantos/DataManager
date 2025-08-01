using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus
{
    public class DigitalDeviceStatusVariantBStrategy : IDigitalDeviceStatusStrategy
    {
        public DigitalDeviceStatusVariantBStrategy()
        {
            GenerateValueFunc = GenerateRandomBoolean;
        }

        public Func<bool> GenerateValueFunc { get; set; }

        public string GenerateStatus()
        {
            return GenerateStatus(GenerateValueFunc());
        }

        public string GenerateStatus(bool value)
        {
            return value
                ? "On"
                : "Off";
        }

        private bool GenerateRandomBoolean()
        {
            return Convert.ToBoolean(Random.Shared.Next(0, 2));
        }
    }
}
