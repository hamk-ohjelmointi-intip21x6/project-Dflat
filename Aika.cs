using System;
using System.Collections.Generic;

namespace Dflat
{
    public class Aika
    {


        public DateTime OstosPäivä = DateTime.Now;
        public DateTime PalveluAika { get; set; }

        public string PalveluAikaTeksti { get; set; }

        public int PalveluAikaNumero { get; set; }

        public List<Aika> palveluAikaLista = new List<Aika>();

        public string ValittuPalveluAika;

        public void PalveluAikaLista()
        {
            Aika aika = new Aika();

            Aika Kuukausi = new Aika();
            Kuukausi.PalveluAika = OstosPäivä.AddMonths(1);
            Kuukausi.PalveluAikaTeksti = "1 kuukausi palveluaikaa";
            Kuukausi.PalveluAikaNumero = 1;

            Aika KuusiKuukautta = new Aika();
            KuusiKuukautta.PalveluAika = OstosPäivä.AddMonths(6);
            KuusiKuukautta.PalveluAikaTeksti = "6 kuukautta palveluaikaa";
            KuusiKuukautta.PalveluAikaNumero = 2;

            Aika KaksitoistaKuukautta = new Aika();
            KaksitoistaKuukautta.PalveluAika = OstosPäivä.AddYears(1);
            KaksitoistaKuukautta.PalveluAikaTeksti = "12 kuukautta palveluaikaa";
            KaksitoistaKuukautta.PalveluAikaNumero = 3;

            palveluAikaLista.Add(Kuukausi);
            palveluAikaLista.Add(KuusiKuukautta);
            palveluAikaLista.Add(KaksitoistaKuukautta);

        }
    }
}