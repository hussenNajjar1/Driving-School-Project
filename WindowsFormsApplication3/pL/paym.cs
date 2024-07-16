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
    public partial class paym : Form
    {
        BL.Exports prddd = new BL.Exports();
        BL.payman prd = new BL.payman();
        public paym()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.get_paymant();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            prd.add_paymant(Convert.ToInt32(txt_id.Text), txt_name.Text);
           
            this.dataGridView1.DataSource = prd.get_paymant();
            txt_name.Clear();
            txt_id.Clear();
            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void paym_Load(object sender, EventArgs e)
        {

        }

        private void but_updet_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("هل تريد بالتاكيد التعديل؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count < 1) return;
                
                prd.update_paymant(Convert.ToInt32(txt_id.Text), txt_name.Text);
                txt_name.Clear();
                txt_id.Clear();
                this.dataGridView1.DataSource = prd.get_paymant();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void but_delet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                DialogResult res = MessageBox.Show("يرجى تحديد البيانات المراد حذفها ", "  تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == DialogResult.OK)
                    return;
            }
        }
    }
}
