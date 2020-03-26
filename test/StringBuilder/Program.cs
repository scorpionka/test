using System;
using System.Text;

namespace StringBuilder_test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.UtcNow);
            sb.Append('\n');
            sb.Append("Hello!");
            Console.WriteLine(sb.ToString());
        }
    }
}