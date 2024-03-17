using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    internal class LiczbyZespolone
    {
        public double KKRzeczywista { get; set; }
        public double KKUrojona { get; set; }

        public LiczbyZespolone(double rzeczywista, double urojona)
        {
            KKRzeczywista = rzeczywista;
            KKUrojona = urojona;
        }

        public override string ToString()
        {
            return $"{KKRzeczywista} + {KKUrojona}i";
        }

        public static LiczbyZespolone Dodaj(LiczbyZespolone a, LiczbyZespolone b)
        {
            return new LiczbyZespolone(a.KKRzeczywista + b.KKRzeczywista, a.KKUrojona + b.KKUrojona);
        }

        // Dodaj inne operacje (odejmowanie, mnożenie, dzielenie, itd)
        public static LiczbyZespolone Odejmij(LiczbyZespolone a, LiczbyZespolone b)
        {
            return new LiczbyZespolone(a.KKRzeczywista - b.KKRzeczywista, a.KKUrojona - b.KKUrojona);
        }
        public static LiczbyZespolone Pomnoz(LiczbyZespolone a, LiczbyZespolone b)
        {
            double rzeczywista = (a.KKRzeczywista * b.KKRzeczywista) - (a.KKUrojona * b.KKUrojona);
            double urojona = (a.KKRzeczywista * b.KKUrojona) + (a.KKUrojona * b.KKRzeczywista);

            return new LiczbyZespolone(rzeczywista, urojona);
        }
        public static LiczbyZespolone Podziel(LiczbyZespolone a, LiczbyZespolone b)
        {
            double mianownik = b.KKRzeczywista * b.KKRzeczywista + b.KKUrojona * b.KKUrojona;

            if (mianownik == 0)
            {
                throw new ArgumentException("Dzielenie przez zero jest niemożliwe.");
            }

            double rzeczywista = (a.KKRzeczywista * b.KKRzeczywista + a.KKUrojona * b.KKUrojona) / mianownik;
            double urojona = (a.KKUrojona * b.KKRzeczywista - a.KKRzeczywista * b.KKUrojona) / mianownik;

            return new LiczbyZespolone(rzeczywista, urojona);
        }
        public static LiczbyZespolone Negacja(LiczbyZespolone a)
        {
            return new LiczbyZespolone(-a.KKRzeczywista, -a.KKUrojona);
        }
        public static LiczbyZespolone LiczbaE(LiczbyZespolone a, LiczbyZespolone b, LiczbyZespolone e)
        {
            LiczbyZespolone sumaBE = Dodaj(a, Pomnoz(b, e));
            LiczbyZespolone roznicaEA = Odejmij(Pomnoz(e, a), Pomnoz(a, e));
            return Odejmij(sumaBE, roznicaEA);
        }
        public static LiczbyZespolone Sprezenie(LiczbyZespolone a)
        {
            // Oblicz sprzężenie liczby zespolonej
            return new LiczbyZespolone(a.KKRzeczywista, -a.KKUrojona);
        }
        public static LiczbyZespolone NegacjaA(LiczbyZespolone a)
        {
            // Oblicz negację liczby zespolonej
            return new LiczbyZespolone(-a.KKRzeczywista, -a.KKUrojona);
        }
        public static bool operator !=(LiczbyZespolone a, LiczbyZespolone b)
        {
            return !(a == b);
        }

        public static bool operator ==(LiczbyZespolone a, LiczbyZespolone b)
        {
            return a.KKRzeczywista == b.KKRzeczywista && a.KKUrojona == b.KKUrojona;
        }
        public double reZ(double a, double b)
        {
            return a; // Część rzeczywista liczby zespolonej
        }
        public static LiczbyZespolone SprzezenieA(LiczbyZespolone liczba)
        {
            return new LiczbyZespolone(liczba.KKRzeczywista, -liczba.KKUrojona);
        }
        public static double module(LiczbyZespolone z)
        {
            return Math.Sqrt(z.KKRzeczywista * z.KKRzeczywista + z.KKUrojona * z.KKUrojona);
        }
        public static LiczbyZespolone operator - (LiczbyZespolone z)
        {
            return new LiczbyZespolone ( - z.KKRzeczywista, z.KKUrojona);
        }
    }
}

