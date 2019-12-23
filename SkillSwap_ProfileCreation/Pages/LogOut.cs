using OpenQA.Selenium;
using System;

namespace SkillSwap_ProfileCreation
{
    internal class LogOut
    {
        internal void LogOutSuccess(IWebDriver driver)
        {
            IWebElement signout = driver.FindElement(By.XPath("//button[contains(.,'Sign Out')]"));
            signout.Click();

        }
    }
}