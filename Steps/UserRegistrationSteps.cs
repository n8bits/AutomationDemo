﻿using AutomationDemo.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebShopDemo.Extensions;

namespace AutomationDemo.Steps
{
    [Binding]
    public class UserRegistrationSteps
    {
        private readonly IWebDriver driver;

        private readonly AuthenticationPage authPage;

        public UserRegistrationSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.authPage = new AuthenticationPage(driver);
        }

        [Given(@"I am an unregistered user")]
        public void GivenIAmAnUnregisteredUser()
        {
            
        }
        
        [Given(@"I have navigated to the Sign in page")]
        public void GivenIHaveNavigatedToTheSignInPage()
        {
            this.authPage.GoToPage();
        }
        
        [When(@"I enter a valid email address in the email address field")]
        public void WhenIEnterAValidEmailAddressInTheEmailAddressField()
        {
            this.authPage.AccountCreationForm.EnterEmail("validemail@validdomain.com");
        }
        
        [When(@"I tab out of the email address field")]
        public void WhenIClickOutsideTheEmailAddressField()
        {
            this.authPage.AccountCreationForm.UnfocusEmailField();
        }
        
        [Then(@"the style of the input box should change to indicate the email address is valid")]
        public void ThenTheStleOfTheInputBoxShouldChangeToIndicateTheEmailAddressIsValid()
        {
            Assert.IsTrue(authPage.AccountCreationForm.IsEmailValid);
        }

        [When(@"I attempt to begin registration using the email adress ""(.*)""")]
        public void WhenIAttemptToBeginRegistrationUsingTheEmailAdress(string email)
        {
            this.authPage.AccountCreationForm.SubmitEmail(email);
        }

        [Then(@"I should not be taken to the Account Creation page")]
        public void ThenIShouldNotBeTakenToTheAccountCreationPage()
        {
            Assert.IsTrue(driver.Url == this.authPage.Url);
        }

        [Then(@"I should see an alert indicating the email address entered is invalid")]
        public void ThenIShouldSeeAnAlertIndicatingTheEmailAddressEnteredIsInvalid()
        {
            var errorMessage = this.authPage.AccountCreationForm.AccountCreationErrorMessage;
            Assert.IsTrue(errorMessage == "Invalid email address.");
        }
    }
}
