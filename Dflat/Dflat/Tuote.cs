using System;
using System.Collections.Generic;

namespace Dflat
{
    class Tuote
    {
        public string Tuotenimi { get; set; }
        public int Tuotenumero { get; set; }
        public double Hinta { get; set; }

        public List<Tuote> tuotelista = new List<Tuote>();

        public void TuoteLista() // Pitäis lisää tuotteet jossai kohtaa johonki tekstitiedostoon
        {
            Tuote tuote = new Tuote();

            Tuote Basic = new Tuote();
            Basic.Tuotenumero = 1;
            Basic.Tuotenimi = "Basic   ";
            Basic.Hinta = 40.0;

            Tuote Pro = new Tuote();
            Pro.Tuotenumero = 2;
            Pro.Tuotenimi = "Pro     ";
            Pro.Hinta = 80.0;

            Tuote Enterprise = new Tuote();
            Enterprise.Tuotenumero = 3;
            Enterprise.Tuotenimi = "Enterprise";
            Enterprise.Hinta = 120.0;

            tuotelista.Add(Basic);
            tuotelista.Add(Pro);
            tuotelista.Add(Enterprise);
        }
    }

    class Tulostaja
    {
        public void TulostaTuotteet() // Kun asiakkaalla ei ole käyttäjää, lista tuotteista, ei voi valita mitään.
        {
            Tuote tuote = new Tuote();
            tuote.TuoteLista();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Alla lista tuotteista");
            Console.WriteLine("===============================================================");
            Console.WriteLine("* Uudelle asiakkaalle 30 päivän ilmainen kokeilu.");
            Console.WriteLine("   Tuotenimi\t\t\tTuotenumero\t\t\tHinta   ");

            for (int i = 0; i < tuote.tuotelista.Count; i++)
            {
                Tuote listallaOlevaTuote = tuote.tuotelista[i];
                var tuloste = $"{"   " + listallaOlevaTuote.Tuotenimi}\t\t\t{listallaOlevaTuote.Tuotenumero}\t\t\t\t{listallaOlevaTuote.Hinta + "   "}";
                Console.WriteLine(tuloste);
            }

            Console.WriteLine();
            Console.WriteLine("Paina enteriä palataksesi...");
            Console.ReadLine();

            Valikko valikko = new Valikko();
            Console.Clear();
            valikko.AlkuValikko();
        }

        // Ei tallenna vielä tietoja minnekkään
        public void TuoteValinta() // Kun asiakas kirjautunut sisään, pystyy valitsemaan tuotteen. Maksutapahtuman ensimmäinen vaihe, valitse tuote, ALE juttu puuttuu viel
        {
            Tuote tuote = new Tuote();
            tuote.TuoteLista();
            Console.WriteLine("===============================================================");
            Console.WriteLine("Alla lista tuotteista");
            Console.WriteLine("===============================================================");
            Console.WriteLine("* Uudelle asiakkaalle 30 päivän ilmainen kokeilu.\n");
            Console.WriteLine("   Tuotenimi\t\tTuotenumero\t\t\tHinta   ");

            for (int i = 0; i < tuote.tuotelista.Count; i++)
            {
                Tuote listallaOlevaTuote = tuote.tuotelista[i];
                var tuloste = $"{"   " + listallaOlevaTuote.Tuotenimi}\t\t{listallaOlevaTuote.Tuotenumero}\t\t\t\t{listallaOlevaTuote.Hinta + "   "}";
                Console.WriteLine(tuloste);
            }

            Console.WriteLine();
            Console.WriteLine("Valitse tuotenumero...");
            Console.WriteLine("<< 0: Lopetus >>");
            Console.WriteLine("<< 1: Basic >>");
            Console.WriteLine("<< 2: Pro >>");
            Console.WriteLine("<< 3: Enterprise >>");
            Console.WriteLine();

            Palvelu palvelu = new Palvelu();

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "0":
                    Console.WriteLine("\nSuljetaan...");
                    Environment.Exit(0);
                    break;
                case "1": // Basic tuote
                    Console.WriteLine("Valitsit tuotteen, Basic\n");
                    Console.WriteLine("Paina enteriä jatkaaksesi...");
                    Console.ReadLine();
                    Console.Clear();
                    palvelu.TuotePalvelut(40.0);
                    break;
                case "2": // Pro tuote
                    Console.WriteLine("Valitsit tuotteen, Pro\n");
                    Console.WriteLine("Paina enteriä jatkaaksesi...");
                    Console.ReadLine();
                    Console.Clear();
                    palvelu.TuotePalvelut(80.0);
                    break;
                case "3": // Enterprise tuote
                    Console.WriteLine("Valitsit tuotteen, Enterprise\n");
                    Console.WriteLine("Paina enteriä jatkaaksesi...");
                    Console.ReadLine();
                    Console.Clear();
                    palvelu.TuotePalvelut(120.0);
                    break;
                default:
                    Console.WriteLine("Valitse ylläolevista vaihtoehdoista");
                    break;
            }
        }
    }
}
