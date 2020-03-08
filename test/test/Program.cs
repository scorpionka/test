using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) Явное преобразование типов
            //1) Преобразование double в int
            double a1 = 105.248;
            int a2;
            a2 = (int)a1;
            System.Console.WriteLine(a2);
            //2) Преобразование int в uint
            int b1 = -150;
            uint b2;
            b2 = (uint)b1;
            System.Console.WriteLine(b2);
            //3) Преобразование ushort в short
            ushort c1 = 60000;
            short c2;
            c2 = (short)c1;
            System.Console.WriteLine(c2);
            //b) Неявное преобразование типов
            //1) Преобразование float в double
            float d1 = 254.142F;
            double d2 = d1;
            System.Console.WriteLine(d2);

            int a = 70000;
            Console.WriteLine(a);
            object b = a;
            ushort c = (ushort)(int)b;
            Console.WriteLine(c);
        }
    }
}
