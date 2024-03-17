using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Figury_geometryczne.FiguryGeometryczne;
using static Figury_geometryczne.FiguryGeometryczne.Punkt;


namespace Figury_geometryczne
{
    public partial class KreślenieFigur : Form
    {

        Graphics Rysownica;
        Pen Pióro = new Pen(Color.Black, 1.0F);
        SolidBrush Pędzel = new SolidBrush(Color.Blue);
        Punkt[] TFG;
        ushort IndexTFG;
        const ushort kkMargines = 10;
        const ushort kkMarginesFormularza = 20;
        ErrorProvider errorProvider1 = new ErrorProvider();
        bool widoczny;
        private Control kontrolka;
        private Point nowaLokalizacja;

        public KreślenieFigur()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + kkMarginesFormularza,
                Screen.PrimaryScreen.Bounds.Y + kkMarginesFormularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9F);
            this.StartPosition = FormStartPosition.Manual;
            pbRysownica.BackColor = Color.Beige;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            checkBox1.Location = new Point(pbRysownica.Left +
                pbRysownica.Width + kkMargines, pbRysownica.Top);
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            lblZaznaczFigury.Location = new Point(checkBox1.Location.X, checkBox1.Location.Y - kkMargines - lblZaznaczFigury.Height);
           
        }

        private void LaboratoriumNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult oknoDialogowe = MessageBox.Show(
                "Czy chcesz zamknąć  ten formuklarz i wrócić do głównego ?", this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oknoDialogowe == DialogResult.Yes)
            {
                foreach (Form szukanyFormularz in Application.OpenForms)
                    //sprawdzenie czy jest to formularz główny
                    if (szukanyFormularz.Name == "KokpitNr2")
                    { // ukrycie bieżącego formularza
                        this.Hide();
                        // odsłoniećie znalezionego formularza
                        szukanyFormularz.Show();
                        return;
                    }
                // jeżlei jesteśmy tutaj oznaczas to awarię
                MessageBox.Show("Awaria : ktoś usunął z kolekcji OpenForms egzemplarz formularza głównegoi musi nastąpić zmaknięcie"
                    , this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // zamknięcie całego programu 
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void LaboratoriumNr2_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ushort N; 

            errorProvider1.Dispose();

            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorProvider1.SetError(textBox1, "Error - musisz podać liczbę figur geometrycznych");
                return;
            }

            if (!ushort.TryParse(textBox1.Text, out N ))
            {
                errorProvider1.SetError(textBox1,"Error - w zapisie liczby wystąpił niedozwolony znak");
                return;
             }

            textBox1.Enabled = false;
            TFG = new Punkt[N];
           
            IndexTFG = 0;
            
            if ( checkBox1.CheckedItems.Count <= 0 )
            {
                errorProvider1.SetError(checkBox1, "Error - musisz wybrać przynajmniej jedną figurę");
                return;
            }

            CheckedListBox.CheckedItemCollection WybraneFigury = checkBox1.CheckedItems;

            checkBox1.Enabled = false;

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            int X, Y;
            Color kolorLinii;
            Color kolorWypełnienia;
            int grubośćLinii;
            int grubośćPunktu;
            DashStyle StylLinii;
            int ośDuża, ośMała;
            int Xk, Yk;
            int wylosowanyIndeksFigury;
            int promień;
            int długośćBoku;
            int wysokośćProstokąta;
            int szerokośćProstokąta;
            bool widoczny;

            for(int i = 0; i < N; i++)
            {
                X = rnd.Next(kkMargines, Xmax/4 - kkMargines);
                Y = rnd.Next(kkMargines, Ymax/4 - kkMargines);
                kolorLinii = Color.FromArgb(rnd.Next(0, 255),
                    rnd.Next(0,255),
                    rnd.Next(0,255));
                kolorWypełnienia = Color.FromArgb(rnd.Next(0,255),
                    rnd.Next(0,255),
                        rnd.Next(0,255));
                switch (rnd.Next(0,5))
                {
                    case 0: StylLinii = DashStyle.Solid; break;
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.Dot;break;
                    case 3: StylLinii = DashStyle.DashDotDot;break;
                    case 4: StylLinii = DashStyle.DashDot;break;
                    default: StylLinii = DashStyle.Solid;break;
                }
                grubośćLinii = rnd.Next(1,10);
                grubośćPunktu = rnd.Next(3, 15);
                wylosowanyIndeksFigury = rnd.Next(WybraneFigury.Count);
                ośDuża = rnd.Next(kkMargines, Xmax - kkMargines);
                ośMała = rnd.Next(kkMargines, Ymax - kkMargines);
                promień = rnd.Next(kkMargines,Ymax - kkMargines );
                długośćBoku = rnd.Next(50, 200);
                wysokośćProstokąta = rnd.Next(kkMargines, Xmax - kkMargines);
                szerokośćProstokąta = rnd.Next(kkMargines, Ymax - kkMargines);
                

                switch (WybraneFigury[wylosowanyIndeksFigury].ToString())
                {
                    case "Punkt":
                        TFG[IndexTFG] = new Punkt(X, Y, kolorLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;
                        break;
                    case "Linia":
                        Xk = rnd.Next(kkMargines, Xmax - kkMargines);
                        Yk= rnd.Next(kkMargines, Ymax - kkMargines);
                        TFG[IndexTFG] = new Linia(X, Y, Xk, Yk, kolorLinii, StylLinii, grubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;
                        break;
                    case "Elipsa":
                        TFG[IndexTFG] = new Elipsa(X, Y, ośDuża, ośMała, kolorLinii, StylLinii, grubośćLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;
                        break;
                    case "Okrąg":
                        TFG[IndexTFG] = new Okrąg(X, Y,ośDuża,ośMała,kolorLinii, StylLinii, grubośćLinii,promień);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;

                        break;
                    case "Prostokąt":
                       
                        TFG[IndexTFG] = new Prostokąt(X, Y, kolorLinii, StylLinii, grubośćLinii,szerokośćProstokąta, wysokośćProstokąta);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;
                        break;
                    case "Kwadrat":
                        TFG[IndexTFG] = new Kwadrat(X, Y, kolorLinii, StylLinii, grubośćLinii, długośćBoku);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        widoczny = true;
                        break;
                    default:
                        MessageBox.Show("Wylosowana figura: " + (string)checkBox1.CheckedItems[wylosowanyIndeksFigury] +
                            "nie jest jeszcze obsługiwana");
                        return;

                }

            }
            pbRysownica.Refresh();
            btnStart.Enabled = false;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            Random rnd = new Random();
            int Xp;
            int Yp;
            Rysownica.Clear(pbRysownica.BackColor);
            

            for ( int i = 0; i < TFG.Length; i++ ) 
            {
                Xp = rnd.Next(kkMargines, Xmax / 2 - kkMargines);
                Yp = rnd.Next(kkMargines, Ymax/2 - kkMargines);
                TFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
            }
            pbRysownica.Refresh();
                    

                
            
            

            

}

        private void button2_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            Random rnd = new Random();
            int Xp;
            int Yp;
            Color kolor; 
            DashStyle stylLinii;
            int grubośćLinii;
            grubośćLinii = rnd.Next(1, 10);
            
            


            for (int i = 0; i < TFG.Length; i++)
            {
                kolor =  Color.FromArgb(rnd.Next(0, 255),
                    rnd.Next(0, 255),
                    rnd.Next(0, 255));
                grubośćLinii = rnd.Next(1, 10);
                switch (rnd.Next(0, 5))
                {
                    case 0: stylLinii = DashStyle.Solid; break;
                    case 1: stylLinii = DashStyle.Dash; break;
                    case 2: stylLinii = DashStyle.Dot; break;
                    case 3: stylLinii = DashStyle.DashDotDot; break;
                    case 4: stylLinii = DashStyle.DashDot; break;
                    default: stylLinii = DashStyle.Solid; break;
                }

                Xp = rnd.Next(kkMargines, Xmax / 4 - kkMargines);
                Yp = rnd.Next(kkMargines, Ymax / 4 - kkMargines);
                
                TFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
                TFG[i].UstalAtrybutyGraficzne(kolor, stylLinii, grubośćLinii);

            }
            pbRysownica.Refresh();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ; Rysownica.Clear(pbRysownica.BackColor);
           
            int kkXmax = pbRysownica.Width;
            int kkYmax = pbRysownica.Height;
            
            pbRysownica.Refresh();
            if (rdbAutomat.Checked)
            {
                timer1.Enabled = true;
                timer1.Tag = 0;
                textBox2.Text = "0";
            }
            else
            {
                int IndexFigury = 0;
                if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    textBox2.Text = "0";
                }
                else
                {
                    if (!int.TryParse(textBox2.Text, out IndexFigury))
                    {
                        errorProvider1.SetError(textBox2, "Błędny zapis indeksu figury");
                        return;
                    }
                    if ((IndexFigury < 0) || (IndexFigury >= (TFG.Length)))
                    {
                        errorProvider1.SetError(textBox1, " Index figury wykracza poza zakres");
                            return;
                    }
                    errorProvider1.Dispose();
                }
                TFG[0].PrzesuńDoNowegoXY(pbRysownica, Rysownica, kkXmax / 2, kkYmax / 2);
                btnNastępny.Enabled = true;
                btnPoprzedni.Enabled = true;
                pbRysownica.Refresh();
                btnWłączSlajder.Enabled = true;
                btnWyłączSlajder.Enabled = true;

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblZaznaczFigury_Click(object sender, EventArgs e)
        {

        }

        private void btnWyłączSlajder_Click(object sender, EventArgs e)
            
        {
            
            Rysownica.Clear(pbRysownica.BackColor);
            rdbAutomat.Enabled = false;
            timer1.Dispose();
            timer1.Stop();
            textBox2.Text= "";
            btnWłączSlajder.Enabled= true;
            
            btnWyłączSlajder.Enabled = true;
           
            btnNastępny.Enabled = true;
            btnPoprzedni.Enabled = true;
            textBox2 .Enabled = true; 
            Random rnd = new Random();
            int kkx,kky;
            int kkXmax = pbRysownica.Width;
            int kkYmax = pbRysownica.Height;

            for ( int i = 0; i < TFG.Length; i++ ) 
            {
                kkx = rnd.Next(kkMargines, kkXmax - kkMargines);
                kky = rnd.Next(kkMargines,kkYmax - kkMargines);
                TFG[i].PrzesuńDoNowegoXY(pbRysownica,Rysownica,new Point(kkx,kky));
            }
            pbRysownica.Refresh();

        }

        private void btnNastępny_Click(object sender, EventArgs e)
        {
            ushort kkIndexFigury;
            kkIndexFigury = ushort.Parse(textBox2.Text);
            if ( kkIndexFigury < TFG.Length - 1) 
            {
                kkIndexFigury++;
            }
            else
            {
                kkIndexFigury = 0;
            }
            int kkXmax = pbRysownica.Width;
            int kkYmax = pbRysownica.Height;
            TFG[kkIndexFigury].PrzesuńDoNowegoXY(pbRysownica,Rysownica,kkXmax/2,kkYmax/2);
            pbRysownica.Refresh();
            textBox2.Text = kkIndexFigury.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            ushort kkIndexFigury;

            if (textBox2.Text == "")
                return;
            //pobranie numeru indeksu TFG wpisanego do kontrolki TextBox
            if (!ushort.TryParse(textBox2.Text, out kkIndexFigury))
            {
                errorProvider1.SetError(textBox2, "ERROR: w zapisie " + " indeksu figury wystąpił nieprawidłowy znak");
                return;
            }
            //sprawdzenie warunku zawartość 
            if (kkIndexFigury > TFG.Length - 1)
            {
                errorProvider1.SetError(textBox2, "ERROR: przekroczenie dopuszczalnej wartości indeksu: " + (TFG.Length - 1).ToString());
                return;
            }
            //wyczyszczenie rysownicy
            Rysownica.Clear(pbRysownica.BackColor);
            //deklaracje pomocnicze
            //wyznaczenie rozmiarów rysownicy
            int anXmax = pbRysownica.Width;
            int anYmax = pbRysownica.Height;
            //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
            TFG[kkIndexFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, anXmax / 2, anYmax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            ushort anIndexFigury;
            // pobieranie z kontrolki textbox indexu aktualnie wykreślonej figury
            anIndexFigury = ushort.Parse(textBox2.Text);
            //wyznaczenie indeksu dla następnej figury
            if (anIndexFigury != 0)
            {
                anIndexFigury--;
            }
            else
            {
                anIndexFigury = (ushort)(TFG.Length - 1);
            }

            //deklaracje pomocnicze
            //wyznaczenie rozmiarów rysownicy
            int anXmax = pbRysownica.Width;
            int anYmax = pbRysownica.Height;

            //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
            TFG[anIndexFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, anXmax / 2, anYmax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //uaktualnienie zapisu indeksu aktualnie wykreślonej figury
            textBox2.Text = anIndexFigury.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int kkXmax = pbRysownica.Width;
            int kkYmax = pbRysownica.Height;
            textBox2.Text = timer1.Tag.ToString();

            TFG[(int)timer1.Tag].PrzesuńDoNowegoXY(pbRysownica,Rysownica,kkXmax / 2, kkYmax / 2);
            pbRysownica.Refresh();
            timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % (TFG.Length - 1);
        }

        private void checkBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TFG == null || TFG.Length == 0)
            {
                MessageBox.Show("Najpierw utwórz figury geometryczne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz wybrany kolor z przycisku wziernika koloru linii
            Color nowyKolorLinii = btnWziernikKoloru.BackColor;

            // Pobierz wybrany typ figury
            if (checkBox1.SelectedItem == null)
            {
                MessageBox.Show("Wybierz typ figury, któremu chcesz zmienić kolor.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string wybranyTypFigury = checkBox1.SelectedItem.ToString();

            // Przejdź przez wszystkie figury i zmień kolor tych, które pasują do wybranego typu
            foreach (Punkt figura in TFG)
            {
                if (figura != null && figura.GetType().Name == wybranyTypFigury)
                {
                    figura.kolor = nowyKolorLinii; // Ustaw nowy kolor
                    figura.Wymaż(pbRysownica, Rysownica); // Wymaż starą figurę
                    figura.Wykreśl(Rysownica); // Wykreśl ponownie z nowym kolorem
                }
            }

            // Odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnWziernikKoloru_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Otwórz okno dialogowe do wyboru koloru
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Pobierz wybrany kolor
                    Color selectedColor = colorDialog.Color;
                    btnWziernikKoloru.BackColor = selectedColor;

                }
            }
        }
    }
    }
    
     
