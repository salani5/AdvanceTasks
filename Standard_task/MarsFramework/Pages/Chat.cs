using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Chat link
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/a[1]")]
        private IWebElement ChatLink { get; set; }

        //Click on Search Chat user textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[1]/div/div[1]/div/div[1]/input")]
        private IWebElement SearchChatUser { get; set; }

        //Click on Chat User
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[1]/div/div[2]/div[1]/div[2]")]
        private IWebElement ChatUser { get; set; }

        //Click on chat textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input")]
        private IWebElement chatBox { get; set; }

        //Click on chat send button
        [FindsBy(How = How.Id, Using = "btnSend")]
        private IWebElement sendBox { get; set; }

        public void ChatHistory()
        {
            //click on chat link
            ChatLink.Click();



            //chat history 
            int iLength =0;
            IList<IWebElement> NoOfChatList = null;
            
            IWebElement EleChatlist = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='chatList']"));
            NoOfChatList = EleChatlist.FindElements(By.ClassName("item"));
            IWebElement element = null;
            iLength = NoOfChatList.Count;
            for (int icount=0; icount< iLength; icount++) 
            {

                element = NoOfChatList[icount];
                element.Click();
                //Enter Chat message in textbox
                chatBox.SendKeys("Hi! How are you?");
                //click send message
                sendBox.Click();

            }


        }









    }







    
}
