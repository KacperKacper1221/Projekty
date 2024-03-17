using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macierze
{
    public partial class NoweTypyDanych : Form
    {

        bool[] StanAktywnościStronZakładki = { true, true, true };
        

        
        public NoweTypyDanych()
        {
            InitializeComponent();
        }

        private void Zakładki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPage == Zakładki.TabPages[0]) && (StanAktywnościStronZakładki[0]))
            {
                StanAktywnościStronZakładki[1] = true;
                StanAktywnościStronZakładki[2] = true;
                Zakładki.SelectedTab = tabPage1;
            }
            else
            if ((e.TabPage == Zakładki.TabPages[1]) && (StanAktywnościStronZakładki[1]))
            {

                StanAktywnościStronZakładki[2] = false;
                Zakładki.SelectedTab = tabPage2;
            }
            else
            if ((e.TabPage == Zakładki.TabPages[2]) && (StanAktywnościStronZakładki[2]))
            {

                StanAktywnościStronZakładki[1] = false;
                Zakładki.SelectedTab = tabPage3;
            }
            else e.Cancel = true;
        }
    }
}
