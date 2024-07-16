using iTextSharp.text;
using iTextSharp.text.pdf;
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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication3
{
    public partial class report_car : Form
    {
        BL.C_cars prd = new BL.C_cars();
        public report_car()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_car();
            this.guna2DataGridView1.Columns[5].Visible = false;
        }

        private void report_car_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم السيارة";
            guna2DataGridView1.Columns[1].HeaderText = "اسم السيارة";
            guna2DataGridView1.Columns[2].HeaderText = "نوع السيارة";
            guna2DataGridView1.Columns[3].HeaderText = "رقم اللوحة";
            guna2DataGridView1.Columns[4].HeaderText = "اسم المستلم";
            guna2DataGridView1.Columns[5].HeaderText = "الجاهزية ";
        }

        private void buton_close_Click(object sender, EventArgs e)
        {
            
        }

        private void but_maxmm_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.report_car_singl mycar = new RPT.report_car_singl();
            mycar.SetParameterValue("@id", this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = mycar;
            my.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_ol_car my_car = new RPT.CrystalReport_ol_car();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_ol_car bdf= new RPT.CrystalReport_ol_car();

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\car.pdf";
            export = bdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = bdfformat;
            export.ExportDestinationOptions = df;
            bdf.Export();
            MessageBox.Show("تم تصدير الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

           




            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

  
    
}
