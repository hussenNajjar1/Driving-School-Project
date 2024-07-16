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
using System.IO;

namespace WindowsFormsApplication3
{

  
    public partial class add_castemor : Form

    {

        public int years;

        BL.Rejestery prdd = new BL.Rejestery();
        BL.Tr prd = new BL.Tr();
        public add_castemor()
        {

            InitializeComponent();
            

            //جلب اسماء الوكلاء ووضعهم في الكومبوبكس
            com_method_tsgel.DataSource = prd.get_name_agent();
            com_method_tsgel.DisplayMember = "name_agent";
            com_method_tsgel.ValueMember = "id_agent";



            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
            this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
            this.datagrdviw_mtdrb.Columns[14].Visible = false;

        }
        private bool validateinputs()
        {
            if (txt_id.Text == string.Empty || txt_name.Text == string.Empty || txt_fa.Text == string.Empty|| txt_knya.Text == string.Empty || txt_cart.Text == string.Empty || txt_city.Text == string.Empty || com_gendr.SelectedValue == string.Empty || txt_city_now.Text == string.Empty || txt_ephon1.Text == string.Empty )
            {
                txt_id.BackColor = Color.Red;
                txt_name.BackColor = Color.Red;
                txt_fa.BackColor = Color.Red;
                txt_knya.BackColor = Color.Red;
               
                txt_city.BackColor = Color.Red;
                txt_city_now.BackColor = Color.Red;
                txt_cart.BackColor = Color.Red;
                com_gendr.BackColor = Color.Red;
                txt_ephon1.BackColor = Color.Red;
                
                DialogResult res = MessageBox.Show("يرجى ادخال البيانات المطلوبة ", " متدرب جديد", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_id.BackColor = Color.White;
                    txt_name.BackColor = Color.White;
                    txt_fa.BackColor = Color.White;
                    txt_knya.BackColor = Color.White;
                    txt_ephon2.BackColor = Color.White;
                    txt_city.BackColor = Color.White;
                    txt_city_now.BackColor = Color.White;
                    txt_cart.BackColor = Color.White;
                    com_gendr.BackColor = Color.White;
                    txt_ephon1.BackColor = Color.White;
                   
                }
                return false;
            }
            return true;
        }
        public void cler()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_knya.Clear();
            txt_fa.Clear();
            txt_cart.Clear();
            txt_ephon1.Clear();
            txt_ephon2.Clear();
            txt_city_now.Clear();
            txt_city.Clear();
            txt_cart.Clear();
            radioButton1.Checked=false;
            radioButton2.Checked = false;
            pic_image.Image = null;
           
