using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace MyTestFramework
{
    class Drivers
    {
        static void Main(string[] args)
        {
            string browserName = "Chrome";

            IWebDriver driver = null;

            switch (browserName.ToUpper())
            {
                case "CHROME":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "FIREFOX":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Navigate().GoToUrl("http://google.com.ua");

            driver.Quit();

        }
    }
}
