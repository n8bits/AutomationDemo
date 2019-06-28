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

        protected string Url { get; }

        // Allow for overriding in case a page needs additional wait logic when loading.
        internal virtual void GoToPage()
        {
            Driver.Navigate().GoToUrl(this.Url);
        }
    }
}
