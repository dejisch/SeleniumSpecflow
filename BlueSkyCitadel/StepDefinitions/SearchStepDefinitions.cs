using BlueSkyCitadel.Hooks;
using BlueSkyCitadel.PageObjects;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        SearchPage _searchPage = new SearchPage();

        [Given(@"I navigate to PrepMajor\.com")]
        public void GivenINavigateToPrepMajor_Com()
        {
            driver.Navigate().GoToUrl("https://www.prepmajor.com");
        }

        [When(@"I click on the search field")]
        public void WhenIClickOnTheSearchField()
        {
            _searchPage.ClickSearchField();
        }

        [When(@"I type automation in the search field")]
        public void WhenITypeAutomationInTheSearchField()
        {
           _searchPage.TypeIntoSearchField();
        }

        [When(@"I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
            _searchPage.ClickSearchButton();
        }

        [Then(@"the result page is displayed")]
        public void ThenTheResultPageIsDisplayed()
        {
            //validate your test without using page object
            //driver.Url.Should().Be("https://prepmajor.com/courses/?search=Advance");

            //Validates test with page object with assertion inside the page object
            // _searchPage.ValidateSearchURL(); 


            //Best Practice: Validates test using page object and assertionis in the step definition
            _searchPage.GetSearchURL().Should().Be("https://prepmajor.com/courses/?search=Advance");

        }
    }
}
