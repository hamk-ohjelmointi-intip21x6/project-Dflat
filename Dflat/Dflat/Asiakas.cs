using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dflat
{
    class Asiakas
    {
        public void Kirjaudu() //Testissä, Tekstitiedosto juttu pitäis lisää
        {
            //Testiarvoja
            string etunimi, sukunimi;
            string id;

            Console.WriteLine("Anna Etunimi: ");
            etunimi = Console.ReadLine();

            Console.WriteLine("Anna Sukunimi: ");
            sukunimi = Console.ReadLine();

            Console.WriteLine("Anna ID: ");
            id = Console.ReadLine();

            Valikko valikko = new Valikko();
            Console.Clear();
            valikko.PääValikko(ETarkistaja(), STarkistaja());
        }

        public void Rekisteröidy() //Testissä, Tekstitiedosto juttu pitäis lisää
        {
            string etunimi, sukunimi, id;

            Console.WriteLine("Anna Etunimi: ");
            etunimi = Console.ReadLine();

            Console.WriteLine("Anna Sukunimi: ");
            sukunimi = Console.ReadLine();

            Console.WriteLine("Anna ID: ");
            id = Console.ReadLine();
        }

        public string TestiEtuNimi = "Testi"; /////
        public string TestiSukuNimi = "Tyyppi"; /////

        public string ETarkistaja()///////////////// Hakee asiakkaan tiedot, johon varastoidaan nimet ja ehkä jotai muuta tietoo.
        {
            string testietuNimi = TestiEtuNimi;
            return testietuNimi;
        }
        public string STarkistaja()
        {
            string testisukuNimi = TestiSukuNimi;
            return testisukuNimi;
        }
    }
}
