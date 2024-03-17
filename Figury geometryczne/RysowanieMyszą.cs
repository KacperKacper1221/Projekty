using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Figury_geometryczne.FiguryGeometryczne;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using static Figury_geometryczne.FiguryGeometryczne.Punkt;
using System.Net;

namespace Figury_geometryczne
{
    public partial class RysowanieMyszą : Form
    {
        const int kkMarginesForm = 20;
        const int kkMargines = 10;
        Graphics kkRysownica;
        Graphics kkRysownicaTymczas;
        Point kkPunkt;
        Pen kkPióro;
        Color kkKolor = Color.Blue;
        Color kkKolorWypełnienia = Color.Azure;
        SolidBrush kkPędzel;
        Pen kkPióroChwilowe;
        List<Punkt> LFG = new List<Punkt>();
        Punkt punkte = new Punkt();
        ErrorProvider errorProvider1 = new ErrorProvider();


        public RysowanieMyszą()
        {
            InitializeComponent();
            this.Location =
               new Point(Screen.PrimaryScreen.Bounds.X + kkMarginesForm,
                         Screen.PrimaryScreen.Bounds.Y + 2 *kkMarginesForm);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85f);
            //lokalizacja i zwymiarowanie formularza według podanych ustawień
            this.StartPosition = FormStartPosition.CenterScreen;
            //ustawienie stanu braku aktywności przycisków Maksymalizacji i Minimalizacji
          

           
            //ustawienie koloru tła kontrolki PictureBox
            pbRysownica.BackColor = Color.Beige;
            //ustalenie obramowania (Jedno wierszowe obramowanie) kontrolki PictureBox
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            //utworzenie mapy bitowej i podpięcie jej do kontrolki PictureBox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //Lokalizacje pozostałyvh elementów
            
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            kkRysownica = Graphics.FromImage(pbRysownica.Image);
            //utworzenie egzemplarza tymczasowej powierzchni graficznej na kontrolce PictureBox
            kkRysownicaTymczas = pbRysownica.CreateGraphics();
        
            



            kkPunkt = Point.Empty;
            kkPióro = new Pen(Color.Black, 1F);
            kkPióro.DashStyle = DashStyle.Solid;
            kkPióro.StartCap=LineCap.Round;
            kkPióro.EndCap=LineCap.Round;
            kkPióroChwilowe = new Pen(Color.Pink, 1);
            kkPędzel = new SolidBrush(kkKolorWypełnienia);
            kkStylLinii.SelectedIndex = 0;
            int kkOdstępMiędzyLiniami = 20;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            int anXmax = pbRysownica.Width;
            int anYmax = pbRysownica.Height;

            kkRysownica.Clear(pbRysownica.BackColor);
            timer1.Tag = 0;
            txtNumerFigury.Text = 0.ToString();

            if (LFG.Count < 1)
            {
                errorProvider1.SetError(btnWlacz, "ERROR - najpierw wykreśl choć jedną figurę");
                return;
            }
            LFG[0].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, anXmax / 2, anYmax / 2);
            pbRysownica.Refresh();

