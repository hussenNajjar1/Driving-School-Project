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
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class exports : Form
    {
        BL.payman prddd = new BL.payman();
        BL.Exports prd = new BL.Exports();
        public exports()
        {
            InitializeComponent();
            
            this.guna2DataGridView1.DataSource = prd.get_exports();
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.Columns[1].Width = 180;
            //جلب اسماء سبب الدفع ووضعهم في الكومبوبكس
            com_pp.DataSource = prd.get_name_rate();
            com_pp.DisplayMember = "name_m";
            com_pp.ValueMember = "id_m";
        }
        private bool validateinputs()
        {
            if (txt_name.Text == string.Empty || txt_amont_d.Text == string.Empty || txt_amont_t.Text == string.Empty || txt_reate.Text == string.Empty || txt_city.Text == string.Empty) 
            {
                txt_name.BackColor = Color.Red;
                txt_amont_d.BackColor = Color.Red;
                txt_amont_t.BackColor = Color.Red;
                txt_reate.BackColor = Color.Red;

                txt_city.BackColor = Color.Red;


                DialogResult res = MessageBox.Show("يرجى ادخال البيانات المطلوبة ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_name.BackColor = Color.White;
                    txt_amont_d.BackColor = Color.White;
                    txt_amont_t.BackColor = Color.White;
                    txt_reate.BackColor = Color.White;

                    txt_city.BackColor = Color.White;

                }
                return false;
            }
            return true;
        }
        public void cler()
        {
            txt_name.Clear();
            txt_amont_d.Clear(); 
            txt_amont_t.Clear(); 
            txt_reate.Clear();
            txt_city.Clear();
            txt_mm.Clear();
            com_pp.SelectedValue=-1;
            
        }

        private void exports_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
           
            try
            {
                DataTable DT = prd.get_sum_import();

                if (DT.Rows.Count > 0)
                {
                   

                    decimal sum_import = Convert.ToDecimal(prd.get_sum_import().Rows[0][0]);
                    decimal sum_export = Convert.ToDecimal(prd.get_sum_export().Rows[0][0]);

                    decimal amount = sum_import - sum_export;
                    if (Convert.ToDecimal(txt_amont_d.Text) >= Convert.ToDecimal(amount))
                    {
                        MessageBox.Show("الكمية غير كافية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                   

                    prd.add_export(txt_name.Text, Convert.ToDecimal(txt_amont_d.Text), Convert.ToDecimal(txt_amont_t.Text), txt_reate.Text, Convert.ToString(com_pp.SelectedValue), txt_city.Text, Convert.ToString(data_ex.Value), txt_mm.Text);
                    this.guna2DataGridView1.DataSource = prd.get_exports();
                    cler();
                    MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //لتحديث مجموع الصادرات
                    txt_sum.Text = prd.get_sum().Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("الكمية غير كافية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            if (!validateinputs()) return;

            try
            {
              string aa=  guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //but_add.Visible = true;
                DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    decimal sum_import = Convert.ToDecimal(prd.get_sum_import().Rows[0][0]);
                    decimal sum_export = Convert.ToDecimal(prd.get_sum_export().Rows[0][0]);

                    decimal amount = sum_import - sum_export;
                    decimal bb =Convert.ToDecimal( aa) +Convert.ToDecimal( amount);
                    if (Convert.ToDecimal(txt_amont_d.Text) >= Convert.ToDecimal(bb))
                    {
                        MessageBox.Show("الكمية غير كافية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (guna2DataGridView1.SelectedRows.Count < 1) return;
                    string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    prd.updet_expors( id, txt_name.Text,Convert.ToDecimal( txt_amont_d.Text),Convert.ToDecimal( txt_amont_t.Text), txt_reate.Text, Convert.ToString(com_pp.SelectedValue), txt_city.Text, Convert.ToString(data_ex.Value), txt_mm.Text);
                    this.guna2DataGridView1.DataSource = prd.get_exports();
                    cler();
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //لتحديث مجموع الصادرات
                   txt_sum.Text =prd.get_sum().Rows[0][0].ToString();
                }
                else
                {
                    cler();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1.SelectedRows.Count < 1)
                {
                    DialogResult res = MessageBox.Show("يرجى تحديد الوصل المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    if (res == DialogResult.OK)
                        return;
                }
                if (MessageBox.Show("هل تريد بالتأكيد حذف الوصل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.delete_ex(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                    this.guna2DataGridView1.DataSource = prd.get_exports();
                    MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ////لتحديث مجموع الصادرات
                    txt_sum.Text = prd.get_sum().Rows[0][0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            paym p = new paym();
            p.ShowDialog();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
            txt_sum.Text = prd.get_sum().Rows[0][0].ToString();
            
          
        }

        private void txt_amont_d_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_amont_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&e.KeyChar !=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
          
        }

        private void txt_amont_t_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            paym p = new paym();
         p.dataGridView1.DataSource=prddd.get_paymant();
            //جلب اسماء سبب الدفع ووضعهم في الكومبوبكس
            com_pp.DataSource = prd.get_name_rate();
            com_pp.DisplayMember = "name_m";
            com_pp.ValueMember = "id_m";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_ex(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.sum_serch_ex(txt_serch.Text);
            prd.sum_serch_ex(txt_serch.Text);
            txt_sum_serch.Text = prd.sum_serch_ex(txt_serch.Text).ToString();
        }

        private void txt_sum_serch_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_sum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_amont_d_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt_amont_d_Validated(object sender, EventArgs e)
        {
           
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

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index = guna2DataGridView1.SelectedRows[0].Index;
            if (index != -1)
            {
                txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_amont_d.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_amont_t.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_reate.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                com_pp.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_city.Text = this.guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                data_ex.Text = this.guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_mm.Text = this.guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                //but_add.Visible = false;
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_report_export_Click(object sender, EventArgs e)
        {
            report_export ex = new report_export();
            ex.ShowDialog();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport_print_ex my = new RPT.CrystalReport_print_ex();
            my.SetParameterValue("@id", this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.print myform = new RPT.print();
            myform.crystalReportViewer1.ReportSource = my;

            myform.ShowDialog();
        }
    }
}
