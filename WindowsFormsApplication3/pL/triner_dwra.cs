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
    public partial class triner_dwra : Form
    {
        BL.dwra_triner prd = new BL.dwra_triner();
       
        public triner_dwra()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataSource = prd.get_triner_dwra();
            this.guna2DataGridView1.Columns[0].Visible = false;


            //جلب اسماء المدربين ووضعهم في الكومبوبكس
            com_name_triner.DataSource = prd.get_name_triner();
            com_name_triner.DisplayMember = "aaa";
            com_name_triner.ValueMember = "id_triner";
           





        }
        private bool validateinputs()
        {
            if (  com_name_dwra.Text == string.Empty || com_name_triner.Text == string.Empty)
            {
               
                com_name_triner.BackColor = Color.Red;
                com_name_triner.BackColor = Color.Red;
                DialogResult res = MessageBox.Show("يرجى ملء الحقول المطلوبة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                   
                    com_name_triner.BackColor = Color.White;
                    com_name_dwra.BackColor = Color.White;


                }
                return false;
            }
            return true;
        }

        void cler()
        {

           
            com_name_triner.SelectedIndex = -1;
            com_name_dwra.SelectedIndex = -1;
            
            txt_coment.Clear();
            
        }
       public void dwra()
        {
            //جلب اسماء الدورات ووضعهم في الكومبوبكس
            com_name_dwra.DataSource = prd.get_name_dwra();
            com_name_dwra.DisplayMember = "name_dwra";
            com_name_dwra.ValueMember = "id_dwra";
        }

        private void triner_dwra_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "رقم  ";
            guna2DataGridView1.Columns[1].HeaderText = "رقم الدورة ";
            guna2DataGridView1.Columns[2].HeaderText = "اسم المتدرب ";
            guna2DataGridView1.Columns[3].HeaderText = "ملاحظات  ";
            guna2DataGridView1.Columns[4].HeaderText = "تاريخ بدء الدورة ";
            guna2DataGridView1.Columns[5].HeaderText = "تاريخ انتهاء الدورة ";
            dwra();
        }

        private void data_end_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;
            try
            {
                for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                {
                    if (guna2DataGridView1.Rows[i].Cells[1].Value.ToString() == com_name_dwra.Text)
                    {
                        if (guna2DataGridView1.Rows[i].Cells[2].Value.ToString() == com_name_triner.Text)
                        {
                            MessageBox.Show("هذا المدرب تم ادخاله مسبقا في هذه الدورة", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }


                prd.add_dwra_triner(Convert.ToInt32(com_name_dwra.SelectedValue), Convert.ToInt32(com_name_triner.SelectedValue), txt_coment.Text, Convert.ToString(data_start.Value), Convert.ToString(data_end.Value));
                        this.guna2DataGridView1.DataSource = prd.get_triner_dwra();
                        MessageBox.Show("تم اضافة بيانات الدورة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cler();

                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }

        }

        private void but1_add_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_save_Click(object sender, EventArgs e)
        {
            
          
        }

       

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                com_name_dwra.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                com_name_triner.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_coment.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                data_start.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                data_end.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();



            }
            catch
            {
                return;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void datagrdviw_data_dwra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;

            try
            {
                
                DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (guna2DataGridView1.SelectedRows.Count < 1) return;
                    string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    prd.update_dwra_triner(Convert.ToInt32(id),Convert.ToInt32(com_name_dwra.SelectedValue), Convert.ToInt32(com_name_triner.SelectedValue), txt_coment.Text, Convert.ToString(data_start.Value), Convert.ToString(data_end.Value));
                    this.guna2DataGridView1.DataSource = prd.get_triner_dwra();
                    cler();
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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

        private void but_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1.SelectedRows.Count < 1)
                {
                    DialogResult res = MessageBox.Show("يرجى تحديد البيانات المراد حذفها ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    if (res == DialogResult.OK)
                        return;
                }
                if (MessageBox.Show("هل تريد بالتأكيد حذف تفصيل الدورة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.delete_relechn_dwra_triner(this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());

                    this.guna2DataGridView1.DataSource = prd.get_triner_dwra();
                    MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);

            }
        }

        private void com_name_n_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                com_name_dwra.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                com_name_triner.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_coment.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                data_start.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                data_end.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();


            }
            catch
            {
                return;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            dawra a = new dawra();
            a.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            dwra();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
