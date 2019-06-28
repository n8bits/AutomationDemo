using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebShopDemo.Extensions;
using WebShopDemo.PageObjects.AuthenticationPage;

namespace AutomationDemo.PageObjects
{
    internal class AuthenticationPage : WebPage
    {
        internal AuthenticationPage(IWebDriver driver) : base(driver, @"http://automationpractice.com/index.php?controller=authentication&back=my-account")
        {

        }

        internal AccountCreationForm AccountCreationForm => new AccountCreationForm(this.Driver, Driver.FindElementById("create-account_form"));
    }
}
