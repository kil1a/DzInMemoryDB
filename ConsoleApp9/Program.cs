// See https://aka.ms/new-console-template for more information
using ConsoleApp9;
Console.WriteLine("Hello, World!");
using (var dbManager = new ManagerDataBase())
{
    dbManager.SetStock();
}
