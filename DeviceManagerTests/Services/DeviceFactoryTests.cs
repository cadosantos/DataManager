using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Services;

namespace DeviceManagerTests.Services
{
    public class DeviceFactoryTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void FactoryCreatesCorrectDevice(bool? isAnalogicDevice)
        {
            var subject = new DeviceFactory(new IdService());

            if (isAnalogicDevice == true)
            {
                var device = subject.CreateAnalogDevice("Test name");
                Assert.True(device is AnalogDevice);
            }
            else if (isAnalogicDevice == false)
            {
                var device = subject.CreateDigitalDeviceGen1("Test name", DeviceVariantEnum.A);
                Assert.True(device is DigitalDevice);
            }
        }
    }
}
