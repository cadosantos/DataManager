namespace DeviceManagerLib.Domain.Model
{
    public class Device
    {
        public Device(string name, string description)
        {
            Id = Globals.Instance.GetNextFreeDeviceId();
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
