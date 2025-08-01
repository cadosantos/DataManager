namespace DeviceManagerTests.Strategies.DigitalDeviceStatus
{
    public class DigitalDeviceStatusVariantAStrategyTests
    {
        public static TheoryData<decimal, string> StrategyShowsStatusCorrectlyData =>
            new()
            {
                { -50.0m, "Low" },
                { 70.0m, "High" }
            };

        [Theory]
        [MemberData(nameof(StrategyShowsStatusCorrectlyData))]
        public void StrategyShowsStatusCorrectly(decimal value, string expectedStatus)
        {
            var subject = new DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus.DigitalDeviceStatusVariantAStrategy();
            subject.GenerateValueFunc = () => value;
            Assert.Equal(expectedStatus, subject.GenerateStatus());
        }
    }
}
