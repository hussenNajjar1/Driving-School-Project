namespace WindowsFormsApplication3
{
    partial class car
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.com_jah = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mstlm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_serch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.but_serche = new Guna.UI2.WinForms.Guna2Button();
            this.but_clos = new Guna.UI2.WinForms.Guna2Button();
            this.but_delete = new Guna.UI2.WinForms.Guna2Button();
            this.but_ubdate = new Guna.UI2.WinForms.Guna2Button();
            this.but1_add = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 54);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox2.Image = global::WindowsFormsApplication3.Properties.Resources.delo__2_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1176, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(194, 54);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 28;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "السيارات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.guna2GroupBox1.BorderRadius = 18;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox1.Controls.Add(this.com_jah);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.txt_mstlm);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txt_num);
            this.guna2GroupBox1.Controls.Add(this.txt_type);
            this.guna2GroupBox1.Controls.Add(this.txt_name);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(961, 47);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(512, 520);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "بيانات السيارات";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(-898, 82);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.guna2DataGridView1.RowTemplate.Height = 32;
            this.guna2DataGridView1.Size = new System.Drawing.Size(958, 453);
            this.guna2DataGridView1.TabIndex = 74;
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
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            this.guna2DataGridView1.DoubleClick += new System.EventHandler(this.guna2DataGridView1_DoubleClick_1);
            // 
            // com_jah
            // 
            this.com_jah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.com_jah.AutoRoundedCorners = true;
            this.com_jah.BackColor = System.Drawing.Color.Transparent;
            this.com_jah.BorderColor = System.Drawing.Color.Black;
            this.com_jah.BorderRadius = 17;
            this.com_jah.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_jah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_jah.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_jah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_jah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.com_jah.ForeColor = System.Drawing.Color.Black;
            this.com_jah.ItemHeight = 30;
            this.com_jah.Location = new System.Drawing.Point(52, 424);
            this.com_jah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_jah.Name = "com_jah";
            this.com_jah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_jah.Size = new System.Drawing.Size(212, 36);
            this.com_jah.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(377, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "الجاهزية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(336, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "اسم المستلم";
            // 
            // txt_mstlm
            // 
            this.txt_mstlm.AutoRoundedCorners = true;
            this.txt_mstlm.BackColor = System.Drawing.Color.White;
            this.txt_mstlm.BorderColor = System.Drawing.Color.Black;
            this.txt_mstlm.BorderRadius = 17;
            this.txt_mstlm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mstlm.DefaultText = "";
            this.txt_mstlm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mstlm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mstlm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mstlm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mstlm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mstlm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_mstlm.ForeColor = System.Drawing.Color.Black;
            this.txt_mstlm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mstlm.Location = new System.Drawing.Point(52, 338);
            this.txt_mstlm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mstlm.Name = "txt_mstlm";
            this.txt_mstlm.PasswordChar = '\0';
            this.txt_mstlm.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_mstlm.PlaceholderText = "";
            this.txt_mstlm.SelectedText = "";
            this.txt_mstlm.Size = new System.Drawing.Size(212, 37);
            this.txt_mstlm.TabIndex = 4;
            this.txt_mstlm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(360, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "رقم اللوحة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(354, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع السيارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(345, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم السيارة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_num
            // 
            this.txt_num.AutoRoundedCorners = true;
            this.txt_num.BackColor = System.Drawing.Color.White;
            this.txt_num.BorderColor = System.Drawing.Color.Black;
            this.txt_num.BorderRadius = 17;
            this.txt_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num.DefaultText = "";
            this.txt_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_num.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_num.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_num.ForeColor = System.Drawing.Color.Black;
            this.txt_num.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_num.Location = new System.Drawing.Point(52, 261);
            this.txt_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num.Name = "txt_num";
            this.txt_num.PasswordChar = '\0';
            this.txt_num.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_num.PlaceholderText = "";
            this.txt_num.SelectedText = "";
            this.txt_num.Size = new System.Drawing.Size(212, 37);
            this.txt_num.TabIndex = 3;
            this.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_type
            // 
            this.txt_type.AutoRoundedCorners = true;
            this.txt_type.BackColor = System.Drawing.Color.White;
            this.txt_type.BorderColor = System.Drawing.Color.Black;
            this.txt_type.BorderRadius = 17;
            this.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type.DefaultText = "";
            this.txt_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_type.ForeColor = System.Drawing.Color.Black;
            this.txt_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Location = new System.Drawing.Point(52, 175);
            this.txt_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_type.Name = "txt_type";
            this.txt_type.PasswordChar = '\0';
            this.txt_type.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_type.PlaceholderText = "";
            this.txt_type.SelectedText = "";
            this.txt_type.Size = new System.Drawing.Size(212, 37);
            this.txt_type.TabIndex = 2;
            this.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_name
            // 
            this.txt_name.AutoRoundedCorners = true;
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderColor = System.Drawing.Color.Black;
            this.txt_name.BorderRadius = 17;
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
            this.txt_name.Location = new System.Drawing.Point(52, 87);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(212, 37);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txt_serch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serch.ForeColor = System.Drawing.Color.Black;
            this.txt_serch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_serch.Location = new System.Drawing.Point(22, 6);
            this.txt_serch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.PasswordChar = '\0';
            this.txt_serch.PlaceholderText = "";
            this.txt_serch.SelectedText = "";
            this.txt_serch.Size = new System.Drawing.Size(196, 29);
            this.txt_serch.TabIndex = 31;
            this.txt_serch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_serch.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.but_serche);
            this.guna2Panel1.Controls.Add(this.txt_serch);
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Panel1.Location = new System.Drawing.Point(21, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(346, 44);
            this.guna2Panel1.TabIndex = 33;
            // 
            // but_serche
            // 
            this.but_serche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_serche.BackColor = System.Drawing.Color.White;
            this.but_serche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.but_serche.BorderRadius = 18;
            this.but_serche.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_serche.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_serche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_serche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_serche.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.but_serche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_serche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but_serche.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_search_50px;
            this.but_serche.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_serche.Location = new System.Drawing.Point(224, 6);
            this.but_serche.Name = "but_serche";
            this.but_serche.PressedColor = System.Drawing.Color.Orange;
            this.but_serche.ShadowDecoration.BorderRadius = 15;
            this.but_serche.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.but_serche.Size = new System.Drawing.Size(90, 35);
            this.but_serche.TabIndex = 32;
            this.but_serche.Text = "بحث  ";
            this.but_serche.Click += new System.EventHandler(this.but_serche_Click);
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
            this.but_clos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.but_clos.ForeColor = System.Drawing.Color.White;
            this.but_clos.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_back_26px;
            this.but_clos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_clos.ImageSize = new System.Drawing.Size(30, 30);
            this.but_clos.Location = new System.Drawing.Point(245, 601);
            this.but_clos.Name = "but_clos";
            this.but_clos.Size = new System.Drawing.Size(122, 48);
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
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.but_delete.ForeColor = System.Drawing.Color.White;
            this.but_delete.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_Delete_16px;
            this.but_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.but_delete.Location = new System.Drawing.Point(528, 601);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(122, 48);
            this.but_delete.TabIndex = 11;
            this.but_delete.Text = "حذف";
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
            this.but_ubdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.but_ubdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but_ubdate.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_edit_26px;
            this.but_ubdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but_ubdate.Location = new System.Drawing.Point(805, 601);
            this.but_ubdate.Name = "but_ubdate";
            this.but_ubdate.Size = new System.Drawing.Size(122, 48);
            this.but_ubdate.TabIndex = 10;
            this.but_ubdate.Text = "تعديل";
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
            this.but1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.but1_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.but1_add.Image = global::WindowsFormsApplication3.Properties.Resources.icons8_Add_Male_User_Group_50px;
            this.but1_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.but1_add.ImageSize = new System.Drawing.Size(30, 30);
            this.but1_add.Location = new System.Drawing.Point(1081, 601);
            this.but1_add.Name = "but1_add";
            this.but1_add.ShadowDecoration.BorderRadius = 15;
            this.but1_add.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.but1_add.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.but1_add.Size = new System.Drawing.Size(122, 48);
            this.but1_add.TabIndex = 9;
            this.but1_add.Text = "اضافة     ";
            this.but1_add.Click += new System.EventHandler(this.but1_add_Click);
            // 
            // car
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.but_clos);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_ubdate);
            this.Controls.Add(this.but1_add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "car";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدرسة دلو";
            this.Load += new System.EventHandler(this.car_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button but1_add;
        private Guna.UI2.WinForms.Guna2Button but_ubdate;
        private Guna.UI2.WinForms.Guna2Button but_delete;
        private Guna.UI2.WinForms.Guna2Button but_clos;
        private Guna.UI2.WinForms.Guna2TextBox txt_num;
        private Guna.UI2.WinForms.Guna2TextBox txt_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_serch;
        private Guna.UI2.WinForms.Guna2Button but_serche;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_mstlm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox com_jah;
        private System.Windows.Forms.Label label6;
    }
}