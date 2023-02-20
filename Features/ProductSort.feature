Feature: Product Sort

This feature provides to check the Product Sort functionality

Background: Navigate to product page
Given User navigates to login page
When User enters credentials 'standard_user' and 'secret_sauce'
And User clicks the login button
Then User sees the products


Scenario: User should be able to sort products from Z to A
	When User select 'Name (Z to A)' option in the sort dropdown
	Then User sees products are sorted in 'descending' order 

Scenario: User should be able to sort products from A to Z
	When User select 'Name (A to Z)' option in the sort dropdown
	Then User sees products are sorted in 'ascending' order 

Scenario: User should be able to sort products from Price Low to High
	When User select 'Price (low to high)' option in the sort dropdown
	Then User sees products are sorted in 'Price low to high' order

Scenario: User should be able to sort products from Price High to Low
	When User select 'Price (high to low)' option in the sort dropdown
	Then User sees products are sorted in 'Price high to low' order