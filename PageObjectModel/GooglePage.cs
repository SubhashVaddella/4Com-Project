using System;
using OpenQA.Selenium;
using Dynamics365Project.Hooks;

namespace Dynamics365Project.PageObjectModel
{
    internal class GooglePage
    {
        #region Locators

        public IWebDriver driver;

        private By AcceptCookies = By.XPath("//div[text()='Accept all']");
        private By GoogleSearchBar = By.XPath("//textarea[@id='APjFqb']");
        private By searchResultTitle = By.XPath("//h3[contains(text(), 'Business Applications | Microsoft Dynamics 365')]");

        #endregion

        #region Constructor

        public GooglePage()
        {
            driver = WebHooks.driver;
        }
        #endregion

        #region Actions

        public void ClickAcceptAll()
        {
            driver.FindElement(AcceptCookies).Click();
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public void ClickSearchResultTitle()
        {
            var resultTitle = driver.FindElement(searchResultTitle);
            resultTitle.Click();
        }

        public void SetSearchValue(string value)
        {
            driver.FindElement(GoogleSearchBar).SendKeys(value + Keys.Enter);
        }


        #endregion
    }
}
