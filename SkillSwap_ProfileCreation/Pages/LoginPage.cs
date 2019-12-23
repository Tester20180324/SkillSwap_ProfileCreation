using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSwap_ProfileCreation
{
    class LoginPage
    {
        //
        public void LoginSuccess(IWebDriver driver)
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
        }

    }
}
