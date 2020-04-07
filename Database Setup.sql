-- Run this to create the Database
/*
Create Database CoffeeShop;
*/


-- Run this to create the Table
/*
use CoffeeShop;

create Table Products (
	ID int NOT NULL primary key identity(100,1),
 	Name nvarchar(50) NOT NULL,
 	Price float(32) NOT NULL,
 	Description nvarchar(300),
 	Category nvarchar(20) NOT NULL
 )
*/

-- Run this to populate table
/*
use CoffeeShop;
insert into Products 
(Name, Price, Category, Description)
values
('Black Coffee', 0.50, 'Hot Drink', 'Just a regular cup of Joe, Always hot and ready to go'),
('Sweet Tooth Coffee', 0.80, 'Hot Drink', 'Cup of coffee with way too much sugar for the faint of heart'),
('Iced Coffee', 2.50, 'Cold Drink', 'Get a caffinee fix without getting over heated'),
('Plain Bagel', 0.99, 'Food', 'For those that like it plane'),
('Cajun Bagel', 1.99, 'Food', 'Something to Spice things up'),
('Puffy Rice Treat', 2.19, 'Food', 'Just like mom use to make'),
('Single Shot Espresso', 1.59, 'Drink Addon', 'For when you need that espresso feeling'),
('Double Shot Espresso', 2.49, 'Drink Addon', 'For the bean counters in the back')
*/