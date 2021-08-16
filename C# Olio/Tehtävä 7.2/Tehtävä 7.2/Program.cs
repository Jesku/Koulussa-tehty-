using System;
using System.Collections.Generic;

namespace Tehtävä_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary on tietorakenne, jonka alkiot koostuvat avaimesta ja arvosta

            Dictionary<string, string> henkilot = new Dictionary<string, string>();
            henkilot.Add("654321-XXXX", "Jesse Heinäaho");
            henkilot.Add("123456-YYYY", "Matti Meikäläinen");
            henkilot.Add("010101-ZZZZ", "Maija Muukalainen");

            //Tämä ei onnistu, koska samalla avaimella on jo olemassa alkio tässä sanakirjassa
            //henkilot.Add("654321-XXXX", "Pekka");

            //"henkilötunnus, nimi"
            foreach (KeyValuePair<string, string> henkilo in henkilot)
            {
                Console.WriteLine(henkilo.Key + ", " + henkilo.Value);
            }

            Dictionary<char, int> merkkienMaara = new Dictionary<char, int>();
            merkkienMaara.Add('b', 3);
            merkkienMaara.Add('a', 0);
            //merkkienMaara.Add('a', 1); Ei onnistu
            Console.WriteLine(merkkienMaara['a']);
            merkkienMaara['a'] = 1;
            Console.WriteLine(merkkienMaara['a']);
            merkkienMaara['a']++;
            Console.WriteLine(merkkienMaara['a']);

            bool sisaltaakoTietorakenneArvoa = merkkienMaara.ContainsValue(2);
            bool sisaltaakoAvainta = merkkienMaara.ContainsKey('b');

            if (merkkienMaara.ContainsKey('c'))
            {
                Console.WriteLine("Sisältää jo avaimen 'a'");
            }
            else
            {
                merkkienMaara.Add('c', 1);
                Console.WriteLine("Lisättiin c-avain ja sille arvo 1");
            }

            while (true)
            {
                Console.Write("Anna henkilötunnus > ");
                string avain = Console.ReadLine();

                if (henkilot.ContainsKey(avain))
                {
                    Console.WriteLine(henkilot[avain]);
                }
                else
                {
                    Console.WriteLine("Hakemaasi ei löytynyt, lisätään uusi.");
                    Console.Write("Anna uusi nimi > ");
                    string nimi = Console.ReadLine();
                    henkilot.Add(avain, nimi);
                    Console.WriteLine("Lisättiin henkilö tietorakenteeseen!");
                }
            }
        }
    }
}
