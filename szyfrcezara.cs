using System;

namespace Cezar
{
    class Program
    {
        private static string _alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

        public static void Main()
        {
            Console.WriteLine("Wpisz tekst:");
            var input = Console.ReadLine();

            var result = "";
            foreach (var c in input)
            {
                var index = _alphabet.IndexOf(c);
                result += _alphabet[(index + 13) % 35];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}