using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Test Case #1 - Share Skills
        [Test]
        //Creating a method for the test case
        public void TradeSkills()
        { 
            //Initiating a web driver
            IWebDriver driver = new ChromeDriver();
            
            //Instantiating an instance of a class for login  
            Login login = new Login();
            login.LoginSuccess(driver);

            //Instantiating an instance of a class for ShareSkill Page
            ShareSkill Sskill = new ShareSkill();
            Sskill.SaveSkillsbtn(driver);

            //Close driver
            driver.Close();
        }

        [Test]
        //Test Case #2 - Manage Listings
        //Creating a method for the test case 
        public void UpdateServiceListing()
        {
            IWebDriver driver = new ChromeDriver();

            //Instantiating an instance of a class for login  
            Login login = new Login();
            login.LoginSuccess(driver);

            ManageListings managelistings = new ManageListings();
            managelistings.UpdateServices(driver);
        }
        [Test]
        //Test Case #3 - View Services In Details
        //Creating a method for the test case
        public void ServicesInView()
        {
            IWebDriver driver = new ChromeDriver();

            //Instantiating an instance of a class for login  
            Login login = new Login();
            login.LoginSuccess(driver);

            ViewSerices viewservices = new ViewSerices();
            viewservices.ServiceDetails(driver);

            System.Threading.Thread.Sleep(3000);
            driver.Close();
        }
    }
}
