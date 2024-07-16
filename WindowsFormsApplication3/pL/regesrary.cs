using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class regesrary : Form
    {
        BL.Rejestery prd = new BL.Rejestery();
       

        public regesrary()
        {
            InitializeComponent();
           
            this.guna2DataGridView1.DataSource = prd.get_regestry();
            guna2DataGridView1.Columns[0].Visible = false;





            //جلب اسماء الدورات ووضعهم في الكومبوبكس
            com_name_dwra.DataSource = prd.get_name_dwra();
            com_name_dwra.DisplayMember = "name_dwra";
            com_name_dwra.ValueMember = "id_dwra";

           

            //جلب اسماء المتدبين ووضعهم في الكومبوبكس
            com_name_t.DataSource = prd.get_name_tr();
            com_name_t.DisplayMember = "full_name";
            com_name_t.ValueMember = "id_tr";
        }
      
        private bool validateinputs()
        {
            if ( com_name_dwra.Text == string.Empty || com_name_t.Text == string.Empty || com_type.Text == string.Empty)
            {

                com_type.BackColor= Color.Red;
                com_name_t.BackColor = Color.Red;
                com_name_dwra.BackColor = Color.Red;
                DialogResult res = MessageBox.Show("يرجى تعبئة الحقول المطلوبة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                  
                    com_name_dwra.BackColor = Color.White;
                    com_name_t.BackColor = Color.White;
                    com_type.BackColor = Color.White;



                }
                return false;
            }
            return true;
        }
       

        void cler()
        {


            com_name_dwra.SelectedIndex = -1;
            com_name_t.SelectedIndex = -1;

            com_type.SelectedIndex=-1;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            add_castemor d = new add_castemor();
            d.ShowDialog();
        }

        private void regesrary_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = " الرقم";
            guna2DataGridView1.Columns[1].HeaderText = "اسم المتدرب";
            guna2DataGridView1.Columns[2].HeaderText = "اسم الدورة";
            guna2DataGridView1.Columns[3].HeaderText = "نوع الرخصة";
            guna2DataGridView1.Columns[4].HeaderText = "تاريخ التسجيل";
        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateinputs()) return;
                for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[1].Value.ToString() == com_name_t.Text)
                    {
                        if (guna2DataGridView1.Rows[i].Cells[2].Value.ToString() == com_name_dwra.Text)
                        {
                            MessageBox.Show("هذا المدرب تم اضافته مسبقا في هذه الدورة", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                prd.add_regestry(Convert.ToInt32(com_name_t.SelectedValue), Convert.ToInt32(com_name_dwra.SelectedValue), com_type.Text, Convert.ToString(txt_date_naw.Value));
                MessageBox.Show("تم اضافة بيانات تسجيل المتدرب بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.guna2DataGridView1.DataSource = prd.get_regestry();
                cler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }

        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[1].Value.ToString() == com_name_t.Text)
                    {
                        if (guna2DataGridView1.Rows[i].Cells[2].Value.ToString() == com_name_dwra.Text)
                        {
                            MessageBox.Show("هذا المدرب تم اضافته مسبقا في هذه الدورة", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                //but_add.Visible = true;
               
                    if (guna2DataGridView1.SelectedRows.Count < 1) return;
                    string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prd.update_regestry(Convert.ToInt32( id),Convert.ToInt32(com_name_t.SelectedValue), Convert.ToInt32(com_name_dwra.SelectedValue), com_type.Text, Convert.ToString(txt_date_naw.Value));
                    this.guna2DataGridView1.DataSource = prd.get_regestry();
                  
                   cler();
            }
            else
            {
                cler();
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            com_name_t.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            com_name_dwra.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            com_type.Text =  this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_date_naw.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد المتدرب المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات التسجيل المحددة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                prd.delete_reg(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                this.guna2DataGridView1.DataSource = prd.get_regestry();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_ex(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void but_serch_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_ex_name(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_ex_name(txt_serch_name.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void com_name_t_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void com_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //جلب اسماء المتدبين ووضعهم في الكومبوبكس
            com_name_t.DataSource = prd.get_name_tr();
            com_name_t.DisplayMember = "full_name";
            com_name_t.ValueMember = "id_tr";
        }
    }
}