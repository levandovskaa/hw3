using OpenQA.Selenium;
using System.Collections.Generic;

namespace HomeWork3.Page
{
    class CheckboxesPage : BasePage
    {
        public IWebElement isAgeSelectedCheckbox => Driver.FindElement(By.Id("isAgeSelected"));
        public IWebElement checkBoxSuccessText => Driver.FindElement(By.Id("txtAge"));
        public IWebElement allChecked => Driver.FindElement(By.Id("check1"));
        public IReadOnlyCollection<IWebElement> checkboxes => Driver.FindElements(By.ClassName("cb1-element"));

        public CheckboxesPage(IWebDriver driver) : base(driver) { }

        public CheckboxesPage checkIsAgeSelected()
        {
            if (isAgeSelectedCheckbox.Selected != true)
                isAgeSelectedCheckbox.Click();

            return this;
        }

        public CheckboxesPage UncheckIsAgeSelected()
        {
            if (isAgeSelectedCheckbox.Selected != false)
                isAgeSelectedCheckbox.Click();
            return this;
        }

        public CheckboxesPage checkAll()
        {
            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.Selected != true)
                    checkbox.Click();
            }
            return this;
        }


        public CheckboxesPage UncheckAll()
        {
            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.Selected != false)
                    checkbox.Click();
            }
            return this;
        }

        public CheckboxesPage PressChecked()
        {
            allChecked.Click();
            return this;
        }

    }
}
