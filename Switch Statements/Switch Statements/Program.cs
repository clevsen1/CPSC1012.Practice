using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //practice case structure
            //examines a value/expression against another value in the == scenario
            string inputTemp;
            Console.Write("Enter an integer:\t");
            inputTemp = Console.ReadLine();
            int number = int.Parse(inputTemp);

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine($"Case 1: You entered a number from 1 to 3: {number}");
                        break; //break takes you to the next executable statemnent after the switch
                    }
                case 2:
                    {
                        Console.WriteLine($"Case 2: You entered a number from 1 to 3: {number}");
                        break; 
                    }
                case 3:
                    {
                        Console.WriteLine($"Case 2: You entered a number from 1 to 3: {number}");
                        break; 
                    }
                default:
                    {
                        //this last coding block is executed IF ALL OTHER CASES HAVE FAILED
                        Console.WriteLine($"Default: You entered a number outside of 1 to 3: {number}");
                        break;
                    }
            }//eos switch

            if (number == 1)
            {

            }
            else if (number == 2)
            {

            }
            else if (number ==3)
            {

            }
                else
            {

            }
        }
    }
}
