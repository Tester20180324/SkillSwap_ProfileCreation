using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace SkillSwap_ProfileCreation
{
    internal class EducationTab
    {
        internal void AddEducation(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(3000);
            IWebElement EducationTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]"));
            EducationTab.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[21]"));
            AddNewBtn.Click();

            IWebElement CollegeName = driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
            CollegeName.SendKeys("Auckland Institute Of Studies");

            IWebElement SelectCountry = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            System.Threading.Thread.Sleep(5000);
            SelectCountry.GetAttribute("New Zealand");

            System.Threading.Thread.Sleep(3000);
            IWebElement SelectTitle = driver.FindElement(By.ClassName("ui dropdown"));
            SelectTitle.GetAttribute("B.Tech");

            IWebElement Degree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            Degree.SendKeys("Graduate Diploma in Information Technology");

            System.Threading.Thread.Sleep(3000);
            IWebElement YearOfGrad = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]/option[3]"));
            YearOfGrad.Click();

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
            

        }
    }
}