using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingFunctions
{
    class Login
    {
        public void LoginSuccess(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");

            System.Threading.Thread.Sleep(2000);
            IWebElement SignIn = driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
            SignIn.Click();

            IWebElement Email = driver.FindElement(By.XPath("//input[contains(@placeholder,'Email address')]"));
            Email.SendKeys("nazmohammed.nz@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[contains(@type,'password')]"));
            password.SendKeys("password2");

            IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            loginBtn.Click();
            System.Threading.Thread.Sleep(3000);

            //Making console wait after running the whole program
            //Console.ReadLine();

            //Close driver
            //driver.Close();

           
        }
    }
}
