using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace SkillSwap_ProfileCreation
{
    internal class UpdateProfile
    {
        internal void AddDescription(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement DescEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            DescEditIcon.Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement DescriptionBox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            DescriptionBox.SendKeys("In publishing and graphic design, lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content. Lorem ipsum may be used before final copy is available, but it may also be used to temporarily replace copy in a process called greeking, which allows designers to consider form without the meaning of the text influencing the design. Lorem ipsum is typically a corrupted version of De finibus bonorum et malorum, a first-century BCE text by Cicero, with words altered, added, and removed to make it nonsensical, ");

            IWebElement DescSaveBtn = driver.FindElement(By.XPath("//button[@type='button']"));
            DescSaveBtn.Click();
        }
        internal void AddLanguage(IWebDriver driver)
        {
            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]"));
            AddNewBtn.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
            AddNewLanguage.SendKeys("English");

            System.Threading.Thread.Sleep(5000);
            SelectElement SE = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            SE.SelectByText("Fluent");

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }
        internal void AddSkills(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement Profile = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            Profile.Click();

            IWebElement skills = driver.FindElement(By.XPath("(//a[@class='item'])[14]"));
            skills.Click();

            System.Threading.Thread.Sleep(1000);
            IWebElement AddNewBtn = driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));
            AddNewBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement AddSkill = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            AddSkill.SendKeys("Cypress");

            System.Threading.Thread.Sleep(5000);
            SelectElement se = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            se.SelectByText("Expert");

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }
        internal void AddEducation(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement EducationTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            EducationTab.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[21]"));
            AddNewBtn.Click();

            IWebElement CollegeName = driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
            CollegeName.SendKeys("Auckland Institute Of Studies");

            System.Threading.Thread.Sleep(2000);
            SelectElement sCountry = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']")));
            sCountry.SelectByText("New Zealand");

            System.Threading.Thread.Sleep(5000);
            SelectElement sTitle = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']")));
            sTitle.SelectByText("B.Tech");

            IWebElement Degree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            Degree.SendKeys("Graduate Diploma in Information Technology");

            System.Threading.Thread.Sleep(5000);
            SelectElement sYearOgrad = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")));
            sYearOgrad.SelectByText("2018");


            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }
        internal void AddCertification(IWebDriver driver)
        {
            IWebElement certificate = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificate.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[26]"));
            AddNewBtn.Click();

            IWebElement certificateName = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
            certificateName.SendKeys("Internation Software Testing Qualification Board - ISTQB");

            IWebElement CertificationSource = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certified From (e.g. Adobe)')]"));
            CertificationSource.SendKeys("ISTQB - India");

            System.Threading.Thread.Sleep(5000);
            SelectElement sYearOCert = new SelectElement(driver.FindElement(By.XPath("//select[@name='certificationYear']")));
            sYearOCert.SelectByText("2017");

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }
        internal void RefreshProfile(IWebDriver driver)
        {
            //Refresh profile to check the updates are reflecting
            System.Threading.Thread.Sleep(4000);
            IWebElement RefreshProfileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/section[1]/div[1]/a[2]"));
            RefreshProfileTab.Click();
        }
        internal void Signout(IWebDriver driver)
        {
            IWebElement signout = driver.FindElement(By.XPath("//button[contains(.,'Sign Out')]"));
            signout.Click();
        }
    }
}