namespace Week_5_Assignment_5._1._1
{
    internal class Program
    {
        // Given an integer x, return true if x is a palindrome, and false otherwise.

        //Example 1:
        //Input: x = 121
        //Output: true
        //Explanation: 121 reads as 121 from left to right and from right to left.

        //Example 2:
        //Input: x = -121
        //Output: false
        //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

        static bool Palindrome(int x)
        {
            int original = x;
            int reversed = 0;

            while (x > 0)
            {
                int digit = x % 10; // Extract the last number
                reversed = reversed * 10 + digit; // Adding to end of reversed
                x /= 10; // Remove the last number 
            }
            return original == reversed; // Checking if Original equal Reversed
        }
        
        static void Main(string[] args)
        {
            Console.Write("Please enter any numbers to dertemine if Palindrome: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(Palindrome(x));
        }
    }
}
