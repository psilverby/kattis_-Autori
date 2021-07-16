using System;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] names = input.Split("-");
            string abbrevation = string.Empty;
            foreach (var name in names)
            {
                abbrevation =  string.Concat(abbrevation, name.Substring(0, 1));
            }

            Console.WriteLine(abbrevation);
        }
    }
}
