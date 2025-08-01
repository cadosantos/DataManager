using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model.Devices
{
    public class DigitalDevice : Device
    {
        public DigitalDevice(IIdService idService, string name, DigitalDeviceStrategies strategies)
            : base(name)
        {
            DeviceTypeEnum deviceType;
            switch (strategies.Generation)
            {
                case DeviceGenerationEnum.Gen1:
                    deviceType = DeviceTypeEnum.DigitalGen1;
                    break;
                case DeviceGenerationEnum.Gen2:
                    deviceType = DeviceTypeEnum.DigitalGen2;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(strategies.Generation), ExceptionMessagesHelper.UnknownDeviceGeneration(strategies.Generation));
            }

            Id = idService.GetNextId(deviceType);
            Description = strategies.DescriptionStrategy!.GenerateDescription(Id);
            Status = strategies.StatusStrategy!.GenerateStatus();
        }

        public string Status { get; }

        public override void PrintInfo()
        {
            Console.WriteLine(" >>> ");
            Console.WriteLine($" - {Id}");
            Console.WriteLine($" - {Name}");
            Console.WriteLine($" - {Description}");
            Console.WriteLine($" - {Status}");
            Console.WriteLine(" <<< ");
        }
    }
}
