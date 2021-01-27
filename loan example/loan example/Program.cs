using System;

namespace loan_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //double loanAmount = 35000.00;
            //int yearsWorked = 3;
            //Console.Write("blah blah: ");

            //if (loanAmount < 30000.00)
            //{
            //    if (yearsWorked < 2)
            //    {
            //        Console.WriteLine("You are not qualified for a loan due to low wages and in suffecient years worked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are not qualified for a loan due to in suffecient years worked");
            //    }
            //}
            //else
            //{
            //    if (yearsWorked < 2)
            //    {
            //        Console.WriteLine("You are not qualified for a loan due to in suffecient years worked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are qualified for a loan");
            //}
            //}
            
            //if-else-if structure

            int testScore = 75;

            testScore = int.Parse(Console.ReadLine());

            if (testScore < 50)
            {
                Console.WriteLine("Your grade is a F");
            }
            else if (testScore < 60)
            {
                Console.WriteLine("Your grade is a D");
            }
            else if (testScore < 70)
            {
                Console.WriteLine("Your grade is a C");
            }
            else if (testScore < 80)
            {
                Console.WriteLine("Your grade is a B");
            }
            else if (testScore < 90)
            {
                Console.WriteLine("Your grade is a A");
            }
        }
    }
}
