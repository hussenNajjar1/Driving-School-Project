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
    public partial class report_export : Form
    {
        BL.Exports prd = new BL.Exports();
        public report_export()
        {
            InitializeComponent();
            //جلب اسماء سبب الدفع ووضعهم في الكومبوبكس
            com_pp.DataSource = prd.get_name_rate();
            com_pp.DisplayMember = "name_m";
            com_pp.ValueMember = "id_m";
            guna2DataGridView1.DataSource = prd.get_exports();
        }

        private void report_export_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_export_ol my_car = new RPT.CrystalReport_export_ol();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_expo sport = new RPT.CrystalReport_expo();
           


            sport.SetParameterValue("@namee", com_pp.Text);
            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = sport;
            my.ShowDialog();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
