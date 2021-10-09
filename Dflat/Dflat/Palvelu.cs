using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dflat
{
    class Palvelu
    {
        public void TuotePalvelut(double hinta) // Maksu tapahtuman toinen vaihe, valitse palvelu
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("Alla Lista palveluista");
            Console.WriteLine("===============================================================");
            Console.WriteLine("* Uudelle asiakkaalle 30 päivän ilmainen kokeilu.");
            Console.WriteLine("\n<< 0: Lopetus >>");
            Console.WriteLine("<< 1: 12 kk paketti >>");
            Console.WriteLine("<< 2: 6 kk paketti >>");
            Console.WriteLine("<< 3: Kuukausittain >>");
            Console.WriteLine();

            string valinta = Console.ReadLine();

            double tuote = hinta; // Asiakkaan valitsema tuote edellisestä vaiheesta

            switch (valinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1": // Jos valitsee 12 kuukauden paketin
                    double trial = MonthTrial();
                    double laskuSumma = LaskunLaskija(12.0, trial, tuote); // Paketti on 12, Trial on 1 kuukausi
                    Osto(laskuSumma);
                    break;

                case "2": // Jos valitsee 6 kuukauden paketin
                    double trial2 = MonthTrial();
                    double laskuSumma2 = LaskunLaskija(6.0, trial2, tuote); // 
                    Osto(laskuSumma2);
                    break;
                case "3": // Paketti on 0 eli laskutus alkaa heti
                    double trial3 = MonthTrial();
                    double laskuSumma3 = LaskunLaskija(0, trial3, tuote); //
                    Osto(laskuSumma3);
                    break;
                default:
                    Console.WriteLine("\nValitse ylläolevista vaihtoehdoista");
                    break;
            }
        }

        public void Osto(double laskuSumma) // Maksutapahtuman kolmas vaihe, vahvista tuote
        {
            Valikko valikko = new Valikko();
            Asiakas asiakas = new Asiakas();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Tilausvahvistus:");
            Console.WriteLine("===============================================================");
            if (laskuSumma > 150) // Jos summa isompi kuin 150 niin kysesssä on joko 12 kk tai 6 kk paketti
            {
                Console.WriteLine("Tilaamiesi tuotteiden yhteenveto on " + laskuSumma + " euroa. Määräajan jälkeen laskutus jatkuu kuukausikohtaisena");
                Console.WriteLine("Tilaukseen kuulu valitsema tuote + paketti sekä mahdollinen yhden kuukauden ilmainen kokeilu, jos olet uusi asiakas.");
            }
            if (laskuSumma == 0) // Ilmaiskokeilu
            {
                Console.WriteLine("Tilaamiesi tuotteiden yhteenveto on " + laskuSumma + ". Laskutus alkaa kokeilujakson jälkeen yhden kuukauden päästä.");
                Console.WriteLine("Tilaukseen kuulu valitsema tuote + paketti sekä yhden kuukauden ilmainen kokeilu.");
            }
            if (laskuSumma < 150 && laskuSumma != 0)
            {
                Console.WriteLine("Tilaamiesi tuotteiden yhteenveto on " + laskuSumma + " euroa kuukaudessa.");
                Console.WriteLine("Tilaukseen kuulu valitsema tuote + paketti sekä mahdollinen yhden kuukauden ilmainen kokeilu, jos olet uusi asiakas.");
            }
            Console.WriteLine("\n<< 1. Osta nyt >>");
            Console.WriteLine("<< 2. Peruuta >>"); // Vie takaisin päävalikkoon

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1":
                    Console.WriteLine("\nMaksutapahtuma onnistui\n");
                    Console.WriteLine("Paina enteriä jatkaaksesi...");
                    Console.ReadLine();
                    Console.Clear();
                    valikko.PääValikko(asiakas.TestiEtuNimi, asiakas.TestiSukuNimi);
                    break;
                case "2":
                    Console.WriteLine("\nMaksutapahtuma peruutettiin\n");
                    Console.WriteLine("Paina enteriä palataksesi...");
                    Console.ReadLine();
                    Console.Clear();
                    valikko.PääValikko(asiakas.TestiEtuNimi, asiakas.TestiSukuNimi);
                    break;
                default:
                    Console.WriteLine("\nValitse ylläolevista vaihtoehdoista");
                    break;
            }
        }

        public double LaskunLaskija(double paketti, double trial, double tuote) // Laskee laskun summan
        {
            if (paketti == 0 && trial == 1)
            {
                double laskuSumma = 0;
                return laskuSumma;
            }
            if (paketti == 0)
            {
                double laskuSumma = paketti + tuote;
                return laskuSumma;
            }
            else
            {
                if (paketti == 6.0)
                {
                    double laskuSumma = (paketti - trial) * tuote;
                    double laskuSummaAle = 0.1 * laskuSumma; // Laskee Alen 10 %
                    double lasku = laskuSumma - laskuSummaAle;
                    return lasku;
                }
                else
                {
                    double laskuSumma = (paketti - trial) * tuote;
                    double laskuSummaAle = 0.18 * laskuSumma; // Laskee Alen 18 %
                    double lasku = laskuSumma - laskuSummaAle;
                    return lasku;
                }
            }
        }

        public double MonthTrial() // 
        {
            Console.WriteLine("Oletko uusi asiakas?");
            Console.WriteLine("<< 1: Kyllä >>");
            Console.WriteLine("<< 2: Ei >>");

            string Vastaus = Console.ReadLine();

            if (Vastaus == "1")
            {
                return 1.0;
            }
            else
            {
                return 0;
            }
        }
    }
}
