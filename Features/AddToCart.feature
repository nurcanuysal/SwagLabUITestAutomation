Feature: Add to cart

This feature provides to check the Add To Cart functionality

Background: Navigate homepage
Given User navigates to login page
When User enters credentials 'standard_user' and 'secret_sauce'
And User clicks the login button

Scenario: User should be able to add products to cart
	Then User sees the products
	When User clicks the add to cart button	1 times
	And User sees the correct number 1 on the shopping cart item
	And User goes to cart page


Scenario: User should be able to remove products from cart in the product page
	Then User sees the products
	When User clicks the add to cart button	2 times
	And User sees the correct number 2 on the shopping cart item
	And User clicks the remove button 1 times in product page
	Then User sees the correct number 1 on the shopping cart item


Scenario: User should be able to remove products from cart in the cart page
	Then User sees the products
	When User clicks the add to cart button	1 times
	And User sees the correct number 1 on the shopping cart item
	And User goes to cart page
	When User clicks the remove button 1 times in cart page
	Then User sees the cart is empty