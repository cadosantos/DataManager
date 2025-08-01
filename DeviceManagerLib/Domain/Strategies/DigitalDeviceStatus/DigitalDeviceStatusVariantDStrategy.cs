using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus
{
    public abstract class DigitalDeviceStatusVariantDStrategy : IDigitalDeviceStatusStrategy
    {
        public string GenerateStatus()
        {
            //TODO
            return "D";
        }
    }
}
