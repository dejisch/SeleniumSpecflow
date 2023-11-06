using BlueSkyCitadel.Hooks;
using BlueSkyCitadel.PageObjects;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.StepDefinitions
{
    [Binding]
    public class MenuStepDefinitions : WebHook
    {
        MentorSkidMenuPage _mentorSkidMenuPage = new MentorSkidMenuPage();

        [When(@"I click on the menu ""([^""]*)""")]
        public void WhenIClickOnTheMenu(string menu)
        {
            //================without pageobject
            //driver.FindElement(By.LinkText(menu)).Click();
            //============================

            //================with pageobject
            _mentorSkidMenuPage.ClickOnMenu(menu);
        }

        [Then(@"the text ""([^""]*)"" is displayed on the find a mentor page")]
        public void ThenTheTextIsDisplayedOnTheFindAMentorPage(string text)
        {
            //===================================
            //One Step
            //driver.FindElement(By.CssSelector("body > main > section > div > div > div.col-lg-12 > div > div > h3")).Displayed.Should().BeTrue();
            //=============================================

            //Simple broken steps
            bool IsTextDisplayed = driver.FindElement(By.CssSelector("body > main > section > div > div > div.col-lg-12 > div > div > h3")).Displayed;

            IsTextDisplayed.Should().BeTrue();  

        }

        [Given(@"I navigate to website ""([^""]*)""")]
        public void GivenINavigateToWebsiteHttpsMentorskid_Com(string url)
        {
            driver.Navigate().GoToUrl(url);
        }



        [Then(@"the url ""([^""]*)"" is displayed")]
        public void ThenTheUrlIsDisplayed(string url)
        {
            driver.Url.Should().Be(url);
        }

        [Then(@"the text ""([^""]*)"" is displayed on the about us page")]
        public void ThenTheTextIsDisplayedOnThePage(string text)
        {
            //We need to use relative XPath or CSS here instead of the below absolute CSS
            driver.FindElement(By.CssSelector("body > main > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-98c0385.elementor-section-full_width.elementor-section-stretched.elementor-section-height-default.elementor-section-height-default > div > div > div > div.elementor-element.elementor-element-051d391.animated-fast.elementor-widget.elementor-widget-tuturn_working_process > div > div > div > div.tu-betterresult.tu-processing-content > div > h4")).Text.Should().Be(text);
        }

    }
}
