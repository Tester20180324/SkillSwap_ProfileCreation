Feature: ProfileCreation
	In order to login to the Skillswap website
	As a new user
	I want to be registered in the website 
	And Update my profile as a skill seeker
	And check the profile of a skill trader

@Registration Functionality Tests
Scenario: User is verified through email link after successful signup

	Given the user successfully signs up in a website
	And the user clicks on a link in an email address to get verified
	Then the user should be navigated to the login page
	When the user clicks on a login button after entering valid inputs
	Then the user should be successfully logged in the website.

Scenario: User attempts to register with no values in FirstName field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the FirstName field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in LastName field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the LastName field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Email field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the Email field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Password field

	Given I have registration page opened
	And I have entered the valid inputs in all the fields except the Password field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Confirm Password field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the Confirm Password field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with no values in Confirm Password field

	Given the user have registration page opened
	And the user have entered the valid inputs in all the fields except the Confirm Password field and left it blank
	Then the user becomes unable to click on Join button

Scenario: User attempts to register without ticking the T&C checkbox

	Given the user have registration page opened
	And the user have entered all the valid inputs in all the fields 
	Then the user becomes unable to click on Join button

Scenario: User attempts to register with invalid Email ID

	Given the user have registration page opened
	And the user have entered valid inputs in all the fields except Email ID
	And the user have entered special characters in an Email field
	Then the appropriate error message should be displayed 
	And the user becomes unable to click on Join button

Scenario: User attempts to register with the known Email ID

	Given the user have registration page opened
	And the user have entered valid inputs in all the fields 
	And the user have entered used an Email ID which is already registered
	Then the appropriate error message should be displayed 
	And the user becomes unable to click on Join button

Scenario: User attempts to go to login page from SignUp page

	Given the user have registration page opened
	And the user have clicked on Login hyperlink
	Then the user should be navigated to the login page

Scenario: User attempts to go to Terms and Conditions page

	Given the user have registration page opened
	And the user have clicked on Terms and Conditions hyperlink
	Then the user should be navigated to the T&C page in a new tab

@Login Functionality Tests
Scenario: User attempts to log in from homepage successfully

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	And the user clicks on Login button after inputting the valid email address and password
	Then the user should be logged in successfully in the website

Scenario: User views the appropriate error messages when attempts to login with no valid inputs

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Login button with no valid inputs in the respective fields
	Then the user should be able to see the appropriate error messages

Scenario: User receives an email verification link when attempts to login with new email ID

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	And the user clicks on Login button after entering the new valid email ID and password
	Then the user should be able to see the appropriate pop up message
	And the user clicks on Send Verification Email button 
	Then the appropriate error message should be displayed

Scenario: Verification of Forgot password functionality 

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Forgot Password link
	Then the user should be navigated to the Email Verification Module
	When the user clicks on Send verificatin Email link with no valid input
	Then the user should see the appropriate alert message
	When the user clicks on Send verification Email link after entering valid email address
	Then the user should receive an email link for setting up a new password. 

Scenario: Verification of Remember your password functionality 

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Forgot Password link
	Then the user should be navigated to the Email Verification Module
	When the user clicks on Remember Your Password Link
	Then the user should be navigated to the login module

Scenario: Verification of Haven't got an account?Join! link functionality

	Given the user have home page opened
	And  have clicked on Signin link from the top right side
	Then the user should be navigated to the Login Module
	When the user clicks on Haven't got an account? Join! link
	Then the user should be navigated to the Sign Up Module

@Profile Update
Scenario: Verify if user is able to add description

	Given the user have signed in & profile page opened
	When the user adds a description in the field and save
	Then the added details should be reflected.

Scenario: Verify if user is able to add languages

	Given the user have signed in & profile page opened
	When the user adds a language in the field and save
	Then the added language should be reflected.

Scenario: Verify if user is able to add skills

	Given the user have signed in &  profile page opened
	When the user adds a skill in the field and save
	Then the added skill should be reflected.

Scenario: Verify if user is able to add education

	Given the user have signed in &  profile page opened
	When the user adds an education in the field and save
	Then the added education should be reflected.

Scenario: Verify if user is able to add certifications

	Given the user have signed in &  profile page opened
	When the user adds certification in the field and save
	Then the added certification should be reflected.

@Edit Profile
Scenario: Verify if user is able to Edit description

	Given the user have signed in &  profile page opened
	When the user updates details in the description field and save
	Then the updated details should be reflected.

Scenario: Verify if user is able to Edit languages

	Given the user have signed in &  profile page opened
	When the user updates langauage in the language field and save
	Then the updated language should be reflected.

Scenario: Verify if user is able to Edit skills

	Given the user have signed in &  profile page opened
	When the user updates skills in the language field and save
	Then the updated skill should be reflected.

Scenario: Verify if user is able to update education

	Given the user have signed in &  profile page opened
	When the user updates education in the language field and save
	Then the updated education should be reflected.

Scenario: Verify if user is able to Update certifications

	Given the user have signed in &  profile page opened
	When the user updates certification in the language field and save
	Then the updated certification should be reflected.

@Delete Profile
Scenario: Verify if user is able to Delete description

	Given the user have signed in &  profile page opened
	And  have clicked on pencil sign adjacent to the Description copy
	And removes the details from the description box
	When the user clicks on Save button with no input in the box 
	Then the user should see the prompt message to add details
	When the user clicks on Save button after entering details 
	Then the user should be able to see the prompt success message
	And the newly added details should be displayed below the description copy

Scenario: Verify if user is able to delete languages

	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any language
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section

Scenario: Verify if user is able to Delete skills
	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any skills in the skills tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section

Scenario: Verify if user is able to Delete Education

	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any education in the education tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section

Scenario: Verify if user is able to Delete Certification

	Given the user have signed in &  profile page opened
	When the user clicks on cross mark for any certification in the certification tab
	Then the user should be able to see the prompt success message
	And the details should be removed from the respective section




