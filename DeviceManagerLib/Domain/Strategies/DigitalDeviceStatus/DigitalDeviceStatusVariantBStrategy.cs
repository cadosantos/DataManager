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
            if (value)
                return "On";
            
            return "Off";
        }

        private bool GenerateRandomBoolean()
        {
            Random random = new Random();
            return Convert.ToBoolean(random.Next(0, 2));
        }
    }
}
