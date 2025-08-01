using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;
using DeviceManagerLib.Domain.Model;
using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus;

namespace DeviceManagerLib.Domain.Services
{
    public class DeviceFactory : IDeviceFactory
    {
        private IIdService _idService;

        public DeviceFactory(IIdService idService)
        {
            _idService = idService;
        }

        public IDevice CreateAnalogDevice(string name)
        {
            return new AnalogDevice(_idService, name);
        }

        public IDevice CreateDigitalDeviceGen1(string name, DeviceVariantEnum deviceVariant)
        {
            return new DigitalDevice(_idService, name, GetDigitalStrategies(deviceVariant, DeviceGenerationEnum.Gen1));
        }

        public IDevice CreateDigitalDeviceGen2(string name)
        {
            return new DigitalDevice(_idService, name, GetDigitalStrategies(DeviceVariantEnum.D, DeviceGenerationEnum.Gen2));
        }

        private DigitalDeviceStrategies GetDigitalStrategies(DeviceVariantEnum deviceVariant, DeviceGenerationEnum deviceGeneration)
        {
            DigitalDeviceStrategies strategies = new DigitalDeviceStrategies();
            strategies.Generation = deviceGeneration;

            switch (deviceVariant)
            {
                case DeviceVariantEnum.A:
                    EnsureGen1(deviceVariant, deviceGeneration);
                    strategies.StatusStrategy = new DigitalDeviceStatusVariantAStrategy();
                    break;
                case DeviceVariantEnum.B:
                    EnsureGen1(deviceVariant, deviceGeneration);
                    strategies.StatusStrategy = new DigitalDeviceStatusVariantBStrategy();
                    break;
                case DeviceVariantEnum.D:
                    switch (deviceGeneration)
                    {
                        case DeviceGenerationEnum.Gen1:
                            strategies.StatusStrategy = new DigitalDeviceStatusVariantDGen1Strategy();
                            break;
                        case DeviceGenerationEnum.Gen2:
                            strategies.DescriptionStrategy = new DigitalDeviceDescriptionGen2Strategy();
                            strategies.StatusStrategy = new DigitalDeviceStatusVariantDGen2Strategy();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(ExceptionMessagesHelper.Instance.UnknownDeviceGeneration(deviceGeneration));
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(ExceptionMessagesHelper.Instance.UnknownDeviceVariant(deviceVariant));
            }

            strategies.DescriptionStrategy ??= new DigitalDeviceDescriptionDefaultStrategy();

            return strategies;
        }

        private void EnsureGen1(DeviceVariantEnum deviceVariant, DeviceGenerationEnum deviceGeneration)
        {
            if (deviceGeneration != DeviceGenerationEnum.Gen1)
                throw new Exception(ExceptionMessagesHelper.Instance.UnavailableGenerationForVariant(deviceVariant, deviceGeneration));
        }
    }
}
