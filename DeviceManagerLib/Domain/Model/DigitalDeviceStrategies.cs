using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model
{
    public class DigitalDeviceStrategies
    {
        public DeviceGenerationEnum Generation { get; set; }
        public IDigitalDeviceDescriptionStrategy? DescriptionStrategy { get; set; }
        public IDigitalDeviceStatusStrategy? StatusStrategy { get; set; }
    }
}
