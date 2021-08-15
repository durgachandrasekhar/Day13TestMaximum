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
            string outputString1 = maximumNumberCheck.MaximumStringNumber("925", "731", "635");
            Console.WriteLine("Maximum Number of String at First Place : " + outputString1);

            //Maximum Number At Second Place
            string outputString2 = maximumNumberCheck.MaximumStringNumber("25", "896", "735");
            Console.WriteLine("Maximum Number of String at Seond Place : " + outputString2);

            //Maximum Number At Third Place
            string outputString3 = maximumNumberCheck.MaximumStringNumber("125", "196", "735");
            Console.WriteLine("Maximum Number of String at Third Place : " + outputString3);
        }
    }
}