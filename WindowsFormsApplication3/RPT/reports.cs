using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            report_car car = new report_car();
            car.ShowDialog();
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            report_triner triner = new report_triner();
            triner.ShowDialog();
        }

        private void buton_close_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            report_transportDirect re = new report_transportDirect();
            re.ShowDialog();
        }

        private void but_report_tr_Click(object sender, EventArgs e)
        {
            report_TR tr = new report_TR();
            tr.Show();
        }

        private void but_report_export_Click(object sender, EventArgs e)
        {
            report_assecc ac = new report_assecc();
            ac.Show();
        }
    }
}
