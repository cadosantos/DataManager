using DeviceManagerLib.Domain.Model;

namespace DeviceManagerTests.Model
{
    public class IdRangeTests
    {
        [Fact]
        public void IdRangeThrowsExceptionWhenDepleted()
        {
            int initialId = 1;
            int finalId = 5;

            IdRange idRange = new IdRange(initialId, finalId);
            for (int id = initialId; id <= finalId; id++)
            {
                Assert.Equal(id, idRange.NextId());
            }

            Assert.Throws<Exception>(() => idRange.NextId());
        }
    }
}
