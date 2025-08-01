using DeviceManagerLib.Domain.Model;

namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDigitalDeviceStrategiesFactory
    {
        public DigitalDeviceStrategies GetStrategies(int id);
    }
}
