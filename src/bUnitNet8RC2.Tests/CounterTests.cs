using Bunit;
using bUnitNet8RC2.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bUnitNet8RC2.Tests
{
    [TestClass]
    public class CounterTests : Bunit.TestContext
    {
        [TestMethod]
        public void CounterShouldIncrementWhenClicked()
        {
            var com = RenderComponent<Counter>();

            com.Find("button").Click();

            com.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }

        [TestMethod]
        public void Counter2ShouldIncrementWhenClicked()
        {
            var com = RenderComponent<Counter2>(parameters => parameters.Add(p => p.Step, 2));

            com.Find("button").Click();

            com.Find("p").MarkupMatches("<p>Current count: 2</p>");
        }
    }
}