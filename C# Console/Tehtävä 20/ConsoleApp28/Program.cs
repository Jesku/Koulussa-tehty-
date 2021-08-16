using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä haluamasi merkki niin kerron millainen merkki se on\n-------");
            char character;
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            character = input.KeyChar;
            if (char.IsWhiteSpace(character))
            {
                Console.WriteLine("\nMerkki on välilyönti");
            }
            else if (char.IsNumber(character))
            {
                Console.WriteLine("\nMerkki on numero " + character);
            }
            else if (char.IsUpper(character))
            {
                Console.WriteLine("\nMerkki on isolla");
            }
            else if (char.IsLower(character))
            {
                Console.WriteLine("\nMerkki on pienellä");
            }
            else if (char.IsPunctuation(character))
            {
                Console.WriteLine("\nMerkki on erikoismerkki");
            }
            Console.ReadKey();
        }
    }
}
