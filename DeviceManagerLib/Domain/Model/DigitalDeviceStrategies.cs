using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model
{
    public class DigitalDeviceStrategies
    {
        public DigitalDeviceStrategies()
        {    
        }

        public DigitalDeviceStrategies(IDigitalDeviceDescriptionStrategy descriptionStrategy, IDigitalDeviceStatusStrategy statusStrategy)
        {
            DescriptionStrategy = descriptionStrategy;
            StatusStrategy = statusStrategy;
        }

        public IDigitalDeviceDescriptionStrategy DescriptionStrategy { get; set; }
        public IDigitalDeviceStatusStrategy StatusStrategy { get; set; }
    }
}
