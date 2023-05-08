// See https://aka.ms/new-console-template for more information
using DP.Prototype.Entity;
using System.Runtime.InteropServices;

Customer customer1 = new()
{
    Id = 1,
    FirstName = "Murat",
    LastName = "Karamürsel",
    BirthDate = new DateTime(1987, 03, 20),
    CreditCardNumber = "1234 5678 9000 0001"
};
Customer customer2 = (Customer)customer1.Clone();

Console.WriteLine(customer1.FirstName);
Console.WriteLine(customer2.FirstName);
Console.WriteLine(customer1.Equals(customer2));

customer2.FirstName = "Test";

Console.WriteLine(customer1.FirstName);
Console.WriteLine(customer2.FirstName);
Console.WriteLine(customer1.Equals(customer2));