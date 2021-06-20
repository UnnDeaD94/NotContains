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
                x[index] = r.Next(50);
                Console.WriteLine(x[index].ToString());
                index++;

            }

            Console.WriteLine(notContains(x).ToString());

            Console.ReadKey();
        }

       public static int notContains(int[] array)
        {
            int index = 0;

            Console.WriteLine("*************");
            int min = array[0];
            index = 1;

            while (index < array.Length)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
                index++;
            }
            if (min <= 0)
            {
                throw new Exception("Minimum Number is 0 or < 0");
            }
            return --min;
        }
    }
}
