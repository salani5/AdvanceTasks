using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ChatPage
    {
        //Click on Chat link
        private static IWebElement ChatLink => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/a[1]"));


        //Click on Search Chat user textbox
        private static IWebElement SearchChatUser => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/div[1]/div/div[1]/input"));


        //Click on Chat User
        private static IWebElement ChatUser => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/div[2]/div[1]/div[2]"));


        //Click on chat textbox
        private static IWebElement chatBox => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input"));


        //Click on chat send button
        private static IWebElement sendBox => Driver.driver.FindElement(By.Id("btnSend"));


        public static void clickChatLink()
        {
            //click on chat link
            ChatLink.Click();
        }




        public static void ChatHistory()
        {



            //chat history 
            int iLength = 0;
            IList<IWebElement> NoOfChatList = null;

            IWebElement EleChatlist = Driver.driver.FindElement(By.XPath("//*[@id='chatList']"));
            NoOfChatList = EleChatlist.FindElements(By.ClassName("item"));
            IWebElement element = null;
            iLength = NoOfChatList.Count;
            for (int icount = 0; icount < iLength; icount++)
            {

                element = NoOfChatList[icount];
                element.Click();
                //Enter Chat message in textbox
                chatBox.SendKeys("Hi! How are you?");
                //click send message
                sendBox.Click();

            }
        }
            public static void validateChatList()
            { 
            
            
            }

        

    }
}
