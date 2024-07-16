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
    public partial class car : Form
    {
        BL.C_cars prd = new BL.C_cars();
       
        public car()
        {
            InitializeComponent();
          
            this.guna2DataGridView1.DataSource = prd.get_car();

            //جلب اسماء وضع السيارة في الكومبوبكس
            com_jah.DataSource = prd.get_name_jhz();
            com_jah.DisplayMember = "jah";
            com_jah.ValueMember = "id";
            this.guna2DataGridView1.Columns[0].Visible = false;
        }
       
       
        private bool validateinputs()
        {
            if ( txt_name.Text == string.Empty || txt_num.Text == string.Empty || txt_type.Text == string.Empty || txt_mstlm.Text == string.Empty )
            {
               
                txt_num.BackColor = Color.Red;
                txt_type.BackColor = Color.Red;
                txt_mstlm.BackColor = Color.Red;       
                txt_name.BackColor = Color.Red;
                DialogResult res = MessageBox.Show("مستخدم جديد", "يرجى ملء الحقول المطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    
                    txt_name.BackColor = Color.White;
                    txt_type.BackColor = Color.White;
                    txt_num.BackColor = Color.White;
                    txt_mstlm.BackColor = Color.White;
                    
                }
                return false;
            }
            return true;
        }
        private void buton_close_Click(object sender, EventArgs e)
        {

           
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void car_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم السيارة";
            guna2DataGridView1.Columns[1].HeaderText = "اسم السيارة";
            guna2DataGridView1.Columns[2].HeaderText = "نوع السيارة";
            guna2DataGridView1.Columns[3].HeaderText = "رقم اللوحة";
            guna2DataGridView1.Columns[4].HeaderText = "اسم المستلم";
            guna2DataGridView1.Columns[5].HeaderText = "الجاهزية ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void but_serche_Click(object sender, EventArgs e)
        {

        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد بيانات السيارة المراد حذفها ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("هل تريد بالتأكيد حذف السيارة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) 
            {
                prd.delete_car(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.guna2DataGridView1.DataSource = prd.get_car();
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
               
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                prd.update_car(Convert.ToInt32( id), txt_name.Text, txt_type.Text, txt_num.Text, txt_mstlm.Text,com_jah.SelectedValue.ToString());
                //استدعاء تابع التحديث البيانات
                this.guna2DataGridView1.DataSource = prd.get_car();

                MessageBox.Show("تم تعديل بيانات السيارة بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                txt_name.Text = "";
                txt_num.Text = "";
                txt_type.Text = "";
                txt_mstlm.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            try

            {
                
                               
                       
                    prd.add_car( txt_name.Text, txt_type.Text, txt_num.Text, txt_mstlm.Text,com_jah.SelectedValue.ToString());
                    //استدعاء تابع التحديث البيانات
                    this.guna2DataGridView1.DataSource = prd.get_car();

                    MessageBox.Show("تم اضافة بيانات السيارة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    txt_name.Text = "";
                    txt_num.Text = "";
                    txt_type.Text = "";
                    txt_mstlm.Text = "";
                    com_jah.SelectedItem = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
           
            


        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_car(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!=8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
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

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_type.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_num.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_mstlm.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
