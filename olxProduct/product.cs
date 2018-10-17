using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SetupPlayground
{
    public class homePage
    {
        IWebDriver browser;
        string homePageURL = "https://www.olx.ua";
        string productUrl = "https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7";

        [FindsBy(How = How.CssSelector, Using = "#headerLogo")]
        public IWebElement showMainPage;

        [FindsBy(How = How.CssSelector, Using = "#offerdescription > div:nth-child(4) > div > img")]
        public IWebElement showOnePhotos;

        [FindsBy(How = How.CssSelector, Using = "#bigImage > div.lshownext.abs.cpointer.bigImageNext > a > span")]
        public IWebElement showAnotherPhotos;

        [FindsBy(How = How.CssSelector, Using = "#contact_methods > li:nth-child(1) > a > span")]
        public IWebElement sendEmailButton;

        [FindsBy(How = How.CssSelector, Using = "#contact_methods > li:nth-child(2) > div")]
        public IWebElement showPhon;

        [FindsBy(How = How.CssSelector, Using = "#offeractions > div.offer-sidebar__box > div.offer-user__details > a")]
        public IWebElement showAds;

        public homePage(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

        public void open()
        { browser.Navigate().GoToUrl(productUrl); }

        public void openMainPage()
        {
            showMainPage.Click();
        }

        public void lookThroughPhotos()
        {
            showOnePhotos.Click();
            showAnotherPhotos.Click();
        }

        public void sendEmail()
        {
            sendEmailButton.Click();
        }

        public void showPhone()
        {
            showPhon.Click();
        }

        public void showAdvertisment()
        {
            showAds.Click();
        }
    }
}
