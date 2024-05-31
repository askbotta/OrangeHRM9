using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.POM
{
    public class EmployeeList
    {
        private readonly IWebDriver _driver;

        public string pimBtn = "//span[text()='PIM']";

        public string addEmployeeBtn = "//a[text()='Add Employee']";
        public string firstName = "//input[@name='firstName']";
        public string middleName = "//input[@name='middleName']";
        public string lastName = "//input[@name='lastName']";
        public string createLoginDetailscbk = "//input[@type='checkbox']";
        public string username = "//input[@class='oxd-input oxd-input--active']//following::label[contains(text(),'Username')]";
        public string passwrod = "(//label[contains(text(),'Password')]//following::input[@class='oxd-input oxd-input--active'])[1]";
        public string confirmPassword = "(//label[contains(text(),'Password')]//following::input[@class='oxd-input oxd-input--active'])[2]";
        public string saveBtn = "//button[@type='submit']";
        public string cancelBtn = "//button[text()=' Cancel ']";

        public string employeeFirstName = "//input[@name='firstName']";
        public string EmployeeMiddleName = "//input[@name='middleName']";
        public string EmployeLastName = "//input[@name='lastName']";

        public string employeeId = "//label[contains(text(),'Employee Id')]//following::input[@class='oxd-input oxd-input--active']";


        public EmployeeList(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void PimBtn()
        {
            _driver.FindElement(By.XPath(pimBtn)).Click();
        }

        public void AddEmployeeBtn()
        {
            _driver.FindElement(By.XPath(addEmployeeBtn)).Click();
        }

        public void EnterDetail(string fname,string mname,string lname)
        {
            //_driver.FindElement(By.XPath(firstName)).SendKeys("Manoj2");
            _driver.FindElement(By.XPath(firstName)).SendKeys(fname);
            //_driver.FindElement(By.XPath(middleName)).SendKeys("Kumar2");
            _driver.FindElement(By.XPath(middleName)).SendKeys(mname);
            //_driver.FindElement(By.XPath(lastName)).SendKeys("Botta2");
            _driver.FindElement(By.XPath(lastName)).SendKeys(lname);
            Thread.Sleep(3000);
            //_driver.FindElement(By.XPath(employeeId)).Click();
            //Thread.Sleep(1000);
            _driver.FindElement(By.XPath(employeeId)).Clear();
            Thread.Sleep(1000);
            int employeId = EmployeeIdCount();
            _driver.FindElement(By.XPath(employeeId)).SendKeys(employeId.ToString());
        }
        public void CreateLoginDetails()
        {
            //IReadOnlyCollection<IWebElement> arrayRadioBtn = _driver.FindElements(By.XPath("//input[@type='checkbox']"));

            //foreach (var radioButton in arrayRadioBtn)
            //{
            //    if (radioButton.Enabled) // Example condition
            //    {
            //        radioButton.Click(); // Click on the radio button if it's enabled
            //    }
            //}
        }

        public void saveBtnClick()
        {
            _driver.FindElement(By.XPath(saveBtn)).Click();
        }

        public string EmployeeDetails()
        {
            Thread.Sleep(3000);
            string fname = _driver.FindElement(By.XPath(employeeFirstName)).GetAttribute("value");
            Console.WriteLine("fname" + ":" +fname);
            string mName = _driver.FindElement(By.XPath(EmployeeMiddleName)).GetAttribute("value");
            string lName = _driver.FindElement(By.XPath(EmployeLastName)).GetAttribute("value");
            return fname +":"+ mName +":"+ lName;
        }
        public int EmployeeIdCount()
        {
            Random rnd = new Random();
            return rnd.Next(0400, 0900);
        }
    }
}
