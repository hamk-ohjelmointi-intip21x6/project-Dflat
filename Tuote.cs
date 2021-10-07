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
            Basic.Tuotenimi = "Basic";
            Basic.Hinta = 40.0;

            Tuote Pro = new Tuote();
            Pro.Tuotenumero = 2;
            Pro.Tuotenimi = "Pro";
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


    public class Aika
    {
        
        public DateTime OstosPäivä = DateTime.Now;
        public DateTime PalveluAika { get; set; }

        public string PalveluAikaTeksti { get; set; }

        public List<Aika> palveluAikaLista = new List<Aika>();

        public void PalveluAikaLista()
        {
            Aika aika = new Aika();

            Aika Kuukausi = new Aika();
            Kuukausi.PalveluAika = OstosPäivä.AddMonths(1);
            Kuukausi.PalveluAikaTeksti = "1 Kuukausi palveluaikaa";

            Aika KuusiKuukautta = new Aika();
            KuusiKuukautta.PalveluAika = OstosPäivä.AddMonths(6);
            KuusiKuukautta.PalveluAikaTeksti = "6 Kuukautta palveluaikaa";

            Aika KaksitoistaKuukautta = new Aika();
            KaksitoistaKuukautta.PalveluAika = OstosPäivä.AddMonths(12);
            KaksitoistaKuukautta.PalveluAikaTeksti = "12 Kuukautta palveluaikaa";

            palveluAikaLista.Add(Kuukausi);
            palveluAikaLista.Add(KuusiKuukautta);
            palveluAikaLista.Add(KaksitoistaKuukautta);
        }
        
            
        
    }

    class Tulostaja
    {
        public void TulostaTuotteet() // Kun asiakkaalla ei ole käyttäjää, lista tuotteista, ei voi valita mitään, pitää varmaa joskus järjestää tuloste hienommi. Tuotteista pitäis lisää enemmä infoo myös
        {
            Tuote tuote = new Tuote();
            tuote.TuoteLista();

            Aika aika = new Aika();
            aika.PalveluAikaLista();


            Console.WriteLine("\nTuotenimi\t\tTuotenumero\t\t\tHinta");

            for (int i = 0; i < tuote.tuotelista.Count; i++)
            {
                Tuote listallaOlevaTuote = tuote.tuotelista[i];
                var tuloste = $"{listallaOlevaTuote.Tuotenimi}\t\t\t{listallaOlevaTuote.Tuotenumero}\t\t\t\t{listallaOlevaTuote.Hinta}";
                Console.WriteLine(tuloste);
            }

            Console.WriteLine();
            Console.WriteLine("Paina enteriä palataksesi...");
            Console.ReadLine();

            Valikko valikko = new Valikko();
            valikko.AlkuValikko();
        }

        public void TulostaTuoteValinta() // Kun asiakas kirjautunut sisään, pystyy valitsemaan tuotteen
        {

        }
    }
}
