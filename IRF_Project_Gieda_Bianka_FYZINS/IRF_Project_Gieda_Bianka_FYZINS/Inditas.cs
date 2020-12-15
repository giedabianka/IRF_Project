using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_Gieda_Bianka_FYZINS
{
    public partial class Inditas : Form
    {
        public static string[] jatekosokszama = { "1", "2", "3" };
        public static string[] betukszama = { "3", "4", "5", "6", "7" };
        public Inditas()
        {
            InitializeComponent();
            Jatekosok_szama_Cbox.DataSource = jatekosokszama;
            Betuk_szama_Cbox.DataSource = betukszama;

        }

        private void Jatek_inditasa_Btn_Click_1(object sender, EventArgs e)
        {
            Form1 ablak = new Form1(Convert.ToInt32(Betuk_szama_Cbox.SelectedItem), Convert.ToInt32(Jatekosok_szama_Cbox.SelectedItem));
            ablak.Show();
            this.Hide();
        }

        private void Inditas_Load(object sender, EventArgs e)
        {
        }
    }

}
