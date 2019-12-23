using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SkillSwap_ProfileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        // Test Case #1 - Sign Up and Login Functionality
        public void SignUpNLogIn()
        {
        //Instantiating a web driver
         IWebDriver driver = new ChromeDriver();

        //Instantiating an instance of a class for Registration
         SignUpPage signup = new SignUpPage();
         signup.ClickJoin(driver);
         signup.ClickRegisterBtn(driver);

         //Instantiating an instance of a class for Login
         LoginPage loginPage = new LoginPage();
         loginPage.LoginSuccess(driver);

         //Instantiating an instance of a class for log out
         LogOut logout = new LogOut();
         logout.LogOutSuccess(driver);

         //Close driver
         driver.Close();
         }

        [Test]
        //Test Case #2
        //Creating a method for the test case 
        public void HomePageSkillSearch()
        {

        IWebDriver driver = new ChromeDriver();

        //Non-logged-in skill seeker searches a skill using homepage search and spots a traders profile
        HomePageSearch hpsearch = new HomePageSearch();
        hpsearch.SkillSearch(driver);

        //Skill seeker attempts to login in his account
        System.Threading.Thread.Sleep(4000);
        IWebElement SeekerProfileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/section[1]/div[1]/a[2]"));
        SeekerProfileTab.Click();

        //Skill seeker logs in his account
        System.Threading.Thread.Sleep(4000);
        LoginPage profilepage = new LoginPage();
        profilepage.LoginSuccess(driver);

        //Logged-In skill seeker goes to his profile by clicking on Profile Tab
        System.Threading.Thread.Sleep(5000);
        IWebElement ProfileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
        System.Threading.Thread.Sleep(5000);
        ProfileTab.Click();

        //Skill seeker updates his/her profile
        UpdateProfile updateprofile = new UpdateProfile();
        updateprofile.AddDescription(driver);
        updateprofile.AddLanguage(driver);
        updateprofile.AddSkills(driver);
        updateprofile.AddEducation(driver);
        updateprofile.AddCertification(driver);
        updateprofile.RefreshProfile(driver);
        updateprofile.Signout(driver);

        //closing driver
        driver.Close();
        }

        [Test]
        public void ChangePassword()
        { 
            //Instantiating a web driver
            IWebDriver driver = new ChromeDriver();

            //Instantiating an instance of a class for Registration
            ChangePassword cPassword = new ChangePassword();
            cPassword.ClickLogin(driver);
            cPassword.ClickGoToPassword(driver);
            cPassword.ClickSaveBtn(driver);
            cPassword.ValidatePasswordChange(driver);

            driver.Close();
        }

    
    }
    
}
