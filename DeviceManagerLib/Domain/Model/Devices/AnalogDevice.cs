namespace DeviceManagerLib.Domain.Model.Devices
{
    public class AnalogDevice : Device
    {
        public AnalogDevice(int id, string name)
            : base(id, name, $"AD{id:D4}")
        {
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
