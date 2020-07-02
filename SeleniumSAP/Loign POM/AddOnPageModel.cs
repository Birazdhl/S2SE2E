using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumSAP.Navsol_POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.POM
{
    class AddOnPageModel
    {
        public AddOnPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }


        [FindsBy(How = How.ClassName, Using = "c540000002")]
        public IWebElement cancelPopUp { get; set; }

        [FindsBy(How = How.Id, Using = "tree-3328-0_anchor")]
        public IWebElement administrationMenu { get; set; }

        [FindsBy(How = How.Id, Using = "tree-43523-0")]
        public IWebElement addonMenu { get; set; }

        [FindsBy(How = How.Id, Using = "tree-8201-0_anchor")]
        public IWebElement addonManagerMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'slick-cell l0 r0 row_2 cid_7']")]
        public IWebElement chooseSprint { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@title='Start']")]
        public IWebElement startButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@title='OK'])[position()=2]")]
        public IWebElement okButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Close')])[position() = 3]")]
        public IWebElement cancelSystemMessage { get; set; }

       

        public NavSetPageModel LoginToConnectAddOns()
        {
            //Thread.Sleep(10000);
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            cancelPopUp.Click();
            try
            {
                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                cancelSystemMessage.Click();
            }
            catch (Exception ex)
            {

                
            }
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(55);
            administrationMenu.Click();
            Thread.Sleep(1000);
            addonMenu.Click(); 
            addonManagerMenu.Click();
            chooseSprint.Click();
            Thread.Sleep(3000);
            startButton.Click();
            Thread.Sleep(3000);
            okButton.Click();


            Console.WriteLine("Confiuration Function Success - PASS");
            return new NavSetPageModel();

            
        }

    }


}
