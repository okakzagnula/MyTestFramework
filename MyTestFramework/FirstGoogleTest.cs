using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDemo1
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;

        [AssemblyInitialize]
        public static void SetUp(NUnit.Framework.TestContext context)
        {
            driver = new FirefoxDriver();
            driver = new ChromeDriver(); 
        }
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Id("gbqfq")).SendKeys("Selenium");
            driver.FindElement(By.Id("gbqfq")).SendKeys(Keys.Enter);
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}