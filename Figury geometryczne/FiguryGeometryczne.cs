using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ProjektNr2_Kacper_Krajewski_66460
{
    public class FiguryGeometryczne
    {
        public class Punkt 
        {

            //deklaracje atrybutów niezbędnych dla wykreślenia punktu 
            protected int X, Y;
            public Color kolor;
            protected float grubośćPunktu;
            public int promieńPunktu = 5;
            public int średnicaPunktu;

            //deklaracje atrybutów ważnych dla implementacji funkcjonalności udostępnianych
            //na formluarzu
            protected DashStyle stylLinii;
            public int grubośćLinii;
            protected Color kolorTła;
            public bool widoczny { get; protected set; }
            // deklaracje konstruktora 

            public enum FiguraGeometryczna : byte
            { Punkt, Linia, Elipsa, Prostokąt, Okrąg, Kwadrat};
            private FiguraGeometryczna figura;
            public FiguraGeometryczna rodzajFigury {  get { return figura; } private set { figura = value; } }
            public Punkt(int x,int y, int c, int z)
            {

            }
            public Punkt()
            {
                
            }
            public Punkt(int x, int y)
            {
                //ustalenie wartosci atrybutów : X i Y 
                X = x;
                Y = y;

                //ustawienie wartości domyślnych dla pozostałych atrybutów 
                kolor = Color.Black;
                grubośćPunktu = 3.0F;
                stylLinii = DashStyle.Solid;
                kolorTła = Color.White;
                widoczny = false;
                średnicaPunktu = 2 * promieńPunktu;
            }
            public Punkt(int x, int y, Color kolorPunktu) : this(x, y)
            {
                kolor = kolorPunktu;

            }

            public virtual void Wykreśl(Graphics rysownica)
            {
                SolidBrush pędzel = new SolidBrush(kolor);
                rysownica.FillEllipse(pędzel, X - promieńPunktu, Y - promieńPunktu, średnicaPunktu, średnicaPunktu);
                widoczny = true;
                pędzel.Dispose();
            }
            public virtual void Nakreśl(Graphics rysownica)
            {
                SolidBrush pędzel = new SolidBrush(kolor);
                rysownica.FillEllipse(pędzel, X - promieńPunktu, Y - promieńPunktu, średnicaPunktu, średnicaPunktu);
                widoczny = true;
                pędzel.Dispose();
            }
            public virtual void Wymaż(Control kontrolka, Graphics rysownica)
            {
                if (this.widoczny)
                {
                    SolidBrush pędzel = new SolidBrush(kontrolka.BackColor);
                    rysownica.FillEllipse(pędzel, X - promieńPunktu, Y - promieńPunktu, średnicaPunktu, średnicaPunktu);
                    this.widoczny = false;
                    pędzel.Dispose();
                }
            }

            public virtual void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
            {
                UstawXY(nowaLokalizacja);
                Wykreśl(rysownica);

            }
            public virtual void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, int x, int y)
            {
                UstawXY(x,y);
                Wykreśl(rysownica);

            }
           
            public virtual void UstawXY(int X, int Y)
            {
                this.X = X; this.Y = Y;
            }
            public virtual void UstawXY(Point lokalizacja)
            {
                X = lokalizacja.X; Y = lokalizacja.Y;
            }
            public virtual void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
            {
                this.kolor = kolorLinii;
                this.stylLinii = stylLinii;
                this.grubośćLinii = grubośćLinii;
            }
            public virtual void UstalAtrybutyGraficzne(Color kolorWypełnienia)
            {
                this.kolorTła = kolorWypełnienia;
            }
            protected virtual void UstalStylLinii(DashStyle stylLinii)
            {
                this.stylLinii = stylLinii;
            }


            public class Linia : Punkt
            {
               public int Xk, Yk;
               
             
                public Linia(int x, int y, int Xk, int Yk, Color kolorLinii, DashStyle stylLinii, int grubośćLinii) : base ( x,y)
                {
                    this.X = X;
                    this.Y = Y;
                    this.Xk = Xk;
                    this.Yk = Yk;
                    this.kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                    
                    
                }
                public Linia ( int x, int y , int Xk, int Yk) : base (x, y)
                {
                    this.Xk = Xk;
                    this.Yk = Yk;
                }
                public Linia()
                {
                    
                }
                public override void Wykreśl(Graphics rysownica)
                {
                    using (Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawLine(pióro, X, Y,Xk,Yk);
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    }
                }
               
                public override void Wymaż(Control kontrolka, Graphics rysownica)
                {//sprawdzenie czy Elipsa jest aktualnie wykroślona
                    if (widoczny)
                    {//utworzenie Pióra w kolorze tła kontrolki
                        using (Pen pióro = new Pen(kontrolka.BackColor, grubośćLinii))
                        {
                            //ustawienie stylu Linii
                            pióro.DashStyle = stylLinii;
                            rysownica.DrawLine(pióro, X, Y, Xk,Yk);
                            //ustawienie nowego atrybutu widoczności
                            widoczny = false;
                        }
                    }
                }
                public override void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
                {
                    UstawXY(nowaLokalizacja);
                    Wykreśl(rysownica);

                }
                public override void UstawXY(int X, int Y)
                {
                    this.X = X; this.Y = Y;
                }
                public override void UstawXY(Point lokalizacja)
                {
                    X = lokalizacja.X; Y = lokalizacja.Y;
                }
                public override void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
                {
                    this.kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                }
                public override void UstalAtrybutyGraficzne(Color kolorWypełnienia)
                {
                    this.kolorTła = kolorWypełnienia;
                }
                protected override void UstalStylLinii(DashStyle stylLinii)
                {
                    this.stylLinii = stylLinii;
                }



            }
            public class LiniaPodwójna : Linia
            {
                public LiniaPodwójna()
                {
                    
                }
                public LiniaPodwójna(int x, int y, int Xk, int Yk) : base (x, y,Xk,Yk)
                {

                    
                }
                public override void Wykreśl(Graphics rysownica)
                {
                    using (Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawLine(pióro, X, Y, Xk, Yk);
                        s
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    }
                }
            }
            public class Elipsa : Punkt
            {
                protected int OśDuza, OśMała;

                public Elipsa(int x, int y, int OśDuza, int OśMała,Color KolorLinii,DashStyle StylLinii, int GrubośćLinii)
                    : base(x,y, KolorLinii)
                {
                    this.OśDuza = OśDuza;
                    this.OśMała = OśMała;
                    this.stylLinii = StylLinii;
                    this.grubośćLinii = GrubośćLinii;
                    this.kolor = KolorLinii;
                }
                public Elipsa(int x, int y, int OsDuza, int OsMala) : base(x, y)
                {
                    this.OśDuza = OsDuza;
                    this.OśMała = OsMala;
                }
                //nadpisanie metod wirtualnych 

                public override void Wykreśl(Graphics rysownica)
                {
                    using( Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawEllipse(pióro, X, Y, OśDuza, OśMała);
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    } 
                }
                public override void Wymaż(Control kontrolka, Graphics rysownica)
                {//sprawdzenie czy Elipsa jest aktualnie wykroślona
                    if ( widoczny ) 
                    {//utworzenie Pióra w kolorze tła kontrolki
                        using (Pen pióro = new Pen(kontrolka.BackColor, grubośćLinii))
                        {
                            //ustawienie stylu Linii
                            pióro.DashStyle = stylLinii;
                            rysownica.DrawEllipse(pióro, X, Y, OśDuza, OśMała);
                            //ustawienie nowego atrybutu widoczności
                            widoczny= false;
                        }
                    }
                }
                public override void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
                {
                    UstawXY(nowaLokalizacja);
                    Wykreśl(rysownica);

                }
               
                public override void UstawXY(int X, int Y)
                {
                    this.X = X; this.Y = Y;
                }
                public override void UstawXY(Point lokalizacja)
                {
                    X = lokalizacja.X; Y = lokalizacja.Y;
                }
                public override void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
                {
                    this.kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                }
                public override void UstalAtrybutyGraficzne(Color kolorWypełnienia)
                {
                    this.kolorTła = kolorWypełnienia;
                }
                protected override void UstalStylLinii(DashStyle stylLinii)
                {
                    this.stylLinii = stylLinii;
                }

            }//do Class Elipsa: Punkt
            public class Prostokąt : Punkt
            {
                protected int szerokośćProstokąta, wysokośćProstokąta;
                
                public Prostokąt(int x, int y, Color KolorLinii, DashStyle StylLinii, int GrubośćLinii,
                    int szerokośćProstokąta, int wysokośćProstokąta) : base(x,y, KolorLinii)
                {
                    this.kolor = KolorLinii;
                    this.stylLinii = StylLinii;
                    this.grubośćLinii = GrubośćLinii;
                    this.szerokośćProstokąta = szerokośćProstokąta;
                    this.wysokośćProstokąta = wysokośćProstokąta;
                }

                public Prostokąt(int x, int y, int Xk, int Yk) : base ( x,y)
                {
this.szerokośćProstokąta = Xk;
                    this.wysokośćProstokąta = Yk;
                }
                public Prostokąt(int x, int y, int dł) : base ( x,y)
                {
                    this.szerokośćProstokąta = dł;
                }



                public Prostokąt(int x, int y, Color KolorLinii, DashStyle StylLinii,int GrubośćLinii) : base (x,y,KolorLinii) 
                {
                    this.kolor = KolorLinii;
                    this.stylLinii = StylLinii;
                    this.grubośćLinii = GrubośćLinii;

                }
                public override void Wykreśl(Graphics rysownica)
                {
                    using (Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawRectangle(pióro, X, Y, wysokośćProstokąta,szerokośćProstokąta);
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    }
                }
                public override void Wymaż(Control kontrolka, Graphics rysownica)
                {//sprawdzenie czy Elipsa jest aktualnie wykroślona
                    if (widoczny)
                    {//utworzenie Pióra w kolorze tła kontrolki
                        using (Pen pióro = new Pen(kontrolka.BackColor, grubośćLinii))
                        {
                            //ustawienie stylu Linii
                            pióro.DashStyle = stylLinii;
                            rysownica.DrawRectangle(pióro, X, Y, wysokośćProstokąta, szerokośćProstokąta);
                            //ustawienie nowego atrybutu widoczności
                            widoczny = false;
                        }
                    }
                }
                public override void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
                {
                    UstawXY(nowaLokalizacja);
                    Wykreśl(rysownica);

                }
                public override void UstawXY(int X, int Y)
                {
                    this.X = X; this.Y = Y;
                }
                public override void UstawXY(Point lokalizacja)
                {
                    X = lokalizacja.X; Y = lokalizacja.Y;
                }
                public override void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
                {
                    kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                }
                public override void UstalAtrybutyGraficzne(Color kolorWypełnienia)
                {
                    this.kolorTła = kolorWypełnienia;
                }
                protected override void UstalStylLinii(DashStyle stylLinii)
                {
                    this.stylLinii = stylLinii;
                }


            }
            public class Okrąg : Elipsa
            {
                int Xk, Yk;
                protected int promień;
                public Okrąg(int x, int y, int OśDuza, int OśMała, Color KolorLinii, DashStyle StylLinii, int GrubośćLinii, int promień)
                    : base(x,y,OśDuza,OśMała,KolorLinii,StylLinii,GrubośćLinii) 
                {
                    this.Xk = Xk;
                    this.Yk = Yk;
                    this.OśDuza = OśDuza;
                    this.OśMała = OśMała;
                    this.stylLinii = StylLinii;
                    this.grubośćLinii = GrubośćLinii;
                    this.promień = promień;
                }
                public Okrąg(int x, int y , int promień) : base (x,y,2*promień,2*promień)
                {
                    this.promień = promień;
                    
                }
                public override void Wykreśl(Graphics rysownica)
                {
                    using (Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawEllipse(pióro, X, Y, promień, promień);
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    }
                }
                public override void Wymaż(Control kontrolka, Graphics rysownica)
                {//sprawdzenie czy Elipsa jest aktualnie wykroślona
                    if (widoczny)
                    {//utworzenie Pióra w kolorze tła kontrolki
                        using (Pen pióro = new Pen(kontrolka.BackColor, grubośćLinii))
                        {
                            //ustawienie stylu Linii
                            pióro.DashStyle = stylLinii;
                            rysownica.DrawEllipse(pióro, X, Y, promień,promień);
                            //ustawienie nowego atrybutu widoczności
                            widoczny = false;
                        }
                    }
                }
                public override void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
                {
                    UstawXY(nowaLokalizacja);
                    Wykreśl(rysownica);

                }
                public override void UstawXY(int X, int Y)
                {
                    this.X = X; this.Y = Y;
                }
                public override void UstawXY(Point lokalizacja)
                {
                    X = lokalizacja.X; Y = lokalizacja.Y;
                }
                public override void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
                {
                    kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                }
                public override void UstalAtrybutyGraficzne(Color kolorWypełnienia)
                {
                    this.kolorTła = kolorWypełnienia;
                }
                protected override void UstalStylLinii(DashStyle stylLinii)
                {
                    this.stylLinii = stylLinii;
                }


            }
            public class Kwadrat : Prostokąt
            {
                int długoścBoku;
                public Kwadrat(int x, int y,Color kolorLinii,DashStyle stylLinii, int grubośćLinii,int długośćBoku) 
                    : base ( x,  y,  kolorLinii, stylLinii, grubośćLinii )
                    
                {
                    this.kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                    this.długoścBoku = długośćBoku;

                }
                public Kwadrat(int x, int y, int dł) : base (x,y,dł) 
                {
                    this.długoścBoku = dł; 
                   
                }
                public override void Wykreśl(Graphics rysownica)
                {
                    using (Pen pióro = new Pen(kolor, grubośćLinii))
                    {
                        //ustawianie styli Linii
                        pióro.DashStyle = stylLinii;
                        // wykreślenie Elipsy
                        rysownica.DrawRectangle(pióro, X, Y, długoścBoku, długoścBoku);
                        //ustawienie atrybutu widoczności
                        widoczny = true;
                        //tutaj zwolnienie pióra
                    }
                }
                public override void Wymaż(Control kontrolka, Graphics rysownica)
                {//sprawdzenie czy Elipsa jest aktualnie wykroślona
                    if (widoczny)
                    {//utworzenie Pióra w kolorze tła kontrolki
                        using (Pen pióro = new Pen(kontrolka.BackColor, grubośćLinii))
                        {
                            //ustawienie stylu Linii
                            pióro.DashStyle = stylLinii;
                            rysownica.DrawRectangle(pióro, X, Y, długoścBoku, długoścBoku);
                            //ustawienie nowego atrybutu widoczności
                            widoczny = false;
                        }
                    }
                }
                public override void PrzesuńDoNowegoXY(Control kontrolka, Graphics rysownica, Point nowaLokalizacja)
                {
                    UstawXY(nowaLokalizacja);
                    Wykreśl(rysownica);

                }
                public override void UstawXY(int X, int Y)
                {
                    this.X = X; this.Y = Y;
                }
                public override void UstawXY(Point lokalizacja)
                {
                    X = lokalizacja.X; Y = lokalizacja.Y;
                }
                public override void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle stylLinii, int grubośćLinii)
                {
                    kolor = kolorLinii;
                    this.stylLinii = stylLinii;
                    this.grubośćLinii = grubośćLinii;
                }
                public override void UstalAtrybutyGraficzne(Color kolorWypełnienia)
                {
                    this.kolorTła = kolorWypełnienia;
                }
                protected override void UstalStylLinii(DashStyle stylLinii)
                {
                    this.stylLinii = stylLinii;
                }
            }

        }
    }
}
