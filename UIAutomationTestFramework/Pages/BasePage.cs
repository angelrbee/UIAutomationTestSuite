using OpenQA.Selenium.Support.PageObjects;

namespace UIAutomationTestFramework.Pages
{
    public class BasePage
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static HomePage HomePage
        {
            get { return GetPage<HomePage>(); }
        }
    }

}
