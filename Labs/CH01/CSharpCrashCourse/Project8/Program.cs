﻿//Classes are Blueprints for objects
using Project8;

//Create a Cart class that represents a shopping cart in an e-commerce application

//The Cart class should have the following instance fields:

//_cartId (string)
//_items (Dictionary of <string,double> such as <"lollypop", 2.5>

//The Cart class should have the following methods:
//Optionally add Constructors/ToString methods
//AddItem - Adds an item to the cart
//RemoveItem - Removes an item from the cart
//GetTotal - Returns the total cost of the items in the cart

Dictionary<string, double> items = new Dictionary<string, double>();
items.Add("Lollypop", 2.5);
items.Add("Gum", 1.5);
items.Add("Soda", 3.75);

Cart cart1 = new Cart("1234");
cart1.AddItem("Lollypop", 2.5);
cart1.AddItem("Gum", 1.5);
cart1.AddItem("Soda", 3.75);
Console.WriteLine(cart1);

cart1.RemoveItem("Gum");
Console.WriteLine(cart1);

Cart cart2 = new Cart("5678");
cart2.AddItem("Milk", 2.5);
cart2.AddItem("Bread", 1.5);
cart2.AddItem("Eggs", 3.75);
Console.WriteLine(cart2);