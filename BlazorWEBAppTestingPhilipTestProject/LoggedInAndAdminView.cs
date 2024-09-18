using Bunit;
using Bunit.TestDoubles;

namespace BlazorWEBAppTestingPhilipTestProject
{
    public class LoggedInAndAdminViewTest
    {
        [Fact]
        public void LoggedInAdmin()
        {
            //Arrange
            using var ctx = new TestContext();
            var auth = ctx.AddTestAuthorization();

            auth.SetAuthorized("philip@gmail.com");
            auth.SetRoles("Admin");
            //Act
            var cut = ctx.RenderComponent<BlazorWEBAppTestingPhilip.Components.Pages.Home>();
            //Assert

            cut.MarkupMatches("<p>You are logged in!</p>" + "<p>You are admin</p>");

        }
    }
}