using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSAP.POM
{
    class LoginPageModel
    {
        public LoginPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "login_inputUsername")]
        public IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "login_inputPassword")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "login_btnOK")]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[@class = 'c1'])[position() = 2 ]")]
        public IWebElement alreadyLogin { get; set; }

        public AddOnPageModel LogIn()
        {
            userName.SendKeys("nbsqa05");
            password.SendKeys("Welcome5");
            submitButton.Click();
            try
            {
                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                alreadyLogin.Click();
            }
            catch (Exception)
            {

            }

            Console.WriteLine("Login Functionality - PASS");
            return new AddOnPageModel();
        }
    }
}
