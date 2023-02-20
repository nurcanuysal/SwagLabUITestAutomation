Feature: CheckOut
This feature provides to check the Checkout functionality

Background: Navigate homepage
Given User navigates to login page
When User enters credentials 'standard_user' and 'secret_sauce'
And User clicks the login button

Scenario: User should be able to add products to cart
	Then User sees the products
	When User clicks the add to cart button	1 times
	And User sees the correct number 1 on the shopping cart item
	And User goes to cart page
