using DeviceManagerLib.Domain.Model.Devices;

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
            var digitalDevice = new DigitalDevice(id, "Test Digital Device");
            Assert.Equal(expectedDescription, digitalDevice.Description);
        }
    }
}
