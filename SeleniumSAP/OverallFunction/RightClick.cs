using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSAP.OverallFunction
{
    public class Functions
    {
        public void RightClick(IWebElement element)
        {
            Actions builder = new Actions(StaticDriver.driver);
            builder.ContextClick(element).Build().Perform();
        }
    }
}
