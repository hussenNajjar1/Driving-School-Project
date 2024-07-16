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
    public partial class daily_exercises : Form
    {
        BL.daily prd = new BL.daily();

        public daily_exercises()
        {
            InitializeComponent();
            this.datagrdviwe_daily.DataSource = prd.get_daily();
            this.datagrdviwe_daily.Columns[0].Visible = false;
            //جلب اسماء الدورات ووضعهم في الكومبوبكس
            com_name_dwra.DataSource = prd.get_dwra();
            com_name_dwra.DisplayMember = "name_dwra";
            com_name_dwra.ValueMember = "id_dwra";
            //جلب اسماء السيارات ووضعهم في الكومبوبكس
            coom_name_car.DataSource = prd.get_name_cars();
            coom_name_car.DisplayMember = "name_car";
            coom_name_car.ValueMember = "id_car";

            //جلب اسماء الايام ووضعهم في الكومبوبكس
            com_name_dey.DataSource = prd.get_name_dey();
            com_name_dey.DisplayMember = "namee";
            com_name_dey.ValueMember = "id";

            //جلب اسماء الدورات ووضعهم في الكومبوبكس
            com_name_triner.DataSource = prd.get_name_triner();
            com_name_triner.DisplayMember = "aaa";
            com_name_triner.ValueMember = "id_triner";

            nmae_t();
          
        }
        void nmae_t()
        {
            DataTable DT = new DataTable();
            DT = prd.get_name_tr(Convert.ToInt32(com_name_dwra.SelectedValue), com_type.Text);
            this.com_name_tr.DataSource = DT;
            com_name_tr.DisplayMember = "aaa";
            com_name_tr.ValueMember = "id";
        }
        
        void cler()
        {
            com_type.SelectedIndex = -1;
            com_name_tr.SelectedIndex = -1;
            com_name_dwra.SelectedIndex = -1;
            com_name_dey.SelectedIndex = -1;
            com_type.SelectedIndex = -1;
            guna2ComboBox5.SelectedIndex = -1;
        }
        private void datagrdviw_mtdrb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void daily_exercises_Load(object sender, EventArgs e)
        {
            datagrdviwe_daily.Columns[0].HeaderText = "رقم ";
            datagrdviwe_daily.Columns[1].HeaderText = "اسم المتدرب ";
            datagrdviwe_daily.Columns[2].HeaderText = "رقم الدورة ";
            datagrdviwe_daily.Columns[3].HeaderText = "نوع الرخصة ";
            datagrdviwe_daily.Columns[4].HeaderText = "اسم المدرب ";
            datagrdviwe_daily.Columns[5].HeaderText = "اسم السيارة ";
            datagrdviwe_daily.Columns[6].HeaderText = "التقييم  ";
            datagrdviwe_daily.Columns[7].HeaderText = "اليوم ";
            datagrdviwe_daily.Columns[8].HeaderText = "تاريخ التدريب ";
            datagrdviwe_daily.Columns[9].HeaderText = "الحضور ";
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nmae_t();
        }

        private void com_name_dwra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_name_triner_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }

        private void com_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmae_t();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void com_name_dey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_date_add_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < datagrdviwe_daily.Rows.Count - 1; i++)
                {
                    if (datagrdviwe_daily.Rows[i].Cells[1].Value.ToString() == com_name_tr.Text)
                    {
                        if (datagrdviwe_daily.Rows[i].Cells[4].Value.ToString() == com_name_triner.Text)
                        {
                            if (datagrdviwe_daily.Rows[i].Cells[5].Value.ToString() == com_name_triner.Text)
                            {

                                MessageBox.Show("هذا المتدرب تم اضافته مسبقا   ", "تنبيه", MessageBoxButtons.OK);
                                return;

                            }
                        }
                    }

                }
                prd.insert_daily(Convert.ToInt32(com_name_tr.SelectedValue), Convert.ToInt32(com_name_triner.SelectedValue), Convert.ToInt32(coom_name_car.SelectedValue), guna2ComboBox5.Text, Convert.ToInt32(com_name_dey.SelectedValue), Convert.ToString(txt_date_add.Text), com_aaaa.Text);
                this.datagrdviwe_daily.DataSource = prd.get_daily();
                cler();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

                
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطا" + ex);
                }

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {


            try
            {
                DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    if (datagrdviwe_daily.SelectedRows.Count < 1) return;
                    string id = datagrdviwe_daily.SelectedRows[0].Cells[0].Value.ToString();
                    prd.update_daily(Convert.ToInt32(id), Convert.ToInt32(com_name_tr.SelectedValue), Convert.ToInt32(com_name_triner.SelectedValue), Convert.ToInt32(coom_name_car.SelectedValue), guna2ComboBox5.Text, Convert.ToInt32(com_name_dey.SelectedValue), Convert.ToString(txt_date_add.Text), com_aaaa.Text);
                    this.datagrdviwe_daily.DataSource = prd.get_daily();
                    cler();
                    MessageBox.Show("تم تعديل بيانات المتدرب اليومية المحددة بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void datagrdviwe_daily_DoubleClick(object sender, EventArgs e)
        {
            com_name_tr.Text = this.datagrdviwe_daily.CurrentRow.Cells[1].Value.ToString();
            com_name_dwra.Text = this.datagrdviwe_daily.CurrentRow.Cells[2].Value.ToString();
            com_type.Text = this.datagrdviwe_daily.CurrentRow.Cells[3].Value.ToString();
            com_name_triner.Text = this.datagrdviwe_daily.CurrentRow.Cells[4].Value.ToString();
            coom_name_car.Text = this.datagrdviwe_daily.CurrentRow.Cells[5].Value.ToString();
            guna2ComboBox5.Text = this.datagrdviwe_daily.CurrentRow.Cells[6].Value.ToString();
            com_name_dey.Text = this.datagrdviwe_daily.CurrentRow.Cells[7].Value.ToString();
            txt_date_add.Text = this.datagrdviwe_daily.CurrentRow.Cells[8].Value.ToString();
            com_aaaa.Text= this.datagrdviwe_daily.CurrentRow.Cells[9].Value.ToString();



        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات التدريب للمتدرب المحدد؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {


                prd.delete_daily(this.datagrdviwe_daily.CurrentRow.Cells[0].Value.ToString());
                this.datagrdviwe_daily.DataSource = prd.get_daily();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void but_maxmm_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void buton_close_Click(object sender, EventArgs e)
        {
           
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToString("hh :mm:ss.tt");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_daily(guna2TextBox1.Text);
            this.datagrdviwe_daily.DataSource = DT;
        }
    }
}
