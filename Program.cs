using System;
using System.Linq;

namespace StringComparison
{
    class Program
    {
        static void Main()
        {
            string[] strings1 = new string[] { "Dodge Challenger", "Chevrolet Camaro", "Ford Mustang", "Chevrolet Chevelle" };
            string[] strings2 = new string[] { "Ford Mustang", "Dodge Charger", "Shelby Mustang", "Chevrolet Chevelle" };

            var common = strings1.Intersect(strings2).ToList();
            common.ForEach(Console.WriteLine); // Ford Mustang, Chevrolet Chevelle

            Console.WriteLine($"Количество совпадающих строк: {common.Count}"); // 2

            Console.ReadKey();
        }
    }
}