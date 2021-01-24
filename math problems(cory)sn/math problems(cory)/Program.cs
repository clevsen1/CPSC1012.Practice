using System;

namespace math_problems_cory_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare double variables
            //declare string variable for input
            //prompt, input, convert test scores; repeat 3 times 
            //add test scores then divide by 3
            //display test score average

            string inputNumber;
            double testOne;
            double testTwo;
            double testThree;
            double average;

            Console.Write("Enter a real number: ");
            inputNumber = Console.ReadLine();
            testOne = double.Parse(inputNumber);

            Console.Write("Enter a real number: ");
            inputNumber = Console.ReadLine();
            testTwo = double.Parse(inputNumber);

            Console.Write("Enter a real number: ");
            inputNumber = Console.ReadLine();
            testThree = double.Parse(inputNumber);

            average = (testOne + testTwo + testThree) / 3.0;
                Console.WriteLine($"The average from the 3 test scores are {average}");

            //round the mean average to two decimal places

            Console.WriteLine($"The rounded average from the 3 test scores are {Math.Round(average, 2)}");

            //Pythagorean Theorem
            //declare 1 string for input
            //declare 3 double for triangle base, hieght, hypotenuse
            //prompt and read user input for height
            //prompt and read user input for base
            //calucluate hypotenuse
            //display data

            double triangleBase;
            double triangleHeight;
            double hypotenuse;

            string triangleInput;

            Console.Write("Enter the triangle's base: ");
            triangleInput = Console.ReadLine();
            triangleBase = double.Parse(triangleInput);

            Console.Write("Enter the triangle's height: ");
            triangleInput = Console.ReadLine();
            triangleHeight = double.Parse(triangleInput);

            hypotenuse = Math.Sqrt(Math.Pow(triangleBase, 2) + Math.Pow(triangleHeight, 2));
            
            Console.WriteLine($"The hypotenuse of a triangle with a height of {triangleHeight} and a base of {triangleBase} is {hypotenuse}");



        }
    }
}
