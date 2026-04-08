using Xunit;
using BasicDotNetApp;

namespace BasicDotNetApp.Tests
{
    public class AppTests
    {
        [Fact]
        public void ShouldReturnHelloMessage()
        {
            // Act
            string result = App.Message();

            // Assert
            Assert.Equal("Hello world!", result);
        }
    }
}
