using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumSAP.CloningWizardPOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP.Navsol_POM
{
    class NavSetPageModel
    {
        public NavSetPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "m_4864")]
        public IWebElement tools { get; set; }

        
        [FindsBy(How = How.Id, Using = "mb_51200")]
        public IWebElement userDefinedWindows { get; set; }

        [FindsBy(How = How.Id, Using = "mb_51228")]
        public IWebElement nscUserOptions { get; set; }

        [FindsBy(How = How.Id, Using = "mb_51222")]
        public IWebElement nscSetting { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l4 r4 row_8 cid_U_Value1']")]
        public IWebElement CCM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l4 r4 row_8 cid_U_Value1 active editable']/child::input")]
        public IWebElement ccmOne { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l4 r4 row_11 cid_U_Value1']")]
        public IWebElement blankSpace { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@title='Update']")]
        public IWebElement Update { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class = 'c1'])[position() = 3]")]
        public IWebElement ok { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l3 r3 row_3 cid_U_Value']")] 
        public IWebElement serializeStage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l3 r3 row_3 cid_U_Value active editable']/child::input")]
        public IWebElement serializeStageInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'ui-widget-content slick-row even row_15']")]
        public IWebElement serializePlant { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l3 r3 row_15 cid_U_Value active editable']/child::input")]
        public IWebElement serializePlantInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'slick-cell l2 r2 row_70 cid_Name active editable']/child::input")]
        public IWebElement lastRow { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='ui-resizable-handle ui-resizable-nw'])[position() = 6]")]
        public IWebElement dilogeBox { get; set; }

        


        public CloningWizardPageModel MenuBar(string nscType)
        {
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            tools.Click();
            userDefinedWindows.Click();
            if (nscType == "userOption")
            {
                nscUserOptions.Click();

                dilogeBox.Click();
                CCM.Click();
                dilogeBox.Click();
                Thread.Sleep(1000);
                dilogeBox.Click();
                ccmOne.Clear();
                dilogeBox.Click();
                Thread.Sleep(1000);
                ccmOne.SendKeys("Y");
                ccmOne.SendKeys(Keys.Enter);

                Console.WriteLine("Value Successfully Entered in Navsol User Options - PASS");

            }
            else
            {
                nscSetting.Click();

                for (int i=0; i<5; i++)
                { 
                    lastRow.SendKeys(Keys.PageUp);
                }

                Thread.Sleep(2000);
                serializeStage.Click();
                Thread.Sleep(1000);
                serializeStageInput.Clear();
                Thread.Sleep(1000);
                serializeStageInput.SendKeys("NONE");
                serializeStageInput.SendKeys(Keys.PageDown);
                Thread.Sleep(2000);
                serializePlant.Click();
                Thread.Sleep(1000);
                serializePlantInput.Clear();
                Thread.Sleep(1000);
                serializePlantInput.SendKeys("N");
                serializePlantInput.SendKeys(Keys.Enter);
                Thread.Sleep(3000);

                Console.WriteLine("Value Successfully Entered in NSC Settings - PASS");

            }

            //if (Update != null)
            //{
            //    Update.Click();
            //}
            try
            {
                //Update.Click();
                Thread.Sleep(2000);
                ok.Click();
            }
            catch (Exception ex)
            {

                      
            }

            
            return new CloningWizardPageModel();

        }
    }
}
