using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumSAP.CloneViablePlant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.Clone_Planner_POM
{
    class ClonePlannerPageObject
    {
        public ClonePlannerPageObject()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "tree-52229-0_anchor")]
        public IWebElement productionMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='slick-cell-span'])[position() = 1]")]
        public IWebElement firstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "(((//div[@class='grid-canvas'])[last()])//div[contains(@class, 'ui-widget-content slick-row ')][last()])//div[contains(@class,'slick-cell l4 r4')]")]
        public IWebElement productionBatch { get; set; }

        [FindsBy(How = How.ClassName, Using = "editor-textEx")]
        public IWebElement editText { get; set; }

        [FindsBy(How = How.ClassName, Using = "cTXT_DAYS")]
        public IWebElement estimateDaysToPropogate { get; set; }

        [FindsBy(How = How.ClassName, Using = "ctxtWH_CFL")]
        public IWebElement sendToLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'sapChooseIcon inlinePicker']")]
        public IWebElement chooseLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='c1'])[last()]")]
        public IWebElement choose { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_RELE")]
        public IWebElement releaseIssue { get; set; }

        [FindsBy(How = How.XPath, Using = "((((//div[@class='grid-canvas'])[last()])//div[contains(@class, 'ui-widget-content slick-row ')][last()])//div[contains(@class,'slick-cell l0 r0')]//div)//following-sibling::div")]
        public IWebElement choosePlant { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(@title,'Close')])[last()]")]
        public IWebElement cancelButton { get; set; }
        public CloneViablePlantYield cloneBankPlanner()
        {
            Thread.Sleep(5000);
            productionMenu.Click();
            Thread.Sleep(1000);
            firstRow.Click();
            Thread.Sleep(2000);
            editText.SendKeys(Keys.PageDown);
            editText.SendKeys(Keys.PageDown);
            editText.SendKeys(Keys.PageDown);
            Thread.Sleep(1000);
            productionBatch.Click();
            Thread.Sleep(1000);
            editText.Click();
            Thread.Sleep(1000);
            editText.SendKeys("test");
            Thread.Sleep(1000);
            estimateDaysToPropogate.Click();
            Thread.Sleep(1000);
            estimateDaysToPropogate.SendKeys("8");
            Thread.Sleep(2000);
            sendToLocation.Click();
            Thread.Sleep(2000);
            chooseLocation.Click();
            Thread.Sleep(2000);
            choose.Click();
            Thread.Sleep(2000);
            choosePlant.Click();
            Thread.Sleep(2000);
            releaseIssue.Click();
            Thread.Sleep(2000);
            cancelButton.Click();


            Console.WriteLine("Clone Planner Functionality - PASS");
            return new CloneViablePlantYield();

        }
    }
}
