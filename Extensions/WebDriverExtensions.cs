using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebShopDemo.Extensions
{
    internal static class WebDriverExtensions
    {
        public static IWebElement FindElementById(this IWebDriver driver, string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static IWebElement WaitUntilElementExists(this IWebDriver driver, By by, int timeoutMilliseconds = 5000)
        {
            Func<IWebDriver, IWebElement> elementWaiter = new Func<IWebDriver, IWebElement>((IWebDriver webDriver) =>
            {
                var element = webDriver.FindElements(by).FirstOrDefault();

                return element; 
            });

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeoutMilliseconds));

            return wait.Until(elementWaiter);
        }
    }
}
