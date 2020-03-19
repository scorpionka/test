using System;
using System.Collections.Generic;

namespace switch_ver7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> collection = new List<object>();
            collection.Add(43);
            collection.Add(DayOfWeek.Monday);
            collection.Add("Hello, guys!");
            collection.Add(null);
            collection.Add(false);
            collection.Add("Hello, world!");
            foreach (var item in collection)
            {
                switch (item)
                {
                    case string text when text.Equals("Hello, guys!"):
                        Console.WriteLine(text);
                        break;
                    case null:
                        Console.WriteLine("Null");
                        break;
                    case Boolean @bool:
                        Console.WriteLine(@bool);
                        break;
                    case int num when num == 43:
                        Console.WriteLine(num);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
