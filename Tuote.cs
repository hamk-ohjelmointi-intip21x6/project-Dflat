using System;
using System.Collections.Generic;

namespace Dflat
{
    public class Tuote
    {
        public string Tuotenimi { get; set; }
        public int Tuotenumero { get; set; }
        public double Hinta { get; set; }

        public string ValittuTuote;

        public List<Tuote> tuotelista = new List<Tuote>();

        public void TuoteLista() // Pitäis lisää tuotteet jossai kohtaa johonki tekstitiedostoon
        {

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
}