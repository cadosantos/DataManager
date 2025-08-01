using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model.Devices
{
    public abstract class Device : IDevice
    {
        protected Device(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(" >>> ");
            Console.WriteLine($" - {Id}");
            Console.WriteLine($" - {Name}");
            Console.WriteLine($" - {Description}");
            Console.WriteLine(" <<< ");
        }
    }
}
