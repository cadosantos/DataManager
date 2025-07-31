namespace DeviceManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBasicAssertions()
        {
            // Expect two strings not to be equal.
            Assert.NotEqual("hello", "world");
            // Expect equality.
            Assert.Equal(7 * 6, 42);
        }
    }
}