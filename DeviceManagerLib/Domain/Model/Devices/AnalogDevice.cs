using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model.Devices
{
    public class AnalogDevice : Device
    {
        public AnalogDevice(IIdService idService, string name)
            : base(name)
        {
            Id = idService.GetNextId(DeviceTypeEnum.Analog);
            Description = $"AD{Id:D4}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine(" >>> ");
            Console.WriteLine($" - {Id}");
            Console.WriteLine($" - {Name}");
            Console.WriteLine($" - {Description}");
            Console.WriteLine(" <<< ");
        }
    }
}
