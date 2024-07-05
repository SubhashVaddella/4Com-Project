using Dynamics365Project.Hooks;
using Dynamics365Project.PageObjectModel;
using LivingDoc.Dtos;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace BookingFormProject.Steps
{
    [Binding]
    public class NavigateSteps
    {

        public IWebDriver driver = WebHooks.driver;
        String websiteURL = "https://www.google.co.uk/";
        GooglePage _GooglePage = new GooglePage();

        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }


        [Given(@"I navigate to Google")]
        public void GivenINavigateToGoogle()
        {
            driver.Navigate().GoToUrl(websiteURL);
            driver.Manage().Window.Maximize();
        }

        [Given(@"I Accept All the Cookies")]
        public void GivenIAcceptCookies()
        {
            _GooglePage.ClickAcceptAll();
            
        }

        [Then(@"the page title should be ""([^""]*)""")]
        public void ThenThePageTitleShouldBe(string expectedTitle)
        {
            string actualTitle = _GooglePage.GetPageTitle();
            Assert.AreEqual(expectedTitle, actualTitle, $"The page title is not as expected. Expected: {expectedTitle}, Actual: {actualTitle}");
        }


        [Given(@"I search for ""([^""]*)""")]
        public void WhensearchforDetails(String value)
        {
            _GooglePage.SetSearchValue(value);

        }

        [When(@"I click on the search result for Dynamics 365")]
        public void WhenIClickOnTheSearchResultForBusinessApplications()
        {
            _GooglePage.ClickSearchResultTitle();
        }

        [Then(@"I wait for (\d+) seconds")]
        public void ThenWaitForSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}
