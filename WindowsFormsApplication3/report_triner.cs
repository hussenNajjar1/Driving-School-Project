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
    public partial class report_triner : Form
    {
        BL.Trainer prd = new BL.Trainer();
        public report_triner()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_triner();
           
        }

        private void report_triner_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportTRINER_OL triner = new RPT.CrystalReportTRINER_OL();
            crestal_report_car myy = new crestal_report_car();
            myy.crystalReportViewer1.Refresh();
            myy.crystalReportViewer1.ReportSource = triner;
           


            myy.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportTRINER_SINGL mycar = new RPT.CrystalReportTRINER_SINGL();
            mycar.SetParameterValue("@id", this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = mycar;
            my.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            RPT.CrystalReportTRINER_OL triner = new RPT.CrystalReportTRINER_OL();

            //انشاء اعدادات التصدير
            ExportOptions export = new ExportOptions();
            //تحديد مكان الحفظ
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions exelformat = new ExcelFormatOptions();

            dfoption.DiskFileName = @"D:\triner.xls";
            export = triner.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = exelformat;

            export.ExportDestinationOptions = dfoption;

            triner.Export();
            MessageBox.Show("تم الحفظ الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buton_close_Click(object sender, EventArgs e)
        {

        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportTRINER_OL bdf = new RPT.CrystalReportTRINER_OL();

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\TRINER.pdf";
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
