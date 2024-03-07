using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator math = new Calculator();
            //Console.WriteLine(math.Multiply(2,3,4));
            //Console.WriteLine(math.Divide(10,20));
            //Console.WriteLine(math.Difference(100,200,300));
            //Console.WriteLine(math.Sum(200,500));
            //Console.WriteLine(math.Rectangle(4,5));
            Console.WriteLine(math.Triangle());


        }
    }
}
