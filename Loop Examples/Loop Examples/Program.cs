using System;

namespace Loop_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            //pre-test loop structure (a.k.a Do-While structure
            string inputTemp;
            int aNumber;
            Console.Write("Enter a number:");
            inputTemp = Console.ReadLine();
            aNumber = int.Parse(inputTemp);
            int loopExecution = 0;
            //pre test loop
            while (aNumber != 0)
            {
                //all code within this coding block belongs to the loop
                //a fast way of adding 1 to a counter
                //alternate way: loopExecution = loopExecution + 1;
                loopExecution++;
                Console.WriteLine($"You entered the number {aNumber}");
                Console.Write("Enter a number:");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);
            }

            //next statement is the first executable statement after the loop
            Console.WriteLine($"The loop has finished, you executed the loop {loopExecution} times");


            //post-tes loop
            do
            {
                //all code within this coding block belongs to the loop
                //a fast way of adding 1 to a counter
                //alternate way: loopExecution = loopExecution + 1;
                loopExecution++;

                Console.Write("Enter a number:");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);
                Console.WriteLine($"You entered the number {aNumber}");
            } while (aNumber != 0);
            

                //next statement is the first executable statement after the loop
                 Console.WriteLine($"The loop has finished, you executed the loop {loopExecution} times");

            //assume you are a instructor
            //enter a mark for each student in your class
            //continue to enter marks for the students and after all marks have been entered
            //calculate the average. The highest mark for any student is 100.
            //the lowest mark for any student is 0
        }
    }
}
