using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50 , b = 50 ;
            if (a > b) 
            {
                Console.WriteLine("a is maximum");

            }
            else if (b > a) 
            {
                Console.WriteLine("b is maximum");
            }

            else
            {
                Console.WriteLine("both are equal");
            }
                    


                Console.ReadLine();


        }
    }
}
