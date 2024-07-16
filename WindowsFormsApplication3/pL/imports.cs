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
    public partial class imports : Form
    {
        BL.import prd = new BL.import();
        public imports()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_import();
            //this.guna2DataGridView1.Columns[7].Visible = false;
            guna2DataGridView1.Columns[0].Visible = true;
            guna2DataGridView1.Columns[8].Visible = false;
            guna2DataGridView1.Columns[1].Width = 220;
            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
            txt_sum.Text = prd.summm().Rows[0][0].ToString();
           
        }
        void sum()
        {
            if (txt_amount_full.Text != string.Empty)
            {
                double amount = Convert.ToDouble(txt_amount_full);
            }

        }
        void seltt()
        {
            if (txt_amount_full.Text != string.Empty||txt_seltt.Text!=string.Empty)
            {
                decimal dis =Convert.ToDecimal( txt_seltt.Text);
                decimal amount = Convert.ToDecimal(txt_amount_full.Text);
                decimal total = amount - (amount * (dis / 100));
                txt_amount.Text = total.ToString();
            }
        }
        private bool validateinputs()
        {
            if (txt_id.Text == string.Empty || txt_name.Text == string.Empty || txt_amount.Text == string.Empty || txt_amount_full.Text == string.Empty || txt_seltt.Text == string.Empty || txt_id_tr.Text == string.Empty )
            {
                txt_id.BackColor = Color.Red;
                txt_name.BackColor = Color.Red;
                txt_amount_full.BackColor = Color.Red;
                txt_amount.BackColor = Color.Red;

                txt_id_tr.BackColor = Color.Red;
                txt_seltt.BackColor = Color.Red;
                
                DialogResult res = MessageBox.Show("يرجى ادخال البيانات المطلوبة ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_id.BackColor = Color.White;
                    txt_name.BackColor = Color.White;
                    txt_amount_full.BackColor = Color.White;
                    txt_amount.BackColor = Color.White;

                    txt_id_tr.BackColor = Color.White;
                    txt_seltt.BackColor = Color.White;
                }
                return false;
            }
            return true;
        }
        public void cler()
        {
            txt_id.Clear();
            txt_id_tr.Clear();
            txt_name.Clear();
            txt_seltt.Clear();
            txt_name_dwra.Clear();
            txt_coment.Clear();
            txt_amount_full.Clear();
            txt_amount.Clear();
            pictur_image.Image = null;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void imports_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            main abd = new main();
            this.Hide();
            abd.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

            data_tr neww = new data_tr();
            neww.ShowDialog();

            if (neww.data_data_tr.CurrentRow.Cells[4].Value is DBNull)
            {
                MessageBox.Show("هذا المدرب لا يوجد له صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_id_tr.Text = neww.data_data_tr.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = neww.data_data_tr.CurrentRow.Cells[1].Value.ToString();
                txt_name_dwra.Text = neww.data_data_tr.CurrentRow.Cells[2].Value.ToString();
                pictur_image.Image = null;
                txt_amount_full.Text = prd.get_sal_dwra(Convert.ToInt32(txt_id_tr.Text)).Rows[0][0].ToString();


            }
            else
            {
                txt_id_tr.Text = neww.data_data_tr.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = neww.data_data_tr.CurrentRow.Cells[1].Value.ToString();
                txt_name_dwra.Text = neww.data_data_tr.CurrentRow.Cells[2].Value.ToString();
                byte[] cust = (byte[])neww.data_data_tr.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(cust);
                pictur_image.Image = Image.FromStream(ms);
                txt_amount_full.Text = prd.get_sal_dwra(Convert.ToInt32(txt_id_tr.Text)).Rows[0][0].ToString();
            }

        }

        private void but_maxmm_Click(object sender, EventArgs e)
        {
           
        }

        private void buton_close_Click(object sender, EventArgs e)
        {
           

            
          
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        { try
            {
                if (!validateinputs()) return;
                for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[1].Value.ToString() == txt_name.Text)
                    {
                        if (guna2DataGridView1.Rows[i].Cells[2].Value.ToString() == txt_name_dwra.Text)
                        {
                            MessageBox.Show("هذا المدرب تم اضافته مسبقا في هذه الدورة", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                prd.add_import(Convert.ToInt32(txt_id.Text),Convert.ToDecimal( txt_amount_full.Text), Convert.ToDecimal( txt_amount.Text), txt_seltt.Text, txt_coment.Text, Convert.ToString(date_add.Value), Convert.ToInt32(txt_id_tr.Text));
               
                cler();
                this.guna2DataGridView1.DataSource = prd.get_import();
                this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                txt_sum.Text = prd.summm().Rows[0][0].ToString();
               
                txt_sum.Text = prd.summmmmmmmm().Rows[0][0].ToString();
                MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }

        }

        private void txt_amount_full_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter &&txt_amount_full.Text !=string.Empty)
            {
                txt_seltt.Focus();
            }
        }

        private void txt_seltt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                txt_amount.Focus();
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void txt_seltt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            seltt();
        }

        private void txt_seltt_KeyUp(object sender, KeyEventArgs e)
        {
            seltt();
        }

        private void txt_amount_full_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            RPT.CrystalRepor_print_import_singel my = new RPT.CrystalRepor_print_import_singel();
            my.SetParameterValue("@id", this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.print myform = new RPT.print();
            myform.crystalReportViewer1.ReportSource = my;
           
            myform.ShowDialog();
          
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            
                
      
            DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {

                   

                    prd.updet_import(Convert.ToInt32(txt_id.Text), txt_amount_full.Text, txt_amount.Text, txt_seltt.Text, txt_coment.Text, Convert.ToString(date_add.Value), Convert.ToInt32(txt_id_tr.Text));
                    this.guna2DataGridView1.DataSource = prd.get_import();
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id.Clear();
                    txt_id_tr.Clear();
                    txt_name.Clear();
                    txt_seltt.Clear();
                    txt_name_dwra.Clear();
                    txt_coment.Clear();
                    txt_amount_full.Clear();
                    txt_amount.Clear();
                    pictur_image.Image = null;
                    this.guna2DataGridView1.DataSource = prd.get_import();
                    this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                    txt_sum.Text = prd.summm().Rows[0][0].ToString();
                    txt_sum.Text = prd.summmmmmmmm().Rows[0][0].ToString();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطا" + ex);

                }
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_delete_Click(object sender, EventArgs e)
        { try
            {
                if (guna2DataGridView1.SelectedRows.Count < 1)
                {
                    DialogResult res = MessageBox.Show("يرجى تحديد الوصل المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    if (res == DialogResult.OK)
                        return;
                }
                   
                if (MessageBox.Show("هل تريد بالتأكيد حذف الوصل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.delete_tr(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                    this.guna2DataGridView1.DataSource = prd.get_import();
                    MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_sum.Text = prd.summm().Rows[0][0].ToString();

                    txt_sum.Text = prd.summmmmmmmm().Rows[0][0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);

            }
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_amount_full_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            DataTable DT = new DataTable();
            DT = prd.serch_import(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
            guna2DataGridView1.Columns[1].Width = 220;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_sum.Text = prd.summmmmmmmm().Rows[0][0].ToString();
        }

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txt_id.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_name_dwra.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_amount_full.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_seltt.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_amount.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_coment.Text = this.guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            date_add.Text = this.guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_id_tr.Text = this.guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void txt_sum_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void but_report_export_Click(object sender, EventArgs e)
        {
            report_imports im = new report_imports();
            im.ShowDialog();

        }
    }
}
