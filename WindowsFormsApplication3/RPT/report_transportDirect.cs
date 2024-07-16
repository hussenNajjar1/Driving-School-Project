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
    public partial class report_transportDirect : Form
    {
        BL.Tr prd = new BL.Tr();
        public report_transportDirect()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_sport();
           
        }
      
        private void report_transportDirect_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            //DataTable DT = new DataTable();
            //DT = prd.sport(txt_serch.Text,com_gendr.Text);
            //this.guna2DataGridView1.DataSource = DT;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportSpo sport = new RPT.CrystalReportSpo();
           
            sport.SetParameterValue("@name_dwra", txt_serch.Text);
            sport.SetParameterValue("@famill", com_gendr.Text);

            crestal_report_car my = new crestal_report_car();
            my.crystalReportViewer1.ReportSource = sport;
            my.ShowDialog();
        }

        private void buton_close_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportSpo sport = new RPT.CrystalReportSpo();
            sport.SetParameterValue("@name_dwra", txt_serch.Text);
            sport.SetParameterValue("@famill", com_gendr.Text);

            //انشاء اعدادات التصدير
            ExportOptions export = new ExportOptions();
           
            //تحديد مكان الحفظ
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions exelformat = new ExcelFormatOptions();
           

            dfoption.DiskFileName = @"D:\sport.xls";
            export = sport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = exelformat;

            export.ExportDestinationOptions = dfoption;
            
            sport.Export();
            MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void but_print_car_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportSpo bdf = new RPT.CrystalReportSpo();
            bdf.SetParameterValue("@name_dwra", txt_serch.Text);
            bdf.SetParameterValue("@famill", com_gendr.Text);

            DiskFileDestinationOptions df = new DiskFileDestinationOptions();

            ExportOptions export = new ExportOptions();

            PdfFormatOptions bdfformat = new PdfFormatOptions();
            df.DiskFileName = @"D:\sport.pdf";
            export = bdf.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = bdfformat;
            export.ExportDestinationOptions = df;
            bdf.Export();
            MessageBox.Show("تم تصدير الملف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_Sport_ol my_car = new RPT.CrystalReport_Sport_ol();
            REPORT myy = new REPORT();
            myy.crystalReportViewer1.ReportSource = my_car;
            myy.ShowDialog();
        }

        private void com_gendr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
