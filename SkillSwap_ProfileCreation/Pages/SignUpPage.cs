using OpenQA.Selenium;
using System;

namespace SkillSwap_ProfileCreation
{
    internal class SignUpPage
    {
        //Creating a method
        internal void ClickJoin(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro/Home");
            IWebElement Join = driver.FindElement(By.XPath("//button[contains(.,'Join')]"));
            Join.Click();
        }
        //Creating a method
        internal void ClickRegisterBtn(IWebDriver driver)
        {
            IWebElement FirstName = driver.FindElement(By.XPath("//input[@name='firstName']"));
            FirstName.SendKeys("Nazeer Khan");

            IWebElement LastName = driver.FindElement(By.XPath("//input[@name='lastName']"));
            LastName.SendKeys("Mohammed");

            IWebElement EmailID = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailID.SendKeys("Mohammednazeer@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("password2");

            IWebElement ConfirmPassword = driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
            ConfirmPassword.SendKeys("password2");

            IWebElement TnCcheckbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            TnCcheckbox.Click();

            IWebElement Register = driver.FindElement(By.XPath("//div[@id='submit-btn']"));
            Register.Click();
            System.Threading.Thread.Sleep(4000);


       
        }
    }
}