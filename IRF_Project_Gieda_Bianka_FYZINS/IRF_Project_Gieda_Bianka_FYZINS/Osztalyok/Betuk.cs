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
        public Betuk()
        {
            Height = 35;
            Width = Height;
            BackColor = Color.White;

            Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            char[] mtipp = Form1.masoltjelenlegi.ToCharArray();
            char[] jtipp = Form1.jelenlegi.ToCharArray();
            char[] nyero = { '_' };

            Button betutipp = (Button)sender;

            char[] gomb = betutipp.Text.ToCharArray();

            if (Form1.jelenlegi.Contains(betutipp.Text))
            {
                for (int i = 0; i < jtipp.Length; i++)
                {
                    if (jtipp[i] == gomb[0])
                    {
                        mtipp[i] = gomb[0];
                    }
                }

                Form1.masoltjelenlegi = new string(mtipp);

                Form1.kitalalando.Text = "";

                for (int i = 0; i < Form1.masoltjelenlegi.Length; i++)
                {
                    Form1.kitalalando.Text += Form1.masoltjelenlegi.Substring(i, 1);
                    Form1.kitalalando.Text += " ";
                }
            }
        }



    }
}
