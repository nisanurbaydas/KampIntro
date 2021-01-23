using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] kurslar = new String[] {"C kampı", "Java kampı", "Python kampı" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-------");

            foreach ( String kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
