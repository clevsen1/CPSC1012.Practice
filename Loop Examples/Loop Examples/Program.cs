using System;

namespace Loop_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            ////pre-test loop structure (a.k.a Do-While structure
            //string inputTemp;
            //int aNumber;
            //Console.Write("Enter a number:");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //int loopExecution = 0;
            ////pre test loop
            //while (aNumber != 0)
            //{
            //    //all code within this coding block belongs to the loop
            //    //a fast way of adding 1 to a counter
            //    //alternate way: loopExecution = loopExecution + 1;
            //    loopExecution++;
            //    Console.WriteLine($"You entered the number {aNumber}");
            //    Console.Write("Enter a number:");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //}

            ////next statement is the first executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecution} times");


            ////post-tes loop
            //do
            //{
            //    //all code within this coding block belongs to the loop
            //    //a fast way of adding 1 to a counter
            //    //alternate way: loopExecution = loopExecution + 1;
            //    loopExecution++;

            //    Console.Write("Enter a number:");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    Console.WriteLine($"You entered the number {aNumber}");
            //} while (aNumber != 0);


            ////next statement is the first executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecution} times");

            ////assume you are a instructor
            ////enter a mark for each student in your class
            ////continue to enter marks for the students and after all marks have been entered
            ////calculate the average.The highest mark for any student is 100.
            ////the lowest mark for any student is 0

            ////requirements
            ////data: counter for marks entered (int)
            ////  totaling variable(int)
            ////  final average variable
            ////processing: loop/iteration
            ////prompt, read, sum, check for next entry
            ////What will be the terminating value-could use a charactrer string to terminate. ie. x
            ////Calculate and display the number of students and their average

            //Declare variables
            //string inputTemp;
            //int sumOfMarks = 0;
            //int countOfStudents = 0;
            //int inputNumber = 0;

            ////get my first value
            //Console.Write("\nEnter the student mark or x to to terminate: ");
            //inputTemp = Console.ReadLine();

            ////pre-test
            //while (inputTemp.ToUpper() != "X")
            //{
            //    sumOfMarks += int.Parse(inputTemp);
            //    countOfStudents++; //fast way to add 1 to a counter
            //    Console.Write("Enter the student mark or x to to terminate: ");
            //    inputTemp = Console.ReadLine();
            //}
            //if (countOfStudents == 0)
            //{
            //    Console.WriteLine("You did not enter any student marks");
            //}
            //else
            //{
            //    Console.WriteLine($"There are {countOfStudents} students. Their average" + $"mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            //}

            //post-test

            //get my first value

            //do
            //{
            //    Console.Write("\nEnter the student mark or x to to terminate: ");
            //    inputTemp = Console.ReadLine();
            //    if (inputTemp.ToUpper() != "X")
            //    {
            //        //is the date of the correct datatype
            //        if (int.TryParse(inputTemp,out inputNumber))
            //        {
            //            //validating that the input number is within the acceptable range
            //            if (inputNumber >= 0 && inputNumber <= 100)
            //            {
            //                //assume that date is good
            //                sumOfMarks += inputNumber;
            //                countOfStudents++;
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Your number: {inputNumber} is outside the acceptable range of 0-100");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Your entered value {inputTemp} is not a number or the character X. Your value is invalid and rejected");
            //        }
            //    }
            //}
            //while (inputTemp.ToUpper() != "X");

            //if (countOfStudents == 0)
            //{
            //    Console.WriteLine("You did not enter any student marks");
            //}
            //else
            //{
            //    Console.WriteLine($"There are {countOfStudents} students. Their average" + $"mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            //}



            //Find the sume of the squares of the intergers from 1 to MySquare, where MySquare is input by the user
            // user enters 4 then returns 1x1, 2x2, 3x3, 4x4 = 30

            //string inputTemp;
            //int mySquare = 0;
            //int sumOfSquares = 0;

            //Console.Write("Enter an interger to find out its sum of squares: ");
            //inputTemp = Console.ReadLine();
            ////Validate the incoming value
            ////xx.TryParse takes the input string and attempts to convert the string to the request numeric datatype
            ////If the attempt is good, then the value is palced in the out variable and a true is returned
            ////If the attempt fails, then a false is returned and no conversion is done
            //if (int.TryParse(inputTemp, out mySquare))
            //{
            //    if (mySquare > 0)
            //    {
            //        ////Needs to do the iteration at least once- post loop
            //        //int loopCount = 1;
            //        //do
            //        //{
            //        //    sumOfSquares += loopCount * loopCount;
            //        //    loopCount++;
            //        //}
            //        //while (loopCount <= mySquare); 

            //        //Pre-loop test
            //        int loopCount = 1;
            //        while (loopCount <=4)
            //        {
            //            sumOfSquares += (int)Math.Pow(loopCount, 2);
            //            loopCount++;
            //        }

            //            Console.WriteLine($"The sum of squares for {mySquare} is {sumOfSquares}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{mySquare} is invalid. Enter a positive number.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid, enter a number.");
            //}


            ////Write a program that reads in a vlue N and then it prints its digits in a column, starting with the last digit
            //// ie: 3456 would be displayed 6543

            //Console.Write("Enter an interger and display digits in reverse order ");
            //inputTemp = Console.ReadLine();
            //int aNumber;
            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    int aNumberLength = inputTemp.Length;

            //    //use the for(...) loop syntax
            //    //the for loop is a pre test structure
            //    //for(declare loopcounter; end condition, increment/decrement)
            //    //{
            //    //  coding block
            //    //}
            //    for (int loopCount = aNumberLength-1; loopCount > 0; loopCount--)
            //    {
            //        Console.WriteLine($"{inputTemp.Substring(loopCount, 1)}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid. Enter a number: ");
            //}






            //Money Maker
            //This program will accept a principle investment amount, a monthly interest rate, and an investment time in months
            //The program will display a monthly investment report using the incoming data
            //This program will conintue until the user enteres an "x" to exit

            //process: declare/assign starting varaibles
            //  request execution or exit from the user
            //      on exit: terminate program
            //      on execution:   input investment values
            //                      itterate mopnthly earnings and report
            //                      on termination of investment period, display a summary

            //This example will use nested loops
            //menu loop wil be a post-loop
            //investment loop will be a pre-test loop using the for loop
            //output will demonstrate formatting of values and columns

            //decimal myPrincipal = 0.0m; //the m character makes this numeric a decimal
            //decimal myMonthlyInterestRate = 0.0m;
            //int myInvestmentTime = 0;

            //string menuChoice;

            //do
            //{
            //    Console.WriteLine("Welcome to CPSC investments\n");
            //    Console.WriteLine("A) Investment");
            //    Console.WriteLine("x) To exit\n");
            //    Console.Write("Enter your menu choice");
            //    menuChoice = Console.ReadLine();

            //    switch (menuChoice.ToUpper())
            //    {
            //        case "A":
            //            {
            //                string inputTemp;
            //                Console.Write("Enter your principle investment amount:\t");
            //                inputTemp = Console.ReadLine();
            //                myPrincipal = decimal.Parse(inputTemp);
            //                Console.Write("Enter your investment monthly rate(3% -> 0.03):\t");
            //                inputTemp = Console.ReadLine();
            //                myMonthlyInterestRate = decimal.Parse(inputTemp);
            //                Console.Write("Enter your investment period in months:\t");
            //                inputTemp = Console.ReadLine();
            //                myInvestmentTime = int.Parse(inputTemp);

            //                //use a loop for a fixed amount of iterations
            //                //best candidate would be a pre-test loop
            //                // A) while w/ a counter
            //                // B) for (...) loop
            //                for (int counter = 0; counter < myInvestmentTime; counter++)
            //                {
            //                    // the {0} is referred to as a placeholder
            //                    // the string.Format(format pattern, value for the pattern)
            //                    // pattern is currency and the 0 indicates a placeholder for the value in the .Format method
            //                    Console.Write("\nOpening: {0}\t", string.Format("{0:c}", myPrincipal));

            //                    //.ToString("pattern")
            //                    // the # indicates a digit position and is optional, printed if NOT zero {0}
            //                    // the 0 indicates a digit postiion and is required, zero's are printed
            //                    Console.Write("Interest Paid: {0}\t", (myPrincipal * myMonthlyInterestRate).ToString("$###,##0.00"));

            //                    myPrincipal += myPrincipal * myMonthlyInterestRate;

            //                    //{variable, x columnd width: pattern}
            //                    //variable is myPrincipal
            //                    // x column width is 15 spaces, positive value is right aligned, negative values are left alligned
            //                    // the c stands for currency with a $ sign
            //                    Console.Write($"Closing: {myPrincipal,15:c}\n");
            //                    //Console.Write($"Closing: {myPrincipal,15:0:$###,##0.00}");

            //                }

            //                Console.WriteLine($"\nClosing {myPrincipal.ToString("c"),20}");
            //                break;
            //            }
            //        case "x":
            //            {
            //                Console.WriteLine("Thank you, Good-bye");
            //               break;
            //            }
            //        default:
            //            {
            //                 Console.WriteLine("Your entry for menu choice is invalid. Please choice an option above");       
            //                 break;
            //            }
            //    }
            //}
            //while (menuChoice.ToLower() != "x");
            //Console.WriteLine("Good luck on your future investments");


            //Bacteria Looping Problem

            double finalPopulation = 0.0;
            double initialPopulation = 0.0;
            double growthRate = 0.0;
            const decimal MAXDAYS = 10; //PascalCase is alsuse used for constands MaxDays
            string inputTemp;

            //will need the tenth library value for 
            Console.WriteLine("Enter your initial bacterial population: ");
            inputTemp = Console.ReadLine();
            if (double.TryParse(inputTemp, out initialPopulation))
            {
                Console.WriteLine("Enter your bacterial growth rate as a percentage: ");
                inputTemp = Console.ReadLine();
                if ( double.TryParse(inputTemp, out growthRate))
                {
                    //we have a known number of iterations
                    //create column headers and report title
                    Console.WriteLine($"Bacterial Growth Rate for {initialPopulation} on {MAXDAYS} growth\n");
                    Console.WriteLine("{0,5} {1,25}", "Day", "Number of Bacteria Present");
                    for (int i = 1; i <= MAXDAYS; i++)
                    {
                        finalPopulation = initialPopulation * Math.Pow(Math.E, (growthRate * (double) i));
                        Console.WriteLine($"{i,5} {finalPopulation,25:0.000}");
                    }
                }
                else
                {
                    Console.WriteLine($"{inputTemp} is an invalid growth rate input");
                }
            }
            else
            {
                Console.WriteLine($"{inputTemp} is an invalid population input");
            }
        }
    }
}
