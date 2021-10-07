using System;
using System.Collections.Generic;

namespace Dflat
{
    class Valikko
    {
        public void AlkuValikko() // Valikko kun asiakas ei kirjautunut
        {
            Asiakas asiakas = new Asiakas();
            Tulostaja tulostaja = new Tulostaja();


            // Valikko
            Console.WriteLine("===============================================================");
            Console.WriteLine("Tervetuloa asioimaan. Kuinka voimme palvella?");
            Console.WriteLine("===============================================================");
            Console.WriteLine("<< 0: Lopetus >>");
            Console.WriteLine("<< 1: Kirjaudu Sisään >>");
            Console.WriteLine("<< 2: Rekisteröidy >>");
            Console.WriteLine("<< 3: Palvelut >>");
            Console.WriteLine();

            // Valikossa valinta
            string valinta;
            valinta = Console.ReadLine();

            switch (valinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1":
                    asiakas.Kirjaudu();
                    break;
                case "2":
                    asiakas.Rekisteröidy();
                    break;
                case "3":
                    tulostaja.TulostaTuotteet();
                    break;
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;
            }
        }

        public void PääValikko(string etunimi, string sukunimi) // Valikko kun kirjautunut
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("Tervetuloa!, {0} {1}. Kuinka voimme palvella?", etunimi, sukunimi);
            Console.WriteLine("===============================================================");
            Console.WriteLine("<< 0: Lopetus >>");
            Console.WriteLine("<< 1: Laskut >>");
            Console.WriteLine("<< 2: JOTAIN >>");
            Console.WriteLine("<< 3: Palvelut >>");
            Console.WriteLine();
        }
    }
}