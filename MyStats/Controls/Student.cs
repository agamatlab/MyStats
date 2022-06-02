using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStats.Controls
{
    public partial class Student : UserControl
    {
        public enum Participate
        {
            Absent,Late,Exist
        }

        public Image ProfilePicture {
            get { return pic_Profile.Image; }
            set { pic_Profile.Image = value; }
        }

        public string StudentName{
            get { return lbl_Name.Text; }
            set { lbl_Name.Text = value; }
        }

        public string ID{
            get { return lbl_ID.Text; }
            set { lbl_ID.Text = value; }
        }

        public string BirthDate {
            get { return lbl_BirthDate.Text; }
            set { lbl_BirthDate.Text = value; } 
        }

        public Participate ParticipateStatus {
            set {
                if (value == Participate.Absent)
                    rBtn_Absent.Checked = true;
                else if (value == Participate.Late)
                    rBtn_Late.Checked = true;
                else if (value == Participate.Exist)
                    rBtn_Exist.Checked = true;
                else
                    throw new NotImplementedException();
            } 
        }

        private int CurrentGemCount { get; set; } = default;

        public Student()
        {
            InitializeComponent();
            cmb_LabWork.DataSource = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; ;
            cmb_LessonWork.DataSource = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; ;
        }

        private void btn_ClearCrystal_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
                if(item is Guna2ImageCheckBox cBox)
                {
                    if (cBox.Checked)
                    {
                        var crystalCount = Convert.ToByte(Form1.lbl_CrystalCount.Text);
                        if (crystalCount < Form1.MaxCrystalCount)
                            Form1.lbl_CrystalCount.Text = 
                                (crystalCount + 1).ToString();
                        
                        cBox.Checked = false;
                    }
                }

            CurrentGemCount = 0;
        }

        private void cBox_Crystal_Click(object sender, EventArgs e)
        {
            int gemCount = Convert.ToInt32(Form1.lbl_CrystalCount.Text);
            int clickedNumber = Convert.ToInt32((sender as Guna2ImageCheckBox).Tag);
            int activationNumber = clickedNumber;

            if (clickedNumber < CurrentGemCount)
            {
                activationNumber = clickedNumber;
                Form1.lbl_CrystalCount.Text = (gemCount + (CurrentGemCount - clickedNumber)).ToString();

            }
            else if (clickedNumber > CurrentGemCount)
            {
                if (gemCount == 0)
                {
                    var cBox = sender as Guna2ImageCheckBox;
                    cBox.Checked = false;
                    return;
                }

                if(CurrentGemCount != 0)
                activationNumber = Math.Min(clickedNumber - CurrentGemCount, gemCount);
                Form1.lbl_CrystalCount.Text = (gemCount - (activationNumber - CurrentGemCount)).ToString();
            }

            ActivateCrystal(activationNumber);
        }

        void ActivateCrystal(int num)
        {

            cBox_Crystal1.Checked = num >= 1;
            cBox_Crystal2.Checked = num >= 2;
            cBox_Crystal3.Checked = num >= 3;
            
            CurrentGemCount = num;
        }


        private void rBtn_Absent_CheckedChanged(object sender, EventArgs e)
        {
            btn_ClearCrystal.Enabled = !rBtn_Absent.Checked;
            foreach (var item in Controls)
                if(item is Guna2ImageCheckBox crystal)
                    crystal.Enabled = !rBtn_Absent.Checked;
                
            cmb_LessonWork.Enabled = !rBtn_Absent.Checked;
            cmb_LabWork.Enabled = !rBtn_Absent.Checked;
        }

        private void btn_AddDesc_Click(object sender, EventArgs e)
        {
            EditNote editForm = new EditNote();
            DialogResult result = editForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                if(lbl_Description.Text.Length > 60)
                {
                    MessageBox.Show("Letter Limit Exceeded.");
                    return;
                }

                btn_AddDesc.Visible = false;
                lbl_Description.Visible = true;
                lbl_Description.Text = editForm.tBox_Description.Text;
            }

        }

        private void pic_Profile_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm();
            pictureForm.pic_Main.Image = pic_Profile.Image;
            pictureForm.Show();
        }
    }


}