            com_method_tsgel.SelectedValue = -1;
        }
        private void add_castemor_Load(object sender, EventArgs e)
        {
            
            com_method_tsgel.SelectedValue = -1;
            datagrdviw_mtdrb.Columns[0].HeaderText = "رقم المتدرب";
            datagrdviw_mtdrb.Columns[1].HeaderText = "اسم المتدرب";
            datagrdviw_mtdrb.Columns[2].HeaderText = "اسم الاب";
            datagrdviw_mtdrb.Columns[3].HeaderText = " الكنية";
            datagrdviw_mtdrb.Columns[4].HeaderText = " رقم الهاتف 1";
            datagrdviw_mtdrb.Columns[5].HeaderText = " رقم الهاتف 2";
            datagrdviw_mtdrb.Columns[6].HeaderText = " الجنس";
            datagrdviw_mtdrb.Columns[7].HeaderText = " رقم البطاقة";
            datagrdviw_mtdrb.Columns[8].HeaderText = " مكان الولادة";
            datagrdviw_mtdrb.Columns[9].HeaderText = " تاريخ الولادة";
            datagrdviw_mtdrb.Columns[10].HeaderText = " مكان الاقامة";


            datagrdviw_mtdrb.Columns[11].HeaderText = " طريقة التسجيل ";
            datagrdviw_mtdrb.Columns[12].HeaderText = " تاريخ الاضافة";

            datagrdviw_mtdrb.Columns[13].HeaderText = " اسم الوكيل";

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            main abd = new main();
            this.Hide();
            abd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور|*.PNG;*.JPG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Move(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Move(object sender, EventArgs e)
        {

        }

        private void but1_add_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void but1_add_MouseHover(object sender, EventArgs e)
        {

        }

        private void but1_add_MouseLeave(object sender, EventArgs e)
        {

        }

        private void but1_add_MouseEnter(object sender, EventArgs e)
        {

        }

        private void but1_add_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            regesrary abd = new regesrary();
           
            //جلب اسماء المتدبين ووضعهم في الكومبوبكس
           abd.com_name_t.DataSource = prdd.get_name_tr();
            abd.com_name_t.DisplayMember = "full_name";
            abd.com_name_t.ValueMember = "id_tr";
            this.Hide();
            abd.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
           
                try
                {


                    DateTime MyAge;
                    MyAge = txt_date_th.Value;
                    years = DateTime.Now.Year - MyAge.Year;



                    string stites = "";
                    if (radioButton2.Checked == true)
                    {
                        stites = radioButton2.Text;
                    }
                    else
                    {
                        stites = radioButton1.Text;
                    }

                    DataTable DT = new DataTable();
                    DT = prd.veri_id_tr(txt_id.Text);
                    if (DT.Rows.Count > 0)
                    {
                        MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_id.Focus();
                        txt_id.SelectionStart = 0;

                    }

                    byte[] byteimage;

                    if (pic_image.Image == null)
                    {



                        if (years >= 18)
                        {
                            byteimage = new byte[0];

                            prd.add_tr(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, com_gendr.Text, txt_cart.Text, txt_city.Text, Convert.ToString(txt_date_th.Value), txt_city_now.Text, stites, Convert.ToString(txt_date_add.Value), Convert.ToInt32(com_method_tsgel.SelectedValue), byteimage, "without_image");

                            prd.insert_ephon(Convert.ToInt32(txt_id.Text), txt_ephon1.Text, txt_ephon2.Text);

                            this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
                            cler();
                            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                        }

                        else
                        {
                            MessageBox.Show("يجب أن يكون العمر أكبر من 18 سنة.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }

                    else
                    {
                        if (years >= 18)
                        {


                            MemoryStream ms = new MemoryStream();
                            pic_image.Image.Save(ms, pic_image.Image.RawFormat);
                            byteimage = ms.ToArray();

                            prd.add_tr(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, com_gendr.Text, txt_cart.Text, txt_city_now.Text, Convert.ToString(txt_date_th.Value), txt_city.Text, stites, Convert.ToString(txt_date_add.Value), Convert.ToInt32(com_method_tsgel.SelectedValue), byteimage, "with_image");
                            prd.insert_ephon(Convert.ToInt32(txt_id.Text), txt_ephon1.Text, txt_ephon2.Text);

                            //استدعاء تابع التحديث البيانات
                            this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
                            cler();
                            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();


                        }
                        else
                        {
                            MessageBox.Show("يجب أن يكون العمر أكبر من 18 سنة.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطا" + ex);
                }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (com_method_tsgel.Visible == false)
                {
                    com_method_tsgel.Show();
                }
                else
                    com_method_tsgel.Hide();
            }
            if (label18.Visible == false)
            {
                label18.Show();
            }
            else
                label18.Hide();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            //this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (datagrdviw_mtdrb.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد المتدرب المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("هل تريد بالتأكيد حذف المتدرب؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               
              
                prd.delete_tr(this.datagrdviw_mtdrb.CurrentRow.Cells[0].Value.ToString());
               
                this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void but_ubdate_Click(object sender, EventArgs e)
        {
            string stites = "";
            if (radioButton1.Checked == true)
            {
                stites = radioButton1.Text;
            }
            else
            {
                stites = radioButton2.Text;
            }
            if (!validateinputs()) return;
            try
            {
                DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    byte[] byteimage;

                    if (pic_image.Image == null)
                    {
                        byteimage = new byte[0];

                        prd.update_tr(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, com_gendr.Text, txt_cart.Text, txt_city.Text, Convert.ToString(txt_date_th.Value), txt_city_now.Text, stites, Convert.ToString(txt_date_add.Value), Convert.ToInt32(com_method_tsgel.SelectedValue), byteimage, "without_image");

                        prd.update_ephon(Convert.ToInt32(txt_id.Text), txt_ephon1.Text, txt_ephon2.Text);
                      
                        this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
                        cler();
                        MessageBox.Show("تم التعديل بيانات المتدرب  بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                    }
                    else
                    {


                        MemoryStream ms = new MemoryStream();
                        pic_image.Image.Save(ms, pic_image.Image.RawFormat);
                        byteimage = ms.ToArray();

                        prd.update_tr(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, com_gendr.Text, txt_cart.Text, txt_city.Text, Convert.ToString(txt_date_th.Value), txt_city_now.Text, stites, Convert.ToString(txt_date_add.Value), Convert.ToInt32(com_method_tsgel.SelectedValue), byteimage, "with_image");
                        prd.update_ephon(Convert.ToInt32(txt_id.Text), txt_ephon1.Text, txt_ephon2.Text);
                      
                        //استدعاء تابع التحديث البيانات
                        this.datagrdviw_mtdrb.DataSource = prd.get_trrrr();
                        cler();
                        MessageBox.Show("تم التعديل بيانات المتدرب  بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }




        }

        private void datagrdviw_mtdrb_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void datagrdviw_mtdrb_DoubleClick_1(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void datagrdviw_mtdrb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToString("hh :mm:ss.tt");
        }

        private void txt_cart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cart_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void com_num_dwra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrdviw_mtdrb_DoubleClick_2(object sender, EventArgs e)
        {
            if (datagrdviw_mtdrb.CurrentRow.Cells[14].Value is DBNull)
            {
                string ss = "";
                if (radioButton1.Checked == true)
                {
                    ss = radioButton1.Text;
                }
                else
                {
                    ss = radioButton2.Text;
                }

                MessageBox.Show("هذا المدرب لا يوجد له صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_id.Clear();
                txt_id.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[1].Value.ToString();
                txt_fa.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[2].Value.ToString();
                txt_knya.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[3].Value.ToString();
                txt_ephon1.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[4].Value.ToString();
                txt_ephon2.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[5].Value.ToString();
                com_gendr.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[6].Value.ToString();
                txt_cart.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[7].Value.ToString();
                txt_city.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[8].Value.ToString();
                txt_date_th.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[9].Value.ToString();
                txt_city_now.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[10].Value.ToString();

                //txt_date_add.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[11].Value.ToString();
                ss = this.datagrdviw_mtdrb.CurrentRow.Cells[12].Value.ToString();
                com_method_tsgel.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[13].Value.ToString();
                pic_image.Image = null;
                return;
            }
            //else
            //{
            string stites = "";
            if (radioButton1.Checked == true)
            {
                stites = radioButton1.Text;
            }
            else
            {
                stites = radioButton2.Text;
            }
            txt_id.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[1].Value.ToString();
            txt_fa.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[2].Value.ToString();
            txt_knya.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[3].Value.ToString();
            txt_ephon1.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[4].Value.ToString();
            txt_ephon2.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[5].Value.ToString();
            com_gendr.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[6].Value.ToString();
            txt_cart.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[7].Value.ToString();
            txt_city.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[8].Value.ToString();
            txt_date_th.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[9].Value.ToString();
            txt_city_now.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[10].Value.ToString();

            //txt_date_add.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[11].Value.ToString();
            stites = this.datagrdviw_mtdrb.CurrentRow.Cells[12].Value.ToString();
            com_method_tsgel.Text = this.datagrdviw_mtdrb.CurrentRow.Cells[13].Value.ToString();
            byte[] pic = (byte[])datagrdviw_mtdrb.CurrentRow.Cells[14].Value;
            MemoryStream ms = new MemoryStream(pic);
            pic_image.Image = Image.FromStream(ms);

            //}
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_tr(textBox1.Text);
            this.datagrdviw_mtdrb.DataSource = DT;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_tr_name(textBox2.Text);
            this.datagrdviw_mtdrb.DataSource = DT;
        }
    }
}
