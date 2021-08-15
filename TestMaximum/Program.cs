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

            //Maximum Number At Third Place
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(141, 282, 733);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);


        }
    }
}