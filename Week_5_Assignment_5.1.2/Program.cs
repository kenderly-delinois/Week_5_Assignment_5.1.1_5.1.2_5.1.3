using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Week_5_Assignment_5._1._2
{
    internal class Program
    {
        //  Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        public static int CalculateSum(int num)
        { 
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
          return sum;
        }
        public static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int output = CalculateSum(num);
            Console.WriteLine($"The result of the sum is: {output}");
        }
    }
}
