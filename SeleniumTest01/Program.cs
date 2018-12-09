using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest01
{
    class Program
    {
        private const string SeleniumPath = @"C:\SeleniumDrivers";

        IWebDriver driver = new ChromeDriver(SeleniumPath);

        static void Main(string[] args)
        {
        }
        
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=maria&Password=tana&Login=Login");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Open Url");
        }
        [Test]
        public void ExecuteTest()
        {
            //Tittle
            SeleniumSetMethods.SelectDropDown(
                driver: driver, 
                element: "TitleId", 
                value: "Mr.", 
                elementtype: "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver: driver, element: "Initial", value: "executeautomation", elementtype: "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

               //Click
            SeleniumSetMethods.Click(driver: driver, element: "Save", elementtype: "Name");
        }

        [Test]
        public void NextTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Wikipedia");
            
            IWebElement buttonsearch = driver.FindElement(By.Id(""));
            buttonsearch.Click();

            IWebElement NamTexBox = driver.FindElement(By.Id(""));
            NamTexBox.SendKeys("Hormigas");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains(("")));

            IWebElement ClickButton = driver.FindElement(By.Id(""));
            ClickButton.SendKeys(Keys.Return);

            Console.WriteLine("Next01 Test");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
