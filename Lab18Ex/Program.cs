// See https://aka.ms/new-console-template for more information
using Lab18Ex.DatabaseStuff;
using Lab18Ex.Models;

Console.WriteLine("Hello, World!");
var dataAcc = DataAccessLayer.Instance;

dataAcc.AddCar("Golf6", "VoltsWagen", 2010, 2000);

