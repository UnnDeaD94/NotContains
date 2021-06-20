using System;

namespace NotContains
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] x = new int[5];
            int index = 0;

            while (index < x.Length)
            {
                x[index] = r.Next(100);
                Console.WriteLine(x[index]);
                index++;
            }

            Console.WriteLine("*************");
            int min = x[0];
            index = 1;

            while (index < x.Length)
            {
                if (x[index] < min)
                {
                    min = x[index];
                }
                index++;
            }
            if (min <= 0) 
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Min in array -> " + min);
            Console.WriteLine("Array NotContains -> " + --min);

            while (min > 1)
            {
                Console.WriteLine(--min);
            }
            Console.ReadKey();
        }
    }
}
