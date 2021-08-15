using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to Maximum Number");

            //Calling Class to call a Function
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();

            //Maximum Number At First Place
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(411, 282, 333);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);


        }
    }
}