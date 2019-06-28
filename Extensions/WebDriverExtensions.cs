using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopDemo.Extensions
{
    internal static class WebDriverExtensions
    {
        public static IWebElement FindElementById(this IWebDriver driver, string id)
        {
            return driver.FindElement(By.Id(id));
        }
    }
}
