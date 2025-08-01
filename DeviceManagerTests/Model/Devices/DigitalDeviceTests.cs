using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Model;
using DeviceManagerLib.Domain.Model.Devices;
using DeviceManagerLib.Domain.Services;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceDescription;
using DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus;

namespace DeviceManagerTests.Model.Devices
{
    public class DigitalDeviceTests
    {
        [Theory]
        [InlineData("DD10000")]
        public void DigitalDeviceSetsDescriptionProperly(string expectedDescription)
        {
            //TODO
            var digitalDevice = new DigitalDevice(new IdService(), "Test Digital Device",
                new DigitalDeviceStrategies()
                {
                    Generation = DeviceGenerationEnum.Gen1,
                    DescriptionStrategy = new DigitalDeviceDescriptionDefaultStrategy(),
                    StatusStrategy = new DigitalDeviceStatusVariantAStrategy(),
                });

            Assert.Equal(expectedDescription, digitalDevice.Description);
        }
    }
}
