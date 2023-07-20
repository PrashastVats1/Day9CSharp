using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
            Employee employee1 = new Employee(12, "Sam");
            employee1.Display();
            Employee employee2 = new Employee();
            employee2.Register();
            employee2.Display();
            Console.ReadKey();
        }
    }
}
