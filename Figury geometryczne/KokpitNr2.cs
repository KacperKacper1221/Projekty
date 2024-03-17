using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figury_geometryczne
{
    public partial class KokpitNr2 : Form
    {
        public KokpitNr2()
        {
            InitializeComponent();
        }

        private void btnFormInd_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy nasz formularz jest w kolekcji OpenForms
            foreach (Form szukanyFormularz in Application.OpenForms)




                //sprawdzenie czy jest to szukany formularz 
                if (szukanyFormularz.Name == "LaboratoriumNr2")
                {
                    // jezeli form został odnaleziony to ukrywamy bieżący formularz(czyli głowny)
                    Hide();
                    //odsłaniamy znaleziony formularz
                    szukanyFormularz.Show();
                    return;
                }
            //poszukiwany form nie został znaleziony
            // utworzenie egzemplarza dla poszukiwanego formularza 
            KreślenieFigur EgzFormularzaLaboratyjnego = new KreślenieFigur();
            this.Hide();
            EgzFormularzaLaboratyjnego.Show();

        }
        private void btnFormInd_Click_1(object sender, EventArgs e)
        {
            
            foreach (Form szukanyFormularz in Application.OpenForms)
            
                if (szukanyFormularz.Name == "Indywidualne")
                {

                    this.Hide();
                    //odsłaniamy znaleziony formularz
                    szukanyFormularz.Show();
                    return;
                }
            
            //poszukiwany form nie został znaleziony
            // utworzenie egzemplarza dla poszukiwanego formularza 
            RysowanieMyszą EgzFormularzaIndywidualnego = new RysowanieMyszą();
            this.Hide();
            EgzFormularzaIndywidualnego.Show();

        }



        private void KokpitNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult oknoDialogowe =
                MessageBox.Show("Czy rzeczywiście chcesz zamknąć formularz i zakończyć działanie programu ? ", this.Name,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // rozpoznanie odpowiedzi użytkownika 
            if (oknoDialogowe == DialogResult.Yes)
            {
                //pozamykanie działających procesów (Wątków) równoległych i wyjście z programu
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

       

    }
    }


