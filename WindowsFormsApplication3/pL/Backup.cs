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
    public partial class Backup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-EVV0GB5\MSSQLSERVERMM; initial catalog = dilo; Integrated Security = True");
        SqlCommand cmd;
        public Backup()
        {
            InitializeComponent();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        { string filname = textBox1.Text + "\\dilo" + DateTime.Now.ToShortDateString().Replace('/', '_') + "_"+DateTime.Now.ToLongTimeString().Replace(':','_');
            string strquery = "BacKup Database dilo  to Disk='"+filname+".bak'";
            cmd = new SqlCommand(strquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حفظ النسخة الاحتياطية بنجاح", "نسخ اختياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            string strquery = "ALTER Database dilo SET OFFLINE WITH ROLLBACK IMMEDIATE;  Restore Database dilo from disk='" + textBox2.Text + "'WITH REPLACE";
            cmd = new SqlCommand(strquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "نسخ اختياطي", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
