using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription
{
    public class DigitalDeviceDescriptionDefaultStrategy : IDigitalDeviceDescriptionStrategy
    {
        public string GenerateDescription(int id)
        {
            return $"DD{id:D5}";
        }
    }
}
