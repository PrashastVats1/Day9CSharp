using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConAppRegEXExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>()
            //{
            //    "Aman","Amit","Vijay", "Mohit","Mojito", "Popcorn Shake"
            //};
            //string pattern = @"\b[M]\w+";
            //Regex regex = new Regex(pattern);

            //string mobPattern = @"^\d{10}$";
            //Regex regex = new Regex(mobPattern);
            //string[] mobiles = new string[]
            //{
            //    "+91-8218213456", "9898989898","9090909090","+91-8234567890","+91-6363636363","9999999999",
            //};
            //foreach (string mobile in mobiles)
            //{
            //    if (regex.IsMatch(mobile))
            //    {
            //        Console.WriteLine("{0} is a valid mobile number", mobile);
            //    }
            //    else { Console.WriteLine("{0} is not a valid mobile number", mobile); }
            //}

            //Create a example to input name, mobile and pincode, check pattern validation
            string choice = "y";
            while (choice=="Y"||choice=="y") {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter mobile");
                string mobile = Console.ReadLine();
                Console.WriteLine("Enter pincode");
                string pincode = Console.ReadLine();
                string namePattern = @"^[A-Za-z\s]+$";
                string mobPattern = @"^\d{10}$";
                string pinPattern = @"^\d{6}$";
                Regex nameRegex = new Regex(namePattern);
                Regex mobRegex = new Regex(mobPattern);
                Regex pinRegex = new Regex(pinPattern);
                bool validName = nameRegex.IsMatch(name);
                bool validMob = mobRegex.IsMatch(mobile);
                bool validPin = pinRegex.IsMatch(pincode);
                if(validName && validMob && validPin) {
                    Console.WriteLine("All details are valid");
                    Console.WriteLine($"Name:\t {name}");
                    Console.WriteLine($"Mobile:\t {mobile}");
                    Console.WriteLine($"Pin code:\t {pincode}");
                }
                else
                {
                    if (!validName) { Console.WriteLine("Invalid Name!");}
                    if(!validMob) { Console.WriteLine("Invalid Mobile"); }
                    if(!validPin) { Console.WriteLine("Invalid Pincode"); }
                }
                Console.WriteLine("To continue press y, to stop press any key");
                choice = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
