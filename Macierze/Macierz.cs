using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class Macierz
    {
        


        private float[,] macierz;
        



        //deklaracja konstruktora który utworzy egzemplarz macierzy.*/
        public Macierz(ushort LiczbaWierszy, ushort LiczbaKolumn)
        {
           macierz = new float[LiczbaWierszy,LiczbaKolumn]; 
        }
        public float this[ushort NrWiersza, ushort NrKolumny]
        {
            set
            {
                if (( NrWiersza >= 0 ) && (NrWiersza < macierz.GetLength(0)) && (NrKolumny < macierz.GetLength(1))) {
                    macierz[NrWiersza,NrKolumny] = value;
                }
                else
                    throw new IndexOutOfRangeException("Co najmniej jeden z indeksów wykracza poza dozowolony zakres");
                    
            }
            get
            {
                if ((NrWiersza >= 0) && (NrWiersza < macierz.GetLength(0)) && (NrKolumny < macierz.GetLength(1)))
                    return macierz[NrWiersza,NrKolumny];
                else
                    throw new IndexOutOfRangeException("Co najmniej jeden z indeksów wykracza poza dozowolony zakres");

            }
            //deklaracja możliwości umożliwiających wykonywanie działań rachunku macierzowego*/
            
        }
        public ushort LiczbaWiwerszy
        {
            //deklarujemy akcesora get dla odczytania liczby wierszy macierzy*/
            get
            {
                return (ushort) macierz.GetLength(0);
            }
        }
        public ushort LiczbaKolumn
        {
            //deklarujemy akcesora get dla odczytania liczby wierszy macierzy*/
            get
            {
                return (ushort)macierz.GetLength(1);
            }
        }
        // przeciązanie operatorów*/
        // "+"*/
        public static Macierz operator +(Macierz a, Macierz b)
        {    // sprawdzenie wawrunku wykonalnosci operacji dodawania*/
            if ((a.LiczbaWiwerszy != b.LiczbaWiwerszy) || (a.LiczbaKolumn != b.LiczbaKolumn))
                //sygnalizacja błędu*/
            {
                throw new ArgumentException("Liczba wierszy lub liczba kolumn w obu macierzach nie jest tożsama");
            }
            // wykonujemy dodawanie Macierzy*/
            // deklaracja macierzy wynikowej*/

            Macierz C = new Macierz(a.LiczbaWiwerszy,a.LiczbaKolumn);
            for (ushort i = 0; i <a.LiczbaWiwerszy; i++) 
                for ( ushort j = 0; j <a.LiczbaKolumn; j++)
                    C.macierz[i,j] = a.macierz[i,j] + b.macierz[i,j];
            return C;

        }
        public static Macierz operator -(Macierz a, Macierz b)
        {    // sprawdzenie wawrunku wykonalnosci operacji dodawania*/
            if ((a.LiczbaWiwerszy != b.LiczbaWiwerszy) || (a.LiczbaKolumn != b.LiczbaKolumn))
            //sygnalizacja błędu*/
            {
                throw new ArgumentException("Liczba wierszy lub liczba kolumn w obu macierzach nie jest tożsama");
            }
            // wykonujemy dodawanie Macierzy*/
            // deklaracja macierzy wynikowej*/

            Macierz C = new Macierz(a.LiczbaWiwerszy, a.LiczbaKolumn);
            for (ushort i = 0; i < a.LiczbaWiwerszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                    C.macierz[i, j] = a.macierz[i, j] - b.macierz[i, j];
            return C;

        }
        // przeciążenie operatora '*'*/

        public static Macierz operator *(Macierz a, Macierz b)
        {
            //sprawdzenie warunku wykonalnosci operacji mnożenia

            if ((a.LiczbaKolumn != b.LiczbaWiwerszy))
                throw new ArgumentException("Operacja nie może zostać wykonana ze względu na niezgodne wymiary macierzy");
            //utworzenie macierzy wynikowej C

            Macierz C = new Macierz(a.LiczbaWiwerszy, b.LiczbaKolumn);
            // obliczanie iloczynu macierzy A i B

            for ( ushort i = 0; i < a.LiczbaWiwerszy; i++)
                for ( ushort j = 0; j <b.LiczbaKolumn; j++)
                {// ustawienie warunku brzegowego
                    C.macierz[i, j] = 0.0F;
                    for (ushort k = 0; k< b.LiczbaKolumn; k++)
                        C.macierz[i,j] = a.macierz[i,k] * b.macierz[k,j];

                }
            return C;
        }
         // przeciązenie operatora ! dla wyznaczenia macierzy transoponowanej

        public static Macierz operator !(Macierz a)
        {
            //deklaracja i utworzenie egzemplarza macierzy wynikowej : transponowanej macierzy a

            Macierz C = new Macierz(a.LiczbaKolumn, a.LiczbaWiwerszy);
            for (ushort i = 0; i < a.LiczbaWiwerszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                    C.macierz[i, j] = a.macierz[j, i];
            return C;
        }
        
    }
}
