﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MyTestFramework
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            Goto(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
