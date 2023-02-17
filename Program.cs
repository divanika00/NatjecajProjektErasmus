using System;

namespace NatjecajProjektErasmus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadatak 1
            //Napišite program za unos i čitanje imena i prezimena te unosa bodova triju predmeta jednog učenika sa natjecanja.
            //Izračunajte ukupno, postotak i rezultat bodova te ovisno 
            //ovisno o rezultatima, učenika pošaljite u jednu od zemalja na ERASMUS projekt 

            //Predmeti: Fizike, Kemija, Osnove programiranja
            //Bodovi su u rasponu od 0-100 (napisati korisniku rasponu)
            // >= 60 Spanjolska
            // <60 i >48 Engleska
            // <48 >=36 Nizozemka
            // Italija
            //Ispis ime i prezime ucenika
            //Bodovi iz pojedinih predmeta
            //Ukupan broj bodova, prosjek, koja destinacija mu je dodjeljena

            Console.WriteLine();
            Console.WriteLine("Natječaj za projekt ERASMUS - studij u drugim državama:");
            Console.WriteLine("=============================================================");
            Console.WriteLine();

            double osnoveProgramiranja, fizika, kemija, ukupno, prosjek;
            string ime, prezime, rezultatNatjecaja;

            Console.WriteLine("Ime studenta:");
            ime = Console.ReadLine();
            Console.WriteLine("Prezime studenta:");
            prezime = Console.ReadLine();

            Console.WriteLine("Unesite ostvarene bodove iz Fizike (0-100): ");
            fizika = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite ostvarene bodove iz Kemije (0-100): ");
            kemija = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite ostvarene bodove iz Osnova programiranja (0-100): ");
            osnoveProgramiranja = double.Parse(Console.ReadLine());

            ukupno = ukupnoBodova(osnoveProgramiranja, fizika, kemija);
            prosjek = prosjekBodova(ukupno);
            rezultatNatjecaja = dodjelaPutovanjaStudentu(prosjek);
            ispisInformacijaONatječaju(osnoveProgramiranja, fizika, kemija, ukupno, prosjek, ime, prezime, rezultatNatjecaja);

            Console.ReadKey();
            #endregion
        }
        private static void ispisInformacijaONatječaju(double osnoveProgramiranja, double fizika, double kemija, double ukupno, double prosjek, string ime, string prezime, string rezultatNatjecaja)
        {
            Console.Write("\nIme i prezime studenta: {0} {1}\n", ime, prezime);
            Console.Write("Bodovi iz Fizike: {0}\nBodovi iz Kemije: {1}\nBodovi iz Osnova programiranja: {2}\n", fizika, kemija, osnoveProgramiranja);
            Console.Write("Ukupno bodova = {0}\nOstvareni postotak = {1}\nStudentu, destinacija za projekt ERASMUS je {2}\n", ukupno, prosjek, rezultatNatjecaja);
        }

        private static string dodjelaPutovanjaStudentu(double prosjek)
        {
            string rezultatNatjecaja;
            if (prosjek >= 60)
            {
                rezultatNatjecaja = "Španjolska";
            }

            else if (prosjek < 60 && prosjek >= 48)
            {
                rezultatNatjecaja = "Engleska";
            }

            else if (prosjek < 48 && prosjek >= 36)
            {
                rezultatNatjecaja = "Nizozemska";
            }
            else
            {
                rezultatNatjecaja = "Italija";
            }

            return rezultatNatjecaja;
        }

        private static double prosjekBodova(double ukupno)
        {
            return ukupno / 3.0;
        }

        private static double ukupnoBodova(double osnoveProgramiranja, double fizika, double kemija)
        {
            return fizika + kemija + osnoveProgramiranja;
        }
    }
}
