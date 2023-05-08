// See https://aka.ms/new-console-template for more information
using DP.Singleton;

SingleObject singleObject_1 = SingleObject.GetInstance();
Console.WriteLine(singleObject_1.CreateDate);

Thread.Sleep(3000);

SingleObject singleObject_2 = SingleObject.GetInstance();
Console.WriteLine(singleObject_2.CreateDate);