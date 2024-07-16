using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace WindowsFormsApplication3
{
    public partial class report_imports : Form
    {
        BL.import prd = new BL.import();
        public report_imports()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = prd.get_import();
            guna2DataGridView1.Columns[8].Visible = false;
            guna2DataGridView1.Columns[1].Width = 220;
        }

        private void report_imports_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم الوصل";
            guna2DataGridView1.Columns[1].HeaderText = "اسم المتدرب";
            guna2DataGridView1.Columns[2].HeaderText = "رقم الدورة";
            guna2DataGridView1.Columns[3].HeaderText = " المبلغ الكامل";
            guna2DataGridView1.Columns[4].HeaderText = "حسم  ";
            guna2DataGridView1.Columns[5].HeaderText = " المبلغ المدفوع ";
            guna2DataGridView1.Columns[6].HeaderText = " ملاحظات";
            guna2DataGridView1.Columns[7].HeaderText = " تاريخ الدفع";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_import_ol my_car = new RPT.CrystalReport_import_ol();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_imort_singl sport = new RPT.CrystalReport_imort_singl();

            sport.SetParameterValue("@data_start", txt_date_th.Text);
            sport.SetParameterValue("@data_end", guna2DateTimePicker1.Text);
            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = sport;
            my.ShowDialog();
        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_imort_singl bdf = new RPT.CrystalReport_imort_singl();
            bdf.SetParameterValue("@data_start", txt_date_th.Text);
            bdf.SetParameterValue("@data_end", guna2DateTimePicker1.Text);

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\import.pdf";
            export = bdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = bdfformat;
            export.ExportDestinationOptions = df;
            bdf.Export();
            MessageBox.Show("تم تصدير الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
