using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM9.POM;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRM9.StepDefinitions
{
    [Binding]
    public class OrangeHRMFeatureStepDefinitions
    {

        IWebDriver _driver;
        LoginPage _loginPage;
        public OrangeHRMFeatureStepDefinitions()
        {
           
            _driver = new ChromeDriver();
            _loginPage = new LoginPage(_driver);
        }


        [Given(@"the user is on the OrangeHRM login page")]
        public void GivenTheUserIsOnTheOrangeHRMLoginPage()
        {
            _loginPage.NavigateToLoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
           
        }

        [When(@"the user enters valid username (.*) and password (.*)")]
        public void WhenTheUserEntersValidUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUserNameAndPassWord(username, password); //static values
        }

        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            _loginPage.ClickButton();
        }

        [Then(@"the user is redirected to the dashboard page")]
        public void ThenTheUserIsRedirectedToTheDashboardPage()
        {
            //Assert.True(_loginPage.IsDashBoardVisible(), "Dasboard is not visible");
            Assert.IsTrue(_driver.Url.Contains("dashboard"));
        }

        [When(@"the user enters an incorrect (.*) and/or (.*)")]
        public void WhenTheUserEntersAnIncorrectUsernameAndOrPassword(string userId, string password)
        {
           _loginPage.EnterUserNameAndPassWord(userId, password);
        }

        //[Then(@"the user sees an error (.*)")]
        //public void ThenTheUserSeesAnErrorMessage(string message)
        //{
        //    //_loginPage.IsError();
        //    Assert.AreEqual(message,_loginPage.IsError().Trim());

        //}

        [When(@"the user enters only (.*)")]
        public void WhenTheUserEntersOnlyPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [Then(@"the user sees an invalid error (.*)")]
        public void ThenTheUserSeesAnErrorInvalidmsg(string errorMsg)
        {
            Assert.AreEqual(errorMsg, _loginPage.IsError().Trim());
        }

        [Then(@"the user sees an error (.*)")]
        public void ThenTheUserSeeAnErrorRequired(string requiredMsg)
        {
            Assert.AreEqual(requiredMsg, _loginPage.IsUserNameRequired().Trim());
        }


        [Then(@"the user sees an username error (.*)")]
        public void ThenTheUserSeesAnusernameErrorRequired(string requiredMsg)
        {
            Assert.AreEqual(requiredMsg, _loginPage.IsUserNameRequired().Trim());
        }
        [Then(@"the user sees an password error (.*)")]
        public void ThenTheUserSeesAnPasswordErrorRequired(string requiredMsg)
        {
            Thread.Sleep(1000);
            Assert.AreEqual(requiredMsg, _loginPage.IsPasswordRequired().Trim());
        }
    }
}
