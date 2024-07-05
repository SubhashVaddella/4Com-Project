using Dynamics365Project.Hooks;
using Dynamics365Project.PageObjectModel;
using LivingDoc.Dtos;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BookingFormProject.Steps
{
    [Binding]
    public class Dynamics365Steps
    {

        public IWebDriver driver = WebHooks.driver;
        Dynamics365Page _Dynamics365Page = new Dynamics365Page();

        [Then(@"the logo image should be displayed")]
        public void ThenTheLogoImageShouldBeDisplayed()
        {
            Assert.True(_Dynamics365Page.IsLogoImageDisplayed(), "Logo image is not displayed.");
        }

        [Then(@"the text ""([^""]*)"" should be visible")]
        public void ThenTheTextDynamics365ShouldBeVisible(String expectedText)
        {
            string dynamicsText = _Dynamics365Page.GetDynamics365Text();
            Assert.AreEqual(expectedText, dynamicsText, expectedText + " text is not as expected.");
        }

        [Then(@"the header text should display ""([^""""]*)""")]
        public void ThenTheH1ElementShouldDisplayTheNewEraOfAIPoweredBusiness(String expectedText)
        {
            string h1Text = _Dynamics365Page.GetH1ElementText();
            Assert.AreEqual(expectedText, h1Text, "The header text is not as expected.");
        }

    }
}
