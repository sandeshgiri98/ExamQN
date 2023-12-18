//Create a interface numb that contains method public void find prime  (int x, int y) and public string
//get odd(int x).Now create a class solution that use interface and provide implementation of both method. 
//First method prime number from x to y and second method finds whether the no is odd or not and returns result.
using System;


internal class Interface
{
   
public interface Numb
    {
        void FindPrime(int x, int y);
        string GetOdd(int x);
    }

    // Class implementing the interface
    public class Solution : Numb
    {
        public void FindPrime(int x, int y)
        {
            Console.WriteLine($"Prime numbers between {x} and {y}:");
            for (int i = x; i <= y; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        public string GetOdd(int x)
        {
            return x % 2 == 1 ? "Odd" : "Even";
        }

        private bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of the Solution class
            Solution solution = new Solution();

            // Using the methods from the interface
            solution.FindPrime(10, 30);

            int number = 15;
            string result = solution.GetOdd(number);
            Console.WriteLine($"{number} is {result}.");
        }
    }

}
