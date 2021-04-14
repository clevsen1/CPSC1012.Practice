using System;

namespace HighLowGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //driver

            //any local variable within a menu is "alive" only as long as the method is also "alive"
            //Variables between methods may have the same name but are local to the method the variable exists in (called scope)
            string inputTemp = "";
            do
            {
                inputTemp = DisplayMenu();
                int lowRange = 1;
                int highRange = 10;
                int target = 0;
                
                Random rnd = new Random();

                switch (inputTemp.ToLower())
                {
                    case "a":
                        {
                            //Prompt for the games lower range
                            lowRange = InputNumeric("Enter the number for the lower range limit");
                            //Prompt for the games higher range
                            highRange = InputNumeric("Enter the number for the higher range limit");
                            Console.WriteLine($"Your range is from {lowRange} to {highRange}");
                            //Could test to see if (lower + 1) < higher
                            //ensures you have a spread of 3 possible numbers
                            //(lower 4, upper 6) - ensures the player did not enter the high number then the low number to mess up your program
                            break;
                        }
                    case "b":
                        {
                            int counter = 0;
                            string guessResult = "";
                            //a random number within the range
                            //the max value is EXCLUSIVE! you must add +1)
                            target = rnd.Next(lowRange, highRange + 1);
                            while (guessResult != "Correct")
                            {
                                guessResult = MakeGuess(lowRange, highRange, target);
                                if (!(guessResult != "Correct"))
                                {
                                    Console.WriteLine($"You did not guess correctly. Your guess is too {guessResult}");
                                }
                                else
                                {
                                    Console.WriteLine($"Correct. The secret number was {guessResult}");
                                }
                            }
                            break;
                        }
                    case "x":
                        {
                            Console.WriteLine("\nThanks for playing!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice, please enter a valid choice");
                            break;
                        }
                }

            } while (!inputTemp.ToLower().Equals("x"));
            
        }

        //a method stub is a method header and any return statement that is required
        //There is no logic in the method stub
        //Skeleton setup for the required method
        //This allows the call statement to the method to be coded elsewhere in your program so the program will run
        static string DisplayMenu()
        {
            //Methods that return a value are also known as functions
            //Methods that do not return a value are also known as sub routines

            Console.WriteLine("\nHigh/Low Guessing Game\n");
            Console.WriteLine("a) Set range");
            Console.WriteLine("b) Play Game");
            Console.WriteLine("x) Exit the program");
            Console.Write("Enter your menu choice: ");
            //inputTemp = Console.ReadLine();
            //return inputTemp;
            return Console.ReadLine();
            
        }

        static int InputNumeric(string prompt)
        {
            string numericInput = "";
            int aNumber = 0;
            bool valid = false;

            //You might see logic that sets a boolean variable(commonly called a flag) and the loop condition tests to see if the value indicates another iteration is required

            while (valid == false)
            {
                Console.Write($"{prompt}: ");
                numericInput = Console.ReadLine();
                //(output-variable-type.TryParse(input-variable, out output-variable)
                //returns true if successful and does the conversion
                //returns false if not able to convert and DOES NOT do the conversion
                if (int.TryParse(numericInput, out aNumber))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("you entered an invalid character");
                }
            }
            return aNumber;
        }

        static string MakeGuess(int low, int high, int target)
        {
            int guessNumber = 0;
            string guessResult = "";
            guessNumber = InputNumeric($"Guess a number between {low} and {high}");
            if (guessNumber == target)
            {
                guessResult = "Correct";
            }
            else if (guessNumber < target)
            {
                guessResult = "low";
            }
            else if (guessNumber > target)
            {
                guessResult = "high";
            }
            return guessResult;
        }
    }
}
