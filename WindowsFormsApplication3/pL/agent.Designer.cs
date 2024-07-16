namespace WindowsFormsApplication3
{
    partial class agent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_jop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_loc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ephon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_serch = new Guna.UI2.WinForms.Guna2TextBox();
            this.but_serche = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.but_clos = new Guna.UI2.WinForms.Guna2Button();
            this.but_delete = new Guna.UI2.WinForms.Guna2Button();
            this.but_ubdate = new Guna.UI2.WinForms.Guna2Button();
            this.but1_add = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 44);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.delo__2_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1118, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(168, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1286, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوكلاء";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.AutoRoundedCorners = true;
            this.txt_id.BorderColor = System.Drawing.Color.Black;
            this.txt_id.BorderRadius = 14;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(23, 72);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(196, 30);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_id.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.Validated += new System.EventHandler(this.txt_id_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم الوكيل";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 18;
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txt_jop);
            this.guna2GroupBox1.Controls.Add(this.txt_loc);
            this.guna2GroupBox1.Controls.Add(this.txt_ephon);
            this.guna2GroupBox1.Controls.Add(this.txt_name);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txt_id);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox1.Location = new System.Drawing.Point(843, 44);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(443, 522);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "بيانات الوكلاء";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(288, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "عمل الوكيل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(279, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "عنوان الوكيل";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(293, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(291, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "اسم الوكيل";
            // 
            // txt_jop
            // 
            this.txt_jop.AutoRoundedCorners = true;
            this.txt_jop.BorderColor = System.Drawing.Color.Black;
            this.txt_jop.BorderRadius = 14;
            this.txt_jop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jop.DefaultText = "";
            this.txt_jop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_jop.ForeColor = System.Drawing.Color.Black;
            this.txt_jop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jop.Location = new System.Drawing.Point(23, 387);
            this.txt_jop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_jop.Name = "txt_jop";
            this.txt_jop.PasswordChar = '\0';
            this.txt_jop.PlaceholderText = "";
            this.txt_jop.SelectedText = "";
            this.txt_jop.Size = new System.Drawing.Size(196, 31);
            this.txt_jop.TabIndex = 4;
            this.txt_jop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_loc
            // 
            this.txt_loc.AutoRoundedCorners = true;
            this.txt_loc.BorderColor = System.Drawing.Color.Black;
            this.txt_loc.BorderRadius = 14;
            this.txt_loc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_loc.DefaultText = "";
            this.txt_loc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_loc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_loc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_loc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_loc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_loc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_loc.ForeColor = System.Drawing.Color.Black;
            this.txt_loc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_loc.Location = new System.Drawing.Point(23, 302);
            this.txt_loc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.PasswordChar = '\0';
            this.txt_loc.PlaceholderText = "";
            this.txt_loc.SelectedText = "";
            this.txt_loc.Size = new System.Drawing.Size(196, 31);
            this.txt_loc.TabIndex = 4;
            this.txt_loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ephon
            // 
            this.txt_ephon.AutoRoundedCorners = true;
            this.txt_ephon.BorderColor = System.Drawing.Color.Black;
            this.txt_ephon.BorderRadius = 14;
            this.txt_ephon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ephon.DefaultText = "";
            this.txt_ephon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ephon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ephon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ephon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ephon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ephon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ephon.ForeColor = System.Drawing.Color.Black;
            this.txt_ephon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ephon.Location = new System.Drawing.Point(23, 223);
            this.txt_ephon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_ephon.Name = "txt_ephon";
            this.txt_ephon.PasswordChar = '\0';
            this.txt_ephon.PlaceholderText = "";
            this.txt_ephon.SelectedText = "";
            this.txt_ephon.Size = new System.Drawing.Size(196, 31);
            this.txt_ephon.TabIndex = 3;
            this.txt_ephon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ephon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.AutoRoundedCorners = true;
            this.txt_name.BorderColor = System.Drawing.Color.Black;
            this.txt_name.BorderRadius = 14;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(23, 149);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(196, 31);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.txt_serch);
            this.guna2Panel1.Controls.Add(this.but_serche);
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 44);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(843, 36);
            this.guna2Panel1.TabIndex = 34;
            // 
            // txt_serch
            // 
            this.txt_serch.BorderColor = System.Drawing.Color.Black;
            this.txt_serch.BorderRadius = 18;
            this.txt_serch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_serch.DefaultText = "";
            this.txt_serch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_serch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_serch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_serch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_serch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serch.ForeColor = System.Drawing.Color.Black;
            this.txt_serch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.Location = new System.Drawing.Point(536, 0);
            this.txt_serch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.PasswordChar = '\0';
            this.txt_serch.PlaceholderText = "";
            this.txt_serch.SelectedText = "";
            this.txt_serch.Size = new System.Drawing.Size(168, 36);
            this.txt_serch.TabIndex = 31;
            this.txt_serch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_serch.TextChanged += new System.EventHandler(this.txt_serch_TextChanged);
            // 
            // but_serche
            // 
            this.but_serche.BackColor = System.Drawing.Color.White;
            this.but_serche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.but_serche.BorderRadius = 18;
            this.but_serche.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_serche.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_serche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_serche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_serche.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_serche.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but_serche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_serche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but_serche.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_search_50px;
            this.but_serche.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_serche.Location = new System.Drawing.Point(704, 0);
            this.but_serche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_serche.Name = "but_serche";
            this.but_serche.PressedColor = System.Drawing.Color.Orange;
            this.but_serche.ShadowDecoration.BorderRadius = 15;
            this.but_serche.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.but_serche.Size = new System.Drawing.Size(139, 36);
            this.but_serche.TabIndex = 32;
            this.but_serche.Text = "بحث  ";
            this.but_serche.Click += new System.EventHandler(this.but_serche_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.ColumnHeadersHeight = 34;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 80);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.guna2DataGridView1.RowTemplate.Height = 32;
            this.guna2DataGridView1.Size = new System.Drawing.Size(843, 359);
            this.guna2DataGridView1.TabIndex = 75;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 32;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.DoubleClick += new System.EventHandler(this.guna2DataGridView1_DoubleClick_1);
            // 
            // but_clos
            // 
            this.but_clos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.but_clos.BorderRadius = 18;
            this.but_clos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_clos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_clos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_clos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_clos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but_clos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.but_clos.ForeColor = System.Drawing.Color.White;
            this.but_clos.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_back_26px;
            this.but_clos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_clos.ImageSize = new System.Drawing.Size(30, 30);
            this.but_clos.Location = new System.Drawing.Point(18, 14);
            this.but_clos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_clos.Name = "but_clos";
            this.but_clos.Size = new System.Drawing.Size(105, 39);
            this.but_clos.TabIndex = 26;
            this.but_clos.Text = "رجوع  ";
            this.but_clos.Click += new System.EventHandler(this.but_clos_Click);
            // 
            // but_delete
            // 
            this.but_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.but_delete.BorderRadius = 18;
            this.but_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.but_delete.ForeColor = System.Drawing.Color.White;
            this.but_delete.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_Delete_16px;
            this.but_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.but_delete.Location = new System.Drawing.Point(233, 14);
            this.but_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(105, 39);
            this.but_delete.TabIndex = 16;
            this.but_delete.Text = "حذف  ";
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_ubdate
            // 
            this.but_ubdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.but_ubdate.BorderRadius = 18;
            this.but_ubdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_ubdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_ubdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_ubdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_ubdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but_ubdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ubdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but_ubdate.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_edit_26px;
            this.but_ubdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_ubdate.Location = new System.Drawing.Point(438, 14);
            this.but_ubdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_ubdate.Name = "but_ubdate";
            this.but_ubdate.Size = new System.Drawing.Size(105, 39);
            this.but_ubdate.TabIndex = 15;
            this.but_ubdate.Text = "تعديل  ";
            this.but_ubdate.Click += new System.EventHandler(this.but_ubdate_Click);
            // 
            // but1_add
            // 
            this.but1_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.but1_add.BorderRadius = 18;
            this.but1_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but1_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but1_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but1_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but1_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but1_add.FocusedColor = System.Drawing.Color.Red;
            this.but1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.but1_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but1_add.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_Add_Male_User_Group_50px;
            this.but1_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but1_add.ImageSize = new System.Drawing.Size(30, 30);
            this.but1_add.Location = new System.Drawing.Point(637, 14);
            this.but1_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but1_add.Name = "but1_add";
            this.but1_add.ShadowDecoration.BorderRadius = 15;
            this.but1_add.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.but1_add.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.but1_add.Size = new System.Drawing.Size(105, 39);
            this.but1_add.TabIndex = 14;
            this.but1_add.Text = "اضافة     ";
            this.but1_add.Click += new System.EventHandler(this.but1_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.but1_add);
            this.panel2.Controls.Add(this.but_ubdate);
            this.panel2.Controls.Add(this.but_delete);
            this.panel2.Controls.Add(this.but_clos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 64);
            this.panel2.TabIndex = 76;
            // 
            // agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "agent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدرسة دلو";
            this.Load += new System.EventHandler(this.agent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_jop;
        private Guna.UI2.WinForms.Guna2TextBox txt_loc;
        private Guna.UI2.WinForms.Guna2TextBox txt_ephon;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button but1_add;
        private Guna.UI2.WinForms.Guna2Button but_ubdate;
        private Guna.UI2.WinForms.Guna2Button but_delete;
        private Guna.UI2.WinForms.Guna2Button but_clos;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_serch;
        private Guna.UI2.WinForms.Guna2Button but_serche;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}