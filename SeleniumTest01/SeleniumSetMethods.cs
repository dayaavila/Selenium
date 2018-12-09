using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest01
{
    class SeleniumSetMethods
    {
        //Enter Text.
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
            driver.FindElement(By.Name(element)).SendKeys(value);
            
        }
        //click into a button, checkbox, option, etc.
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();

        }

        /// <summary>
        /// Selecting a drop down control
        /// </summary>
        /// <param name="driver">este es el webdriver</param>
        /// <param name="element">es el valor del tipo de valor</param>
        /// <param name="value">el valor del texto que busco</param>
        /// <param name="elementtype">tipo de valor</param>
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

        }
    }
}
