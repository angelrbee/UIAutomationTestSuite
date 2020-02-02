using NUnit.Framework;

namespace UIAutomationTestFramework
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void Initialize()
        {
            Browser.Initialize();
            
        }
    }
}
