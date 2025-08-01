using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus;

namespace DeviceManagerLib.Domain.Services
{
    public class DigitalDeviceStrategiesFactory : IDigitalDeviceStrategiesFactory
    {
        private readonly IDigitalDeviceGenerationIdService _digitalDeviceGenerationIdService;
        public DigitalDeviceStrategiesFactory(IDigitalDeviceGenerationIdService digitalDeviceGenerationIdService)
        {
            _digitalDeviceGenerationIdService = digitalDeviceGenerationIdService;
        }

        public DigitalDeviceStrategies GetStrategies(int id)
        {
            DigitalDeviceStrategies digitalDeviceStrategies = new DigitalDeviceStrategies();
            digitalDeviceStrategies.StatusStrategy = new DigitalDeviceStatusVariantAStrategy(); //TODO it could become another service, since the requirement do not explain how variables are defined
            if (_digitalDeviceGenerationIdService.IsGen2Device(id))
            {
                digitalDeviceStrategies.DescriptionStrategy = new DigitalDeviceDescriptionGen2Strategy();
            }
            else
            {
                digitalDeviceStrategies.DescriptionStrategy = new DigitalDeviceDescriptionDefaultStrategy();
            }

            return digitalDeviceStrategies;
        }
    }
}
