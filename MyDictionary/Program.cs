using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Pink");
            dictionary.Add(2, "Black");
            dictionary.Add(3, "White");
            dictionary.Add(4, "Blue");
            dictionary.ListAll();
        }
    }
}
