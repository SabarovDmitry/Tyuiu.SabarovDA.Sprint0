using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SabarovDA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SabarovDA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 5));

            Console.WriteLine(DataService.Subtraction(10, 5));

            Console.WriteLine(DataService.Multiplication(7, 5));

            Console.WriteLine(DataService.Division(50, 5));

            Console.ReadKey();
        }

       
    }
}
