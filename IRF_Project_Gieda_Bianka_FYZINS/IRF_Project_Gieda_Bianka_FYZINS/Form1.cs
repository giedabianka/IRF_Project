using IRF_Project_Gieda_Bianka_FYZINS.Osztalyok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_Gieda_Bianka_FYZINS
{
    public partial class Form1 : Form
    {
        //SZAVAKHOSSZA
        string[] szavak;
        public static int kivbetuszam;

        //RANDOMGENERALAS_VONALAK
        string[] azonhossz_tomb;
        public static string jelenlegi = "";
        public static string masoltjelenlegi = "";

        public Form1(int a)
        {
            InitializeComponent();

            kivbetuszam = a;

            BetuMatrix();
            SzavakBetoltese();
            SzavakHossza();
            RandomGeneralas();
            Vonalak();            
        }

        public void BetuMatrix()
        {
            int tavolsag = 2;
            string[] felirat = new string[35] { "A", "Á", "B", "C", "D", "E", "F", "G", "H", "I", "Í", "J", "K", "L", "J", "M", "N", "O", "Ó", "Ö", "Ő", "P", "Q", "R", "S", "T", "U", "Ú", "Ü", "Ű", "V", "W", "X", "Y", "Z" };
            int i = 0;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Betuk b = new Betuk(this);
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
            using (StreamReader sz = new StreamReader("szavak.csv", Encoding.Default))
            {
                while (!sz.EndOfStream)
                {
                    szavak = sz.ReadLine().Split(';');
                }
            }
        }

        public void SzavakHossza()
        {
            var azonoshosszusagu = from x in szavak
                                   where x.Length == kivbetuszam
                                   select x;
            azonhossz_tomb = azonoshosszusagu.ToArray();
        }

        private void RandomGeneralas()
        {
            Random rand = new Random();
            string valasztott = azonhossz_tomb[rand.Next(azonhossz_tomb.Length)].ToUpper();
            jelenlegi = valasztott;
        }

        public void Vonalak()
        {
            RandomGeneralas();

            for (int i = 0; i < jelenlegi.Length; i++)
            {
                masoltjelenlegi += "_";
            }

            Megjelenites();
        }

        public void Megjelenites()
        {
            for (int i = 0; i < masoltjelenlegi.Length; i++)
            {
                kitalalando.Text += masoltjelenlegi.Substring(i, 1);
                kitalalando.Text += " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {;
            Diagram d = new Diagram(Betuk.eredmenyek3);
            d.Show();
        }

        private void btn_vege_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    
}
