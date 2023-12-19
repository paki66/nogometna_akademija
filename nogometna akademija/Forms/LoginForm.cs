using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nogometna_akademija.DB.Stores;
using nogometna_akademija.Abstract.Models;

namespace nogometna_akademija.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Trener trener { get; private set; }

        private void imetxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            TrenerStore trenerStore = new TrenerStore();

            trener = trenerStore.Autoriziraj(imetxt.Text, lozinkatxt.Text);

            if (trener.aktivan)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Neispravni podaci unosa!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
