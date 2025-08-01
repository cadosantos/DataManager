using DeviceManagerLib.Domain.Enums;
using DeviceManagerLib.Domain.Model;
using DeviceManagerLib.Domain.Services;

namespace DeviceManagerTests.Services
{
    public class IdServiceTests
    {
        [Fact]
        public void IdServiceRangesSetCorrectly()
        {
            var subject = new IdService();

            var deviceTypesIdRange = new Dictionary<DeviceTypeEnum, IdRange>
            {
                { DeviceTypeEnum.Analog, new IdRange(100, 9999) },
                { DeviceTypeEnum.DigitalGen1, new IdRange(10000, 14999) },
                { DeviceTypeEnum.DigitalGen2, new IdRange(15000, 19999) }
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
