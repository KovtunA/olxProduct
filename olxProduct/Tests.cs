﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace SetupPlayground
{
    [TestFixture]
    public class Class1
    {
        IWebDriver browser;
        homePage pageWithProduct;
        public IWebElement logoButton;

        [OneTimeSetUp]
        public void openBrowser()
        { browser = new ChromeDriver(); }

        [SetUp]
        public void prepare()
        {
            pageWithProduct = new homePage(browser);
            pageWithProduct.open();
        }

        [Test]
        public void GoToHomePage()
        {
            pageWithProduct.openMainPage();
        }

        [Test]
        public void LookAtThePhotos()
        {
            pageWithProduct.lookThroughPhotos();
        }


        //[Test]
        //public void emailme()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl(GoodsUrl);
        //    var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
        //    Actions actions = new Actions(browser);
        //    actions.MoveToElement(element);
        //    actions.Perform();
        //    IWebElement mail = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
        //    mail.Click();
        //    browser.Close();
        //}

        //[Test]
        //public void contact()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl(GoodsUrl);
        //    var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
        //    Actions actions = new Actions(browser);
        //    actions.MoveToElement(element);
        //    actions.Perform();
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    IWebElement contac = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
        //    contac.Click();
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    browser.Close();
        //}

        //[Test]
        //public void otherads()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl(GoodsUrl);
        //    IWebElement otherad = browser.FindElement(By.CssSelector("#offeractions > div.offer-sidebar__box > div.offer-user__details > a"));
        //    otherad.Click();
        //    browser.Close();

        //}

        //[Test]
        //public void addToBasket()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl(GoodsUrl);
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    var element = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
        //    Actions actions = new Actions(browser);
        //    actions.MoveToElement(element);
        //    actions.Perform();
        //    IWebElement star = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
        //    star.Click();
        //    browser.Close();
        //}

        //[Test]
        //public void logo()
        //{
        //    IWebDriver browser = new OpenQA.Selenium.Chrome.ChromeDriver();
        //    browser.Navigate().GoToUrl(GoodsUrl);
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    IWebElement cont = browser.FindElement(By.Id("headerLogo"));
        //    cont.Click();
        //    browser.Close();
        //}



        [OneTimeTearDown]
        public void closeBrowser()
        {
            browser.Close();
        }
    }
}