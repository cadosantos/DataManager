using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Services;

namespace DeviceManagerTests.Services
{
    public class DeviceFactoryTests
    {
        [Theory]
        [InlineData(99, null, typeof(ArgumentException))]
        [InlineData(100, true, null)]
        [InlineData(9999, true, null)]
        [InlineData(10000, false, null)]
        [InlineData(19999, false, null)]
        [InlineData(20000, null, typeof(ArgumentException))]
        public void FactoryCreatesCorrectDevice(int id, bool? isAnalogicDevice, Type? expectedExceptionType)
        {
            var subject = new DeviceFactory(new DeviceTypeIdService(), new DigitalDeviceStrategiesFactory(new DigitalDeviceGenerationIdService()));
            
            if (expectedExceptionType != null)
            {
                Assert.Throws(expectedExceptionType, () => subject.CreateDevice(id, "Test name"));
            }
            else
            {
                var device = subject.CreateDevice(id, "Test name");

                if (isAnalogicDevice == true)
                {
                    Assert.True(device is AnalogDevice);
                }
                else if (isAnalogicDevice == false)
                {
                    Assert.True(device is DigitalDevice);
                }
                else
                {
                    Assert.Fail();
                }
            }
        }
    }
}
