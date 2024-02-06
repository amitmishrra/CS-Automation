using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnitFramework.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace NUnitTestProject.StepDefinitions
{
    [Binding]
/*    [DataRow(BrowserType.Edge, "Windows 10", "latest", "Edge Test")]
*/    public sealed class TestStepDefinitions
    {
        private IWebDriver _driver;
        public ThreadLocal<IWebDriver> local = new ThreadLocal<IWebDriver>();

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize the WebDriver instance before each scenario
            // You can adjust this based on your specific requirements
            _driver = null; // Ensure _driver is null initially
        }

        [Given(@"I launch the browser using ""(.*)""")]
        public void InitializeTheBrowser(string browserName)
        {
            // Check if _driver is not already initialized
            if (_driver == null)
            {
                _driver = new DriverFixtures(browserName == "Chrome" ? BrowserType.CHROME : BrowserType.EDGE).Driver;
                local.Value = _driver; // Set the ThreadLocal value
            }

            if (local.Value != null)
            {
                local.Value.Navigate().GoToUrl("https://www.youtube.com/");
            }
            else
            {
                Console.WriteLine("Driver initialization failed");
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Clean up the WebDriver instance after each scenario
            if (local.Value != null && _driver != null)
            {
                try
                {
                    local.Value.Quit();
                    local.Dispose(); // Dispose the ThreadLocal
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception during driver quit: {ex}");
                }
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            try
            {
                    Console.WriteLine("NULLLLL");
            }catch (Exception ex)
            {
                Console.WriteLine($"Exception during After Feature: {ex}");
            }
        }
    }
}
