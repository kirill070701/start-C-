using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("введите число");
            int two, three;
            string one, output;
            one = Console.ReadLine();
            two = Convert.ToInt32(one);
            three = two + 6;
            output = Convert.ToString(three);
            Console.WriteLine(output);

        }
    }
}
