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
        public Inditas()
        {
            InitializeComponent();
            
            string [] jatekosokszama = { "1" , "2" ,"3"};
            string[] betukszama = { "3", "4", "5" , "6" , "7"};
            
            Jatekosok_szama_Cbox.DataSource = jatekosokszama;
            Betuk_szama_Cbox.DataSource = betukszama;
        }

        private void Jatek_inditasa_Btn_Click(object sender, EventArgs e)
        {
            Form1 ablak = new Form1();
            ablak.Show();
            this.Hide();
        }
    }
}
