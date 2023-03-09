using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            var value = rnd.Next(0,5);  
            var value1 = rnd.Next(0,5); 
            var value2 = rnd.Next(0,5); 
            var value3 = rnd.Next(0,5); 
            
       if (value == 0) { Console.WriteLine("Promah!"); }


            Console.WriteLine("Russia:");
            Console.WriteLine(value);  
            Console.WriteLine(value1);
            Console.WriteLine("Itog:" + (value + value1));

            Console.WriteLine("");

            Console.WriteLine("Sweden");
            Console.WriteLine(value2); 
            Console.WriteLine(value3);
            Console.WriteLine("Itog:" + (value2 + value3));

            Console.WriteLine("");

            if (value+value1 > value2+value3) 
            { Console.WriteLine("Рейтинг: '\n' Winner: Russia '\n' Vtoroe mesto: Sweden "); } 
            else if (value+value1 < value2 + value3) { Console.WriteLine("Рейтинг: '\n' Winner: Sweden '\n' Vtoroe mesto: Russia "); }

            Console.ReadKey();
        }

    }
}
