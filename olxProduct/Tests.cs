using System;
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
        { pageWithProduct.openMainPage(); }

        [Test]
        public void LookAtThePhotos()
        { pageWithProduct.lookThroughPhotos(); }

        [Test]
        public void writeEmail()
        { pageWithProduct.sendEmail(); }

        [Test]
        public void showPhoneNumber()
        { pageWithProduct.showPhone(); }

        [Test]
        public void showAnotherAds()
        { pageWithProduct.showAdvertisment(); }

        [Test]
        public void AddProductTheBusket()
        {
            pageWithProduct.AddToTheBasket();
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            browser.Close();
        }
    }
}