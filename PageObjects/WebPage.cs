using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationDemo.PageObjects
{
    internal class WebPage : PageComponent
    {
        internal WebPage(IWebDriver driver, string url) :
            base(driver, driver)
        {
            this.Url = url;
        }

        internal string Url { get; }

        // Allow for overriding in case a page needs additional navigation or wait logic
        internal virtual void GoToPage()
        {
            Driver.Navigate().GoToUrl(this.Url);
        }
    }
}
