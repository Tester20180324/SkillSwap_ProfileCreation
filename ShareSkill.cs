using OpenQA.Selenium;
using System;


namespace SkillTradingFunctions
{
    internal class ShareSkill
    {
        internal void SaveSkillsbtn(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@href='/Home/ServiceListing']")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("Automation Tester");

            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("I have an extensive experience around automation testing");


            IWebElement SelectCategory = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[1]/select[1]/option[7]"));
            System.Threading.Thread.Sleep(2000);
            SelectCategory.Click();
            SelectCategory.GetAttribute("Programming & Tech");

            IWebElement SelectSubCategory = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[2]/div[1]/select[1]/option[5]"));
            System.Threading.Thread.Sleep(2000);
            SelectSubCategory.Click();
            SelectSubCategory.GetAttribute("QA");

            IWebElement EnterTag = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            EnterTag.SendKeys("Automation Expertise");
            EnterTag.SendKeys(Keys.Enter);
            EnterTag.SendKeys("Cypress Expertise");
            EnterTag.SendKeys(Keys.Enter);

            IWebElement ServiceTypeSelection = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[5]/div[2]/div[1]/div[2]/div[1]/input[1]"));
            ServiceTypeSelection.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement LocationTypeSelection = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            LocationTypeSelection.Click();

            IWebElement StartDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            StartDate.SendKeys("20/03/2020");
            //StartDate.SendKeys("02");
            //StartDate.SendKeys("2020");
            IWebElement EndDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
            EndDate.SendKeys("30/02/2020");

            //Monday - Checks the day and defines the timing
            IWebElement MondayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]"));
            MondayAvailable.Click();
            IWebElement MondayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[2]/input[1]"));
            MondayStartTime.SendKeys("09:00");
            MondayStartTime.SendKeys("AM");
            IWebElement MondayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[3]/input[1]"));
            MondayEndTime.SendKeys("05:00");
            MondayEndTime.SendKeys("PM");

            //Wednesday - Checks the day and defines the timing
            IWebElement WednesdayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]"));
            WednesdayAvailable.Click();
            IWebElement WedStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]"));
            WedStartTime.SendKeys("10:00");
            WedStartTime.SendKeys("AM");
            IWebElement WedEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]"));
            WedEndTime.SendKeys("05:30");
            WedEndTime.SendKeys("PM");

            //Wednesday - Checks the day and defines the timing
            System.Threading.Thread.Sleep(2000);
            IWebElement FridayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[1]/div[1]/input[1]"));
            FridayAvailable.Click();
            IWebElement FriStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[2]/input[1]"));
            FriStartTime.SendKeys("11:30");
            FriStartTime.SendKeys("AM");
            IWebElement FriEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[3]/input[1]"));
            FriEndTime.SendKeys("05:45");
            FriEndTime.SendKeys("PM");

            //Choosing the option of learning a new skill
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/input[1]")).Click();

            //Defining the skills to be exchanged for the new one
            System.Threading.Thread.Sleep(2000);
            IWebElement SkillExchange = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            SkillExchange.SendKeys("Cypress");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("SoapUI");
            SkillExchange.SendKeys(Keys.Enter);

            //The file uploading is failing, need to fix it until further progress
            //System.Threading.Thread.Sleep(2000);
            //IWebElement Uploadsample = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[9]/div[1]/div[2]/section[1]/div[1]/input[1]"));
            //System.Threading.Thread.Sleep(2000);
            //Uploadsample.SendKeys("D:\\IndustryConnect\\MVP_Studio\\Project_MARS\\Task_2_(24_Dec-_Jan_2020)");
            //System.Threading.Thread.Sleep(3000);
            //Uploadsample.GetAttribute("16_01_2020");
            //Uploadsample.SendKeys(Keys.Enter);

            //Choosing the appropriate status of a service
            System.Threading.Thread.Sleep(2000);
            IWebElement ServiceStatus = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[2]/div[1]/input[1]"));
            ServiceStatus.Click();

            //Saving the service
            System.Threading.Thread.Sleep(2000);
            IWebElement SaveServiceBtn = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            SaveServiceBtn.Click();










        }
    }
}