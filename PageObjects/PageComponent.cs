using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationDemo.PageObjects
{
    /// <summary>
    /// Base class for all web page components and web pages. 
    /// </summary>
    internal abstract class PageComponent
    {
        internal PageComponent(IWebDriver driver, ISearchContext context)
        {
            this.Driver = driver;
            this.Context = context;
        }

        protected IWebDriver Driver { get; }

        protected ISearchContext Context { get; }

    }
}
