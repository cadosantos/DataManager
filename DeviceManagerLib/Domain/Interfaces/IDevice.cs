namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public void PrintInfo();
    }
}
