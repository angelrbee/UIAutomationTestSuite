﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationTestFramework
{
    public static class Browser
    {
        private static string baseUrl = "https://book.cebupacificair.com/";
        private static IWebDriver webDriver = new ChromeDriver();

        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Close();
        }

    }
}
