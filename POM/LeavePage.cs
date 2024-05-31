using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.POM
{
    public class LeavePage
    {
        IWebDriver driver;
        private readonly string leavBtn =  "//a//span[text()='Leave']";
        private readonly string applyBtn = "//a[text()='Apply']";

        private readonly string fromDate = "(//label[text()='From Date']//following::input[@class='oxd-input oxd-input--active'])[1]";
        private readonly string toDate = "(//label[text()='To Date']//following::input[@class='oxd-input oxd-input--active'])[1]";
        private readonly string showLeavewithStatus = "//label//following::div[text()='Select']";
        private readonly string pendingApproval = "//span[text()='Pending Approval']";
        private readonly string leaveType = "(//label[text()='Leave Type']//following::div[text()='-- Select --'])[1]";
        private readonly string subUnit = "(//label[text()='Sub Unit']//following::div[text()='-- Select --'])[1]";
        private readonly string employeeName = "//input[@placeholder='Type for hints...']";

        public LeavePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToLeavePage()
        {
            driver.FindElement(By.XPath(leavBtn)).Click();
            Assert.IsTrue(driver.Url.Contains("leave"));
        }

        public void FromDate(string date)
        {
            var selectFromDate = driver.FindElement(By.XPath(fromDate));
            selectFromDate.SendKeys(Keys.Control + "a");
            selectFromDate.SendKeys(Keys.Delete);
            selectFromDate.SendKeys(date);
            Thread.Sleep(1000);
        }

        public void ToDate(string date)
        {
            var selectToDate = driver.FindElement(By.XPath(toDate));
            selectToDate.SendKeys(Keys.Control + "a");
            selectToDate.SendKeys(Keys.Delete);
            selectToDate.SendKeys(date);
            Thread.Sleep(1000);
        }

        public void ChooseShowLeaveWithStatus()
        {

        }


    }
}
