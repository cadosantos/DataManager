namespace DeviceManagerLib.Domain.Model.Devices
{
    public class AnalogDevice : Device
    {
        public AnalogDevice(int id, string name)
            : base(id, name, $"AD{id:D4}")
        {
        }
    }
}
