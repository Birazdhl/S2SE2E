//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.PageObjects;
//using OpenQA.Selenium.Support.UI;
//using SeleniumSAP.OverallFunction;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;


//namespace SeleniumSAP.CloneViablePlant
//{
//    class CloneViablePlantYield
//    {
//        public CloneViablePlantYield()
//        {
//            PageFactory.InitElements(StaticDriver.driver, this);
//        }

//        IJavaScriptExecutor je = (IJavaScriptExecutor)StaticDriver.driver;

//        [FindsBy(How = How.Id, Using = "tree-52230-0_anchor")]
//        public IWebElement cloneViablePlanetYield { get; set; }

//        [FindsBy(How = How.Id, Using = "tree-52235-0_anchor")]
//        public IWebElement prodViewViablePlane { get; set; }

//        [FindsBy(How = How.XPath, Using = "(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 5])//div[contains(@class,'slick-cell ')])[position() = 1]")]
//        public IWebElement LastRow { get; set; }

//        [FindsBy(How = How.XPath, Using = "(//*[@class = 'c1'])[position() = 3]")]
//        public IWebElement updateOk { get; set; }

//        [FindsBy(How = How.XPath, Using = "(//*[@id = 'mb_1293'])[last()]")]
//        public IWebElement deleteRow { get; set; }

//        public void CloneViableYield()
//        {
//            Functions func = new Functions();
//            Thread.Sleep(10000);
//            StaticDriver.driver.FindElement(By.Id("tree-4352-0_anchor")).Click();


//            try
//            {
//                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(55);
//                StaticDriver.driver.FindElement(By.Id("tree-52226-0_anchor")).Click();
//            }
//            catch (Exception)
//            {

//                StaticDriver.driver.FindElement(By.Id("tree-4352-0_anchor")).Click();
//                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//                StaticDriver.driver.FindElement(By.Id("tree-52226-0_anchor")).Click();
//            }

//            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
//            StaticDriver.driver.FindElement(By.Id("tree-52230-0_anchor")).Click();

//            Thread.Sleep(2000);
//            waitForElement();
//            Thread.Sleep(1000);
//            //selectTheElementAndDelete();
//            Actions acc = new Actions(StaticDriver.driver);
//            acc.ContextClick(LastRow).Build().Perform();
//            Thread.Sleep(1000);
//            //func.RightClick(LastRow);

//            //IWebElement lol = StaticDriver.driver.FindElement(By.XPath("(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 5])//div[contains(@class,'slick-cell ')])[position() = 1]"));
//            //Actions builder = new Actions(StaticDriver.driver);
//            //builder.ContextClick(lol).Build().Perform();
//            //RightClick();
//            deleteRow.Click();



//            Thread.Sleep(1000);
//            updateOk.Click();
//            Thread.Sleep(1000);
//            updateOk.Click();

//            StaticDriver.driver.FindElement(By.ClassName("cTXT_QUANT")).SendKeys("22");
//            Thread.Sleep(1000);
//            StaticDriver.driver.FindElement(By.ClassName("cBTN_APPLY")).Click();



//        }

//        public void waitForElement()
//        {

//            je.ExecuteScript(" document.getElementsByClassName('slick-viewport')[3].scroll(0,900) ");


//        }

//        public void selectTheElementAndDelete()
//        {
//            StaticDriver.driver.FindElement(By.XPath("(((//*[@class = 'grid-canvas'])[position()=4]//div[contains(@class, 'ui-widget-content')])[last()])//div[contains(@class,'saplink')]")).Click();


//            IWebElement LatRow = StaticDriver.driver.FindElement(By.XPath("(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 5])//div[contains(@class,'slick-cell ')])[position() = 1]"));
//            IWebElement secondLatRow = StaticDriver.driver.FindElement(By.XPath("(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 6])//div[contains(@class,'slick-cell ')])[position() = 1]"));

//            Actions builder = new Actions(StaticDriver.driver);
//            builder.Click(LatRow).KeyDown(Keys.Control).Click(secondLatRow).KeyUp(Keys.Control).KeyDown(Keys.Shift).KeyDown(Keys.F10).KeyUp(Keys.Shift).KeyUp(Keys.F10).Build().Perform();
            
//        }


//        public void RightClick()
//        {
//            Actions builder = new Actions(StaticDriver.driver);
//            builder.KeyDown(Keys.Shift).KeyDown(Keys.F10).KeyUp(Keys.Shift).KeyUp(Keys.F10).Build().Perform();

//        }

//    }
//}



using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumSAP.HarvestProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.CloneViablePlant
{
    class CloneViablePlantYield
    {
        public CloneViablePlantYield()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "tree-52230-0_anchor")]
        public IWebElement cloneViablePlanetYield { get; set; }

        [FindsBy(How = How.XPath, Using = "(((//*[@class = 'grid-canvas'])[position()=4]//div[contains(@class, 'ui-widget-content')])[last()])//div[contains(@class,'saplink')]")]
        public IWebElement prodOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 7])//div[contains(@class,'slick-cell ')])[position() = 1]")]
        public IWebElement rowToDelete { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[@id = 'mb_1293'])[last()]")]
        public IWebElement deleteRow { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class = 'c1'])[position() = 3]")]
        public IWebElement updateOk { get; set; }

        [FindsBy(How = How.ClassName, Using = "cTXT_QUANT")]
        public IWebElement quantity { get; set; }

        [FindsBy(How = How.ClassName, Using = "cBTN_APPLY")]
        public IWebElement Apply { get; set; }

        [FindsBy(How = How.XPath, Using = "(((//*[@class = 'grid-canvas'])[position()=4]//div[contains(@class, 'ui-widget-content')])[last()])//div[contains(@class,'slick-cell-span')]")]
        public IWebElement selectedRow { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(@title,'Close')])[last()]")]
        public IWebElement cancelButton { get; set; }
        public HarvestPageModel CloneViableYield()
        {

            cloneViablePlanetYield.Click();
            Thread.Sleep(2000);
            waitForElement();
            Thread.Sleep(1000);
            prodOrder.Click();
            Thread.Sleep(2000);
            selectTheElementAndDelete();

            updateOk.Click();
            Thread.Sleep(1000);
            updateOk.Click();
            Thread.Sleep(2000);

            quantity.SendKeys("22");
            Thread.Sleep(1000);
            selectedRow.Click();
            Thread.Sleep(2000);
            Apply.Click();
            Thread.Sleep(4000);
            cancelButton.Click();

            Console.WriteLine("Clone Viable Plant Yield Functionality - PASS");

            return new HarvestPageModel();
        }

        public void waitForElement()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)StaticDriver.driver;
            je.ExecuteScript(" document.getElementsByClassName('slick-viewport')[3].scroll(0,1000) ");
        }

        public void selectTheElementAndDelete()
        {
            for (int i = 0; i < 2; i++)
            {
                Actions builder = new Actions(StaticDriver.driver);

                builder.ContextClick(rowToDelete).Build().Perform();
                Thread.Sleep(1000);
                deleteRow.Click();
                Thread.Sleep(2000);
            }
            
            //(((((//div[@class = 'grid-canvas'])[position() = 5])//div[contains(@class, 'ui-widget-content')])[position() = 8])//div[contains(@class,'slick-cell ')])[position() = 1]

        }
    }
}
