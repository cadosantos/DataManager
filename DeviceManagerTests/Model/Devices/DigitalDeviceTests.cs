using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus;

namespace DeviceManagerTests.Model.Devices
{
    public class DigitalDeviceTests
    {
        [Theory]
        [InlineData(1, "DD00001")]
        [InlineData(50, "DD00050")]
        [InlineData(700, "DD00700")]
        [InlineData(8000, "DD08000")]
        [InlineData(90000, "DD90000")]
        public void DigitalDeviceSetsDescriptionProperly(int id, string expectedDescription)
        {
            //TODO
            var digitalDevice = new DigitalDevice(id, "Test Digital Device", new DigitalDeviceDescriptionDefaultStrategy(), new DigitalDeviceStatusVariantAStrategy());
            Assert.Equal(expectedDescription, digitalDevice.Description);
        }
    }
}
