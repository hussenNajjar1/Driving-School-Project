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
    public partial class users : Form
    {
        BL.Users prd = new BL.Users();
        public users()
        {
            InitializeComponent();
            
            this.guna2DataGridView1.DataSource = prd.get_user();
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.Columns[1].Width = 220;
            guna2DataGridView1.Columns[6].Width = 170;
            guna2DataGridView1.Columns[0].HeaderText = "رقم المستخدم";
            guna2DataGridView1.Columns[1].HeaderText = "اسم المستخدم";
            guna2DataGridView1.Columns[2].HeaderText = "رقم الهاتف";
            guna2DataGridView1.Columns[3].HeaderText = "موقع المستخدم";
            guna2DataGridView1.Columns[4].HeaderText = "اسم الحساب";
            guna2DataGridView1.Columns[5].HeaderText = "كلمة المرور";
            guna2DataGridView1.Columns[6].HeaderText = "نوع المستخدم";
        }
        private bool validateinputs()
        {
            if (txt_name.Text == string.Empty || txt_ephon.Text == string.Empty || txt_loc.Text == string.Empty || txt_username.Text == string.Empty || txt_password.Text == string.Empty || com_type.Text == string.Empty)
            {
                txt_name.BackColor = Color.Red;
                txt_ephon.BackColor = Color.Red;
                txt_loc.BackColor = Color.Red;
                txt_username.BackColor = Color.Red;

                txt_password.BackColor = Color.Red;
                com_type.BackColor = Color.Red;

                DialogResult res = MessageBox.Show("يرجى ادخال البيانات المطلوبة ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_name.BackColor = Color.White;
                    txt_ephon.BackColor = Color.White;
                    txt_loc.BackColor = Color.White;
                    txt_username.BackColor = Color.White;

                    txt_password.BackColor = Color.White;
                    com_type.BackColor = Color.White;
                }
                return false;
            }
            return true;
        }
        public void cler()
        {
            txt_name.Clear();
            txt_ephon.Clear();
            txt_loc.Clear();
            txt_username.Clear();
            txt_password.Clear();
            com_type.SelectedIndex=-1;
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد المستخدم المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            else
            {
                if (MessageBox.Show("هل تريد بالتأكيد حذف المستخدم", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.delete_user(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم حذف المستخدم بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.guna2DataGridView1.DataSource = prd.get_user();
                }
                else
                {

                    MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل على بيانات المستخدم؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
               
                
                but1_add.Visible = true;

                if (guna2DataGridView1.SelectedRows.Count < 1) return;
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prd.update_user(id,txt_name.Text, txt_ephon.Text,txt_loc.Text,txt_username.Text,txt_password.Text, com_type.Text);
                this.guna2DataGridView1.DataSource = prd.get_user();

                cler();
            }
            else
            {
                cler();
            }
        }

        private void users_Load(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {


            if (!validateinputs()) return;
            try
            {


                prd.add_user( txt_name.Text, txt_ephon.Text, txt_loc.Text, txt_username.Text, txt_password.Text, com_type.Text);
                this.guna2DataGridView1.DataSource = prd.get_user();
                MessageBox.Show("تم اضافة المستخدم  بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cler();



            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }

        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_name.Text= this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ephon.Text= this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_loc.Text= this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_username.Text= this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text= this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            com_type.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
