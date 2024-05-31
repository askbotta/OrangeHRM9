using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM9.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.StepDefinitions
{
    [Binding]
    public class LeaveStepDefinitions
    {
        IWebDriver _driver;
        ScenarioContext _scenarioContext;
        LoginPage _loginPage;
        LeavePage _leavePage;

        public LeaveStepDefinitions(ScenarioContext scenarioContext)
        {
            _driver = new ChromeDriver();
            _scenarioContext = scenarioContext;
            _loginPage = new LoginPage(_driver);
            _leavePage = new LeavePage(_driver);

        }

        [Given(@"the user is logged in and on the Dashboard (.*) (.*)")]
        public void GivenTheUserIsLoggedInAndOnTheDashboard(string username , string password)
        {
            _loginPage.NavigateToLoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _loginPage.EnterUserNameAndPassWord(username, password);
            _loginPage.ClickButton();
            Assert.IsTrue(_driver.Url.Contains("dashboard"));
            Thread.Sleep(5000);
        }

        [When(@"the user navigates to the Leave section (.*) (.*)")]
        public void WhenTheUserNavigatesToTheLeaveSection(string fromDate, string toDate)
        {
            _leavePage.NavigateToLeavePage();
            Thread.Sleep(2000);
            _leavePage.FromDate(fromDate);
            Thread.Sleep(2000);
            _leavePage.ToDate(toDate);
            Thread.Sleep(2000);
        }

        [When(@"the user clicks on ""([^""]*)""")]
        public void WhenTheUserClicksOn(string apply)
        {

        }

        [When(@"the user fills out the leave application form")]
        public void WhenTheUserFillsOutTheLeaveApplicationForm()
        {
            
        }

        [When(@"the user submits the request")]
        public void WhenTheUserSubmitsTheRequest()
        {
           
        }

        [Then(@"the leave request should be recorded in the system")]
        public void ThenTheLeaveRequestShouldBeRecordedInTheSystem()
        {
           
        }

        [Then(@"the user sees a confirmation message ""([^""]*)""")]
        public void ThenTheUserSeesAConfirmationMessage(string p0)
        {
           
        }

    }
}
