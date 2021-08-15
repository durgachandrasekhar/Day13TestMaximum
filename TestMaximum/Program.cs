using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to Maximum Number");

            //Maximum Integer Number
            GenericMaximum<int> genericMaximumInteger = new GenericMaximum<int>(34, 23, 12);
            int outputInteger1 = genericMaximumInteger.MaxMethod();
            Console.WriteLine("Maximum Integer Number : " + outputInteger1);

            //Maximum Float Number
            GenericMaximum<double> genericMaximumFloat = new GenericMaximum<double>(3.4, 22.23, 48.12);
            double outputDouble1 = genericMaximumFloat.MaxMethod();
            Console.WriteLine("Maximum Float Number : " + outputDouble1);

            //Maximum String Number
            GenericMaximum<string> genericMaximumString = new GenericMaximum<string>("apple", "banana", "peach");
            string outputString1 = genericMaximumString.MaxMethod();
            Console.WriteLine("Maximum String : " + outputString1);

        }
    }
}