using System;

namespace _Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data1 = new int[13];
            for (int x = 0; x < 13; x++)
            {
                data1[x] = rnd.Next();
            }
            foreach (var y in data1)
            {
                Console.Write(y);
                Console.Write(" ");
            }
            Console.WriteLine();
            int index_max = 0;
            for (int z = 1; z < 13; z++)
            {
                Console.WriteLine();
                Console.WriteLine(data1[z]);
                Console.WriteLine(data1[index_max]);
                if (data1[z] > data1[index_max])
                {
                    index_max = z;
                }
                Console.WriteLine(data1[index_max]);
            }
            Console.WriteLine();
            Console.WriteLine(data1[index_max]);
        }
    }
}
