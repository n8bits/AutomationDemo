using AutomationDemo.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationDemo.Steps
{
    [Binding]
    public class UserRegistrationSteps
    {
        private readonly IWebDriver driver;

        public UserRegistrationSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am an unregistered user")]
        public void GivenIAmAnUnregisteredUser()
        {
            
        }
        
        [Given(@"I have navigated to the Sign in page")]
        public void GivenIHaveNavigatedToTheSignInPage()
        {
            AuthenticationPage authPage = new AuthenticationPage(driver);
            authPage.GoToPage();
        }
        
        [When(@"I enter a valid email address in the email address field")]
        public void WhenIEnterAValidEmailAddressInTheEmailAddressField()
        {
            AuthenticationPage authPage = new AuthenticationPage(driver);
            authPage.AccountCreationForm.EnterEmail("validemail@validdomain.com");
        }
        
        [When(@"I tab out of the email address field")]
        public void WhenIClickOutsideTheEmailAddressField()
        {
            AuthenticationPage authPage = new AuthenticationPage(driver);
            authPage.AccountCreationForm.UnfocusEmailField();
        }
        
        [Then(@"the style of the input box should change to indicate the email address is valid")]
        public void ThenTheStleOfTheInputBoxShouldChangeToIndicateTheEmailAddressIsValid()
        {
            AuthenticationPage authPage = new AuthenticationPage(driver);
            Assert.IsTrue(authPage.AccountCreationForm.IsEmailValid);
        }
    }
}
