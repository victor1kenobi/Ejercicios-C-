using System;

namespace Numeros_Loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottoArray = new int[5];

            var rand = new Random();

            Console.WriteLine("Five random integers between 1 and 49:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,5:N0}", rand.Next(0, 50));

            Console.WriteLine();
            Console.WriteLine();

            for (int ctr = 0; ctr <= 1; ctr++)
                Console.Write("{0,5:N0}", rand.Next(0, 10));
        }
    }
}
