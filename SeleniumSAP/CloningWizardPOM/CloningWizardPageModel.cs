using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumSAP.Clone_Planner_POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.CloningWizardPOM
{
    class CloningWizardPageModel
    {
        int i = 0;
        public CloningWizardPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "tree-4352-0_anchor")]
        public IWebElement productionMenu { get; set; }

        [FindsBy(How = How.Id, Using = "tree-52226-0_anchor")]
        public IWebElement propogationNursery { get; set; }

        [FindsBy(How = How.Id, Using = "tree-52228-0_anchor")]
        public IWebElement cloningWizard { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_NEXT")]
        public IWebElement nextButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='sapChooseIcon inlinePicker']")]
        public IWebElement chooseMasterDataIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='sapChooseIcon inlinePicker'])[position() = 2]")]
        public IWebElement chooseMasterDataIconSecond { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@title = 'Item No.']")]
        public IWebElement masterColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[text() = 'GenAg-Mother Cannabis Plant'])[position()=1]")]
        public IWebElement itemData { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='c1'])[last()]")]
        public IWebElement choose { get; set; }

        [FindsBy(How = How.ClassName, Using = "cTXT_QUANT")]
        public IWebElement quantity { get; set; }

        [FindsBy(How = How.ClassName, Using = "ctxtWH_CFL")]
        public IWebElement wareHouse { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='c2'])[position() = 2]")]
        public IWebElement cancel { get; set; }

        [FindsBy(How = How.ClassName, Using = "cTXT_DATE")]
        public IWebElement date { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_FINISH")]
        public IWebElement finishButton { get; set; }

        public ClonePlannerPageObject CloningWizard()
        {
            productionMenu.Click();
            propogationNursery.Click();
            cloningWizard.Click();
            nextButton.Click();
            chooseMasterDataIcon.Click();

            #region Choosing The Value 

            while (i<1)
            {
                try
                {
                    StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                    itemData.Click();
                    Thread.Sleep(2000);
                    choose.Click();
                }
                catch (Exception)
                {

                    FindMasterData();
                }
            }

            #endregion

            nextButton.Click();
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            quantity.SendKeys("33");
            Thread.Sleep(2000);
            wareHouse.Click();
            //Thread.Sleep(2000);
            chooseMasterDataIconSecond.Click();
            Thread.Sleep(1000);
            choose.Click();
            //StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //cancel.Click();

            //new Actions(StaticDriver.driver).DoubleClick(wareHouseChoose).Perform();
            Thread.Sleep(1000);
            nextButton.Click();
            date.Clear();
            Thread.Sleep(1000);
            date.SendKeys("04/28/20");
            Thread.Sleep(1000);
            finishButton.Click();

            Console.WriteLine("Cloning Wizard Functionality - PASS");
            return new ClonePlannerPageObject();


        }


        // For Choosing the GenAg 
        public void FindMasterData()
        {
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(55);
            new Actions(StaticDriver.driver).DoubleClick(masterColumn).Perform();
            try
            {
                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                itemData.Click();
                Thread.Sleep(2000);
                choose.Click();
                
                i = 2;

            }
            catch (Exception)
            {

            }
        }

    }
}
