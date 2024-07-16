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
    public partial class main : Form
    {
        private static main frm;
       
        
        public main()
        {
            InitializeComponent();
            

        }

        private void main_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            agent ag = new agent();
            this.Hide();
            ag.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            car cars = new car();
            this.Hide();
            cars.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add_castemor add = new add_castemor();
            this.Hide();
            add.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainer add = new trainer();
           
            add.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        { 
            
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible == false)
            {
                flowLayoutPanel1.Show();
            }
            else
                flowLayoutPanel1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
            }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            exports ex = new exports();
           
            ex.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            imports imp = new imports();
           
            imp.Show();
        }

        private void guna2Button2_Click_3(object sender, EventArgs e)
        {
            trainer ag = new trainer();
           
            ag.Show();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            regesrary ad = new regesrary();
         
            ad.Show();

        }

        private void guna2Button5_Click_2(object sender, EventArgs e)
        {
            car ca = new car();
          
            ca.Show();
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            agent ag = new agent();
           
            ag.Show();
        }

        private void comm_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            triner_dwra d = new triner_dwra();
           
            d.ShowDialog();
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            daily_exercises d = new daily_exercises();
            d.ShowDialog();
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            ratings r = new ratings();
            r.ShowDialog();
        }

        private void buton_close_Click(object sender, EventArgs e)
        {

        }

        private void but_maxmm_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            reports r = new reports();
            r.ShowDialog();
        }

        private void but_users_Click(object sender, EventArgs e)
        {
            users u = new users();
            u.ShowDialog();
        }

        private void but_copy_Click(object sender, EventArgs e)
        {
            Backup ba = new Backup();
            ba.Show();
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
    
}
