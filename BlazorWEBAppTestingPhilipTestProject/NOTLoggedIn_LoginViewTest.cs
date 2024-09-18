using Bunit;
using Bunit.TestDoubles;


namespace BlazorWEBAppTestingPhilipTestProject
{
    public class NOTLoggedIn_LoginViewTest
    {
        [Fact]
        public void NotLoggedIn_LoginViewTest()
        {
            // Arrange
            using var ctx = new TestContext();
            var authContext = ctx.AddTestAuthorization();
            // Act
            var cut = ctx.RenderComponent<BlazorWEBAppTestingPhilip.Components.Pages.Home>();
            // Assert
            cut.MarkupMatches("<p>You are NOT logged in!</p>");
        }
    }
}
