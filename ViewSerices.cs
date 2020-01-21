using OpenQA.Selenium;
using System;

namespace SkillTradingFunctions
{
    internal class ViewSerices
    {
        internal void ServiceDetails(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement MListingsTab = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
            MListingsTab.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement viewService = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewService.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement ChatBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/a[1]"));
            ChatBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement MsgInput = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            MsgInput.SendKeys("Just for Testing purpose");

            System.Threading.Thread.Sleep(2000);
            IWebElement SendBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/button[2]"));
            SendBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement MListingsTabback= driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
            MListingsTabback.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement DeleteService = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"));
            DeleteService.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement NoBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[3]/button[1]"));
            NoBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement DeleteServiceagain = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"));
            DeleteServiceagain.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement YesBtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            YesBtn.Click();

        }
    }
}