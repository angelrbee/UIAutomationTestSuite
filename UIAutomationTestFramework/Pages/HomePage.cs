using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using UIAutomationTestFramework.Pages;

namespace UIAutomationTestFramework.Pages
{
    public class HomePage
    {
        #region elements
        [FindsBy(How = How.Id, Using = "signInLink")]
        private IWebElement signIn;
        #endregion

        #region Methods
        public void ClickSignIn()
        {
            signIn.Click();
        }
        #endregion
    }
}
