using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V122.LayerTree;
using OrangeHRM9.POM;
using Slack.Webhooks.Elements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.StepDefinitions
{
    [Binding]
    public class EmployeeListStepDifinition
    {
        private readonly IWebDriver _driver;
        private readonly EmployeeList _employeeList;
        private readonly LoginPage _loginPage;

        

        public EmployeeListStepDifinition()
        {
            _driver = new ChromeDriver();
            _employeeList = new EmployeeList(_driver);
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"the user is logged in and on the Employee List page (.*) (.*)")]
        public void GivenTheUserIsLoggedInAndOnTheEmployeeListPage(string username,string password)
        {
            _loginPage.NavigateToLoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _loginPage.EnterUserNameAndPassWord(username, password);
            _loginPage.ClickButton();
            Assert.IsTrue(_driver.Url.Contains("dashboard"));

            Thread.Sleep(1000);
            _employeeList.PimBtn();
            Thread.Sleep(1000);
            Assert.IsTrue(_driver.Url.Contains("pim"));
        }

        [When(@"the user clicks on Add Employee")]
        public void WhenTheUserClicksOn()
        {
            _employeeList.AddEmployeeBtn();
            Thread.Sleep(1000);
            Assert.IsTrue(_driver.Url.Contains("addEmployee"));
        
        }

        [When(@"the user enters valid details for the new employee (.*) (.*) (.*)")]
        public void WhenTheUserEntersValidDetailsForTheNewEmployee(string fname , string mname , string lname )
        {
            _employeeList.EnterDetail(fname, mname, lname);
        }

        [When(@"the user clicks the save button")]
        public void WhenTheUserClicksTheSaveButton()
        {
            _employeeList.saveBtnClick();
        }

        [Then(@"the new employee should be listed in the Employee List (.*) (.*) (.*)")]
        public void ThenTheNewEmployeeShouldBeListedInTheEmployeeList(string fname, string mname, string lname)
        {
            Thread.Sleep(5000);
            Console.WriteLine(_driver.Url);
            Assert.True(_driver.Url.Contains("viewPersonalDetails"));
            Console.WriteLine(_driver.Url.Contains("viewPersonalDetails"));
            Thread.Sleep(10000);
            string empfull = _employeeList.EmployeeDetails();
            string[] arremp = empfull.Split(":");
            //Assert.AreEqual("Manoj2", arremp[0].Trim());
            Assert.AreEqual(fname, arremp[0].Trim());
            //Assert.AreEqual("Kumar2", arremp[1].Trim());
            Assert.AreEqual(mname, arremp[1].Trim());
            //Assert.AreEqual("Botta2", arremp[2].Trim());
            Assert.AreEqual(lname, arremp[2].Trim());
        }
    }
}
