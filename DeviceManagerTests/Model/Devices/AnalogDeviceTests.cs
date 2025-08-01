using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Services;

namespace DeviceManagerTests.Model.Devices
{
    public class AnalogDeviceTests
    {
        [Theory]
        [InlineData("AD0100")]
        public void AnalogDeviceSetsDescriptionProperly(string expectedDescription)
        {
            var analogDevice = new AnalogDevice(new IdService(),"Test Analog Device");
            Assert.Equal(expectedDescription, analogDevice.Description);
        }
    }
}
