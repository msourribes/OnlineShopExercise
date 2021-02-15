_____________________________________________________________________________________________________________________

TASK OVERVIEW

This project models:
- an Online Shopping Cart
- a Calculator which can currently calculate the price of the items in the Cart and add any shipping costs.

Your task is:
- to implement the handling of Coupon Codes. A Coupon Code represents a Discount that can be applied on the Cart.
For that you will need to change the current implementation of the Calculator so it will be able to apply the Discount associated with that Coupon Code.

______________________________________________________________________________________________________________________


There can be three types of Coupon Codes:

- A discount based on supplier: X% off each item in the Cart for a specific supplier. For example, for supplier, Apple, coupon code, SAVE15, gives you 15% off all Apple products)
- A free shipping-based discount: Free shipping regardless of total cost
- A discount based on category: Y% off each item that is part of a specified Product Category. Products can have more than one Product Category. For example, for category, Audio, coupon code, LOVEMYMUSIC, gives you 20% off of all products with category "Audio"

There are three types of Product Categories that you need to implement:
- Electronic
- Accessory
- Audio

There are three types of Suppliers:
- HP
- Dell
- Apple




Currently, the price of the Cart is calculated as follows:
- For each Product in the Cart, find its price and multiply by the number of units required
- Once all summed up, add any shipping costs as follows:
	- running total is less than 20, shipping cost is 7
	- running total is less than 40, shipping cost is 5
	- otherwise shipping cost is free
- Return the running total added to the shipping cost


YOU NEED TO IMPLEMENT THE FOLLOWING:

Given a Cart that contains
- 2 * headphones from Apple, at 10 per unit
- 1 * usb cable from Apple, at 4 per unit
- 1 * monitor from HP, at 100 per unit
- 1 * laptop from Dell, at 1000 per unit

Given these Products and associated Product Categories:
- Headhphones: Accessory, Electronic, Audio
- USB cable: Accessory
- Monitor: Electronic
- Laptop: Electronic

Write passing unit tests for:

1) applying the "AUDIO10" Coupon Code to the above cart
2) applying the "APPLE5" Coupon Code to the above cart
3) applying the "FREESHIPPING" Coupon Code to the above cart
4) applying an invalid or unknown Coupon Code to the above cart

We would like to see:
- NUnit is used currently, but you are free to use an alternative. Or something to complement it.
- Add or change any of the classes/code-base as you find appropriate
- Make your solution extensible and follow SOLID principles

When we will evaluate the solution we will be looking for the following points:

- Good understanding of SOLID Principles	
- Good understanding of DI	
- Unit Testing	
- Good data structure choices	
- Appropriate refactoring of base implementation
- Easy to follow and readable solution


Feel free to change the existing code as you want, it could potentially contain bugs or improper error handling etc...
You can comment (in the code, in an e-mail, or verbally when we will go through your solution together) what you think of the design and the code, are there any potential bugs, or misleading elements?


BONUS QUESTION:  what would you do with this solution to handle the use case of a user being refunded the correct amount for a returned item?
