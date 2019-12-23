using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SkillSwap_ProfileCreation
{
    internal class ChangePassword
    {
        internal void ClickLogin(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro/Home");

            IWebElement SignIn = driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
            SignIn.Click();

            IWebElement EmailAddress = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailAddress.SendKeys("nazmohammed.nz@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("password1");

            IWebElement LoginBtn = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            LoginBtn.Click();
            System.Threading.Thread.Sleep(2000);
        }

        internal void ClickGoToPassword(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(5000);
            IWebElement ProfileSection = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]"));
            ProfileSection.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement changePassword = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePassword.Click();

        }
        internal void ClickSaveBtn(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement CurrentPassword = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[1]/div[2]/form[1]/div[1]/input[1]"));
            CurrentPassword.SendKeys("password1");

            System.Threading.Thread.Sleep(2000);
            IWebElement NewPassword = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[1]/div[2]/form[1]/div[2]/input[1]"));
            NewPassword.SendKeys("password2");

            System.Threading.Thread.Sleep(2000);
            IWebElement ConfirmPassword = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[1]/div[2]/form[1]/div[3]/input[1]"));
            ConfirmPassword.SendKeys("password2");

            IWebElement SaveBtn = driver.FindElement(By.XPath("//button[@type='button']"));
            SaveBtn.Click();
        }

        internal void ValidatePasswordChange(IWebDriver driver)
        {
            IWebElement signout = driver.FindElement(By.XPath("//button[contains(.,'Sign Out')]"));
            signout.Click();

            IWebElement SignIn = driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
            SignIn.Click();

            IWebElement EmailAddress = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailAddress.SendKeys("nazmohammed.nz@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("password2");

            IWebElement LoginBtn = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            LoginBtn.Click();
        }
    }
}