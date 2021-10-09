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
            Console.WriteLine("<< 2: Rekisteröidy >>"); //
            Console.WriteLine("<< 3: Palvelut >>"); // Lista palveluista
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
            Lasku laskut = new Lasku();
            Tulostaja tulostaja = new Tulostaja();

            //Valikko
            Console.WriteLine("===============================================================");
            Console.WriteLine("Tervetuloa!, {0} {1}. Kuinka voimme palvella?", etunimi, sukunimi);
            Console.WriteLine("===============================================================");
            Console.WriteLine("<< 0: Lopetus >>");
            Console.WriteLine("<< 1: Laskut >>"); // Näytetään tulevat laskut
            Console.WriteLine("<< 2: Palvelut >>"); // Täältä ostetaan palvelu
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
                    laskut.Tilaukset();
                    Console.Clear();
                    break;
                case "2":
                    tulostaja.TuoteValinta();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nValitse ylläolevista vaihtoehdoista");
                    break;
            }
        }
    }
}
