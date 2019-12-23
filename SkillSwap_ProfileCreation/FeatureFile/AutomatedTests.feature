Feature: ProfileCreation
	In order to login to the Skillswap website
	As a new user
	I want to be registered in the website 
	And Update my profile as a skill seeker
	And check the profile of a skill trader

	
@Registration & Login Functionality Tests
Scenario: User Registers and logs in successfully with valid inputs
	Given the new user registers successfuly
	And logs in with the same credentials 
	Then logs out of the website successfully.

@User Updates own Profile and views sellers profile
Scenario: Non-logged-in skill seeker views Traders profile detials and updaes his/her profile.
	Given a user views traders profile by seeking skill from homepage search
	And he logs into his account to update his profile
	When a user clicks on Profile Tab
	Then he is navigated to his profile section to update and eventually logs out

@Change Password functionality
Scenario: User changes his/her password and login with newly created password
	Given The user is logged in Successfully.
	When the user changes password
	Then the user is able to logged in successfully with the new password

