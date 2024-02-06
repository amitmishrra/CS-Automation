using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.Drivers
{
    public  class DriverFixtures
    {
        public IWebDriver Driver { get; private set; }

        public DriverFixtures(BrowserType browserType) 
        {
            Driver = GetWebDriver(browserType);
        }

        private IWebDriver GetWebDriver(BrowserType browserType)
        {
            Console.WriteLine("calledddd");
            return browserType switch 
            {
                BrowserType.CHROME => new ChromeDriver(),
                BrowserType.EDGE => new EdgeDriver(),
                BrowserType.FIREFOX => new FirefoxDriver(),
                BrowserType.SAFARI => new SafariDriver(),
                _ => new ChromeDriver()
            };
        }
    }
}


public enum BrowserType
{
    CHROME,
    FIREFOX,
    SAFARI,
    EDGE
}