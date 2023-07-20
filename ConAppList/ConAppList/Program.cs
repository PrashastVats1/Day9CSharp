using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 21, 20, 30, 4, 55, 69 };
            Console.WriteLine("All numbers");
            Console.WriteLine("Total numbers in the list are: "+ numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine("Total numbers in the list are: " + numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Enter number to search in list");
            int searchNumber = int.Parse(Console.ReadLine());
            if(numbers.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is a part of numbers list");
            }
            else { Console.WriteLine("Not found"); }
            Console.ReadKey();
        }
    }
}
