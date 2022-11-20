using System;

namespace _9._137
{
    class Program
    {
        static string Metod(string Name)
        {
            Console.WriteLine($"Введите {Name}:");
            string a = "";
            while (a.Length < 1)
                a = Console.ReadLine();
            return a;
        }
        static void Main(string[] args)
        {
            string b;
            do
            {
                b = Metod("слово из 12-ти букв");
            }
            while (b.Length != 12);
            for (int i = 1; i < b.Length / 2; i++)
            {
                string c = b[b.Length - 1].ToString();
                b = b.Remove(b.Length - 1).Insert(i * 2 - 1, c);
            }
            Console.WriteLine(b);
            
        }
    }
}
