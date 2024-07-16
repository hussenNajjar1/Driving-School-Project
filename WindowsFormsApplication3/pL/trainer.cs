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
    public partial class trainer : Form
    {

        public int years;
        BL.Trainer prd = new BL.Trainer();
        public trainer()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_triner();
            guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Columns[12].Visible = false;
            this.guna2DataGridView1.Columns[0].Visible = false;
            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();


        }
        private bool validateinputs()
        {
            if (txt_id.Text == string.Empty || txt_name.Text == string.Empty || txt_fa.Text == string.Empty || txt_ephon.Text == string.Empty || txt_knya.Text == string.Empty)
            {
                txt_id.BackColor = Color.Red;
                txt_name.BackColor = Color.Red;
                txt_fa.BackColor = Color.Red;
                txt_knya.BackColor = Color.Red;
                txt_ephon.BackColor = Color.Red;
                DialogResult res = MessageBox.Show( "يرج ملئ الحقول المطلوبة", "متدرب جديد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    txt_id.BackColor = Color.White;
                    txt_name.BackColor = Color.White;
                    txt_fa.BackColor = Color.White;
                    txt_knya.BackColor = Color.White;
                    txt_ephon.BackColor = Color.White;

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
            txt_ephon.Clear();
            txt_chh.Clear();
            txt_loc.Clear();
            txt_sal.Clear();
            com_famil.SelectedIndex = -1;
            txt_stits.SelectedIndex = -1;
            
           
            
            pictur_image.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            main abd = new main();
            this.Hide();
            abd.Show();

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور|*.PNG;*.JPG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictur_image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            main abd = new main();
            this.Hide();
            abd.Show();
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {

        }

        private void but_delete_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void but_clos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trainer_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم المتدرب";
            guna2DataGridView1.Columns[1].HeaderText = "اسم المتدرب";
            guna2DataGridView1.Columns[2].HeaderText = "اسم الاب";
            guna2DataGridView1.Columns[3].HeaderText = "الكنية ";
            guna2DataGridView1.Columns[4].HeaderText = " الشهادة";
            guna2DataGridView1.Columns[5].HeaderText = " رقم الهاتف";
            guna2DataGridView1.Columns[6].HeaderText = "تاريخ الولادة";
            guna2DataGridView1.Columns[7].HeaderText = "مكان الاقامة";
            guna2DataGridView1.Columns[8].HeaderText = " الراتب";
            guna2DataGridView1.Columns[9].HeaderText = " الجنس";
            guna2DataGridView1.Columns[10].HeaderText = "الحالة الاجتماعية";
            guna2DataGridView1.Columns[11].HeaderText = "تاريخ الاضافة";
            //guna2DataGridView1.Columns[12].HeaderText = "صورة الشخصية";
            guna2DataGridView1.Columns[0].Width = 80;
            guna2DataGridView1.Columns[1].Width = 120;
            guna2DataGridView1.Columns[2].Width = 120;
            guna2DataGridView1.Columns[3].Width = 120;
            guna2DataGridView1.Columns[4].Width = 120;
            guna2DataGridView1.Columns[5].Width = 120;
            guna2DataGridView1.Columns[6].Width = 160;
            guna2DataGridView1.Columns[7].Width = 160;
            guna2DataGridView1.Columns[8].Width = 120;
            guna2DataGridView1.Columns[7].DefaultCellStyle.Format = "C";
        }

        private void txt_chh_TextChanged(object sender, EventArgs e)
        {

        }

        private void but1_add_Click(object sender, EventArgs e)
        {
           

            if (!validateinputs()) return;
            try
            {
                DataTable DT = new DataTable();
            DT = prd.veri_id_triner(txt_id.Text);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                txt_id.SelectionStart = 0;

            }
          
                byte[] byteimage;
               
                if (pictur_image.Image == null)
                {

                   


                        byteimage = new byte[0];
                        prd.add_triner(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, txt_chh.Text, txt_ephon.Text, Convert.ToString(txt_date.Value), txt_loc.Text, txt_sal.Text, com_famil.Text, txt_stits.Text, Convert.ToString(txt_add.Value), byteimage, "without_image");
                        this.guna2DataGridView1.DataSource = prd.get_triner();
                        cler();
                        MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    
                   

                }
                else
                {
                   


                        MemoryStream ms = new MemoryStream();
                        pictur_image.Image.Save(ms, pictur_image.Image.RawFormat);
                        byteimage = ms.ToArray();

                        prd.add_triner(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, txt_chh.Text, txt_ephon.Text, Convert.ToString(txt_date.Value), txt_loc.Text, txt_sal.Text, com_famil.Text, txt_stits.Text, Convert.ToString(txt_add.Value), byteimage, "with_image");
                        cler();
                        //استدعاء تابع التحديث البيانات
                        this.guna2DataGridView1.DataSource = prd.get_triner();
                        MessageBox.Show("تم اضافة بيانات المدرب بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                  }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
            }


        

        private void txt_knya_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_ubdate_Click_1(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
           
                try
                {
                byte[] byteimage;

                if (pictur_image.Image == null)
                {
                    byteimage = new byte[0];
                    prd.updaet_triner(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, txt_chh.Text, txt_ephon.Text, Convert.ToString(txt_date.Value), txt_loc.Text, txt_sal.Text, com_famil.Text, txt_stits.Text, Convert.ToString(txt_add.Value), byteimage, "without_image");
                    this.guna2DataGridView1.DataSource = prd.get_triner();
                    cler();
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                }
                else
                {


                    MemoryStream ms = new MemoryStream();
                    pictur_image.Image.Save(ms, pictur_image.Image.RawFormat);
                    byteimage = ms.ToArray();

                    prd.updaet_triner(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_fa.Text, txt_knya.Text, txt_chh.Text, txt_ephon.Text, Convert.ToString(txt_date.Value), txt_loc.Text, txt_sal.Text, com_famil.Text, txt_stits.Text, Convert.ToString(txt_add.Value), byteimage, "with_image");
                    //استدعاء تابع التحديث البيانات
                    this.guna2DataGridView1.DataSource = prd.get_triner();
                    cler();
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }

        }
        //تعبئة البيانات في الاسطر
        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            

            
        }

        private void but_delete_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد المدرب المراد حذفه ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("هل تريد بالتأكيد حذف المدرب؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.delete_triner(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                this.guna2DataGridView1.DataSource = prd.get_triner();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_triner(txt_serch.Text);
            this.guna2DataGridView1.DataSource = DT;
        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.veri_id_triner(txt_id.Text);
            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا\nاختر معرف اخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                



            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txt_id.Text = prd.get_id_max().Rows[0][0].ToString();
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8  && e.KeyChar!=43 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_sal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ephon_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow.Cells[12].Value is DBNull)
            {
                MessageBox.Show("هذا المدرب لا يوجد له صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_id.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_fa.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_knya.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_chh.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_ephon.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_date.Text = this.guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_loc.Text = this.guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_sal.Text = this.guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                com_famil.Text = this.guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_stits.Text = this.guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
                txt_add.Text = this.guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
                pictur_image.Image = null;
            }
            else
            {
                txt_id.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_fa.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_knya.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_chh.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_ephon.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_date.Text = this.guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_loc.Text = this.guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_sal.Text = this.guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                com_famil.Text = this.guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_stits.Text = this.guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
                txt_add.Text = this.guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
                byte[] pic = (byte[])guna2DataGridView1.CurrentRow.Cells[12].Value;

                MemoryStream ms = new MemoryStream(pic);
                pictur_image.Image = Image.FromStream(ms);
            }
        }
    }
}
