using System;

namespace Logical_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //practice logical operators
            string inputNumber;
                Console.Write("Enter an interger: ");
            inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);

            // && Test
            // all conduitions must be true to execute the true path
            // if any of your conditions are false, execute the false path
                    //if (number % 2 == 0 && number % 3 == 0)
                    //{
                    //    Console.WriteLine($"{number} is divisable by 2 and 3");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisable by 2 and 3");


            // || Test
            // One ofconditions must be true to execute the true path
            // if all of your conditions are false, execute the false path
                if (number % 2 == 0 || number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divisable by 2 or 3");
                }
                else
                {
                    Console.WriteLine($"{number} is not divisable by 2 or 3");
                }

            //combining && and ||
            // T || T && T
            // F || T && T
            // T || F && T ...

            if (number % 2 == 0 || number % 3 == 0 && number < 10)
            {
                Console.WriteLine($"{number} is divisable by 2 or 3");
            }
            else
            {
                Console.WriteLine($"{number} is not divisable by 2 or 3 and number is not less than 10");
            }

        }
    }
}
