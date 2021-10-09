using Dflat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dflat
{
    public class Tulostaja
    {
        Tuote tuote = new Tuote();
        Aika aika = new Aika();

        Valikko valikko = new Valikko();
        public DateTime OstosPäivä = DateTime.Now;
        public static string ValittuTuote;
        public static DateTime ValittuAika;
        public void TulostaTuotteet()
        {

            tuote.TuoteLista();


            Console.WriteLine("\nTuotenimi\t\tTuotenumero\t\t\tHinta");
           

            foreach (var item in tuote.tuotelista)
            {
                Console.WriteLine(item.Tuotenimi + "\t\t" + item.Tuotenumero + "\t\t\t" + item.Hinta);
            }

            string valinta = Console.ReadLine();
            

            switch (valinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Valitsitte Basic tuotteen");
                    ValittuTuote = "Basic";
                    valikko.valittuTuote1.Add(ValittuTuote);

                    break;
                case "2":
                    Console.WriteLine("Valitsitte Pro tuotteen");
                    ValittuTuote = "Pro";
                    valikko.valittuTuote1.Add(ValittuTuote);

                    break;
                case "3":
                    Console.WriteLine("Valitsitte Enterprise tuotteen");
                    ValittuTuote = "Enterprise";
                    valikko.valittuTuote1.Add(ValittuTuote);
                    break;
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;

            }

            aika.PalveluAikaLista();
            Console.WriteLine("\n Tuoteninmi \t\t Palvelu loppuu \t\t\t Palvelun numero");

            

            foreach(var aikaitem in aika.palveluAikaLista)
            {
                Console.WriteLine(aikaitem.PalveluAikaTeksti + "\t\t" + aikaitem.PalveluAika + "\t\t\t" + aikaitem.PalveluAikaNumero);

            }
            

            string ajanValinta = Console.ReadLine();

            switch (ajanValinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Valitsitte 1 kuukausi palveluaikaa");
                    ValittuAika = OstosPäivä.AddMonths(1);
                    valikko.valittuAika1.Add(ValittuAika);
                    break;
                case "2":
                    Console.WriteLine("Valitsitte 6 kuukautta palveluaikaa");
                    ValittuAika = OstosPäivä.AddMonths(6);
                    valikko.valittuAika1.Add(ValittuAika);
                    break;
                case "3":
                    Console.WriteLine("Valitsitte 12 kuukautta palveluaikaa");
                    ValittuAika = OstosPäivä.AddYears(1);
                    valikko.valittuAika1.Add(ValittuAika);
                    break;
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;
            }
            valikko.PääValikko();
        } 
    }
}
