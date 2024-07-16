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
    public partial class report_TR : Form
    {
        BL.Tr prd = new BL.Tr();
        public report_TR()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = prd.get_trt();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_TR_OL triner = new RPT.CrystalReport_TR_OL();

            //انشاء اعدادات التصدير
            ExportOptions export = new ExportOptions();
            //تحديد مكان الحفظ
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions exelformat = new ExcelFormatOptions();

            dfoption.DiskFileName = @"D:\متدربين.xls";
            export = triner.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = exelformat;

            export.ExportDestinationOptions = dfoption;

            triner.Export();
            MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void report_TR_Load(object sender, EventArgs e)
        {

            guna2DataGridView1.Columns[0].HeaderText = " اسم المتدرب";
            guna2DataGridView1.Columns[1].HeaderText = " تاريخ الولادة";
            guna2DataGridView1.Columns[2].HeaderText = "مكان الاقامة";
            guna2DataGridView1.Columns[3].HeaderText = "رقم الهاتف ";
            guna2DataGridView1.Columns[4].HeaderText = "  رقم الدورة";
            guna2DataGridView1.Columns[5].HeaderText = "  نوع الرخصة";
            guna2DataGridView1.Columns[6].HeaderText = " تاريخ التسجيل ";
            guna2DataGridView1.Columns[7].HeaderText = " الترشيح";


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_TR_OL my_car = new RPT.CrystalReport_TR_OL();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_TR_OL bdf = new RPT.CrystalReport_TR_OL();

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\المتدربين.pdf";
            export = bdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = bdfformat;
            export.ExportDestinationOptions = df;
            bdf.Export();
            MessageBox.Show("تم تصدير الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_tr_singl sport = new RPT.CrystalReport_tr_singl();

            sport.SetParameterValue("@name_dwra", txt_serch.Text);
            sport.SetParameterValue("@famil", com_gendr.Text);

            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = sport;
            my.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
