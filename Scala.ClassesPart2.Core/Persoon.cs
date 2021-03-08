using System;
using System.Collections.Generic;
using System.Text;

namespace Scala.ClassesPart2.Core
{
    public class Persoon
    {
        private string naam;
        private string voornaam;
        private DateTime geboortedatum;

        public string Naam
        {
            get { return naam; }
            set
            {
                value = value.Trim();
                if (value.Length == 0)
                {
                    throw new Exception("De naam is verplicht !");
                }
                else
                {
                    naam = value;
                }
            }
        }
        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                value = value.Trim();
                if (value.Length == 0)
                {
                    throw new Exception("De voornaam is verplicht !");
                }
                else
                {
                    voornaam = value;
                }
            }
        }

        public DateTime Geboortedatum
        {
            get { return geboortedatum; }
            set
            {
                DateTime minimumDatum = new DateTime(1900, 1, 1);
                if (value < minimumDatum)
                {
                    throw new Exception("Oudst mogelijke datum is 1/1/1900 !");
                }
                else if (value > DateTime.Now)
                {
                    throw new Exception("Geboortedatum kan niet in toekomst liggen !");
                }
                else
                {
                    geboortedatum = value;
                }
            }
        }
        public bool IsMan { get; set; }

        public string Leeftijd
        {
            get
            {
                DateTime vandaag = DateTime.Now;
                TimeSpan verschil = vandaag - Geboortedatum;
                DateTime leeftijd = DateTime.MinValue + verschil;
                return $"{leeftijd.Year-1} jaar, {leeftijd.Month-1} maanden en {leeftijd.Day-1} dagen";
            }
        }
        

        public Persoon()
        {

        }
        public Persoon(string naam, string voornaam, DateTime geboortedatum, bool isman)
        {
            Naam = naam;
            Voornaam = voornaam;
            Geboortedatum = geboortedatum;
            IsMan = isman;
        }

        public override string ToString()
        {
            return $"{Naam} {Voornaam}";
        }
    }
}
