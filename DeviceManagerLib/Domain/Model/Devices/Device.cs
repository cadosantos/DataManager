using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Model.Devices
{
    public abstract class Device : IDevice
    {
        public Device(string name)
        {
            Name = name;
        }

        public int Id { get; protected set; }
        public string Name { get; }
        public string Description { get; protected set; }

        public abstract void PrintInfo();
    }
}
