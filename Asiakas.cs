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
            string etunimi = "admin";
            string sukunimi = "admin";
            string id = "id";
            string vastaus = "0";

            while (vastaus != etunimi & vastaus != sukunimi & vastaus != id)
            {
                Console.WriteLine("Anna Etunimi: ");
                etunimi = Console.ReadLine();

                Console.WriteLine("Anna Sukunimi: ");
                sukunimi = Console.ReadLine();

                Console.WriteLine("Anna ID: ");
                id = Console.ReadLine();
            }

            Valikko valikko = new Valikko();
            valikko.PääValikko(etunimi, sukunimi);
        }

        public void Rekisteröidy() //Testissä, Tekstitiedosto juttu pitäis lisää
        {
            User._id = 100;
            User u1 = new User();

            Console.WriteLine("Anna etunimesi: ");
            u1.etunimi = Console.ReadLine();

            Console.WriteLine("Anna sukunimesi: ");
            u1.sukunimi = Console.ReadLine();

            PersonList personList = new PersonList();
            personList.SaveUser();

            
        }
    }
}