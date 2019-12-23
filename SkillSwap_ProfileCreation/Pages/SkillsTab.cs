using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSwap_ProfileCreation
{
    class SkillsTab
    {
        public void AddNewSkill(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement Profile = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            Profile.Click();

            IWebElement skills = driver.FindElement(By.XPath("(//a[@class='item'])[14]"));
            skills.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));
            AddNewBtn.Click();

            IWebElement AddSkill = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            AddSkill.SendKeys("Automation Testing");

            IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            SkillLevel.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }
    }
}
