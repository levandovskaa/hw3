using HomeWork3.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Test
{
    class TestCheckboxesPage
    {
        private static IWebDriver _driver;
        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [TestCase]
        public static void TestOneCheckbox()
        {
            CheckboxesPage page = new CheckboxesPage(_driver).checkIsAgeSelected();
            Assert.IsTrue(page.checkBoxSuccessText.Displayed, "Success text is on the page");
            page.UncheckIsAgeSelected();
        }

        [TestCase]
        public static void TestCheckAll()
        {
            CheckboxesPage page = new CheckboxesPage(_driver).checkAll();
            Assert.AreEqual(page.allChecked.GetAttribute("value"), "Uncheck All", "Displays 'Uncheck All'");
        }

        [TestCase]
        public static void TestCheckAll()
        {
            CheckboxesPage page = new CheckboxesPage(_driver).UncheckAll();
            Assert.AreEqual(page.allChecked.GetAttribute("value"), "Check All", "Displays 'Check All'");

        }

        [TestCase]
        public static void TestUncheckAllButton()
        {
            CheckboxesPage page = new CheckboxesPage(_driver).checkAll().PressChecked();
            foreach (IWebElement checkbox in page.checkboxes) 
            {
                Assert.IsFalse(checkbox.Selected);
            }
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
    }
}
