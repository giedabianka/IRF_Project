using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_Gieda_Bianka_FYZINS.Osztalyok
{
    class Betuk : Button
    {
        int kor = 1;
        public static int hiba = 0;

        public static Form1 _frm1;

        public static List<Eredmenyek> eredmenyek3 = new List<Eredmenyek>();
        public Betuk(Form1 frm1)
        {
            _frm1 = frm1;

            Height = 35;
            Width = Height;
            BackColor = Color.White;

            Click += Btn_Click;
        }

        public static void Kepek(Form1 frm1)
        {
            _frm1 = frm1;

            hiba++;

            if (hiba == 0)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_00.png");
            }
            else if (hiba == 1)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_01.png");
            }
            else if (hiba == 2)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_02.png");
            }
            else if (hiba == 3)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_03.png");
            }
            else if (hiba == 4)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_04.png");
            }
            else if (hiba == 5)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_05.png");
            }
            else if (hiba == 6)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_06.png");
            }
            else if (hiba == 7)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_07.png");
            }
            else if (hiba == 8)
            {
                _frm1.pictureBox1.Image = Image.FromFile("akasztofa_08.png");

                //ÚJRATÖLTÉS
                _frm1.hibas_betuk.Text = "";
                Form1.jelenlegi = "";
                Form1.masoltjelenlegi = "";
                _frm1.kitalalando.Text = "";
                hiba = 0;
                _frm1.BetuMatrix();
                _frm1.SzavakHossza();
                _frm1.Vonalak();
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            char[] mtipp = Form1.masoltjelenlegi.ToCharArray();
            char[] jtipp = Form1.jelenlegi.ToCharArray();
            char[] nyero = { '_' };
            string jotipp = "";

            Button betutipp = (Button)sender;

            char[] gomb = betutipp.Text.ToCharArray();

            //A KIVÁLASZTOTT SZÓ TARTALMAZZA A TIPPET
            if (Form1.jelenlegi.Contains(betutipp.Text))
            {
                //ADOTT BETŰ MEGJELENÍTÉSE A VONAL HELYETT
                for (int i = 0; i < jtipp.Length; i++)
                {
                    if (jtipp[i] == gomb[0])
                    {
                        mtipp[i] = gomb[0];                        
                    }
                }

                Form1.masoltjelenlegi = new string(mtipp);
                _frm1.kitalalando.Text = "";

                //ADOTT SZÁMÚ VONAL MEGJELENÍTÉSE
                for (int i = 0; i < Form1.masoltjelenlegi.Length; i++)
                {
                    _frm1.kitalalando.Text += Form1.masoltjelenlegi.Substring(i, 1);
                    _frm1.kitalalando.Text += " ";
                    jotipp += Form1.masoltjelenlegi.Substring(i, 1);
                }

                //HA NYERSZ
                if (jotipp == Form1.jelenlegi)
                {
                    Eredmenyek ered = new Eredmenyek();

                    if (Form1.kivbetuszam == 3)
                    {
                        ered.pontokszama = 30;
                    }
                    else if (Form1.kivbetuszam == 4)
                    {
                        ered.pontokszama = 40;
                    }
                    else if (Form1.kivbetuszam == 5)
                    {
                        ered.pontokszama = 50;
                    }
                    else if (Form1.kivbetuszam == 6)
                    {
                        ered.pontokszama = 60;
                    }
                    else if (Form1.kivbetuszam == 7)
                    {
                        ered.pontokszama = 70;
                    }
                    
                    ered.korokszama = kor;
                    eredmenyek3.Add(ered);

                    kor++;

                    //ÚJRATÖLTÉS
                    _frm1.hibas_betuk.Text = "";
                    Form1.jelenlegi = "";
                    Form1.masoltjelenlegi = "";
                    _frm1.kitalalando.Text = "";
                    hiba = 0;
                    _frm1.BetuMatrix();
                    _frm1.SzavakHossza();
                    _frm1.Vonalak();

                }
                                  
                //betutipp.Visible = false;
            }

            //ROSSZ TIPPEK
            else
            {
                //betutipp.Visible = false;
                _frm1.hibas_betuk.Text += (betutipp.Text) + (" ");
                Kepek(_frm1);
            }
        }

    }
}
