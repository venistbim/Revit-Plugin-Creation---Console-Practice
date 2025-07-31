using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace If_else_excersise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter number1 :");
            string input1 = Console.ReadLine();


            Console.Write("enter number2 :");
            string input2 = Console.ReadLine();


            int num1, num2;

            num1 = Convert.ToInt32(input1);
            num2 = Convert.ToInt32(input2);


           Console.Write(("Total sum of :") + (num1+num2));


            Console.ReadKey();









        }
    }
}
