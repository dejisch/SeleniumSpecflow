using OpenQA.Selenium;
using BlueSkyCitadel.Hooks;

namespace BlueSkyCitadel.PageObjects
{
    class SearchPage
    {
        public IWebDriver driver;

        private By searchField = By.Id("search-courses-input");

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
            driver.FindElement(searchField).SendKeys("Automation");
        }
    }
}
