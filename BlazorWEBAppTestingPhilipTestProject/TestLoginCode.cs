using Bunit;
using Bunit.TestDoubles;

namespace BlazorWEBAppTestingPhilipTestProject
{
    public class TestLoginCode
    {
        [Fact]
        public void TestLoginCode1()
        {
            // Arrange
            using var ctx = new TestContext();
            var authContext = ctx.AddTestAuthorization();
            // Act
            var cut = ctx.RenderComponent<BlazorWEBAppTestingPhilip.Components.Pages.Home>();
            var ins = cut.Instance;
            // Assert
            Assert.False(ins._isAuthenticated);
        }
    }
}
