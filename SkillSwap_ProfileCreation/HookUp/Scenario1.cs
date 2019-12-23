using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SkillSwap_ProfileCreation.HookUp
{
    [Binding]
    public class Scenario1
    {
        IWebDriver driver;

        [Given(@"the new user registers successfuly")]
        public void GivenTheNewUserRegistersSuccessfuly()
        {
                SignUpPage signup = new SignUpPage();
                signup.ClickJoin(driver);
                signup.ClickRegisterBtn(driver);
        }

        [Given(@"logs in with the same credentials")]
        public void GivenLogsInWithTheSameCredentials()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }

        [Then(@"logs out of the website successfully\.")]
        public void ThenLogsOutOfTheWebsiteSuccessfully_()
        {
            LogOut logout = new LogOut();
            logout.LogOutSuccess(driver);
        }
    }
}
