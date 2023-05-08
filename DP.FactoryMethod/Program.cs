// See https://aka.ms/new-console-template for more information
using DP.FactoryMethod.Business;
using DP.FactoryMethod.Logger;

CustomerManager customerManager = new(LoggerFactory.GetInstance());
customerManager.SaveCustomer();