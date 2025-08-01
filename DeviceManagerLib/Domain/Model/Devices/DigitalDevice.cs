namespace DeviceManagerLib.Domain.Model.Devices
{
    public class DigitalDevice : Device
    {
        public DigitalDevice(int id, string name)
            : base(id, name, $"DD{id:D5}")
        {
        }
    }
}
