
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UIAutomationTestFramework;

namespace UIAutomationTestSuite.Hooks
{
    [Binding]
    public class SignInHooks : TestBase
    {




        public SignInHooks()
        {

        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {

            Browser.Initialize();


        }


        [AfterScenario]
        public void Teardown()
        {
            Browser.Close();
        }


    }
}
