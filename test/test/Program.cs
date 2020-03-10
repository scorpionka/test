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
            System.Console.WriteLine(a1);
            int a2;
            a2 = (int)a1;
            System.Console.WriteLine(a2);
            //2) Преобразование int в uint
            int b1 = -150;
            System.Console.WriteLine(b1);
            uint b2;
            b2 = (uint)b1;
            System.Console.WriteLine(b2);
            //3) Преобразование ushort в short
            ushort c1 = 60000;
            System.Console.WriteLine(c1);
            short c2;
            c2 = (short)c1;
            System.Console.WriteLine(c2);
            //b) Неявное преобразование типов
            //1) Преобразование float в double
            float d1 = 254.142F;
            System.Console.WriteLine(d1);
            double d2 = d1;
            System.Console.WriteLine(d2);
            //2) Преобразование short в float
            short e1 = 3005;
            System.Console.WriteLine(e1);
            float e2 = e1;
            System.Console.WriteLine(e2);
            //3) Преобразование byte в double
            byte f1 = 120;
            System.Console.WriteLine(f1);
            double f2 = f1;
            System.Console.WriteLine(f2);

            int a = 70000;
            Console.WriteLine(a);
            object b = a;
            ushort c = (ushort)(int)b;
            Console.WriteLine(c);
        }
    }
}
