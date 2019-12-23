using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSwap_ProfileCreation
{
    class LanguagesTab
    {
        public void AddNewLanguage(IWebDriver driver)
        {
            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]"));
            AddNewBtn.Click();

            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
            AddNewLanguage.SendKeys("English");

            System.Threading.Thread.Sleep(3000);
            IWebElement AddLevel = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            AddLevel.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }
    }
}
