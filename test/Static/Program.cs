using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem item1 = new UniqueItem();
            UniqueItem item2 = new UniqueItem();
            UniqueItem item3 = new UniqueItem();
            Console.WriteLine(UniqueItem.LastId);
            Console.WriteLine(item1._id);
            Console.WriteLine(item2._id);
            Console.WriteLine(item3._id);
            UniqueItem item4 = new UniqueItem(7);
            Console.WriteLine(UniqueItem.LastId);
            Console.WriteLine(item1._id);
            Console.WriteLine(item2._id);
            Console.WriteLine(item3._id);
            UniqueItem item5 = new UniqueItem();
            Console.WriteLine(UniqueItem.LastId);
            Console.WriteLine(item1._id);
            Console.WriteLine(item2._id);
            Console.WriteLine(item3._id);
        }
        class UniqueItem
        {
            public int _id;
            public static int LastId = 1;
            public UniqueItem()
            {
                _id = LastId + 1;
                LastId = _id;
            }
            public UniqueItem(int id)
            {
                _id = id;
                LastId = _id;
            }
        }
    }
}
