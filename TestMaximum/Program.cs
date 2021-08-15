using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to Maximum Number");

            //Array With Different Data Types
            int[] intArray = { 34, 23, 12, 36 };
            double[] doubleArray = { 12.5, 45.65, 987.45, 658.78 };
            string[] stringArray = { "Apple", "Peach", "Banana" };

            // Objects 
            ExtendGenericMaximum<int> extendGenericMaximum = new ExtendGenericMaximum<int>(intArray);
            ExtendGenericMaximum<double> extendGenericMaximum1 = new ExtendGenericMaximum<double>(doubleArray);
            ExtendGenericMaximum<string> extendGenericMaximum2 = new ExtendGenericMaximum<string>(stringArray);

            //Display Output
            extendGenericMaximum.PrintMaxValue();
            extendGenericMaximum1.PrintMaxValue();
            extendGenericMaximum2.PrintMaxValue();
        }
    }
}