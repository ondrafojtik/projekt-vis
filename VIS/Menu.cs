using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VIS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button_hromadne_pridani_zaku_Click(object sender, EventArgs e)
        {
            //button_hromadne_pridani_zaku
            Form1 form1 = new Form1(this);
            form1.Show();
            Hide();
        }

        private void button_zaslani_hromadneho_emailu_Click(object sender, EventArgs e)
        {
            //button_zaslani_hromadneho_emailu
            FormZaslaniHromadnehoEmailu form = new FormZaslaniHromadnehoEmailu(this);
            form.Show();
            Hide();
        }

        private void button_kontaktovat_studenta_Click(object sender, EventArgs e)
        {
            FormKontaktovaniStudenta form = new FormKontaktovaniStudenta(this);
            Hide();
            form.Show();
        }

        private void button_zadat_znamku_Click(object sender, EventArgs e)
        {
            FormZadatZnamku form = new FormZadatZnamku(this);
            Hide();
            form.Show();
        }
    }
}
