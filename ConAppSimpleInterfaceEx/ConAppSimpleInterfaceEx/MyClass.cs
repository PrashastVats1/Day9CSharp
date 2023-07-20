using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSimpleInterfaceEx
{
    public class MyClass : IMyInterface
    {
        public void Display()
        {
            Console.WriteLine("Welcome to interface");
        }
    }
}
