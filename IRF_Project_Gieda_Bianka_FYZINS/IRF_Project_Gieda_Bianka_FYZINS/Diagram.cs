using IRF_Project_Gieda_Bianka_FYZINS.Osztalyok;
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
    public partial class Diagram : Form
    {
        List<Eredmenyek> eredmenyek = new List<Eredmenyek>();

        public Diagram()
        {
            InitializeComponent();
            ListaFeltoltes();
            EredmenyDiagram();
        }

        private void ListaFeltoltes()
        {
            eredmenyek.Add(new Eredmenyek
            {
                korokszama = 1,
                pontokszama = 65,
            });

            eredmenyek.Add(new Eredmenyek
            {
                korokszama = 2,
                pontokszama = 80,
            });

            eredmenyek.Add(new Eredmenyek
            {
                korokszama = 3,
                pontokszama = 40,
            });

            foreach (var eredmeny in eredmenyek)
            {
                Console.WriteLine(eredmeny.korokszama);
                Console.WriteLine(eredmeny.pontokszama);
            }
        }
        
        private void EredmenyDiagram()
        {
            DiagramChart.DataSource = eredmenyek;

            var series = DiagramChart.Series[0];
            series.XValueMember = "korokszama";
            series.YValueMembers = "pontokszama";

            var chartArea = DiagramChart.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }


        private void Diagram_Load(object sender, EventArgs e)
        {
        }
    }
}
