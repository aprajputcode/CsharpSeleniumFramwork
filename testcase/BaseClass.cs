using demo.driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace demo.testcase
{
    public class BaseClass
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            Driver.Init();

        }
        
        [TearDown]
        public void afterEach()
        {
            Driver.Current.Quit();
        }
    }
}
