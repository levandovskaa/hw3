using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }

    }
}
