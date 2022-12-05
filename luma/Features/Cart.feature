Feature: Add To Cart
	As a user I want to be able to add items to the cart
	So that I can buy 2 jackets and 1 Pants for man

@AddToCart
Scenario: Proceed add items to cart
	Given that user do login
	And user go to man section
	And user go to the jacket section
	And user adding the first jackets to the cart
	And user adding the second jackets to the cart
	And user go back to the  man section
	And user go to the pants section
	And user adding the pants to the cart
	And user click cart icon
	And user click proceed to checkout button
	And user fill company name
	And user fill city
	And user choose state or province
	And user fill zip or postal code
	And user choose country
	And user fill phone number
	And user choose shipping methods
	And user click next
	And user verify the order summary
	And user place an order
	And user go to my account page
	And user go to my order page
	When user verify the order
	Then the order successful