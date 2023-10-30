using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;

        [Given(@"I navigate to PrepMajor\.com")]
        public void GivenINavigateToPrepMajor_Com()
        {
            driver.Navigate().GoToUrl("https://www.prepmajor.com");
        }

        [When(@"I click on the search field")]
        public void WhenIClickOnTheSearchField()
        {
           // throw new PendingStepException();
        }

        [When(@"I type automation in the search field")]
        public void WhenITypeAutomationInTheSearchField()
        {
           // throw new PendingStepException();
        }

        [When(@"I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
           // throw new PendingStepException();
        }

        [Then(@"the result page is displayed")]
        public void ThenTheResultPageIsDisplayed()
        {
           // throw new PendingStepException();
        }
    }
}
