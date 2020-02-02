using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomationTestFramework.Classes

{
    
    public static class ElementExtensions
    {

        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Enabled;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static bool WaitForElementToAppear(IWebElement element, int timeout)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Browser.webDriver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                return true;
            }
            catch (Exception e) //didnt appear so exception thrown return false

            {
                return false;
            }
        }

    }
}
