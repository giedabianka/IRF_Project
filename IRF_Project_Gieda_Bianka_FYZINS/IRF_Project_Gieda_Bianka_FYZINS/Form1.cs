using IRF_Project_Gieda_Bianka_FYZINS.Osztalyok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_Gieda_Bianka_FYZINS
{
    public partial class Form1 : Form
    {
        string[] szavak;

        public Form1()
        {
            InitializeComponent();
            BetuMatrix();
            SzavakBetoltese();
            
        }

        private void BetuMatrix()
        {
            int tavolsag = 2;
            string[] felirat = new string[35] {"A","Á","B","C","D","E","F","G","H","I","Í","J","K","L","J","M","N","O","Ó","Ö","Ő","P","Q","R","S","T","U","Ú","Ü","Ű","V","W","X","Y","Z"};
            int i=0;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Betuk b = new Betuk();
                    b.Left = col * b.Width + (int)(Math.Floor((double)(col))) * tavolsag;
                    b.Top = row * b.Height + (int)(Math.Floor((double)(row))) * tavolsag;
                    panel_betuk.Controls.Add(b);

                    b.Text = (string)(felirat[i]);
                    i++;
                }
            }
        }

        private void SzavakBetoltese()
        {
            using (StreamReader szo = new StreamReader("szavak.csv", Encoding.Default))
            {
                while (!szo.EndOfStream)
                {
                    szavak = szo.ReadLine().Split(';');
                }

            }

        }



    }
}
