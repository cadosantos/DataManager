using DeviceManagerLib.Domain.Model.Devices;

namespace DeviceManagerTests.Model.Devices
{
    public class AnalogDeviceTests
    {
        [Theory]
        [InlineData(1, "AD0001")]
        [InlineData(50, "AD0050")]
        [InlineData(700, "AD0700")]
        [InlineData(8000, "AD8000")]
        public void AnalogDeviceSetsDescriptionProperly(int id, string expectedDescription)
        {
            var analogDevice = new AnalogDevice(id, "Test Analog Device");
            Assert.Equal(expectedDescription, analogDevice.Description);
        }
    }
}
