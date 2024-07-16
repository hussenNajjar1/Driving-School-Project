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
    public partial class ratings : Form
    {
        BL.Rating prd = new BL.Rating();
        public ratings()
        {
            InitializeComponent();
            this.datagrdviw_ratings.DataSource = prd.get_ratings();
            this.datagrdviw_ratings.Columns[0].Visible = false;
            //جلب اسماء الدورات ووضعهم في الكومبوبكس
            com_name_dwra.DataSource = prd.get_dwra();
            com_name_dwra.DisplayMember = "name_dwra";
            com_name_dwra.ValueMember = "id_dwra";
        }
        void nmae_t()
        {
            DataTable DT = new DataTable();
            DT = prd.get_name_tr(Convert.ToInt32(com_name_dwra.SelectedValue), com_type.Text);
            this.com_name_tr.DataSource = DT;

            com_name_tr.DisplayMember = "aaa";
            com_name_tr.ValueMember = "id";
        }
        private bool validateinputs()
        {
            if (com_name_dwra.Text == string.Empty || com_name_tr.Text == string.Empty || com_type.Text == string.Empty || com_rating.Text == string.Empty || txt_attend.Text == string.Empty || txt_prac.Text == string.Empty || txt_theroe.Text == string.Empty)
            {
                com_rating.BackColor = Color.Red;
                com_name_tr.BackColor = Color.Red;
                com_type.BackColor = Color.Red;
                com_name_dwra.BackColor = Color.Red;
                txt_theroe.BackColor = Color.Red;

                txt_attend.BackColor = Color.Red;
                txt_prac.BackColor = Color.Red;



                DialogResult res = MessageBox.Show("يرجى ادخال البيانات المطلوبة ", " متدرب جديد", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                {
                    com_rating.BackColor = Color.White;
                    com_name_tr.BackColor = Color.White;
                    com_type.BackColor = Color.White;
                    com_name_dwra.BackColor = Color.White;
                    txt_theroe.BackColor = Color.White;

                    txt_attend.BackColor = Color.White;
                    txt_prac.BackColor = Color.White;

                }
                return false;
            }
            return true;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToString("hh :mm:ss.tt");
        }

        private void ratings_Load(object sender, EventArgs e)
        {

        }

        private void com_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmae_t();
        }

        private void but1_add_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;

            try
            {
                for (int i = 0; i < datagrdviw_ratings.Rows.Count - 1; i++)
                {
                    if (datagrdviw_ratings.Rows[i].Cells[2].Value.ToString() == com_name_dwra.Text)
                    {
                        if (datagrdviw_ratings.Rows[i].Cells[1].Value.ToString() == com_name_tr.Text)
                        {
                            MessageBox.Show("هذا المدرب تم اضافته مسبقا ", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }

                prd.insert_ratings(Convert.ToInt32(com_name_tr.SelectedValue), txt_theroe.Text, txt_prac.Text, txt_attend.Text, txt_coment.Text, com_rating.Text);
                this.datagrdviw_ratings.DataSource = prd.get_ratings();
                MessageBox.Show("  تم اضافة تقييم المتدرب بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            main m = new main();
            Close();
            m.ShowDialog();
        }

        private void but_ubdate_Click(object sender, EventArgs e)
        {
            if (!validateinputs()) return;

            try
            {
                for (int i = 0; i < datagrdviw_ratings.Rows.Count - 1; i++)
                {
                    if (datagrdviw_ratings.Rows[i].Cells[2].Value.ToString() == com_name_dwra.Text)
                    {
                        if (datagrdviw_ratings.Rows[i].Cells[1].Value.ToString() == com_name_tr.Text)
                        {
                            MessageBox.Show("هذا المدرب تم اضافته مسبقا ", "تنبيه", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                but1_add.Visible = true;
                DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (datagrdviw_ratings.SelectedRows.Count < 1) return;
                    string id = datagrdviw_ratings.SelectedRows[0].Cells[0].Value.ToString();
                    prd.update_ratings(Convert.ToInt32(id),Convert.ToInt32(com_name_tr.SelectedValue), txt_theroe.Text, txt_prac.Text, txt_attend.Text, txt_coment.Text, com_rating.Text);
                    this.datagrdviw_ratings.DataSource = prd.get_ratings();
                    //cler();
                    MessageBox.Show("تم تعديل بيانات المتدرب  بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    //cler();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا" + ex);
            }
        }

        private void datagrdviw_ratings_DoubleClick(object sender, EventArgs e)
        {
            com_name_tr.Text= this.datagrdviw_ratings.CurrentRow.Cells[1].Value.ToString();
            com_name_dwra.Text= this.datagrdviw_ratings.CurrentRow.Cells[2].Value.ToString();
            com_type.Text= this.datagrdviw_ratings.CurrentRow.Cells[3].Value.ToString();
            txt_theroe.Text= this.datagrdviw_ratings.CurrentRow.Cells[4].Value.ToString();
            txt_prac.Text= this.datagrdviw_ratings.CurrentRow.Cells[5].Value.ToString();
           txt_attend.Text =this.datagrdviw_ratings.CurrentRow.Cells[6].Value.ToString();
            txt_coment.Text= this.datagrdviw_ratings.CurrentRow.Cells[7].Value.ToString();
            com_rating.Text= this.datagrdviw_ratings.CurrentRow.Cells[8].Value.ToString();

        }

        private void datagrdviw_ratings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد حذف بيانات المتدرب؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {


                prd.delet_ratings(this.datagrdviw_ratings.CurrentRow.Cells[0].Value.ToString());

                this.datagrdviw_ratings.DataSource = prd.get_ratings();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("تم الغاء الحذف", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.serch_rating(guna2TextBox1.Text);
            this.datagrdviw_ratings.DataSource = DT;
        }
    }
}
