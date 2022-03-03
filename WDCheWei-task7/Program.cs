using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDCheWei_task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //{
            //    Console.WriteLine("The answer is greater than 10.");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //}
            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) && (a > b))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("And the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("Or the first number is not greater than the second");
            //}
            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) || (a > b))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("Or the first number is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("The answer is not greater than 10");
            //    Console.WriteLine("And the first number is not greater than the second");
            //}
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //} while (counter < 10);
            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //}
            //var names = new List<string>() { "Mikkeli", "Porvoo", "Oulu", "Not in Finland"};
            //foreach (string name in names)
            //{
            //    if (name == " Not in Finland")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(name);
            //}
            int j;
            ////int k =0;
            int sum = 0;
            for (j = 1; j < 20; j++)
            {
                if (j % 3 == 0)
                {
                    sum = sum + j;
            //        //Console.WriteLine($"{j}");
            //        //Console.WriteLine(sum);
            //        //Console.Write($"{k}");
                }
            };
            Console.WriteLine($"{sum}");
        }
    }
}
