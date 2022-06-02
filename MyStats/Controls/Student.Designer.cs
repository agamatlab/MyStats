namespace MyStats.Controls
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.rBtn_Exist = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.pic_Profile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rBtn_Late = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rBtn_Absent = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cmb_LabWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_LessonWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cBox_Crystal1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.cBox_Crystal2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.cBox_Crystal3 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btn_ClearCrystal = new System.Windows.Forms.Button();
            this.btn_AddDesc = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.Location = new System.Drawing.Point(15, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(28, 32);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "0";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(125, 32);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(150, 19);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name Surname Father";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_BirthDate.Location = new System.Drawing.Point(331, 33);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(79, 19);
            this.lbl_BirthDate.TabIndex = 3;
            this.lbl_BirthDate.Text = "00.00.0000";
            // 
            // rBtn_Exist
            // 
            this.rBtn_Exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBtn_Exist.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_Exist.CheckedState.BorderThickness = 0;
            this.rBtn_Exist.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.rBtn_Exist.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.rBtn_Exist.Location = new System.Drawing.Point(474, 33);
            this.rBtn_Exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Exist.Name = "rBtn_Exist";
            this.rBtn_Exist.Size = new System.Drawing.Size(18, 16);
            this.rBtn_Exist.TabIndex = 6;
            this.rBtn_Exist.Text = "guna2CustomRadioButton1";
            this.rBtn_Exist.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.rBtn_Exist.UncheckedState.BorderThickness = 2;
            this.rBtn_Exist.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_Exist.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pic_Profile
            // 
            this.pic_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_Profile.ImageRotate = 0F;
            this.pic_Profile.Location = new System.Drawing.Point(49, 7);
            this.pic_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Profile.Name = "pic_Profile";
            this.pic_Profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Profile.Size = new System.Drawing.Size(60, 60);
            this.pic_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Profile.TabIndex = 5;
            this.pic_Profile.TabStop = false;
            this.pic_Profile.Click += new System.EventHandler(this.pic_Profile_Click);
            // 
            // rBtn_Late
            // 
            this.rBtn_Late.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBtn_Late.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_Late.CheckedState.BorderThickness = 0;
            this.rBtn_Late.CheckedState.FillColor = System.Drawing.Color.Yellow;
            this.rBtn_Late.CheckedState.InnerColor = System.Drawing.Color.Yellow;
            this.rBtn_Late.Location = new System.Drawing.Point(507, 33);
            this.rBtn_Late.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Late.Name = "rBtn_Late";
            this.rBtn_Late.Size = new System.Drawing.Size(18, 16);
            this.rBtn_Late.TabIndex = 7;
            this.rBtn_Late.Text = "guna2CustomRadioButton2";
            this.rBtn_Late.UncheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.rBtn_Late.UncheckedState.BorderThickness = 2;
            this.rBtn_Late.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_Late.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rBtn_Absent
            // 
            this.rBtn_Absent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rBtn_Absent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBtn_Absent.CheckedState.BorderThickness = 0;
            this.rBtn_Absent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rBtn_Absent.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rBtn_Absent.Location = new System.Drawing.Point(539, 33);
            this.rBtn_Absent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Absent.Name = "rBtn_Absent";
            this.rBtn_Absent.Size = new System.Drawing.Size(18, 16);
            this.rBtn_Absent.TabIndex = 8;
            this.rBtn_Absent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rBtn_Absent.UncheckedState.BorderThickness = 2;
            this.rBtn_Absent.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBtn_Absent.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBtn_Absent.CheckedChanged += new System.EventHandler(this.rBtn_Absent_CheckedChanged);
            // 
            // cmb_LabWork
            // 
            this.cmb_LabWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_LabWork.BackColor = System.Drawing.Color.Transparent;
            this.cmb_LabWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.cmb_LabWork.BorderRadius = 10;
            this.cmb_LabWork.BorderThickness = 3;
            this.cmb_LabWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_LabWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LabWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_LabWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_LabWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_LabWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_LabWork.ItemHeight = 30;
            this.cmb_LabWork.Location = new System.Drawing.Point(610, 27);
            this.cmb_LabWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_LabWork.Name = "cmb_LabWork";
            this.cmb_LabWork.Size = new System.Drawing.Size(75, 36);
            this.cmb_LabWork.TabIndex = 9;
            // 
            // cmb_LessonWork
            // 
            this.cmb_LessonWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_LessonWork.BackColor = System.Drawing.Color.Transparent;
            this.cmb_LessonWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(231)))), ((int)(((byte)(182)))));
            this.cmb_LessonWork.BorderRadius = 10;
            this.cmb_LessonWork.BorderThickness = 3;
            this.cmb_LessonWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_LessonWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LessonWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_LessonWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_LessonWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_LessonWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_LessonWork.ItemHeight = 30;
            this.cmb_LessonWork.Location = new System.Drawing.Point(703, 28);
            this.cmb_LessonWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_LessonWork.Name = "cmb_LessonWork";
            this.cmb_LessonWork.Size = new System.Drawing.Size(75, 36);
            this.cmb_LessonWork.TabIndex = 10;
            // 
            // cBox_Crystal1
            // 
            this.cBox_Crystal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_Crystal1.CheckedState.Image = global::MyStats.Properties.Resources.christal;
            this.cBox_Crystal1.Image = global::MyStats.Properties.Resources.christal_non_checked;
            this.cBox_Crystal1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cBox_Crystal1.ImageRotate = 0F;
            this.cBox_Crystal1.Location = new System.Drawing.Point(807, 30);
            this.cBox_Crystal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_Crystal1.Name = "cBox_Crystal1";
            this.cBox_Crystal1.Size = new System.Drawing.Size(26, 22);
            this.cBox_Crystal1.TabIndex = 11;
            this.cBox_Crystal1.Tag = "1";
            this.cBox_Crystal1.Click += new System.EventHandler(this.cBox_Crystal_Click);
            // 
            // cBox_Crystal2
            // 
            this.cBox_Crystal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_Crystal2.CheckedState.Image = global::MyStats.Properties.Resources.christal;
            this.cBox_Crystal2.Image = global::MyStats.Properties.Resources.christal_non_checked;
            this.cBox_Crystal2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cBox_Crystal2.ImageRotate = 0F;
            this.cBox_Crystal2.Location = new System.Drawing.Point(835, 30);
            this.cBox_Crystal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_Crystal2.Name = "cBox_Crystal2";
            this.cBox_Crystal2.Size = new System.Drawing.Size(26, 22);
            this.cBox_Crystal2.TabIndex = 12;
            this.cBox_Crystal2.Tag = "2";
            this.cBox_Crystal2.Click += new System.EventHandler(this.cBox_Crystal_Click);
            // 
            // cBox_Crystal3
            // 
            this.cBox_Crystal3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_Crystal3.CheckedState.Image = global::MyStats.Properties.Resources.christal;
            this.cBox_Crystal3.Image = global::MyStats.Properties.Resources.christal_non_checked;
            this.cBox_Crystal3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cBox_Crystal3.ImageRotate = 0F;
            this.cBox_Crystal3.Location = new System.Drawing.Point(863, 30);
            this.cBox_Crystal3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_Crystal3.Name = "cBox_Crystal3";
            this.cBox_Crystal3.Size = new System.Drawing.Size(26, 22);
            this.cBox_Crystal3.TabIndex = 13;
            this.cBox_Crystal3.Tag = "3";
            this.cBox_Crystal3.Click += new System.EventHandler(this.cBox_Crystal_Click);
            // 
            // btn_ClearCrystal
            // 
            this.btn_ClearCrystal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearCrystal.FlatAppearance.BorderSize = 0;
            this.btn_ClearCrystal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearCrystal.Image = global::MyStats.Properties.Resources.xamarin_30px;
            this.btn_ClearCrystal.Location = new System.Drawing.Point(896, 31);
            this.btn_ClearCrystal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearCrystal.Name = "btn_ClearCrystal";
            this.btn_ClearCrystal.Size = new System.Drawing.Size(22, 19);
            this.btn_ClearCrystal.TabIndex = 14;
            this.btn_ClearCrystal.UseVisualStyleBackColor = true;
            this.btn_ClearCrystal.Click += new System.EventHandler(this.btn_ClearCrystal_Click);
            // 
            // btn_AddDesc
            // 
            this.btn_AddDesc.Animated = true;
            this.btn_AddDesc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddDesc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddDesc.ForeColor = System.Drawing.Color.White;
            this.btn_AddDesc.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddDesc.Image")));
            this.btn_AddDesc.Location = new System.Drawing.Point(934, 30);
            this.btn_AddDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddDesc.Name = "btn_AddDesc";
            this.btn_AddDesc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_AddDesc.Size = new System.Drawing.Size(26, 22);
            this.btn_AddDesc.TabIndex = 15;
            this.btn_AddDesc.Click += new System.EventHandler(this.btn_AddDesc_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(244)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 65);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1045, 15);
            this.guna2Separator1.TabIndex = 16;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Description.Location = new System.Drawing.Point(924, 7);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(114, 60);
            this.lbl_Description.TabIndex = 17;
            this.lbl_Description.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Profile);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btn_AddDesc);
            this.Controls.Add(this.btn_ClearCrystal);
            this.Controls.Add(this.cBox_Crystal3);
            this.Controls.Add(this.cBox_Crystal2);
            this.Controls.Add(this.cBox_Crystal1);
            this.Controls.Add(this.cmb_LessonWork);
            this.Controls.Add(this.cmb_LabWork);
            this.Controls.Add(this.rBtn_Absent);
            this.Controls.Add(this.rBtn_Late);
            this.Controls.Add(this.rBtn_Exist);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(1050, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ID;
        private Label lbl_Name;
        private Label lbl_BirthDate;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_Exist;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Profile;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_Late;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rBtn_Absent;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_LabWork;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_LessonWork;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cBox_Crystal1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cBox_Crystal2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox cBox_Crystal3;
        private Button btn_ClearCrystal;
        private Guna.UI2.WinForms.Guna2CircleButton btn_AddDesc;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label lbl_Description;
    }
}
