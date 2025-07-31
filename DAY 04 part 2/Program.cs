using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_04_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            double Number1 = 1;
            double Number2 = 2;
            double Number3 = 3;


            double add = Number1 + Number2 + Number3;
            Console.WriteLine(add);

            Console.ReadKey();


            double mul = Number1 * Number2;
            double sub = Number1 - Number2;
            double quo = Number1 / Number2;
            double rem = Number1 % Number2;


            Console.Write("multiplication value" +(mul));
            Console.WriteLine(sub);
            Console.WriteLine(quo);
            Console.WriteLine(rem);
            Console.ReadKey();




        }
    }
}
