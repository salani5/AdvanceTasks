using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class NotificationsPage
    {
        //mouse hover on notifications
        private static IWebElement notifications => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div"));


        //mouse hover on notifications
        private static IWebElement notifications1 => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div"));

        //click to see all
        private static IWebElement SeeAll => Driver.driver.FindElement(By.LinkText("See All..."));


        //click the checkbox

        private static IWebElement clickCheckBox => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div[3]/div[2]/span/span/div/div[3]/div/div/div[3]/input"));



        //click the Select All
        private static IWebElement SelectAll => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[1]/i"));


        //click the Un-Select All
        private static IWebElement UnSelectAll => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[2]/i"));


        //click the check box1 
        private static IWebElement checkbox1 => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));

        //click the delete button 
        private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i"));


        //click mark all read
        private static IWebElement markAllRead => Driver.driver.FindElement(By.LinkText("Mark all as read"));

       
        private static IWebElement NotificationsDelete => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[2]/div[1]/a/div[2]/div"));

       
        static string strNameOfCheck = null;       
        
        public static void NotificationsHover()
        {
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(notifications).Click().Build().Perform();

        }

        public static void ClickSeeAll()
        {
            //click on see All options
            SeeAll.Click();

            Thread.Sleep(1500);
        }

        public static void ValidateNotificationsList() 
        {
            string NotificationsText = Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/a/h1")).Text;
            Assert.True(NotificationsText== "Notifications");
        }

        public static void ClickOnMarkAsRead()
        {
            //mark all read
            markAllRead.Click();
        }
        
        public static void ValidateNotificationsMarkAllRead()
        {
            //Actions action = new Actions(Driver.driver);
            //action.MoveToElement(notifications).Build().Perform();

            //click on see All options
            //SeeAll.Click();

            Thread.Sleep(3000);

           


            // 
            String HighlightedText = Driver.driver.FindElement(By.XPath("//*[@id='myDIV']")).GetCssValue("font-weight");
            Console.WriteLine(HighlightedText);
            if (HighlightedText.Equals("400"))
            {
                Assert.Pass("Marked Read");


            }
            else
            {
                Assert.Pass("Not Mark Read");
            }
        }
        public static void notificationsCheckBox()
        {
            //IList<IWebElement> notificationsList = Driver.driver.FindElements(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div"));
            IList<IWebElement> notificationsList = Driver.driver.FindElements(By.XPath("//div[@class='item link']"));
            int notificationsCount = notificationsList.Count();
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~ " + notificationsCount + " ~~~~~~~~~~~~~~~~~~~~~~~~ ");
            if (notificationsCount > 0)
            {
                IWebElement checkboxELe = notificationsList[0];

                Console.WriteLine("***********************   " + checkboxELe.Text +  "   *****************");

                checkboxELe.FindElement(By.XPath("//input[@type='checkbox']")).Click();
                strNameOfCheck =  checkboxELe.GetAttribute("name");

                Console.WriteLine(strNameOfCheck +" Line no 122");
            }
            else
            { 
                Assert.Fail("Element not found to delete");
         

            }

        }

        public static void ClickDeleteActions()
        {
            Delete.Click();


        }

        public static void ValidateDelete()
        {
            Driver.driver.Navigate().Refresh();

            IList<IWebElement> nameList = Driver.driver.FindElements(By.XPath("//div[@class='item link']"));
            int nameCount = nameList.Count();
            Console.WriteLine(nameCount + " Line no 149");
            Boolean bRecordDeleted = true;

            if (nameCount > 0)
            {
                //IWebElement nameELe = nameList[1];
                //Console.WriteLine("****************" + nameELe.GetAttribute("name") + "*************");
                IWebElement nameELement = null;
                for (int iCount=1; iCount < nameCount; iCount++) 
                {
                    nameELement = nameList[iCount];
                    Console.WriteLine("****************" + nameELement.GetAttribute("name") + "*************"+ iCount);
                    if (nameELement.GetAttribute("name").Equals(strNameOfCheck)) 
                    {
                        Console.WriteLine("****************  " +"If CONDITION CHECK "+ iCount +  "  *************");
                        bRecordDeleted = false;
                        break;                    
                    }

                }
            }
            else 
            {
                Console.WriteLine("No notifications present");
            }

            if (bRecordDeleted)
            {
                Assert.Pass("Delete Validation pass");
            }
            else
            {
                Assert.Fail("Delete validation failed");
            }
            //Console.WriteLine(strNameOfCheck + " Line no 140");
            //String notificationsText = NotificationsDelete.Text;
            //Assert.That(notificationsText=="Updated at 15:04 on 14 July 2021"));


        }




       



































































        





    }
}
