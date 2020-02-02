using OpenQA.Selenium;
using UIAutomationTestFramework.Classes;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace UIAutomationTestFramework.Pages
{
    public class SignInPage 
    {

        #region
        [FindsBy(How = How.Id, Using = "u_0_m")]
        private IWebElement FirstName;

        [FindsBy(How = How.Id, Using = "u_0_o")]
        private IWebElement LastName;

        [FindsBy(How = How.Id, Using = "u_0_r")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.Id, Using = "u_0_u")]
        private IWebElement ReenterEmailAddress;

        [FindsBy(How = How.Id, Using = "u_0_w")]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "day")]
        private IWebElement Day;
        public SelectElement DayDropdownElement
        {
            get { return new SelectElement(Day); }
        }

        [FindsBy(How = How.Id, Using = "month")]
        private IWebElement Month;
        public SelectElement MonthDropdownElement
        {
            get { return new SelectElement(Month); }
        }

        [FindsBy(How = How.Id, Using = "year")]
        private IWebElement Year;
        public SelectElement YearDropdownElement
        {
            get { return new SelectElement(Year); }
        }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Male')]")]
        private IWebElement Male;

        [FindsBy(How = How.Name, Using = "websubmit")]
        private IWebElement SignUpButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='lfloat _ohe']//h1//a")]
        private IWebElement FbLogo;

        [FindsBy(How = How.ClassName, Using = "uiHeaderTitle")]
        private IWebElement fbHeaderEnterCode;

        [FindsBy(How = How.Id, Using = "checkpointSubmitButton")]
        private IWebElement ContinueButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='_1yqt']")]
        private IWebElement WeNeedToConfirmYourIdentity;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Enter a combination of at least six numbers')]")]
        private IWebElement ErrorMessage;
        #endregion

        #region methods

        public void Goto()
        {
            Pages.SignInPage.FbLogo.Click();
        }


        public void SignUpUser(Enums.ScenarioEnum caseSwitch)
        {
            switch (caseSwitch)
            {
                case Enums.ScenarioEnum.ValidScenario:
                    {
                        var user = UserGenerator.Generate();
                        Pages.SignInPage.FirstName.SendKeys(user.FirstName);
                        Pages.SignInPage.LastName.SendKeys(user.LastName);
                        Pages.SignInPage.EmailAddress.SendKeys(user.EmailAddress);
                        Pages.SignInPage.ReenterEmailAddress.SendKeys(user.EmailAddress);
                        Pages.SignInPage.Password.SendKeys(user.Password);
                        Pages.SignInPage.DayDropdownElement.SelectByText(user.Day);
                        Pages.SignInPage.MonthDropdownElement.SelectByText(user.Month);
                        Pages.SignInPage.YearDropdownElement.SelectByText(user.Year);
                        ElementExtensions.WaitForElementToAppear(Pages.SignInPage.Male, 10);
                        Pages.SignInPage.Male.Click();
                        Pages.SignInPage.SignUpButton.Click();
                        break;
                    }
                case Enums.ScenarioEnum.BlankPassword:
                    {
                        var user = UserGenerator.Generate();
                        Pages.SignInPage.FirstName.SendKeys(user.FirstName);
                        Pages.SignInPage.LastName.SendKeys(user.LastName);
                        Pages.SignInPage.EmailAddress.SendKeys(user.EmailAddress);
                        Pages.SignInPage.ReenterEmailAddress.SendKeys(user.EmailAddress);
                        ElementExtensions.WaitForElementToAppear(Pages.SignInPage.Male, 10);
                        Pages.SignInPage.Male.Click();
                        Pages.SignInPage.SignUpButton.Click();
                        break;
                    }
            }

        }

        public bool CheckSuccessfulSignUp()
        {
            ElementExtensions.WaitForElementToAppear(Pages.SignInPage.WeNeedToConfirmYourIdentity, 10);
            return ElementExtensions.IsDisplayed(Pages.SignInPage.WeNeedToConfirmYourIdentity);
        }

        public bool CheckErrorIcon()
        {
            return ElementExtensions.IsDisplayed(Pages.SignInPage.ErrorMessage);
        }


        #endregion
    }
}

