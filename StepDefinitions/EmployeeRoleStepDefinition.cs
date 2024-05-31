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
    public class EmployeeRoleStepDefinition
    {
        private readonly IWebDriver _driver;
        ScenarioContext _scenarioContext;
        private readonly EmployeeRole _employeeRole;
      


        public EmployeeRoleStepDefinition(IWebDriver driver, ScenarioContext scenarioContext)
        {

            _driver = driver;
            _employeeRole = new EmployeeRole(_driver);
            _scenarioContext = scenarioContext;
        }

        [When(@"the admin accesses the User Management section")]
        public void WhenTheAdminAccessesTheUserManagementSection()
        {
            Console.WriteLine("Hello world ");
            _employeeRole.ClickAdminButton();
        }

        [When(@"the admin selects an employee to modify")]
        public void WhenTheAdminSelectsAnEmployeeToModify()
        {
           
        }

        [When(@"the admin changes the role of the employee")]
        public void WhenTheAdminChangesTheRoleOfTheEmployee()
        {
           
        }

        [When(@"the admin saves the changes")]
        public void WhenTheAdminSavesTheChanges()
        {
          
        }

        [Then(@"the system should update the employee's role")]
        public void ThenTheSystemShouldUpdateTheEmployeesRole()
        {
         
        }

        [Then(@"the admin sees a confirmation message ""([^""]*)""")]
        public void ThenTheAdminSeesAConfirmationMessage(string p0)
        {
           
        }

    }
}
