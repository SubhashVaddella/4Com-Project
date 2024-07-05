using OpenQA.Selenium;
using Dynamics365Project.Hooks;
using System;

namespace Dynamics365Project.PageObjectModel
{
    internal class Dynamics365Page
    {
        #region Locators

        public IWebDriver driver;
        private By logoImage = By.CssSelector("img.c-image[itemprop='logo']");
        private By dynamics365Text = By.XPath("//*[@id='uhfCatLogo']/span");
        private By h1Element = By.XPath("//h1[contains(text(), 'The new era of AI-powered business')]");
        private By solutionsLink = By.XPath("//a[contains(@class, 'menu-list__item-link') and contains(@aria-label, 'Solutions')]");

        #endregion

        #region Constructor

        public Dynamics365Page()
        {
            driver = WebHooks.driver;
        }
        #endregion

        #region Actions

        public bool IsLogoImageDisplayed()
        {
            return driver.FindElement(logoImage).Displayed;
        }

        public string GetDynamics365Text()
        {
            return driver.FindElement(dynamics365Text).Text;
        }

        public string GetH1ElementText()
        {
            return driver.FindElement(h1Element).Text;
        }

        #endregion
    }
}
