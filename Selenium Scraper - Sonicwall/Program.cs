using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace Selenium_Scraper___Sonicwall
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\joshua.barr\\source\\repos\\Selenium Scraper - Sonicwall\\chromedriver_win32");

            driver.Url = "https://180.150.85.108:442/auth1.html";

            IWebElement ele = driver.FindElement(By.Id("details-button"));
            ele.Click();

            Thread.Sleep(500);

            IWebElement ele1 = driver.FindElement(By.CssSelector("#proceed-link"));
            ele1.Click();

            Thread.Sleep(5000);

            IWebElement ele2 = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            ele2.SendKeys("test");

            IWebElement ele3 = driver.FindElement(By.XPath("//*[@id=\"password_line\"]/div[2]/input"));
            ele3.SendKeys("test");

        }
    }
}
