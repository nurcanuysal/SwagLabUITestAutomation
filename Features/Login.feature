Feature: Login

This feature provides to be able to login and check the result

Background: Navigate homepage
Given User navigates to login page

Scenario Outline: User should be able to login with valid credentials
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the products
	Examples:
	| userName                | Password     |
	| standard_user           | secret_sauce |
	| performance_glitch_user | secret_sauce |


Scenario Outline: User cannot login with locked user credentials
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the locked out user message
	Examples:
	| userName                | Password     |
	| locked_out_user         | secret_sauce |


Scenario Outline: User login with problem user credentials
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the problem user images
	Examples:
	| userName             | Password     |
	| problem_user         | secret_sauce |


Scenario Outline: User cannot login with invalid credentials
	When User enters credentials '<userName>' and '<Password>'
	And User clicks the login button
	Then User sees the error message
	Examples:
	| userName         | Password      |
	| testuser         | secret_sauce  |
	| standard_user    | test_password |