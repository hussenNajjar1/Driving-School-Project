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
    public partial class loginform : Form
    {
        BL.Login prd = new BL.Login();
       
        

        public loginform()
        {
           
            InitializeComponent();
           

            

           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
                    }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable DT = prd.login_user(txt_username.Text, txt_password.Text);
            main m = new main();
            if (DT.Rows.Count>0)
            {
                //Form_welcom mm = new Form_welcom();
                //mm.ShowDialog();
                if (DT.Rows[0][6].ToString() == "مدير")
                {
                    this.Hide();
                    m.Show();

                }
              else  if (DT.Rows[0][6].ToString() == "موظف مالية")
                { 

                   
                    m.but_copy.Visible = false;
                  
                    m.but_dwra.Visible = false;
                  
                    m.but_tr.Visible = false;
                  
                    m.but_triner.Visible = false;
                
                    m.but_users.Visible = false;
                 
                    m.but_24.Visible = false;
               
                    m.but_agent.Visible = false;
                    m.but_car.Visible = false;
                    m.but_repoet.Visible = false;
                    m.but_assess.Visible = false;
                   

                    this.Hide();
                    m.Show();

                }
               




                   
                
                else if (DT.Rows[0][6].ToString() == "موظف شؤون")
                {
                    m.but_copy.Visible = false;

                    m.but_dwra.Visible = false;

                    m.but_tr.Visible = true;

                    m.but_triner.Visible = true;

                    m.but_users.Visible = false;

                    m.but_24.Visible = true;
                    m.but_import.Visible = false;
                    m.but_agent.Visible = false;
                    m.but_car.Visible = false;
                    m.but_repoet.Visible = true;
                    m.but_assess.Visible = true;

                    this.Hide();
                    m.Show();

                }
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة \n يرجى المحاولة مجددا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
           
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
