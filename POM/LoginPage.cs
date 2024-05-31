using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM9.POM
{
    
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        string _username = "//input[@name='username']";
        string _password = "//input[@name='password']";
        string _submitBtn = "//button[@type='submit']";
        string _dashBoard = "//h6[text()='Dashboard']";
        string _errorMsg = "//p[text()='Invalid credentials']";
        string _usernameRequiredMsg = "(//span[text()='Required'])[1]";
        string _passwordRequiredMsg = "(//span[text()='Required'])[2]";
       // string url = ;


        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void NavigateToLoginPage(string url) 
        {
            _driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            _driver.Manage().Window.Maximize();
        }

        public void EnterUserNameAndPassWord(string userName, string password)
        {
            _driver.FindElement(By.XPath(_username)).SendKeys(userName);
            _driver.FindElement(By.XPath(_password)).SendKeys(password);
        }
        public void EnterPassword(string password)
        {
            _driver.FindElement(By.XPath(_password)).SendKeys(password);
        }

        public void ClickButton()
        {
            _driver.FindElement(By.XPath(_submitBtn)).Click();
        }



        public bool IsDashBoardVisible()
        {
            Thread.Sleep(1000);
            return _driver.FindElement(By.XPath(_dashBoard)).Displayed;
        }
        //public bool IsError()
        //{
        //    Thread.Sleep(1000);
        //        return _driver.FindElement(By.XPath(_errorMsg)).Displayed;
        //}

        public string IsError()
        {
            Thread.Sleep(1000);
            return _driver.FindElement(By.XPath(_errorMsg)).Text;
        }
        public string IsUserNameRequired()
        {
            Thread.Sleep(1000);
            return _driver.FindElement(By.XPath(_usernameRequiredMsg)).Text;
        }
        public string IsPasswordRequired()
        {
            Thread.Sleep(1000);
            return _driver.FindElement(By.XPath(_passwordRequiredMsg)).Text;
        }


    }
}
