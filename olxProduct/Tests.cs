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

        [Test]
        public void writeEmail()
        {
            pageWithProduct.sendEmail();
        }

        [Test]
        public void showPhoneNumber()
        {
            pageWithProduct.showPhone();
        }

        [Test]
        public void showAnotherAds()
        {
            pageWithProduct.showAdvertisment();
        }


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