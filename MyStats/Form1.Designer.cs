namespace MyStats
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_GroupInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.rBtn_TempTeacher = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbl_SwapTeacher = new System.Windows.Forms.Label();
            this.lbl_MainTeacher = new System.Windows.Forms.Label();
            this.rBtn_MainTeacher = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tBox_Content = new System.Windows.Forms.TextBox();
            this.pic_Edit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Students = new Guna.UI2.WinForms.Guna2Panel();
            this.student6 = new MyStats.Controls.Student();
            this.student5 = new MyStats.Controls.Student();
            this.student4 = new MyStats.Controls.Student();
            this.student3 = new MyStats.Controls.Student();
            this.student2 = new MyStats.Controls.Student();
            this.student1 = new MyStats.Controls.Student();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_CrystalCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AllExist = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edit)).BeginInit();
            this.pnl_Students.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GroupInfo
            // 
            this.lbl_GroupInfo.AutoSize = true;
            this.lbl_GroupInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GroupInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GroupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(246)))));
            this.lbl_GroupInfo.Location = new System.Drawing.Point(12, 9);
            this.lbl_GroupInfo.Name = "lbl_GroupInfo";
            this.lbl_GroupInfo.Size = new System.Drawing.Size(558, 32);
            this.lbl_GroupInfo.TabIndex = 0;
            this.lbl_GroupInfo.Text = "FBAS_2214_AZ (Windows Forms and WPF (CT - 3))";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.rBtn_TempTeacher);
            this.panel1.Controls.Add(this.lbl_SwapTeacher);
            this.panel1.Controls.Add(this.lbl_MainTeacher);
            this.panel1.Controls.Add(this.rBtn_MainTeacher);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.tBox_Content);
            this.panel1.Controls.Add(this.pic_Edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 128);
            this.panel1.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 20;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(1137, 33);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 38);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BorderRadius = 20;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1049, 33);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 38);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.Visible = false;
            // 
            // rBtn_TempTeacher
            // 
            this.rBtn_TempTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBtn_TempTeacher.Animated = true;
            this.rBtn_TempTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_TempTeacher.CheckedState.BorderThickness = 0;
            this.rBtn_TempTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_TempTeacher.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_TempTeacher.Location = new System.Drawing.Point(15, 48);
            this.rBtn_TempTeacher.Name = "rBtn_TempTeacher";
            this.rBtn_TempTeacher.Size = new System.Drawing.Size(20, 21);
            this.rBtn_TempTeacher.TabIndex = 12;
            this.rBtn_TempTeacher.Text = "rBtn_ReplacementTeacher";
            this.rBtn_TempTeacher.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_TempTeacher.UncheckedState.BorderThickness = 2;
            this.rBtn_TempTeacher.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_TempTeacher.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBtn_TempTeacher.CheckedChanged += new System.EventHandler(this.rBtn_Teahcer_CheckedChanged);
            // 
            // lbl_SwapTeacher
            // 
            this.lbl_SwapTeacher.AutoSize = true;
            this.lbl_SwapTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SwapTeacher.Location = new System.Drawing.Point(41, 48);
            this.lbl_SwapTeacher.Name = "lbl_SwapTeacher";
            this.lbl_SwapTeacher.Size = new System.Drawing.Size(168, 23);
            this.lbl_SwapTeacher.TabIndex = 10;
            this.lbl_SwapTeacher.Text = "Müəllim əvəz olunur";
            this.lbl_SwapTeacher.Click += new System.EventHandler(this.lbl_SwapTeacher_Click);
            // 
            // lbl_MainTeacher
            // 
            this.lbl_MainTeacher.AutoSize = true;
            this.lbl_MainTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_MainTeacher.Location = new System.Drawing.Point(41, 13);
            this.lbl_MainTeacher.Name = "lbl_MainTeacher";
            this.lbl_MainTeacher.Size = new System.Drawing.Size(116, 23);
            this.lbl_MainTeacher.TabIndex = 9;
            this.lbl_MainTeacher.Text = "Əsas müəllim";
            this.lbl_MainTeacher.Click += new System.EventHandler(this.lbl_MainTeacher_Click);
            // 
            // rBtn_MainTeacher
            // 
            this.rBtn_MainTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBtn_MainTeacher.Animated = true;
            this.rBtn_MainTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_MainTeacher.CheckedState.BorderThickness = 0;
            this.rBtn_MainTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.Location = new System.Drawing.Point(15, 13);
            this.rBtn_MainTeacher.Name = "rBtn_MainTeacher";
            this.rBtn_MainTeacher.Size = new System.Drawing.Size(20, 21);
            this.rBtn_MainTeacher.TabIndex = 7;
            this.rBtn_MainTeacher.Text = "rBtn_MainTeacher";
            this.rBtn_MainTeacher.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.UncheckedState.BorderThickness = 2;
            this.rBtn_MainTeacher.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_MainTeacher.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBtn_MainTeacher.CheckedChanged += new System.EventHandler(this.rBtn_Teahcer_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1049, 72);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(173, 38);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Material Əlavə Etmək";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tBox_Content
            // 
            this.tBox_Content.Enabled = false;
            this.tBox_Content.Location = new System.Drawing.Point(715, 31);
            this.tBox_Content.Multiline = true;
            this.tBox_Content.Name = "tBox_Content";
            this.tBox_Content.Size = new System.Drawing.Size(314, 84);
            this.tBox_Content.TabIndex = 4;
            // 
            // pic_Edit
            // 
            this.pic_Edit.BackColor = System.Drawing.Color.Transparent;
            this.pic_Edit.Image = global::MyStats.Properties.Resources.edit_25px;
            this.pic_Edit.ImageRotate = 0F;
            this.pic_Edit.Location = new System.Drawing.Point(861, 3);
            this.pic_Edit.Name = "pic_Edit";
            this.pic_Edit.Size = new System.Drawing.Size(25, 25);
            this.pic_Edit.TabIndex = 3;
            this.pic_Edit.TabStop = false;
            this.pic_Edit.Click += new System.EventHandler(this.pic_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(715, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dərsin Mövzusu:";
            // 
            // pnl_Students
            // 
            this.pnl_Students.AutoScroll = true;
            this.pnl_Students.Controls.Add(this.student6);
            this.pnl_Students.Controls.Add(this.student5);
            this.pnl_Students.Controls.Add(this.student4);
            this.pnl_Students.Controls.Add(this.student3);
            this.pnl_Students.Controls.Add(this.student2);
            this.pnl_Students.Controls.Add(this.student1);
            this.pnl_Students.Enabled = false;
            this.pnl_Students.Location = new System.Drawing.Point(12, 258);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1238, 538);
            this.pnl_Students.TabIndex = 3;
            // 
            // student6
            // 
            this.student6.BirthDate = "26.05.2022";
            this.student6.ID = "6";
            this.student6.Location = new System.Drawing.Point(3, 534);
            this.student6.Name = "student6";
            this.student6.ProfilePicture = ((System.Drawing.Image)(resources.GetObject("student6.ProfilePicture")));
            this.student6.Size = new System.Drawing.Size(1204, 99);
            this.student6.StudentName = "Ağamətləb Əkbərzade Mətləb";
            this.student6.TabIndex = 6;
            // 
            // student5
            // 
            this.student5.BirthDate = "26.05.2022";
            this.student5.ID = "5";
            this.student5.Location = new System.Drawing.Point(3, 429);
            this.student5.Name = "student5";
            this.student5.ProfilePicture = global::MyStats.Properties.Resources.Leyla;
            this.student5.Size = new System.Drawing.Size(1204, 99);
            this.student5.StudentName = "Leyla Qocayeva Zaur";
            this.student5.TabIndex = 5;
            this.student5.Load += new System.EventHandler(this.student5_Load);
            // 
            // student4
            // 
            this.student4.BirthDate = "26.05.2022";
            this.student4.ID = "4";
            this.student4.Location = new System.Drawing.Point(3, 328);
            this.student4.Name = "student4";
            this.student4.ProfilePicture = global::MyStats.Properties.Resources.Nihad;
            this.student4.Size = new System.Drawing.Size(1204, 99);
            this.student4.StudentName = "Nihad Axunzadə Rəfi";
            this.student4.TabIndex = 4;
            // 
            // student3
            // 
            this.student3.BirthDate = "23.05.2022";
            this.student3.ID = "3";
            this.student3.Location = new System.Drawing.Point(3, 223);
            this.student3.Name = "student3";
            this.student3.ProfilePicture = global::MyStats.Properties.Resources.Ferman;
            this.student3.Size = new System.Drawing.Size(1204, 99);
            this.student3.StudentName = "Fərman Əsədov Süleyman";
            this.student3.TabIndex = 3;
            // 
            // student2
            // 
            this.student2.BirthDate = "26.05.2022";
            this.student2.ID = "2";
            this.student2.Location = new System.Drawing.Point(3, 118);
            this.student2.Name = "student2";
            this.student2.ProfilePicture = global::MyStats.Properties.Resources.Sebine;
            this.student2.Size = new System.Drawing.Size(1204, 99);
            this.student2.StudentName = "Səbinə Şükürova Bəxtiyar";
            this.student2.TabIndex = 2;
            // 
            // student1
            // 
            this.student1.BirthDate = "24.05.2022";
            this.student1.ID = "1";
            this.student1.Location = new System.Drawing.Point(3, 13);
            this.student1.Name = "student1";
            this.student1.ProfilePicture = global::MyStats.Properties.Resources.Jafar_PP;
            this.student1.Size = new System.Drawing.Size(1204, 99);
            this.student1.StudentName = "İmaməliyev Cəfər Yavər";
            this.student1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(lbl_CrystalCount);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.btn_AllExist);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.guna2Separator1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 182);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1196, 70);
            this.guna2Panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStats.Properties.Resources.christal;
            this.pictureBox1.Location = new System.Drawing.Point(970, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_CrystalCount
            // 
            lbl_CrystalCount.AutoSize = true;
            lbl_CrystalCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            lbl_CrystalCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_CrystalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            lbl_CrystalCount.Location = new System.Drawing.Point(941, 24);
            lbl_CrystalCount.Name = "lbl_CrystalCount";
            lbl_CrystalCount.Size = new System.Drawing.Size(23, 28);
            lbl_CrystalCount.TabIndex = 24;
            lbl_CrystalCount.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(816, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sinifdə iş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(693, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yoxlama işlər";
            // 
            // btn_AllExist
            // 
            this.btn_AllExist.Animated = true;
            this.btn_AllExist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllExist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllExist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AllExist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AllExist.FillColor = System.Drawing.Color.Transparent;
            this.btn_AllExist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AllExist.ForeColor = System.Drawing.Color.White;
            this.btn_AllExist.Image = global::MyStats.Properties.Resources.circle_25px;
            this.btn_AllExist.Location = new System.Drawing.Point(581, 34);
            this.btn_AllExist.Name = "btn_AllExist";
            this.btn_AllExist.Size = new System.Drawing.Size(29, 20);
            this.btn_AllExist.TabIndex = 21;
            this.btn_AllExist.Click += new System.EventHandler(this.btn_AllExist_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(521, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hər kəsi qeyd etmək";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(356, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "MyStats\'a daxil olub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(162, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı / Soyadı / Ata adı";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(244)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 53);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1194, 20);
            this.guna2Separator1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 853);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_GroupInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edit)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_GroupInfo;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Edit;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox tBox_Content;
        private Guna.UI2.WinForms.Guna2Panel pnl_Students;
        private Controls.Student student2;
        private Controls.Student student1;
        private Controls.Student student5;
        private Controls.Student student4;
        private Controls.Student student3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_TempTeacher;
        private Label lbl_SwapTeacher;
        private Label lbl_MainTeacher;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_MainTeacher;
        private Controls.Student student6;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_AllExist;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        public static Label lbl_CrystalCount;
    }
}