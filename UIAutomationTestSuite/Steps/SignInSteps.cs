
using TechTalk.SpecFlow;
using UIAutomationTestFramework.Pages;
using NUnit.Framework;
using UIAutomationTestFramework.Enums;
using System;

namespace UIAutomationTestSuite.Steps
{
    [Binding]
    public class SignInSteps 
    {
        private readonly SignInPage _signInPage;


        public SignInSteps(SignInPage signInPage)
        {
            _signInPage = signInPage;
        }

        [StepDefinition(@"I am in Facebook Page")]
        public void GivenIAmInFacebookPage()
        {

        }


        [StepDefinition(@"I sign up for '(.*)'")]
        public void WhenISignUpFor(string strScenario)
        {
            ScenarioEnum enumScenario = (ScenarioEnum)Enum.Parse(typeof(ScenarioEnum), strScenario);
            _signInPage.Goto();
            _signInPage.SignUpUser(enumScenario);
        }


        [StepDefinition(@"I am '(.*)'")]
        public void ThenIAm(string strResult)
        {
            ResultEnum enumResult = (ResultEnum)Enum.Parse(typeof(ResultEnum), strResult);

            switch(enumResult)
            {
                case ResultEnum.Successful:
                    {
                        Assert.True(_signInPage.CheckSuccessfulSignUp(), "Facebook Sign up is not successful");
                        break;
                    }

                case ResultEnum.ErrorBlankPassword:
                    {
                        Assert.True(_signInPage.CheckErrorIcon(), "Error message is not displayed");
                        break;
                    }

            }
        }





    }
}
