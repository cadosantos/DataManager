using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription
{
    public class DigitalDeviceDescriptionGen2Strategy : IDigitalDeviceDescriptionStrategy
    {
        public string GenerateDescription(int id)
        {
            var defaultDescription = new DigitalDeviceDescriptionDefaultStrategy().GenerateDescription(id);
            return $"{defaultDescription}(Gen 2)";
        }
    }
}
