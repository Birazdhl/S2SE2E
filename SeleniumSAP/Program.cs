using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumSAP.Clone_Planner_POM;
using SeleniumSAP.CloneViablePlant;
using SeleniumSAP.CloningWizardPOM;
using SeleniumSAP.HarvestProcess;
using SeleniumSAP.Navsol_POM;
using SeleniumSAP.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumSAP
{
    class Program
    {
        static void Main(string[] args)
        {
            //StaticDriver.driver = new ChromeDriver();
            //StaticDriver.driver.Navigate().GoToUrl("https://ba1.business1cloud.com/dispatcher/");
            Program p = new Program();
            p.Initialize();
            p.Test();
            p.CleanUp();
        }

        [SetUp]
        public void Initialize()
        {
            StaticDriver.driver = new ChromeDriver();
            StaticDriver.driver.Navigate().GoToUrl("https://ba1.business1cloud.com/dispatcher/");
            StaticDriver.driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test()
        {
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(55);
            LoginPageModel loginModel = new LoginPageModel();
            AddOnPageModel addOn =  loginModel.LogIn();
            Thread.Sleep(5000);
            NavSetPageModel navSetModel = addOn.LoginToConnectAddOns();
            navSetModel.MenuBar("userOption");
            Thread.Sleep(3000);
            CloningWizardPageModel cloneWizard = navSetModel.MenuBar("settingOption");
            ClonePlannerPageObject clonePlanner = cloneWizard.CloningWizard();
            CloneViablePlantYield data = clonePlanner.cloneBankPlanner();
            HarvestPageModel harvestPageModel = data.CloneViableYield();
            harvestPageModel.HarvestPlant();


        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(2000);
            StaticDriver.driver.Close();
            Console.WriteLine("Test Passed");
        }
    }
}