            if (chAutomatyczny.Checked)
            {
                //uaktywnienie zegara
                timer1.Enabled = true;
            }
            else
            { //stawienie stanu braku aktywności dla kontrolek slajdera manualnego
                btnNastępny.Enabled = true;
                btnPoprzedni.Enabled = true;
                txtNumerFigury.Enabled = true;
            }
            btnWlacz.Enabled = false;
            btnWylacz.Enabled = true;
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            lblX.Text =e.Location.X.ToString();
            lblY.Text =e.Location.Y.ToString();
            if ( e.Button == MouseButtons.Left)
            {
                kkPunkt = e.Location;
                kkPióro.Color = kkTextBox1.BackColor;
                kkPióro.DashStyle = WybranyStylLinii(kkStylLinii.SelectedIndex);
                kkPióro.Width = kkGrubośćLinii.Value;
                if(rdbLinia.Checked)
                {
                    kkPióro.Color = kkTextBox1.BackColor;
                    kkPióro.DashStyle = WybranyStylLinii(kkStylLinii.SelectedIndex);
                    kkPióro.Width = kkGrubośćLinii.Value;
                    
                }
            }
        }

        DashStyle WybranyStylLinii(int i ) 
        { 
            switch (i)
            {
                case 0 :
                    return DashStyle.Solid;
                    case 1 :
                    return DashStyle.Dash;
                    case 2 :
                    return DashStyle.DashDot;
                    case 3 :
                    return DashStyle.DashDotDot;
                    case 4 :
                    return DashStyle.Dot;
                default:
                    return DashStyle.Solid;
            }
        }


        private void lblY_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            int kklewyGórnyNarożnikX = (kkPunkt.X > e.Location.X) ? e.Location.X : kkPunkt.X;
            int kklewyGórnyNarożnikY = (kkPunkt.Y > e.Location.Y) ? e.Location.Y : kkPunkt.Y;
            int szerokość = Math.Abs(kkPunkt.X - e.Location.X);
            int wysokość = Math.Abs(kkPunkt.Y - e.Location.Y);
            int kkOdstępMiędzyLiniami2 = 40;
            if ( e.Button == MouseButtons .Left )
            {
                if (rdbPunkt.Checked)
                {


                    //utworzenie egzemplarza i dodanie jego referencji do LFG
                    LFG.Add(new Punkt(kkPunkt.X, kkPunkt.Y));
                    //ustalenie atrybutów geometrycznych i graficznych punktu
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie punktu
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                }
                if ( rdbLinia.Checked )
                {
                    //utowrzenie egzemplarza i dodanie jego referencji do LFG
                    LFG.Add(new Linia(kkPunkt.X, kkPunkt.Y, e.Location.X, e.Location.Y));
                    //ustalenie atrybutów geometrycznych i graficznych linii
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie linii
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                }
                if ( kkrdbLiniaPodwójna.Checked )
                {
                    LFG.Add(new LiniaPodwójna(kkPunkt.X, kkPunkt.Y,e.Location.X,e.Location.Y));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie punktu
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                    
                }
                if(rdbElipsa.Checked)
                {

                    //utowrzenie egzemplarza i dodanie jego referencji do LFG
                    LFG.Add(new Elipsa(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, wysokość));
                    //ustalenie atrybutów geometrycznych i graficznych elipsy
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie elipsy
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);

                }
                if(rdbOkrąg.Checked )
                {
                    LFG.Add(new Okrąg(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość / 2));
                    //ustalenie atrybutów geometrycznych i graficznych okręgu
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie okręgu
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                }
                if(rdbProstokąt.Checked )
                {
                    LFG.Add(new Prostokąt(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, wysokość));
                    //ustalenie atrybutów geometrycznych i graficznych okręgu
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie okręgu
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                }
                if(rdbKwadrat.Checked )
                {
                    //utowrzenie egzemplarza i dodanie jego referencji do LFG
                    LFG.Add(new Kwadrat(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość));
                    //ustalenie atrybutów geometrycznych i graficznych okręgu
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(kkKolor, kkPióro.DashStyle, kkGrubośćLinii.Value);
                    //wykreślenie okręgu
                    LFG[LFG.Count - 1].Wykreśl(kkRysownica);
                }
                if ( rdbLiniaKreślonaMyszą.Checked )
                {
                    kkRysownica.DrawLine(kkPióro,kkPunkt.X,kkPunkt.Y,e.Location.X,e.Location.Y);
                    kkPunkt.X = e.Location.X;
                    kkPunkt.Y= e.Location.Y;
                }
                pbRysownica.Refresh();
            }
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            int kklewyGórnyNarożnikX = (kkPunkt.X > e.Location.X) ? e.Location.X : kkPunkt.X;
            int kklewyGórnyNarożnikY = (kkPunkt.Y > e.Location.Y) ? e.Location.Y : kkPunkt.Y;
            int szerokość = Math.Abs(kkPunkt.X - e.Location.X);
            int wysokość = Math.Abs(kkPunkt.Y - e.Location.Y);
            if (rdbPunkt.Checked)
            {
                //punktu nie rozciągamy
            }
            if (rdbLinia.Checked)
            {
                //kreślenie linii na powierzchni tymczasowej
                kkRysownicaTymczas.DrawLine(kkPióroChwilowe, kkPunkt.X, kkPunkt.Y, e.Location.X, e.Location.Y);
            }
            if (rdbLiniaKreślonaMyszą.Checked)
            {
                //rysowanie punktów
                kkRysownicaTymczas.DrawLine(kkPióro, kkPunkt.X, kkPunkt.Y, e.Location.X, e.Location.Y);
                kkPunkt.X = e.Location.X;
                kkPunkt.Y = e.Location.Y;
            }
            if (rdbElipsa.Checked)
            {
                kkRysownicaTymczas.DrawEllipse(kkPióroChwilowe,
                    new Rectangle(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, wysokość));
            }
            if (rdbOkrąg.Checked)
            {
                kkRysownicaTymczas.DrawEllipse(kkPióroChwilowe,
                    new Rectangle(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, szerokość));
            }
            if (rdbKwadrat.Checked)
            {
                kkRysownicaTymczas.DrawRectangle
                    (kkPióroChwilowe, kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, szerokość);

            }
            if (rdbProstokąt.Checked)
            {
                kkRysownicaTymczas.DrawRectangle
                    (kkPióroChwilowe, kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, szerokość, szerokość);

            }
            
            if (rdbFillSquare.Checked)
            {
                kkRysownicaTymczas.FillRectangle(kkPędzel,
                    new Rectangle(kklewyGórnyNarożnikX, kklewyGórnyNarożnikY, wysokość, wysokość));
            }
            if( rdbLiniaKreślonaMyszą.Checked)
                {
                kkRysownica.DrawLine(kkPióro,kkPunkt.X,kkPunkt.Y,e.Location.X,e.Location.Y);
                kkPunkt.X = e.Location.X; kkPunkt.Y = e.Location.Y;

            }


            //itd...

            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnKolor_Click(object sender, EventArgs e)
        {
            ColorDialog kkkolor = new ColorDialog();
            kkkolor.ShowDialog();
            kkKolor = kkkolor.Color;
            kkPióro.Color = kkkolor.Color;
            kkTextBox1.BackColor = kkkolor.Color;


        }

       

        private void btnPrzesuńFigury_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (LFG.Count < 1)
            {
                errorProvider1.SetError(btnPrzesuńFigury, "ERROR - najpierw wykreśł chociaż jedną figurę");
                return;
            }
            //wyczyszczenie powierzchni graficznej
            kkRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów powierzchni graficznej
            int anXmax = pbRysownica.Width, Ymax = pbRysownica.Height;
            //deklaracja i utworzenie egzemplarza generatora współżędnych 
            Random rnd = new Random();
            //losowe współżędne
            ushort anx, any;
            for (int ani = 0; ani < LFG.Count; ani++)
            {
                anx = (ushort)rnd.Next(kkMargines, anXmax - kkMargines);
                any = (ushort)rnd.Next(kkMargines, Ymax - kkMargines);
                LFG[ani].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, anx, any);
            }

            pbRysownica.Refresh();
        }

    

    private void timer1_Tick(object sender, EventArgs e)
        {
            //wymazanie całej powierzchni graficznej
            kkRysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów powierzchni graficznej
            int anXmax = pbRysownica.Width;
            int anYmax = pbRysownica.Height;
            //wpisanie do kontrolki slajder indeksu TFG pokazywanej figury
            txtNumerFigury.Text = timer1.Tag.ToString();
            //wykreślenie figury o indeksie timer1.Tag w środku powierzchni graficznej
            LFG[(int)(timer1.Tag)].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, anXmax / 2, anYmax / 2);
            //odświeżenie pow. graficznej
            pbRysownica.Refresh();
            //ustawienie indeksu dla następnej figury do pokazu
            timer1.Tag = ((int)(timer1.Tag) + 1) % (LFG.Count);
        }

        private void btnWylacz_Click(object sender, EventArgs e)
        {
            kkRysownica.Clear(pbRysownica.BackColor);
            //wyłączenie zegara
            timer1.Enabled = false;
            //ustawienie indeksu na 0
            txtNumerFigury.Text = "";
            //uaktywnienie przycisku poleceń WączenieSlajdera
            btnWlacz.Enabled = true;
            //ustawienie stanu braku aktywności dla przycisku btnWyłączenieSlajdera
            btnWylacz.Enabled = true;
            //uaktywnienie/brak aktywności przycisków slajdera
            chAutomatyczny.Checked = true;
            btnNastępny.Enabled = true;
            btnPoprzedni.Enabled = true;
            txtNumerFigury.Enabled = true;
            //ponowne wykreślenie wszystkich figur "zapisanych" w TFG
            Random anrnd = new Random();
            //deklaracje pomocnicze
            int anx, any;
            //wyznaczenie rozmiarów rysownicy
            int anXmax = pbRysownica.Width;
            int anYmax = pbRysownica.Height;
            //wykreślenie wszystkich figur z TFG w losowej lokalizacji
            for (int ani = 0; ani < LFG.Count; ani++)
            {
                //wylosowanie nowej lokalizacji: (x, y) dla i-tej figury
                anx = anrnd.Next(kkMargines, anXmax - kkMargines);
                any = anrnd.Next(kkMargines, anYmax - kkMargines);
                //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
                LFG[ani].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, new Point(anx, any));
            }
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnNastępny_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort anIndexFigury;
            // pobieranie z kontrolki textbox indexu aktualnie wykreślonej figury
            anIndexFigury = ushort.Parse(txtNumerFigury.Text);
            //wyznaczenie indeksu dla następnej figury
            if (anIndexFigury < LFG.Count - 1)
            {
                anIndexFigury++;
            }
            else
            {
                anIndexFigury = 0;
            }

            //deklaracje pomocnicze
            //wyznaczenie rozmiarów rysownicy
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            kkRysownica.Clear(pbRysownica.BackColor);
            //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
            LFG[anIndexFigury].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, Xmax / 2, Ymax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //uaktualnienie zapisu indeksu aktualnie wykreślonej figury
            txtNumerFigury.Text = anIndexFigury.ToString();
        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort anIndexFigury;
            // pobieranie z kontrolki textbox indexu aktualnie wykreślonej figury
            anIndexFigury = ushort.Parse(txtNumerFigury.Text);
            //wyznaczenie indeksu dla następnej figury
            if (anIndexFigury != 0)
            {
                anIndexFigury--;
            }
            else
            {
                anIndexFigury = (ushort)(LFG.Count - 1);
            }

            //deklaracje pomocnicze
            //wyznaczenie rozmiarów rysownicy
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            kkRysownica.Clear(pbRysownica.BackColor);
            //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
            LFG[anIndexFigury].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, Xmax / 2, Ymax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //uaktualnienie zapisu indeksu aktualnie wykreślonej figury
            txtNumerFigury.Text = anIndexFigury.ToString();
        }

        private void txtNumerFigury_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            ushort anIndeksFigury;

            if (txtNumerFigury.Text == "")
                return;
            //pobranie numeru indeksu TFG wpisanego do kontrolki TextBox
            if (!ushort.TryParse(txtNumerFigury.Text, out anIndeksFigury))
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR: w zapisie " + " indeksu figury wystąpił nieprawidłowy znak");
                return;
            }
            //sprawdzenie warunku zawartość 
            if (anIndeksFigury > LFG.Count - 1)
            {
                errorProvider1.SetError(txtNumerFigury, "ERROR: przekroczenie dopuszczalnej wartości indeksu: " + (LFG.Count - 1).ToString());
                return;
            }
            //wyczyszczenie rysownicy
            kkRysownica.Clear(pbRysownica.BackColor);
            //deklaracje pomocnicze
            //wyznaczenie rozmiarów rysownicy
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //zmiana lokalizacji i-tej figury geometrycznej i wykreślenie
            LFG[anIndeksFigury].PrzesuńDoNowegoXY(pbRysownica, kkRysownica, Xmax / 2, Ymax / 2);
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

       

        private void button1_Click(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoDialogowe = MessageBox.Show("czy chcesz zamknac ten formularz i wrocic do formularza glownego?",
              this.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //rozpoznanie wybranego (kliknieciem) przycisku: Yes lub No
            if (OknoDialogowe == DialogResult.Yes)
            { //odszukanie formularza glownego w kolekcji OpenForms
                foreach (Form SzukanyFormularz in Application.OpenForms)
                    //sprawdzenie czy jest to formularz glowny 
                    if (SzukanyFormularz.Name == "KokpitNr2")
                    { //ukrycie biezacego formularza 
                        this.Hide();
                        //odsloniecie znalezionego formularza 
                        SzukanyFormularz.Show();
                        //Zakonczenie obslugi zdarzenia FormClicking 
                        return;
                    }
                //a gdy znajdziemy sie tutaj, to jest awaria !!!
                MessageBox.Show("AWARIA: Ktos usunal z kolekcji OpenForms " +
                    "egzemplarz formularza glownego i musi nastapic zamkniecie programu", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //zamkniecie calego programu, lacznie z rownolegle dzialajacymi procesami rownoleglymi (zwanymi watkami)
                Application.ExitThread();

            }

            else
                //nie, nie! to przypadkowo
                e.Cancel = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
    }
    
    



       
    

