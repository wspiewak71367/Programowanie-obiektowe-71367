using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string pesel;

        public void SetFirstName(string imie) => this.imie = imie;
        public void SetLastName(string nazwisko) => this.nazwisko = nazwisko;
        public void SetPesel(string pesel) => this.pesel = pesel;

        public int GetAge()
        {
            if (string.IsNullOrEmpty(pesel) || pesel.Length < 11) return 0;

            int rok = int.Parse(pesel.Substring(0, 2));
            int miesiac = int.Parse(pesel.Substring(2, 2));

            int pelnyRok = (miesiac > 20) ? 2000 + rok : 1900 + rok;
            return DateTime.Now.Year - pelnyRok;
        }

        public string GetGender()
        {
            int cyfraPlci = int.Parse(pesel[3].ToString());
            return (cyfraPlci % 2 == 0) ? "Kobieta" : "Mężczyzna";
        }

        public abstract string GetEducationInfo();
        public virtual string GetFullName() => $"{imie} {nazwisko}";
        public abstract bool CanGoAloneToHome();

    }
}
