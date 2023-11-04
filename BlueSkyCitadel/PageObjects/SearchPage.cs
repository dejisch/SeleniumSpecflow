using OpenQA.Selenium;
using BlueSkyCitadel.Hooks;
using FluentAssertions;

namespace BlueSkyCitadel.PageObjects
{
    class SearchPage
    {
        public IWebDriver driver;

        private By searchField = By.Id("search-courses-input");
        private By searchButton = By.XPath("//*[@id='header']/div/div[2]/div/div/div/div[2]/div[1]/div/a");

        public void ValidateSearchURL()
        {
            driver.Url.Should().Be("https://prepmajor.com/courses/?search=Advance");

        }

        public string GetSearchURL()
        {
            return driver.Url;

        }
        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public SearchPage()
        {
            driver = WebHook.driver;
        }

        public void ClickSearchField()
        {
            driver.FindElement(searchField).Click();
        }

        public void TypeIntoSearchField()
        {
            driver.FindElement(searchField).SendKeys("Advance");
        }
    }
}
