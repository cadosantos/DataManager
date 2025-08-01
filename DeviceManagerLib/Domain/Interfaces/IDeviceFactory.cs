namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDeviceFactory
    {
        public IDevice CreateDevice(int id, string name);
    }
}
