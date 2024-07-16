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
    public partial class dawra : Form
    {
        BL.dwra_triner prdd = new BL.dwra_triner();
        BL.Dwra prd = new BL.Dwra();
        public dawra()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_dwra();
            
        }

        private void dawra_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم الدورة";
            guna2DataGridView1.Columns[1].HeaderText = "اسم الدورة";
            guna2DataGridView1.Columns[2].HeaderText = "تاريخ البدء";
            guna2DataGridView1.Columns[3].HeaderText = "تاريخ الانتهاء";
            guna2DataGridView1.Columns[4].HeaderText = "سعر الدورة";

        }
        private bool validateinputs()
        {
            if (txt_id.Text == string.Empty || txt_name.Text == string.Empty  )
            {
                txt_id.BackColor = Color.Red;
                txt_name.BackColor = Color.Red;
                DialogResult res = MessageBox.Show("يرجى ملء الحقول المطلوبة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_id.BackColor = Color.White;
                    txt_name.BackColor = Color.White;
                   

                }
                return false;
            }
            return true;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            try
            {
                //للتحقق من عدم تكرار id
                DataTable DT = new DataTable();
                DT = prd.veri_id_dwra(txt_id.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Focus();
                    txt_id.SelectionStart = 0;
                    txt_id.SelectionLength = txt_id.TextLength;
                }

                prd.add_dwra(Convert.ToInt32(txt_id.Text), txt_name.Text,Convert.ToString( txt_date_naw.Value ),Convert.ToString( txt_datre_end.Value),Convert.ToInt32(txt_sal.Text));
                //استدعاء تابع التحديث البيانات
                this.guna2DataGridView1.DataSource = prd.get_dwra();
                MessageBox.Show("تم اضافة الدورة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
                txt_name.Text = "";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
            
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد الدورة المراد حذفها ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("هل تريد بالتأكيد حذف الدورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.delete_dwra(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
      
                this.guna2DataGridView1.DataSource = prd.get_dwra();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            try
            {
                prd.update_dwra(Convert.ToInt32(txt_id.Text), txt_name.Text, Convert.ToString(txt_date_naw.Value), Convert.ToString(txt_datre_end.Value), Convert.ToInt32(txt_sal.Text));
                //استدعاء تابع التحديث البيانات
                this.guna2DataGridView1.DataSource = prd.get_dwra();

                MessageBox.Show("تم تعديل بيانات الدورة بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
                txt_name.Text = "";
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.veri_id_dwra(txt_id.Text);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                txt_id.SelectionStart = 0;
                txt_id.SelectionLength = txt_id.TextLength;
            }
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

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txt_id.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_date_naw.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_datre_end.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_sal.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
