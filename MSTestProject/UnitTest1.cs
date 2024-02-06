using OpenQA.Selenium;
using NUnitFramework.Drivers;
using System;
using System.Diagnostics;

namespace MSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Start the stopwatch
            Stopwatch stopwatch = Stopwatch.StartNew();

            var _driver = new DriverFixtures(BrowserType.CHROME).Driver;
            if (_driver != null)
            {
                _driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
                _driver.FindElement(By.XPath("//*[@id=\"username\"]")).SendKeys("student");
                _driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("Password123");
                _driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
                _driver.Close();
            }
            else
            {
                Console.WriteLine("Driver initialization failed");
            }

            // Stop the stopwatch
            stopwatch.Stop();

            // Print the elapsed time
            Console.WriteLine($"Test execution time: {stopwatch.Elapsed}");
        }
    }
}
