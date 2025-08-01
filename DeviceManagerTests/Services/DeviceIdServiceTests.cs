using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Model;
using DeviceManagerLib.Domain.Services;

namespace DeviceManagerTests.Services
{
    public class DeviceIdServiceTests
    {
        [Theory]
        [InlineData(99, null)]
        [InlineData(100, true)]
        [InlineData(9999, true)]
        [InlineData(10000, false)]
        [InlineData(19999, false)]
        [InlineData(20000, null)]
        public void DeviceIdServiceIdentifyDeviceTypeCorrectly(int id, bool? isAnalogicDevice)
        {
            var subject = new DeviceIdService();

            if (isAnalogicDevice.HasValue)
            {
                Assert.Equal(subject.IsAnalogDevice(id), isAnalogicDevice);
                Assert.Equal(subject.IsDigitalDevice(id), !isAnalogicDevice);
            }
            else
            {
                Assert.False(subject.IsAnalogDevice(id));
                Assert.False(subject.IsDigitalDevice(id));
            }
        }

        [Fact]
        public void DeviceIdServiceGetsNextIdCorrectly()
        {
            var subject = new DeviceIdService();

            var deviceTypesIdRange = new Dictionary<DeviceTypeEnum, IdRange>
            {
                { DeviceTypeEnum.Analog, new IdRange(100, 9999) },
                { DeviceTypeEnum.Digital, new IdRange(10000, 19999) }
            };

            foreach (var keyValuePair in deviceTypesIdRange)
            {
                DeviceTypeEnum deviceType = keyValuePair.Key;
                IdRange idRange = keyValuePair.Value;

                for (int id = idRange.InitialId; id <= idRange.FinalId; id++)
                {
                    Assert.Equal(id, subject.GetNextId(deviceType));
                }

                Assert.Throws<Exception>(() => subject.GetNextId(deviceType));
            }
        }
    }
}
