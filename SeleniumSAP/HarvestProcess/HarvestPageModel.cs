using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.HarvestProcess
{
    class HarvestPageModel
    {
        public HarvestPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "tree-52226-0_anchor")]
        public IWebElement propogationNursery { get; set; }

        [FindsBy(How = How.Id, Using = "tree-52234-0_anchor")]
        public IWebElement propogationGarden { get; set; }

        [FindsBy(How = How.Id, Using = "tree-52235-0_anchor")]
        public IWebElement prodViewViablePlants { get; set; }

        //[FindsBy(How = How.XPath, Using = "(//*[text() = 'select'])[position() = 4]")]
        //public IWebElement workRoom { get; set; }

        [FindsBy(How = How.XPath, Using = "((//*[@class= 'grid-canvas'])[position() = 6]//div[contains(@class,'slick-cell-span')])[position() = 1]")]
        public IWebElement workRoom { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[text() = 'select'])[position() = 3]")]
        public IWebElement genAg { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_FILTER")]
        public IWebElement filterBySelection { get; set; }

        [FindsBy(How = How.XPath, Using = "((((//*[@class = 'grid-canvas'])[position() = 4]//div[contains(@class,'ui-widget-content')])[last()])//div[contains(@class,'slick-cell-span')])[position() = 1]")]
        public IWebElement selectedPlant { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_MOVE")]
        public IWebElement Move { get; set; }

        [FindsBy(How = How.Id, Using = "NSC_PRODUCTION__TAB_2")]
        public IWebElement Vegetating { get; set; }

        //[FindsBy(How = How.XPath, Using = "(//*[text() = 'select'])[position() = 5")]
        //public IWebElement vegWorkRoom { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[text() = 'select'])[position() = 2]")]
        public IWebElement genAgVeg { get; set; }

        [FindsBy(How = How.Id, Using = "NSC_PRODUCTION__TAB_3")]
        public IWebElement Flowering { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[text() = 'select'])[position() = 2]")]
        public IWebElement genAgFlow { get; set; }

        [FindsBy(How = How.ClassName, Using = "ctxtWH_CFL")]
        public IWebElement wareHouseLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'sapChooseIcon inlinePicker')]")]
        public IWebElement selectWarehouse { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='c1'])[last()]")]
        public IWebElement chooseWareHouse { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_MOVE")]
        public IWebElement Harvest { get; set; }

        //sadas

        [FindsBy(How = How.ClassName, Using = "cCMB_WRHS")]
        public IWebElement destinationWH { get; set; }

        [FindsBy(How = How.ClassName, Using = "ccboHType")]
        public IWebElement harvestType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id,'totalg')]")]
        public IWebElement harvestTotal { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[contains(@id,'CHK')])[position() = 2]")]
        public IWebElement harChkBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'ctxtHName')]")]
        public IWebElement harvestName { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_OK")]
        public IWebElement Apply { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(@title,'Close')])[last()]")]
        public IWebElement cancelButton { get; set; }
        public void HarvestPlant() 
        {
            propogationNursery.Click();
            Thread.Sleep(1000);
            propogationGarden.Click();
            prodViewViablePlants.Click();
            Thread.Sleep(2000);
            workRoom.Click();
            Thread.Sleep(1000);
            genAg.Click();
            Thread.Sleep(1000);
            filterBySelection.Click();
            Thread.Sleep(2000);
            selectedPlant.Click();
            Thread.Sleep(2000);
            wareHouseLocation.Click();
            Thread.Sleep(1000);
            selectWarehouse.Click();
            Thread.Sleep(1000);
            chooseWareHouse.Click();
            Thread.Sleep(1000);
            Move.Click();
            Thread.Sleep(2000);

            Console.WriteLine("Move Plant To Vegetation - PASS");
            
            Vegetating.Click();
            Thread.Sleep(1000);
            genAgVeg.Click();
            Thread.Sleep(2000);
            filterBySelection.Click();
            Thread.Sleep(2000);
            selectedPlant.Click();
            Thread.Sleep(1000);
            wareHouseLocation.Click();
            Thread.Sleep(1000);
            selectWarehouse.Click();
            Thread.Sleep(1000);
            chooseWareHouse.Click();
            Thread.Sleep(1000);
            Move.Click();
            Thread.Sleep(1000);

            Console.WriteLine("Move Plant to Flowering - PASS");

            Flowering.Click();
            Thread.Sleep(2000);
            workRoom.Click();
            Thread.Sleep(1000);
            genAgFlow.Click();
            Thread.Sleep(2000);
            filterBySelection.Click();
            Thread.Sleep(2000);
            selectedPlant.Click();
            Thread.Sleep(1000);
            Harvest.Click();
            Thread.Sleep(2000);
            new SelectElement(destinationWH).SelectByValue("Harvest Room");
            new SelectElement(harvestType).SelectByValue("Full");
            Thread.Sleep(1000);
            harvestName.SendKeys("biraz2");
            Thread.Sleep(2000);
            harvestTotal.SendKeys("22");
            Thread.Sleep(2000);
            harChkBox.Click();
            Thread.Sleep(2000);
            Apply.Click();
            Thread.Sleep(3000);

            Console.WriteLine("Harvest Plant - PASS");

            cancelButton.Click();
            

        }

    }
}
