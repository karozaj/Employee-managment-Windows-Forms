using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public decimal Pensja { get; set; }
        public string Stanowisko { get; set; }
        public string Umowa { get; set; }

        public Pracownik(string imie, string nazwisko, DateTime dataUrodzenia, decimal pensja, string stanowisko, string umowa)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Pensja = pensja;
            Stanowisko = stanowisko;
            Umowa = umowa;
        }

        public Pracownik()
        {

        }

        public override string ToString()
        {
            return $"{Nazwisko},{Imie},{DataUrodzenia.Date.ToString("dd/MM/yyyy")},{Pensja},{Stanowisko},{Umowa}";
        }

        public bool IsSameAs(Pracownik p)
        {
            if(p.Imie==this.Imie && p.Nazwisko==this.Nazwisko && p.DataUrodzenia==this.DataUrodzenia &&
                p.Pensja==this.Pensja && p.Stanowisko==this.Stanowisko && p.Umowa==this.Umowa)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
