using Bunit;
using Bunit.TestDoubles;

namespace BlazorWEBAppTestingPhilipTestProject
{
    public class IsAdmin_LoginCode
    {
        [Fact]
        public void Admin_LoginCodeTest()
        {
            // Arrange
            using var ctx = new TestContext();
            var testAuth = ctx.AddTestAuthorization();
            testAuth.SetRoles("Admin");
            // Act
            var cut = ctx.RenderComponent<BlazorWEBAppTestingPhilip.Components.Pages.Home>();
            var ins = cut.Instance;
            // Assert
            Assert.True(ins._isAuthenticated && ins._isAdmin);
        }
    }
}
