using SeleniumExtras.PageObjects;

namespace UIAutomationTestFramework.Pages
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static SignInPage SignInPage
        {
            get { return GetPage<SignInPage>(); }
        }
    }

}
