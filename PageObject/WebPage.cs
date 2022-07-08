using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.PageObject
{
    internal class WebPage
    {
        private IWebDriver _driver;
        public WebPage(IWebDriver driver)
        {
            _driver = driver;

        }

        public void Url(String url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }

        public IWebElement cards()
        {
            return _driver.FindElement(By.CssSelector("a[href='/cards']"));
        }
        public String headerMedium_name()
        {
            return _driver.FindElement(By.CssSelector("div[class='ui__headerMedium']")).Text;
        }
        public IWebElement CardName(String cardname)

        {
            cardname=cardname.Replace(" ", "+");
            return _driver.FindElement(By.XPath("//a[contains(@href,'/"+cardname+"')]"));
        }
        public String CardNameText()
        {
            return _driver.FindElement(By.CssSelector("div[class='ui__headerMedium card__cardName']")).Text;
        }

    }
}
