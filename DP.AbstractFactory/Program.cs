// See https://aka.ms/new-console-template for more information

using DP.AbstractFactory.Business;
using DP.AbstractFactory.Factory;

ProductManager productManager = new(new CrossCuttingConcernsFactoryB());
productManager.GetAll();
Console.ReadLine();