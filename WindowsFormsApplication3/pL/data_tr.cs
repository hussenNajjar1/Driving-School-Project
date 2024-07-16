using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class data_tr : Form
    {
        BL.import prd = new BL.import();
        public data_tr()
        {
            InitializeComponent();
            this.data_data_tr.DataSource = prd.data_tr();
            this.data_data_tr.Columns[4].Visible = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_tr_Load(object sender, EventArgs e)
        {
            data_data_tr.Columns[0].HeaderText = "رقم المتدرب ";
            data_data_tr.Columns[1].HeaderText = "اسم المتدرب";
            data_data_tr.Columns[2].HeaderText = " رقم الدورة";
            data_data_tr.Columns[3].HeaderText = "القسط";
            data_data_tr.Columns[4].HeaderText = " المبلغ المدفوع ";
        }

        private void data_data_tr_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_data_tr(txt_serch.Text);
            this.data_data_tr.DataSource = DT;
        }
    }
}
