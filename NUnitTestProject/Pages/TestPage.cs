using NUnitFramework.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject.Pages
{
    internal class TestPage
    {
        private readonly IWebDriverFixture iWebDriverFixture;   

        public TestPage(IWebDriverFixture iWebDriverFixture)
        {
            this.iWebDriverFixture = iWebDriverFixture;
        }

        private IWebElement button => iWebDriverFixture.Driver.FindElement(By.XPath("//*[@id='button']"));

    }
}
