using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 for Extension Method
            Calculator objcalculator = new Calculator();
            Console.WriteLine(objcalculator.Sum(5, 2));
            Console.WriteLine(objcalculator.Sub(5, 2));
            Console.WriteLine(objcalculator.returnIdentifier());


            //Example 1 for Extension Method
            string str = "Hello";
            Console.WriteLine(str.Length);
            Console.WriteLine(str.stringLength());
            Console.ReadLine();
        }
    }
}
