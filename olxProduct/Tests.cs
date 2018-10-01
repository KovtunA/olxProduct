using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace olxProduct
{
    [TestFixture]
    public class Class1
    {
        static string GoodsUrl = "https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7";
        static void pageWithgoods(OpenQA.Selenium.Chrome.ChromeDriver browser)
        {
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
        }

        [Test]
        public void go_to_home_page()
        {
            ChromeDriver browser = new ChromeDriver();
            pageWithgoods(browser);
            IWebElement button = browser.FindElement(By.CssSelector("#headerLogo"));
            button.Click();
            IWebElement button1 = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button1.Click();
            browser.Close();
        }

        [Test]
        public void submit_search()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement button = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button.Click();
            browser.Close();
        }

        [Test]
        public void choicephoto()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
            IWebElement hare = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(4) > div > img"));
            hare.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement button = browser.FindElement(By.CssSelector("#bigImage > div.lshownext.abs.cpointer.bigImageNext > a > span"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            browser.Close();
        }

        [Test]
        public void emailme()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            IWebElement mail = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
            mail.Click();
            browser.Close();
        }

        [Test]
        public void contact()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement contac = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
            contac.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            browser.Close();
        }

        [Test]
        public void otherads()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            IWebElement otherad = browser.FindElement(By.CssSelector("#offeractions > div.offer-sidebar__box > div.offer-user__details > a"));
            otherad.Click();
            browser.Close();

        }

        [Test]
        public void addToBasket()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var element = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            IWebElement star = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
            star.Click();
            browser.Close();
        }

        [Test]
        public void logo()
        {
            IWebDriver browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement cont = browser.FindElement(By.Id("headerLogo"));
            cont.Click();
            browser.Close();
        }
    }
}