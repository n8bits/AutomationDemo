using AutomationDemo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebShopDemo.Extensions;

namespace WebShopDemo.PageObjects.AuthenticationPage
{
    internal class AccountCreationForm : PageComponent
    {
        internal AccountCreationForm(IWebDriver driver, ISearchContext context) 
            : base(driver, context)
        {
        }

        private IWebElement EmailField => this.Driver.FindElement(By.Id("email_create"));

        private IWebElement CreateAccountButton => this.Driver.FindElementById("email_create");

        private IWebElement ValidationDiv => this.Driver.FindElement(By.CssSelector("#create-account_form div[class*='form-group']"));

        public Boolean IsEmailValid => this.ValidationDiv.GetAttribute("class").Contains("form-ok");

        public void EnterEmail(string email)
        {
            this.EmailField.Clear();
            this.EmailField.SendKeys(email);
            this.EmailField.SendKeys(Keys.Tab);
        }

        public void UnfocusEmailField()
        {
            this.EmailField.Click();
            this.EmailField.SendKeys(Keys.Tab);
        }

    }
}
