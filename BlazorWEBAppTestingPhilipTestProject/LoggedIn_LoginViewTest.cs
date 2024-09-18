using Bunit;
using Bunit.TestDoubles;

namespace BlazorWEBAppTestingPhilipTestProject
{
    public class LoggedIn_LoginViewTest
    {
        [Fact]
        public void LoggedIn_LoginViewTest1()
        {
            // Arrange
            using var ctx = new TestContext();
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("philip@gmail.com");
            // Act
            var cut = ctx.RenderComponent<BlazorWEBAppTestingPhilip.Components.Pages.Home>();
            // Assert
            cut.MarkupMatches("<p>You are logged in!</p>");
        }
    }
}
