using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SkillSwap_ProfileCreation.HookUp
{
    [Binding]
    public class ProfileCreationSteps
    {
        IWebDriver driver;

        [Given(@"The user is logged in Successfully\.")]
        public void GivenTheUserIsLoggedInSuccessfully_()
        {
            ChangePassword cPassword = new ChangePassword();
            cPassword.ClickLogin(driver);
        }
        
        [When(@"the user changes password")]
        public void WhenTheUserChangesPassword()
        {
            ChangePassword cPassword = new ChangePassword();
            cPassword.ClickGoToPassword(driver);
            cPassword.ClickSaveBtn(driver);
        }
        
        [Then(@"the user is able to logged in successfully with the new password")]
        public void ThenTheUserIsAbleToLoggedInSuccessfullyWithTheNewPassword()
        {
            ChangePassword cPassword = new ChangePassword();
            cPassword.ValidatePasswordChange(driver);
        }
    }
}
