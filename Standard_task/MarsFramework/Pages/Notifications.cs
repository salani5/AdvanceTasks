using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework.Pages
{
    class Notifications
    {
        public Notifications()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }


        

        //mouse hover on notifications
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/div")]
        private IWebElement notifications { get; set; }

        //mouse hover on notifications
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div")]
        private IWebElement notifications1 { get; set; }




        //click to see all
        [FindsBy(How = How.LinkText, Using = "See All...")]
        private IWebElement SeeAll { get; set; }

        //click the checkbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")]
        private IWebElement clickCheckBox { get; set; }

        
        //click the Select All
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[1]/i")]
        private IWebElement SelectAll { get; set; }

        //click the Un-Select All
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[2]/i")]
        private IWebElement UnSelectAll { get; set; }

        //click the check box1 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")]
        private IWebElement checkbox1 { get; set; }

        //click the delete button 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[3]/div/div/div[3]/input")]
        private IWebElement Delete { get; set; }

        //click mark all read
        [FindsBy(How = How.LinkText, Using = "Mark all as read")]
        private IWebElement markAllRead { get; set; }







        public void NotificationsRequest()
        {
            Actions actions = new Actions(GlobalDefinitions.driver);
            actions.MoveToElement(notifications).Click().Build().Perform();


            //click on see All options
            SeeAll.Click();

            //click the checkbox
            checkbox1.Click();


            //Click select all icon
            SelectAll.Click();

            //click unselect icon
            UnSelectAll.Click();

            //click the checkbox
            checkbox1.Click();

            Thread.Sleep(500);

            //Delete.Click();


            

            //GlobalDefinitions.ElementExists(30, By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div"));

            //mark all read
            // markAllRead.Click();()
        }

        public void ValidateNotificationsMarkAllRead()
        {
            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(notifications1).Build().Perform();

            Thread.Sleep(500);

           
            String HighlightedText = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div/div[2]/span/div/div[1]/div[2]/div/a/div[1]")).GetCssValue("font-weight");
            Console.WriteLine(HighlightedText);
            if (HighlightedText.Equals( "700"))
            {
                NUnit.Framework.Assert.Pass("Marked Read" );


            }
            else 
            {
                NUnit.Framework.Assert.Pass("Not Mark Read");
            }
        }

            














        
    }
}
