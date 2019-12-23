using System;
using OpenQA.Selenium;

namespace SkillSwap_ProfileCreation
{
    internal class CertificationTab
    {
        internal void AddCertification(IWebDriver driver)
        {
            IWebElement certificate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[4]"));
            certificate.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[26]"));
            AddNewBtn.Click();

            IWebElement certificateName = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
            certificateName.SendKeys("Internation Software Testing Qualification Board - ISTQB");

            IWebElement CertificationSource = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certified From (e.g. Adobe)')]"));
            CertificationSource.SendKeys("ISTQB - India");

            IWebElement YOCertification = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]/option[4]"));
            YOCertification.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();

        }
    }
}