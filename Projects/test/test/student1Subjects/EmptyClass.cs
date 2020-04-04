using System;
namespace test.Algo
{
    public class SumTwoNumbers
    {
        public static int sumofTwoNumbers(int number1, int number2)
        {
            int sum = number1 + number2;

            return sum;
        }

        public static void Main(string[] args)
        {

            int sum = sumofTwoNumbers(3, 4);
            Console.WriteLine("The sum of two numbers is: " + sum);

        }
    }
}
