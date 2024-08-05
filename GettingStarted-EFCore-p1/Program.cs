using GettingStarted_EFCore_p1.Data;
using GettingStarted_EFCore_p1.Models;
using Microsoft.EntityFrameworkCore.Storage;

using ContosoPizzaContext context = new ContosoPizzaContext();
//Add products to DB
//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special",
//    Price = 9.99M
//};
//context.Products.Add(veggieSpecial);

//Product margaritaPizza = new Product()
//{
//    Name = "Margarita Pizza",
//    Price = 5.00M
//};
//context.Products.Add(margaritaPizza);
//Product fungi = new Product()
//{
//    Name = "Pizza Fungi",
//    Price = 15M
//};
//context.Add(fungi);
//context.SaveChanges();


//Retrieve and change price
//var veggieSpecialRetrieved = context.Products.Where(p => p.Name == "Veggie Special").FirstOrDefault();
//if(veggieSpecialRetrieved is Product)
//{
//    veggieSpecialRetrieved.Price = 20M;
//}
//context.SaveChanges();

// Delete entity:
var veggieSpecialToDelete = context.Products
            .Where(_product => _product.Name == "Veggie Special")
            .FirstOrDefault();
if (veggieSpecialToDelete is Product)
{
    context.Remove(veggieSpecialToDelete);
}
context.SaveChanges();





//read from db:
var products = context.Products
    .Where(p => p.Price > 10M)
    .OrderBy(p => p.Name);//fluent api syntax

foreach(Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}