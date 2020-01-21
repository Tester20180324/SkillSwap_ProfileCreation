using System;
using OpenQA.Selenium;

namespace SkillTradingFunctions
{
    internal class ManageListings
    {
        internal void UpdateServices(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement MListingsTab = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
            MListingsTab.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement ServiceListed = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]"));
            ServiceListed.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            ServiceListed.Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement Title = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            Title.Clear();
            Title.SendKeys("QA Automation Tester");

            System.Threading.Thread.Sleep(4000);
            IWebElement Description = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            Description.Clear();
            Description.SendKeys("I must say that I am neither new to QA activities and nor an apprentice, I am good at what I do");

            IWebElement EditCategory = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[4]"));
            System.Threading.Thread.Sleep(2000);                     
            EditCategory.Click();
            EditCategory.GetAttribute("Writing & Translation");

            IWebElement EditSubCategory = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]"));
            System.Threading.Thread.Sleep(2000);
            EditSubCategory.Click();
            EditSubCategory.GetAttribute("QA");

            System.Threading.Thread.Sleep(2000);
            IWebElement RemoveTag1 = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/span[2]/a"));
            RemoveTag1.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement RemoveTag2 = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a"));
            RemoveTag2.Click();

            IWebElement EnterTag = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            EnterTag.SendKeys("QA Automator");
            EnterTag.SendKeys(Keys.Enter);
            EnterTag.SendKeys("Charles Proxy Debugger");
            EnterTag.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(2000);
            IWebElement ServiceTypeSelection = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            ServiceTypeSelection.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement LocationTypeSelection = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            LocationTypeSelection.Click();

            IWebElement ClearStartDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            ClearStartDate.Clear();

            IWebElement StartDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            StartDate.SendKeys("25/03/2020");
            //StartDate.SendKeys("02");
            //StartDate.SendKeys("2020");

            IWebElement ClearEndDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
            ClearEndDate.Clear();

            IWebElement EndDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
            EndDate.SendKeys("30/04/2020");

            //Sunday - Checks the day and defines the timing
            IWebElement SundayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[2]/div[1]/div[1]/input[1]"));
            SundayAvailable.Click();
            IWebElement SundayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[2]/div[2]/input[1]"));
            SundayStartTime.SendKeys("09:00");
            SundayStartTime.SendKeys("AM");
            IWebElement SundayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[2]/div[3]/input[1]"));
            SundayEndTime.SendKeys("05:00");
            SundayEndTime.SendKeys("PM");

            //Monday - Unchecks the day and removes the timing values
            //System.Threading.Thread.Sleep(2000);
            //IWebElement MondayUncheck = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]"));
            //MondayUncheck.Click();
            //System.Threading.Thread.Sleep(2000);
            //IWebElement MondayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[2]/input[1]"));
            //MondayStartTime.Clear();
            //System.Threading.Thread.Sleep(2000);
            //IWebElement MondayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[3]/input[1]"));
            //MondayEndTime.Clear();

            //Tuesday - Checks the day and defines the timing
            System.Threading.Thread.Sleep(2000);
            IWebElement TuesdayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[4]/div[1]/div[1]/input[1]"));
            TuesdayAvailable.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement TuesdayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[4]/div[2]/input[1]"));
            TuesdayStartTime.SendKeys("09:00");
            TuesdayStartTime.SendKeys("AM");
            System.Threading.Thread.Sleep(2000);
            IWebElement TuesdayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[4]/div[3]/input[1]"));
            TuesdayEndTime.SendKeys("05:00");
            TuesdayEndTime.SendKeys("PM");

            //Wednesday - Unchecks the day and removes the timing values
            //System.Threading.Thread.Sleep(2000);
            //IWebElement WednesdayUncheck = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]"));
            //WednesdayUncheck.Click();
            //System.Threading.Thread.Sleep(2000);
            //IWebElement WedStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]"));
            //WedStartTime.Clear();
            //System.Threading.Thread.Sleep(2000);
            //IWebElement WedEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]"));
            //WedEndTime.Clear();

            //Thursday - Checks the day and defines the timing
            System.Threading.Thread.Sleep(2000);
            IWebElement ThursdayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[6]/div[1]/div[1]/input[1]"));
            ThursdayAvailable.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement ThursdayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[6]/div[2]/input[1]"));
            ThursdayStartTime.SendKeys("09:00");
            ThursdayStartTime.SendKeys("AM");
            System.Threading.Thread.Sleep(2000);
            IWebElement ThursdayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[6]/div[3]/input[1]"));
            ThursdayEndTime.SendKeys("05:00");
            ThursdayEndTime.SendKeys("PM");

            //Friday - Unchecks the day and removes the timing values
            //System.Threading.Thread.Sleep(1000);
            //IWebElement FridayUncheck = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[1]/div[1]/input[1]"));
            //FridayUncheck.Click();
            //System.Threading.Thread.Sleep(1000);
            //IWebElement FriStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[2]/input[1]"));
            //FriStartTime.Clear();
            //System.Threading.Thread.Sleep(1000);
            //IWebElement FriEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[3]/input[1]"));
            //FriEndTime.Clear();

            //Choosing the option of learning a new skill
            System.Threading.Thread.Sleep(2000);
            IWebElement SkillTrade = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[2]/div[1]/input[1]"));
            SkillTrade.Click();

            //Defining the values for credit
            System.Threading.Thread.Sleep(2000);
            IWebElement Credit = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/input[1]"));
            Credit.SendKeys("10");

            //Choosing the appropriate status of a service
            IWebElement ServiceStatus = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            ServiceStatus.Click();

            //Saving the service
            IWebElement SaveServiceBtn = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            SaveServiceBtn.Click();


















        }
    }
}