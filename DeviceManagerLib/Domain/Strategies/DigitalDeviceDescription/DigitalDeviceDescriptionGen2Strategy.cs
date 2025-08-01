using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription
{
    public class DigitalDeviceDescriptionGen2Strategy : IDigitalDeviceDescriptionStrategy
    {
        private readonly IDigitalDeviceDescriptionStrategy _defaultStrategy;
        public DigitalDeviceDescriptionGen2Strategy(IDigitalDeviceDescriptionStrategy defaultStrategy)
        {
            _defaultStrategy = defaultStrategy;
        }

        public string GenerateDescription(int id)
        {
            var defaultDescription = _defaultStrategy.GenerateDescription(id);
            return $"{defaultDescription}(Gen 2)";
        }
    }
}
