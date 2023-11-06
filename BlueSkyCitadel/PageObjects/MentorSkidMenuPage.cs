using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSkyCitadel.PageObjects
{
    internal class MentorSkidMenuPage : WebHook
    {
        

        public void ClickOnMenu(string menu)
        {
            driver.FindElement(By.LinkText(menu)).Click();
    }

    }
}
