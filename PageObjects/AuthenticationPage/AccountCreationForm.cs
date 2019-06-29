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

        private IWebElement CreateAccountButton => this.Driver.FindElementById("SubmitCreate");

        private IWebElement ValidationDiv => this.Driver.FindElement(By.CssSelector("#create-account_form div[class*='form-group']"));

        private IWebElement AccountCreationError => this.Driver.WaitUntilElementExists(By.CssSelector("#create_account_error li"), 1000);

        public Boolean IsEmailValid => this.ValidationDiv.GetAttribute("class").Contains("form-ok");

        public void EnterEmail(string email)
        {
            this.EmailField.Clear();
            this.EmailField.SendKeys(email);
            this.EmailField.SendKeys(Keys.Tab);
        }

        public void SubmitEmail(string email)
        {
            EnterEmail(email);
            this.CreateAccountButton.Click();
        }

        public void UnfocusEmailField()
        {
            this.EmailField.Click();
            this.EmailField.SendKeys(Keys.Tab);
        }

        public string AccountCreationErrorMessage
        {
            get
            {
                if (this.AccountCreationError == null)
                {
                    return "";
                }
                else
                {
                    return AccountCreationError.Text;
                }
            }
        }

    }
}
