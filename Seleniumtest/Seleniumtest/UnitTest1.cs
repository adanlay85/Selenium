using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Seleniumtest
{
    [TestClass]
    public class DriversCommands
    {
        [TestMethod]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");

            //Launch the ToolsQA Website
            driver.Url = "http://www.demoqa.com";

            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title length in Int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine("Title of the page is : " + Title);

            // Printing Title length on console
            Console.WriteLine("Length of the Title is : " + TitleLength);

            // Storing URL in String variable
            String PageURL = driver.Url;

            // Storing URL length in Int variable
            int URLLength = PageURL.Length;

            // Printing URL on Console
            Console.WriteLine("URL of the page is : " + PageURL);

            // Printing URL length on console
            Console.WriteLine("Length of the URL is : " + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // Printing Page Source on console
            Console.WriteLine("Page Source of the page is : " + PageSource);

            // Printing Page SOurce length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            //Closing browser
            driver.Quit();

        }
        [TestMethod]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            //Launch the ToolsQA Website
            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test3()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            driver.Navigate().GoToUrl("http://demoqa.com");
            driver.FindElement(By.XPath(".//*[@id='menu-item-3']/a")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            driver.Close();
        }

        [TestMethod]
        public void Test4()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            // Launch the ToolsQA WebSite
            driver.Url = ("http://toolsqa.wpengine.com/Automation-practice-form/");
            driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");
            driver.FindElement(By.Name("lastname")).SendKeys("Sharma");
            driver.FindElement(By.Id("submit")).Click();
        }
        [TestMethod]
        public void Test5()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            driver.Url = ("http://toolsqa.wpengine.com/Automation-practice-form/");
            driver.FindElement(By.PartialLinkText("Partial")).Click();
            Console.WriteLine("Partial Link Test Pass");

            // Convert element in to a string 
            String sClass = driver.FindElements(By.TagName("button")).ToString();
            Console.WriteLine(sClass);
          
            driver.FindElement(By.LinkText("Link Test")).Click();

        }
    }
}
