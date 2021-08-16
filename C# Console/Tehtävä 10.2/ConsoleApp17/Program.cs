using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtava 10 vaihe 2");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Arvaa luku väliltä 1-12 (lopetus L-merkillä)\n");
            int x;
            Random randnum = new Random();
            x = randnum.Next(1, 13);
            for (int i = 1; i > 0; i++)
            {
                Console.Write(i + ". yritys: Arvaa luku? ");
                string quess = (Console.ReadLine());
                Console.WriteLine("");
                if (quess == "L")
                {
                    Console.WriteLine("Lopetetaan...\n");
                    Console.WriteLine("Halusit lopettaa LUUSERI!!\n");
                    Console.WriteLine("Oikea vastaus on " + x);
                    break;
                }
                int y = Int32.Parse(quess);
                if (x == y)
                {
                    Console.WriteLine("\nOnneksi olkoon, arvasit oikein!!");
                    Console.WriteLine("Oikea vastaus on " + x);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}