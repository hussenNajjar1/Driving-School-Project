using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication3
{
    public partial class agent : Form
    {
        BL.Agent prd = new BL.Agent();
        public agent()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_agent();
        }
        private bool validateinputs()
        {
            if (txt_id.Text == string.Empty || txt_name.Text == string.Empty || txt_ephon.Text == string.Empty || txt_loc.Text == string.Empty || txt_jop.Text == string.Empty)
            {
                txt_id.BackColor = Color.Red;
                txt_name.BackColor = Color.Red;
                txt_ephon.BackColor = Color.Red;
                txt_loc.BackColor = Color.Red;
                txt_jop.BackColor = Color.Red;
                DialogResult res = MessageBox.Show("مستخدم جديد", "يرجى ملء الحقول المطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_id.BackColor = Color.White;
                    txt_name.BackColor = Color.White;
                    txt_ephon.BackColor = Color.White;
                    txt_loc.BackColor = Color.White;
                    txt_jop.BackColor = Color.White;

                }
                return false;
            }
            return true;
        }
        public void cler()
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    c.Text = "";
        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void agent_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم الوكيل";
            guna2DataGridView1.Columns[1].HeaderText = "اسم الوكيل ";
            guna2DataGridView1.Columns[2].HeaderText = "رقم الهاتف";
            guna2DataGridView1.Columns[3].HeaderText = "عنوان ";
            guna2DataGridView1.Columns[4].HeaderText = "نوع العمل";
            guna2DataGridView1.Columns[0].Width = 80;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
        //    if (!validateinputs()) return;
        //    try
        //    {
        //        prd.add_agent(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_ephon.Text, txt_loc.Text, txt_jop.Text);
        //        //استدعاء تابع التحديث البيانات
        //        this.guna2DataGridView1.DataSource = prd.get_agent();
        //        txt_id.Text = "";
        //        txt_name.Text = "";
        //        txt_ephon.Text = "";
        //        txt_loc.Text = "";
        //        txt_jop.Text = "";
        //        MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        cler();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حدث خطا" + ex);
        //    }
            // التحقق من صحة الإدخالات

            if (!validateinputs())
            {
                MessageBox.Show("الرجاء التحقق من صحة الإدخالات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // استخدام متغيرات لتخزين القيم من حقول الإدخال
                int agentId = Convert.ToInt32(txt_id.Text);
                string agentName = txt_name.Text;
                string agentPhone = txt_ephon.Text;
                string agentLocation = txt_loc.Text;
                string agentJob = txt_jop.Text;

                // إضافة وكيل جديد
                prd.add_agent(agentId, agentName, agentPhone, agentLocation, agentJob);

                // تحديث مصدر البيانات للجدول
                this.guna2DataGridView1.DataSource = prd.get_agent();

                // مسح حقول الإدخال
                txt_id.Text = "";
                txt_name.Text = "";
                txt_ephon.Text = "";
                txt_loc.Text = "";
                txt_jop.Text = "";

                MessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // استدعاء دالة لمسح أي بيانات إضافية إذا كان ذلك ضروريًا
                cler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        
    }

        private void but_delete_Click(object sender, EventArgs e)
        {
          //  if (guna2DataGridView1.SelectedRows.Count == -1)
          //  {
          //      MessageBox.Show("                      يرجى تحديد الوكيل", "حذف", MessageBoxButtons.OK,
          //MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, options: MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
          //  }
          //  else
          //  {
          //      if (MessageBox.Show("هل تريد بالتأكيد حذف الوكيل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          //      {
          //          prd.delete_agent(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
          //          MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //          this.guna2DataGridView1.DataSource = prd.get_agent();
          //      }
          //      else
          //      {

          //          MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //      }
          //  }


            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد وكيل للحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل تريد بالتأكيد حذف الوكيل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    string agentIdToDelete = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();

                    try
                    {
                        prd.delete_agent(agentIdToDelete);
                        MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // تحديث مصدر البيانات للجدول
                        this.guna2DataGridView1.DataSource = prd.get_agent();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("تم إلغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }





        }
        //بحث عن وكيل
        private void txt_serch_TextChanged(object sender, EventArgs e)
        {

            //DataTable DT = new DataTable();
            //DT = prd.serch_agent(txt_serch.Text);
            //this.guna2DataGridView1.DataSource = DT;


            // إنشاء DataTable لتخزين نتائج البحث
            DataTable DT = new DataTable();

            try
            {
                // قم بالبحث باستخدام القيمة الموجودة في txt_serch وقم بتخزين النتائج في DataTable
                DT = prd.serch_agent(txt_serch.Text);

                // قم بتحديث مصدر البيانات لـ guna2DataGridView1 لعرض النتائج
                this.guna2DataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                // في حالة حدوث خطأ أثناء البحث
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.veri_id(txt_id.Text);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                txt_id.SelectionStart = 0;
                txt_id.SelectionLength = txt_id.TextLength;
            }
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            try
            {
                prd.updet_agent(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_ephon.Text, txt_loc.Text, txt_jop.Text);
                //استدعاء تابع التحديث البيانات
                this.guna2DataGridView1.DataSource = prd.get_agent();

                MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
                txt_name.Text = "";
                txt_ephon.Text = "";
                txt_loc.Text = "";
                txt_jop.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&e.KeyChar!=Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
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

        private void but_serche_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txt_id.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ephon.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_loc.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_jop.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
