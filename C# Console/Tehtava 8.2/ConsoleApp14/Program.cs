using System;
using System.Text;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tehtava 8.2 1.vaihe");
            Console.WriteLine("-------------------\n");
            string[] name = { "Vasara", "Saha", "Kirves" };
            int[] price = { 15, 15, 15 };
            Console.WriteLine(name[0] + " " + price[0] + " €");
            Console.WriteLine(name[1] + " " + price[1] + " €");
            Console.WriteLine(name[2] + " " + price[2] + " €");

            Console.WriteLine("\nTehtava 8.2 2-4.vaiheet");
            Console.WriteLine("-------------------\n");
            decimal[] price1 = new decimal[3];
            int[] amount = new int[3];
            string[] name1 = new string[3];
            
            /*price1[0] = 10;      ! Vaihe 2 !
            price1[1] = 5;
            price1[2] = 15;
            amount[0] = 5;
            amount[1] = 10;
            amount[2] = 5;
            name1[0] = "Puukko";
            name1[1] = "Mitta";
            name1[2] = "Lamppu";
            Console.WriteLine(name1[0] + " yhteishinta on " + price1[0] * amount[0] + "€.");
            Console.WriteLine(name1[1] + " yhteishinta on " + price1[1] * amount[1] + "€.");
            Console.WriteLine(name1[2] + " yhteishinta on " + price1[2] * amount[2] + "€.");*/
            
            Console.Write("Kuinka monta tuotetta lisätään? ");
            int x = Int32.Parse(Console.ReadLine());            
            for (int i = 0; i < x; i++)
            {
                Console.Write("Anna " + i + ". tuotteen nimi? ");
                name1[i] = Console.ReadLine();
                Console.Write("Anna " + i + ". tuotteen hinta? ");
                price1[i] = Decimal.Parse(Console.ReadLine());
                Console.Write("Anna " + i + ". tuotteen lukumäärä? ");
                amount[i] = Int32.Parse(Console.ReadLine());
            }
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine(name1[j] + " " + price1[j] * amount[j] + "€.");
            }

            Console.WriteLine("\nTehtava 8.2 5.vaihe");
            Console.WriteLine("-------------------\n");
            string[] hero = { " ", "Ana", "Bastion", "Brigette", "D.Va(Mech)" };
            string[] role = { " ", "Support", "Defence", "Support", "Tank" };
            string[] health = { " ", "200", "200", "200", "400" };
            string[] armor = { " ", "0", "100", "50", "200" };
            Console.WriteLine("HEROt ovat seuraavat:");
            for (int i = 1; i < hero.Length; i++)
            {
                Console.WriteLine("(" + i + ")" + " " + hero[i]);
            }
            Console.Write("\nValitse minkä HEROn tideot haluat nähdä? ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n" + hero[y] + " " + role[y] + " " + health[y] + " " + armor[y]);
            Console.ReadKey();
        }
    }
}
