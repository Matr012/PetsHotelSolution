using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsHotel
{
    public class Pet
    {
        public Pet() { }
        public Pet(string nev, string faj, string fajta, string nem, string szin, DateTime szulDatum, int suly, string etel, string jatek)
        {
            Nev = nev;
            Faj = faj;
            Fajta = fajta;
            Nem = nem;
            Szin = szin;
            SzulDatum = szulDatum;
            Suly = suly;
            Etel = etel;
            Jatek = jatek;
        }
        /// <summary>
        /// A bemeneti állomány egy sorát feldolgozó konstruktor.
        /// Név;Faj;Fajta;Nem;Szín;SzületésiDátum;Súly;KedvencÉtel;KedvencJáték az adatok sorrendje.
        /// </summary>
        /// <param name="sor">A bemeneti állomány egy sora, ami adatokat tartalmaz.</param>
        public Pet(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Faj = adatok[1];
            Fajta = adatok[2];
            Nem = adatok[3];
            Szin = adatok[4];
            SzulDatum = DateTime.Parse(adatok[5]);
            Suly = int.Parse(adatok[6]);
            Etel = adatok[7];
            Jatek = adatok[8];
        }

        //Név;Faj;Fajta;Nem;Szín;SzületésiDátum;Súly;KedvencÉtel;KedvencJáték
        public string Nev { get; set; }
        public string Faj { get; set; }
        public string Fajta { get; set; }
        public string Nem { get; set; }
        public string Szin { get; set; }
        public DateTime SzulDatum { get; set; }
        public int Suly { get; set; }
        public string? Etel { get; set; }
        public string? Jatek { get; set; }

        /// <summary>
        /// A házikedvenc életkora betöltött születésnap alapján.
        /// </summary>
        /// <returns>Az életkor egész években.</returns>
        public int Kor()
        {
            int evek = 0;
            if (SzulDatum.Month < DateTime.Today.Month)
                evek = DateTime.Today.Year - SzulDatum.Year;
            else if(SzulDatum.Month > DateTime.Today.Month)
                evek = DateTime.Today.Year - SzulDatum.Year - 1;
            else
            {
                if(SzulDatum.Day <= DateTime.Today.Day)
                    evek = DateTime.Today.Year - SzulDatum.Year;
                else
                    evek = DateTime.Today.Year - SzulDatum.Year - 1;
            }
            return evek;
        }

    }
}
