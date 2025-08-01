namespace DeviceManagerLib.Domain.Interfaces
{
    public interface IDigitalDeviceGenerationIdService
    {
        public bool IsGen1Device(int id);
        public bool IsGen2Device(int id);
    }
}
