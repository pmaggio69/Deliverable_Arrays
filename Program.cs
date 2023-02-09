// Author: Patrick
// date: 2/8/23
// Description: create a program to write Fibonacci numbers
namespace Deliverable_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int[] fibonacci = new int[x];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for(int i = 0; i < x; i++)
            {
                if(i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}