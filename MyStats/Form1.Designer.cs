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
            this.rBtn_TempTeacher = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbl_SwapTeacher = new System.Windows.Forms.Label();
            this.lbl_MainTeacher = new System.Windows.Forms.Label();
            this.rBtn_MainTeacher = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.tBox_Content = new System.Windows.Forms.TextBox();
            this.pic_Edit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_LessonContent = new System.Windows.Forms.Panel();
            this.pnl_Students = new Guna.UI2.WinForms.Guna2Panel();
            this.student6 = new MyStats.Controls.Student();
            this.student5 = new MyStats.Controls.Student();
            this.student4 = new MyStats.Controls.Student();
            this.student3 = new MyStats.Controls.Student();
            this.student2 = new MyStats.Controls.Student();
            this.student1 = new MyStats.Controls.Student();
            this.pnl_Labels = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_CrystalCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AllExist = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edit)).BeginInit();
            this.pnl_LessonContent.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            this.pnl_Labels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GroupInfo
            // 
            this.lbl_GroupInfo.AutoSize = true;
            this.lbl_GroupInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GroupInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GroupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(167)))), ((int)(((byte)(246)))));
            this.lbl_GroupInfo.Location = new System.Drawing.Point(10, 7);
            this.lbl_GroupInfo.Name = "lbl_GroupInfo";
            this.lbl_GroupInfo.Size = new System.Drawing.Size(439, 25);
            this.lbl_GroupInfo.TabIndex = 0;
            this.lbl_GroupInfo.Text = "FBAS_2214_AZ (Windows Forms and WPF (CT - 3))";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtn_TempTeacher);
            this.panel1.Controls.Add(this.lbl_SwapTeacher);
            this.panel1.Controls.Add(this.lbl_MainTeacher);
            this.panel1.Controls.Add(this.rBtn_MainTeacher);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(10, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 96);
            this.panel1.TabIndex = 1;
            // 
            // rBtn_TempTeacher
            // 
            this.rBtn_TempTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtn_TempTeacher.Animated = true;
            this.rBtn_TempTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_TempTeacher.CheckedState.BorderThickness = 0;
            this.rBtn_TempTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_TempTeacher.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_TempTeacher.Location = new System.Drawing.Point(12, 52);
            this.rBtn_TempTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_TempTeacher.Name = "rBtn_TempTeacher";
            this.rBtn_TempTeacher.Size = new System.Drawing.Size(18, 16);
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
            this.lbl_SwapTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_SwapTeacher.AutoSize = true;
            this.lbl_SwapTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SwapTeacher.Location = new System.Drawing.Point(36, 49);
            this.lbl_SwapTeacher.Name = "lbl_SwapTeacher";
            this.lbl_SwapTeacher.Size = new System.Drawing.Size(137, 19);
            this.lbl_SwapTeacher.TabIndex = 10;
            this.lbl_SwapTeacher.Text = "Müəllim əvəz olunur";
            this.lbl_SwapTeacher.Click += new System.EventHandler(this.lbl_SwapTeacher_Click);
            // 
            // lbl_MainTeacher
            // 
            this.lbl_MainTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MainTeacher.AutoSize = true;
            this.lbl_MainTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_MainTeacher.Location = new System.Drawing.Point(36, 23);
            this.lbl_MainTeacher.Name = "lbl_MainTeacher";
            this.lbl_MainTeacher.Size = new System.Drawing.Size(95, 19);
            this.lbl_MainTeacher.TabIndex = 9;
            this.lbl_MainTeacher.Text = "Əsas müəllim";
            this.lbl_MainTeacher.Click += new System.EventHandler(this.lbl_MainTeacher_Click);
            // 
            // rBtn_MainTeacher
            // 
            this.rBtn_MainTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtn_MainTeacher.Animated = true;
            this.rBtn_MainTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_MainTeacher.CheckedState.BorderThickness = 0;
            this.rBtn_MainTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.Location = new System.Drawing.Point(12, 26);
            this.rBtn_MainTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_MainTeacher.Name = "rBtn_MainTeacher";
            this.rBtn_MainTeacher.Size = new System.Drawing.Size(18, 16);
            this.rBtn_MainTeacher.TabIndex = 7;
            this.rBtn_MainTeacher.Text = "rBtn_MainTeacher";
            this.rBtn_MainTeacher.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.rBtn_MainTeacher.UncheckedState.BorderThickness = 2;
            this.rBtn_MainTeacher.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_MainTeacher.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBtn_MainTeacher.CheckedChanged += new System.EventHandler(this.rBtn_Teahcer_CheckedChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 15;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(369, 24);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(74, 28);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BorderRadius = 15;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(288, 24);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 28);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_AddMaterial
            // 
            this.btn_AddMaterial.BorderRadius = 15;
            this.btn_AddMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.btn_AddMaterial.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddMaterial.ForeColor = System.Drawing.Color.White;
            this.btn_AddMaterial.Location = new System.Drawing.Point(288, 54);
            this.btn_AddMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddMaterial.Name = "btn_AddMaterial";
            this.btn_AddMaterial.Size = new System.Drawing.Size(155, 28);
            this.btn_AddMaterial.TabIndex = 5;
            this.btn_AddMaterial.Text = "Material Əlavə Etmək";
            this.btn_AddMaterial.Click += new System.EventHandler(this.btn_AddMaterial_Click);
            // 
            // tBox_Content
            // 
            this.tBox_Content.Enabled = false;
            this.tBox_Content.Location = new System.Drawing.Point(3, 22);
            this.tBox_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox_Content.Multiline = true;
            this.tBox_Content.Name = "tBox_Content";
            this.tBox_Content.Size = new System.Drawing.Size(275, 64);
            this.tBox_Content.TabIndex = 4;
            // 
            // pic_Edit
            // 
            this.pic_Edit.BackColor = System.Drawing.Color.Transparent;
            this.pic_Edit.Image = global::MyStats.Properties.Resources.edit_25px;
            this.pic_Edit.ImageRotate = 0F;
            this.pic_Edit.Location = new System.Drawing.Point(130, 1);
            this.pic_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Edit.Name = "pic_Edit";
            this.pic_Edit.Size = new System.Drawing.Size(22, 19);
            this.pic_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Edit.TabIndex = 3;
            this.pic_Edit.TabStop = false;
            this.pic_Edit.Click += new System.EventHandler(this.pic_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dərsin Mövzusu:";
            // 
            // pnl_LessonContent
            // 
            this.pnl_LessonContent.Controls.Add(this.tBox_Content);
            this.pnl_LessonContent.Controls.Add(this.btn_Cancel);
            this.pnl_LessonContent.Controls.Add(this.pic_Edit);
            this.pnl_LessonContent.Controls.Add(this.label1);
            this.pnl_LessonContent.Controls.Add(this.btn_Save);
            this.pnl_LessonContent.Controls.Add(this.btn_AddMaterial);
            this.pnl_LessonContent.Enabled = false;
            this.pnl_LessonContent.Location = new System.Drawing.Point(643, 36);
            this.pnl_LessonContent.Name = "pnl_LessonContent";
            this.pnl_LessonContent.Size = new System.Drawing.Size(444, 98);
            this.pnl_LessonContent.TabIndex = 15;
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
            this.pnl_Students.Location = new System.Drawing.Point(10, 214);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1077, 404);
            this.pnl_Students.TabIndex = 3;
            // 
            // student6
            // 
            this.student6.BirthDate = "26.05.2022";
            this.student6.CurrentForm = null;
            this.student6.ID = "6";
            this.student6.Location = new System.Drawing.Point(3, 400);
            this.student6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student6.Name = "student6";
            this.student6.ProfilePicture = ((System.Drawing.Image)(resources.GetObject("student6.ProfilePicture")));
            this.student6.Size = new System.Drawing.Size(1035, 74);
            this.student6.StudentName = "Ağamətləb Əkbərzade Mətləb";
            this.student6.TabIndex = 6;
            // 
            // student5
            // 
            this.student5.BirthDate = "26.05.2022";
            this.student5.CurrentForm = null;
            this.student5.ID = "5";
            this.student5.Location = new System.Drawing.Point(3, 322);
            this.student5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student5.Name = "student5";
            this.student5.ProfilePicture = global::MyStats.Properties.Resources.Leyla;
            this.student5.Size = new System.Drawing.Size(1035, 74);
            this.student5.StudentName = "Leyla Qocayeva Zaur";
            this.student5.TabIndex = 5;
            // 
            // student4
            // 
            this.student4.BirthDate = "26.05.2022";
            this.student4.CurrentForm = null;
            this.student4.ID = "4";
            this.student4.Location = new System.Drawing.Point(3, 246);
            this.student4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student4.Name = "student4";
            this.student4.ProfilePicture = global::MyStats.Properties.Resources.Nihad;
            this.student4.Size = new System.Drawing.Size(1035, 74);
            this.student4.StudentName = "Nihad Axunzadə Rəfi";
            this.student4.TabIndex = 4;
            // 
            // student3
            // 
            this.student3.BirthDate = "23.05.2022";
            this.student3.CurrentForm = null;
            this.student3.ID = "3";
            this.student3.Location = new System.Drawing.Point(3, 167);
            this.student3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student3.Name = "student3";
            this.student3.ProfilePicture = global::MyStats.Properties.Resources.Ferman;
            this.student3.Size = new System.Drawing.Size(1035, 74);
            this.student3.StudentName = "Fərman Əsədov Süleyman";
            this.student3.TabIndex = 3;
            // 
            // student2
            // 
            this.student2.BirthDate = "26.05.2022";
            this.student2.CurrentForm = null;
            this.student2.ID = "2";
            this.student2.Location = new System.Drawing.Point(3, 88);
            this.student2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student2.Name = "student2";
            this.student2.ProfilePicture = global::MyStats.Properties.Resources.Sebine;
            this.student2.Size = new System.Drawing.Size(1035, 74);
            this.student2.StudentName = "Səbinə Şükürova Bəxtiyar";
            this.student2.TabIndex = 2;
            // 
            // student1
            // 
            this.student1.BirthDate = "24.05.2022";
            this.student1.CurrentForm = null;
            this.student1.ID = "1";
            this.student1.Location = new System.Drawing.Point(3, 10);
            this.student1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student1.Name = "student1";
            this.student1.ProfilePicture = global::MyStats.Properties.Resources.Jafar_PP;
            this.student1.Size = new System.Drawing.Size(1035, 74);
            this.student1.StudentName = "İmaməliyev Cəfər Yavər";
            this.student1.TabIndex = 1;
            // 
            // pnl_Labels
            // 
            this.pnl_Labels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_Labels.Controls.Add(this.pictureBox1);
            this.pnl_Labels.Controls.Add(this.lbl_CrystalCount);
            this.pnl_Labels.Controls.Add(this.label8);
            this.pnl_Labels.Controls.Add(this.label7);
            this.pnl_Labels.Controls.Add(this.btn_AllExist);
            this.pnl_Labels.Controls.Add(this.label6);
            this.pnl_Labels.Controls.Add(this.label5);
            this.pnl_Labels.Controls.Add(this.label2);
            this.pnl_Labels.Controls.Add(this.guna2Separator1);
            this.pnl_Labels.Enabled = false;
            this.pnl_Labels.Location = new System.Drawing.Point(10, 156);
            this.pnl_Labels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Labels.Name = "pnl_Labels";
            this.pnl_Labels.Size = new System.Drawing.Size(1076, 52);
            this.pnl_Labels.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStats.Properties.Resources.christal;
            this.pictureBox1.Location = new System.Drawing.Point(849, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_CrystalCount
            // 
            this.lbl_CrystalCount.AutoSize = true;
            this.lbl_CrystalCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lbl_CrystalCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CrystalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_CrystalCount.Location = new System.Drawing.Point(823, 14);
            this.lbl_CrystalCount.Name = "lbl_CrystalCount";
            this.lbl_CrystalCount.Size = new System.Drawing.Size(19, 21);
            this.lbl_CrystalCount.TabIndex = 24;
            this.lbl_CrystalCount.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(714, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sinifdə iş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(606, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
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
            this.btn_AllExist.Location = new System.Drawing.Point(508, 21);
            this.btn_AllExist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AllExist.Name = "btn_AllExist";
            this.btn_AllExist.Size = new System.Drawing.Size(25, 15);
            this.btn_AllExist.TabIndex = 21;
            this.btn_AllExist.Click += new System.EventHandler(this.btn_AllExist_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(456, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hər kəsi qeyd etmək";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(312, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "MyStats\'a daxil olub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı / Soyadı / Ata adı";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(244)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(4, 37);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1034, 14);
            this.guna2Separator1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.pnl_Labels);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_LessonContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_GroupInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edit)).EndInit();
            this.pnl_LessonContent.ResumeLayout(false);
            this.pnl_LessonContent.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Labels.ResumeLayout(false);
            this.pnl_Labels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_GroupInfo;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Edit;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_AddMaterial;
        private TextBox tBox_Content;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_TempTeacher;
        private Label lbl_SwapTeacher;
        private Label lbl_MainTeacher;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_MainTeacher;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Panel pnl_LessonContent;
        private Guna.UI2.WinForms.Guna2Panel pnl_Students;
        private Controls.Student student6;
        private Controls.Student student5;
        private Controls.Student student4;
        private Controls.Student student3;
        private Controls.Student student2;
        private Controls.Student student1;
        private Guna.UI2.WinForms.Guna2Panel pnl_Labels;
        private PictureBox pictureBox1;
        public Label lbl_CrystalCount;
        private Label label8;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_AllExist;
        private Label label6;
        private Label label5;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}