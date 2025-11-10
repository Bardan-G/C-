using System;

namespace Week3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");

            try
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input); // May throw FormatException
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }
    }
}