using System;
using HappyNewYear_DAL;
using HappyNewYear_DAL.Models;

namespace HappyNewYear_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            HappyNewYearRepository repo = new HappyNewYearRepository();
            //var names = repo.GetDetails("Osam");
            //var names1 = repo.GetDetails("Alisha");
            //var names2 = repo.GetDetails("Alisha1");
            //Console.WriteLine(names.YourName);
            //Console.WriteLine(names1.YourName);
            //Console.WriteLine(names2.YourName);
            /*var addFarzana = repo.AddDetails("Farzana1");
            Console.WriteLine(addFarzana);
            var addRuby = repo.AddDetails("Ruby");
            Console.WriteLine(addRuby);*/
            var del = repo.DeleteDetails("Farzana1");
            Console.WriteLine(del);

        }
    }
}
