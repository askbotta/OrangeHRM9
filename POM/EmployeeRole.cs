using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.POM
{
    public class EmployeeRole
    {
        IWebDriver _driver;

        private readonly string adminButton = "//a//span[text()='Admin']";
        private readonly string userNameSort = "(//i[@class='oxd-icon bi-sort-alpha-down oxd-icon-button__icon oxd-table-header-sort-icon'])[2]";
        private readonly string pencilButton = "(//label[text()='User Role']//following::i[@class='oxd-icon bi-caret-down-fill oxd-select-text--arrow'])[1]";
        
        public EmployeeRole(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickAdminButton()
        {
            _driver.FindElement(By.XPath(adminButton)).Click();
            Thread.Sleep(3000);
            Assert.IsTrue(_driver.Url.Contains("admin"));
            Console.WriteLine(adminButton);

        }

        public void ClickPencilButton()
        {

            _driver.FindElement(By.XPath(userNameSort)).Click();
            _driver.FindElement(By.XPath(pencilButton)).Click();
        }

        //Actions oAction = new Actions(driver);
        //oAction.Sendkeys(Keys.ArrowDown).Perform();
        //oAction.SendKeys(Keys.Enter).Perform();

    }
}
