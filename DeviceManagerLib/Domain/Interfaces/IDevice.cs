namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDevice
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public void PrintInfo();
    }
}
