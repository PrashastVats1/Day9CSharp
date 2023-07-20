using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSimpleInterfaceEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            Console.ReadKey();
        }
    }
}
