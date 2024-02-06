using NUnitFramework.Drivers;
using OpenQA.Selenium;
using Quartz;
using TechTalk.SpecFlow;
/*[assembly: CollectionBehavior(MaxParallelThreads = 4, DisableTestParallelization = false)]
*/
namespace NUnitTestProject.StepDefinitions
{
    [Binding]
    public sealed class TestStepDefinitions
    {
     
        [Fact]
        public void run2()
        {
            var _driver = new DriverFixtures(BrowserType.CHROME).Driver;
            if (_driver != null)
            {
                _driver.Navigate().GoToUrl("https://www.youtube.com/");
            }
            else
            {
                Console.WriteLine("Driver initialization failed");
            }
            var today = SystemTime.Now().Date;
            Console.WriteLine(today + "THIS IS 2");
        }
    }
}
