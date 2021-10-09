using System;
using System.Collections.Generic;

namespace Dflat
{
    class Lasku
    {
        public void Tilaukset() // Kesken vielä / ei viel yhistetty mihinkään var paketti niiku yhistyis käyttjän ostamaan pakettiin jonka se hakis tiedostosta.
        {
            // Asiakkaan Ostoaika / Pitää varmaan tallentaa jossai kohtaa asiakas tiedostoon
            var OstoAika = DateTime.Now;

            // Verrataan asiakkaan ostoaikaan / Pysyy vakiona / Eli jos nykyinen päivä isompi kuin 16 niin lasku seuraavalle kuulle
            var Ehto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16);

            double KuusiKK = 6.0;
            double KaksitoistaKK = 12.0;

            var paketti = 0; // Asiakkaan paketti. Onko 6kk vai 12kk, jos ei kumpakaan niin paketti on 0 eli laskutus tapahtuu heti

            // Tulevat Laskut / Laskutus 6kk tai 12kk jälkeen kun asiaks ostanut kerrallaan, jos ei ostanut kerrallaan niin laskutus lähtee heti.
            if (paketti == KaksitoistaKK)
            {
                var SeuraavaKuukausi = OstoAika.AddMonths(12);
                Console.WriteLine("12 kk paketti ostettu kerrallaan, laskutukset alkavat vasta: " + SeuraavaKuukausi.ToString("dd.MM.yyyy") + "\n");

                Console.WriteLine("Alla tulevat laskut:");
                for (int i = 0; i < 12; i++) // Aloittaa laskutuksen 12 kk päästä
                {
                    var tuloste = SeuraavaKuukausi.AddMonths(i);
                    Console.WriteLine("*" + tuloste.ToString("dd.MM.yyyy"));
                }
            }
            if (paketti == KuusiKK)
            {
                var SeuraavaKuukausi = OstoAika.AddMonths(6);
                Console.WriteLine("6 kk paketti ostettu kerrallaan, laskutukset alkavat vasta: " + SeuraavaKuukausi.ToString("dd.MM.yyyy") + "\n");

                Console.WriteLine("Alla tulevat laskut:");
                for (int i = 0; i < 12; i++) // Aloittaa laskutuksen 6 kk päästä
                {
                    var tuloste = SeuraavaKuukausi.AddMonths(i);
                    Console.WriteLine("*" + tuloste.ToString("dd.MM.yyyy"));
                }
            }
            if (paketti == 0)
            {
                if (OstoAika < Ehto)
                {
                    var SeuraavaKuukausi = OstoAika;
                    Console.WriteLine("Laskutukset alkavat tänään: " + SeuraavaKuukausi.ToString("dd.MM.yyyy") + "\n");

                    Console.WriteLine("Alla tulevat laskut:");
                    for (int i = 0; i < 12; i++) // Aloittaa laskutuksen heti
                    {
                        var tuloste = SeuraavaKuukausi.AddMonths(i);
                        Console.WriteLine("*" + tuloste.ToString("dd.MM.yyyy"));
                    }
                }
                else
                {
                    var SeuraavaKuukausi = OstoAika.AddMonths(1);
                    Console.WriteLine("Laskutukset alkaa vasta: " + SeuraavaKuukausi.ToString("dd.MM.yyyy") + "\n");

                    Console.WriteLine("Alla tulevat laskut:");
                    for (int i = 0; i < 12; i++) // Aloittaa laskutuksen heti seuraavassa kuussa
                    {
                        var tuloste = SeuraavaKuukausi.AddMonths(i);
                        Console.WriteLine("*" + tuloste.ToString("dd.MM.yyyy"));
                    }
                }

            }

            Valikko valikko = new Valikko();
            Asiakas asiakas = new Asiakas();
            Console.WriteLine();
            Console.WriteLine("Paina enteriä jatkaaksesi...");
            Console.ReadLine();
            Console.Clear();
            valikko.PääValikko(asiakas.ETarkistaja(), asiakas.STarkistaja());
        }
    }
}
