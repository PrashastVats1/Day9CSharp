using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppExamples
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Parameterless constructor call");
            id = -1;
            name = "not given";
        }
        public Employee(int id, string name)
        {
            Console.WriteLine("Parametrized constructor");
            this.id = id;
            this.name = name;
        }
        public void Register()
        {
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID: \t"+id);
            Console.WriteLine("Name: \t"+name);
        }
    }
}
