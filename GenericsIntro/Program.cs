using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic class
            MyList<string> names = new MyList<string>();
            names.Add("Nisa");
        }
    }
}
