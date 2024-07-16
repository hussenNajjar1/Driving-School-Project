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
    public partial class report_assecc : Form
    {
        BL.Rating prd = new BL.Rating();
        public report_assecc()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_ratings();
        }

        private void report_assecc_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_ratings_singel sport = new RPT.CrystalReport_ratings_singel();

            sport.SetParameterValue("@serch", txt_serch.Text);
            sport.SetParameterValue("@famil", com_gendr.Text);

            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = sport;
            my.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_ratings_singel triner = new RPT.CrystalReport_ratings_singel();

            //انشاء اعدادات التصدير
            ExportOptions export = new ExportOptions();
            //تحديد مكان الحفظ
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions exelformat = new ExcelFormatOptions();

            dfoption.DiskFileName = @"D:\التقييمات.xls";
            export = triner.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = exelformat;

            export.ExportDestinationOptions = dfoption;

            triner.Export();
            MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_ratings_singel bdf = new RPT.CrystalReport_ratings_singel();

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\التقييمات.pdf";
            export = bdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = bdfformat;
            export.ExportDestinationOptions = df;
            bdf.Export();
            MessageBox.Show("تم تصدير الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_rating_ol my_car = new RPT.CrystalReport_rating_ol();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }
    }
}
