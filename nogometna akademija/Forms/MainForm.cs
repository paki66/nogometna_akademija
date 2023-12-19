using System;
using System.Windows.Forms;
using nogometna_akademija.Abstract.Models;
using nogometna_akademija.DB.Stores;
using nogometna_akademija.UI.Forms;

namespace nogometna_akademija.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm(Trener trener)
        {
            InitializeComponent();

            ulogiranlbl.Text = string.Format("Dobrodošao {0} {1}!", trener.ime, trener.prezime);
        }

        private void ulogiranlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
