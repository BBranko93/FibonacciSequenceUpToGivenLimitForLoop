using System;

namespace FibonacciSequenceUpToGivenLimitForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;

            Console.WriteLine("Please enter number for terms to be displayed : ");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 );
            for(i = 3; i <= num; i++)
            {
                n3 = n1 + n2;
                Console.Write( " " + n3 + " ");
                n1 = n2;
                n2 = n3;

            }
            Console.Write("\n");
        }
    }
}
