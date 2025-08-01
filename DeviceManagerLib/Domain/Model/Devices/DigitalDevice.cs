using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model.Devices
{
    public class DigitalDevice : Device
    {
        public DigitalDevice(int id, string name, IDigitalDeviceDescriptionStrategy digitalDeviceDescriptionStrategy, IDigitalDeviceStatusStrategy digitalDeviceStatusStrategy)
            : base(id, name, digitalDeviceDescriptionStrategy.GenerateDescription(id))
        {
            Status = digitalDeviceStatusStrategy.GenerateStatus();
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
