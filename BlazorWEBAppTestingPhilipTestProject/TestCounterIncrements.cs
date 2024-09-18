using BlazorWEBAppTestingPhilip;
using Bunit;

namespace BlazorWEBAppTestingPhilipTestProject
{
    public class TestCounterIncrements : TestContext
    {
        [Fact]
        public void TestCounterIncrements1()
        {
            // Arrange
            var cut = RenderComponent<Counter>(); // Use the Counter component
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();

            // Assert
            paraElm.MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}
