using System;
using System.Collections.Generic;




namespace Dflat
{
    public class Valikko
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
                    asiakas.SaveUser();
                    break;
                case "3":
                    tulostaja.TulostaTuotteet();
                    break;
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;
            }
        }

        public void PääValikko() // Valikko kun kirjautunut
        {
            Tulostaja tulostaja = new Tulostaja();
            

            Console.WriteLine("===============================================================");
            Console.WriteLine("Tervetuloa! Kuinka voimme palvella?");
            Console.WriteLine("===============================================================");
            Console.WriteLine("<< 0: Lopetus >>");
            Console.WriteLine("<< 1: 30 päivää kokeiluaikaa >>");
            Console.WriteLine("<< 2: Tiedot >>");
            Console.WriteLine("<< 3: Muuta Palvelut >>");
            Console.WriteLine();

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1":
                    Kokeilu();
                    Näytä();
                    break;
                case "2":
                    Näytä();
                    break;
                case "3":
                    tulostaja.TulostaTuotteet();
                    break; 
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;
            }
        }
        public List<string> valittuTuote1 = new List<string>
        {

        };
        public List<DateTime> valittuAika1 = new List<DateTime>
        {

        };
        public List<double> valittuHinta = new List<double>
        {

        };

        public void Näytä()
        {
            Console.WriteLine("___________________________________________________");
            foreach (string item in valittuTuote1)
            {
                Console.WriteLine("Valitsemasi tuote on: " + item);
            }

            foreach (DateTime item1 in valittuAika1)
            {
                Console.WriteLine("Seuraava eräpäivä on: " + item1);
            }

            foreach (double item2 in valittuHinta)
            {
                Console.WriteLine("Hinta on: " + item2);
            }
            Console.WriteLine("___________________________________________________");

            PääValikko();
        }

        public void Kokeilu()
        {
            DateTime PäiväNyt = DateTime.Now;
            DateTime KokeiluAika = PäiväNyt.AddMonths(1);
            double KokeiluHinta = 0;
            string KokeiluTuote = "30 päivän kokeiluversio";

            valittuAika1.Add(KokeiluAika);
            valittuHinta.Add(KokeiluHinta);
            valittuTuote1.Add(KokeiluTuote);
        }
    }

}