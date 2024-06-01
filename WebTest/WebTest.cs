namespace WebTest
{
    public class WebTest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 10;
            bool result = false;
            if (i == 10) result = true;
            Assert.True(result, "Value should be 10");
        }
    }
}