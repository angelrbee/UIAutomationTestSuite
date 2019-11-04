using TechTalk.SpecFlow;
using UIAutomationTestFramework.Pages;


namespace UIAutomationTestSuite.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        private readonly ScenarioContext context;
        private readonly HomePage homePage;

        public LoginSteps(ScenarioContext injectedContext, HomePage injectedHomePage)
        {
            context = injectedContext;
            homePage = injectedHomePage;
        }

        [Given(@"I click Sign In button")]
        public void GivenIClickSignInButton()
        {
            homePage.ClickSignIn();
        }

        [When(@"I enter '(.*)' and '(.*)'")]
        public void WhenIEnterAnd(string email, string password)
        {

        }

        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {

        }

        [Then(@"I can see My Bookings page")]
        public void ThenICanSeeMyBookingsPage()
        {
            
        }

    }
}
