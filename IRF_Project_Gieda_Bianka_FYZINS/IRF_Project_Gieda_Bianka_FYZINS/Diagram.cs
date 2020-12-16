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
        int[] eredmenyek = {25, 50, 100, 65, 80};

        public Diagram()
        {
            InitializeComponent();
        }

        private void Eredmenyek()
        {
            chart1.DataSource = eredmenyek;
        }





        private void Diagram_Load(object sender, EventArgs e)
        {
        }
    }
}
