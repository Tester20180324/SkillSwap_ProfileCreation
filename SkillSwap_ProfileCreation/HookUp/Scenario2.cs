using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SkillSwap_ProfileCreation.HookUp
{
    [Binding]
    public class Scenario2
    {
        IWebDriver driver;

        [Given(@"a user views traders profile by seeking skill from homepage search")]
        public void GivenAUserViewsTradersProfileBySeekingSkillFromHomepageSearch()
        {
            HomePageSearch hpsearch = new HomePageSearch();
            hpsearch.SkillSearch(driver);
        }
        
        [Given(@"he logs into his account to update his profile")]
        public void GivenHeLogsIntoHisAccountToUpdateHisProfile()
        {
            //Skill seeker attempts to login in his account
            System.Threading.Thread.Sleep(4000);
            IWebElement SeekerProfileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/section[1]/div[1]/a[2]"));
            SeekerProfileTab.Click();

            //Skill seeker logs in his account
            System.Threading.Thread.Sleep(4000);
            LoginPage profilepage = new LoginPage();
            profilepage.LoginSuccess(driver);
        }
        
        [When(@"a user clicks on Profile Tab")]
        public void WhenAUserClicksOnProfileTab()
        {
            //Logged-In skill seeker goes to his profile by clicking on Profile Tab
            System.Threading.Thread.Sleep(5000);
            IWebElement ProfileTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            System.Threading.Thread.Sleep(5000);
            ProfileTab.Click();
        }
        
        [Then(@"he is navigated to his profile section to update and eventually logs out")]
        public void ThenHeIsNavigatedToHisProfileSectionToUpdateAndEventuallyLogsOut()
        {
            //Skill seeker updates his/her profile
            UpdateProfile updateprofile = new UpdateProfile();
            updateprofile.AddDescription(driver);
            updateprofile.AddLanguage(driver);
            updateprofile.AddSkills(driver);
            updateprofile.AddEducation(driver);
            updateprofile.AddCertification(driver);
            updateprofile.RefreshProfile(driver);
            updateprofile.Signout(driver);
        }
    }
}
