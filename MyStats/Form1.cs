namespace MyStats
{
    public partial class Form1 : Form
    {
        public static byte MaxCrystalCount = 5;
        public Form1()
        {
            InitializeComponent();
            InitializeStudents();
            btn_Cancel.Click += ResizeText;
            btn_Cancel.Click += FinishEdit;

            btn_Save.Click += ResizeText;
            btn_Save.Click += FinishEdit;
        }

        private void InitializeStudents()
        {
            foreach (var item in pnl_Students.Controls)
            {
                if(item is Controls.Student student)
                    student.CurrentForm = this;
            }
        }

        string startingText = "";

        private void pic_Edit_Click(object sender, EventArgs e)
        {
                //ResizeContent(tBox_Content);
            if (!tBox_Content.Enabled)
            {
                tBox_Content.Font = new Font("Segoe UI", 9);
                tBox_Content.Enabled = true;
                startingText = tBox_Content.Text;

                btn_Save.Visible = true;
                btn_Cancel.Visible = true;

            }
        }


        private void btn_AllExist_Click(object sender, EventArgs e)
        {
            foreach ( Controls.Student student in pnl_Students.Controls)
                student.ParticipateStatus = MyStats.Controls.Student.Participate.Exist;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (btn_Cancel.Visible)
                tBox_Content.Text = startingText;
        }

        private void ResizeText(object sender, EventArgs e)
        {
            if (tBox_Content.Enabled)
            {
                float addedValue = .3f;
                if (tBox_Content.Text == String.Empty) return;


                while (true)
                {
                    var newFont = new Font("Segoe UI", tBox_Content.Font.Size + addedValue);
                    var fontMeasures = TextRenderer.MeasureText(tBox_Content.Text, newFont);

                    if (((fontMeasures.Width / tBox_Content.Width) + 1) * fontMeasures.Height < tBox_Content.Height - 10)
                        tBox_Content.Font = newFont;
                    else
                    {
                        tBox_Content.Font = new Font("Segoe UI", tBox_Content.Font.Size - addedValue); ;
                        break;

                    }
                }
            }
        }

        private void FinishEdit(object sender, EventArgs e)
        {
            if (tBox_Content.Enabled)
            {
                tBox_Content.Enabled = false;
                btn_Cancel.Visible = false;
                btn_Save.Visible = false;
            }
        }

        private void rBtn_Teahcer_CheckedChanged(object sender, EventArgs e)
        {
            pnl_LessonContent.Enabled = true;
        }

        private void lbl_MainTeacher_Click(object sender, EventArgs e)
        {
            rBtn_MainTeacher.Checked = true;
        }

        private void lbl_SwapTeacher_Click(object sender, EventArgs e)
        {
            rBtn_TempTeacher.Checked = true;
        }

        private void btn_AddMaterial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Homework Successfully Added...");
        }

        private void tBox_Content_TextChanged(object sender, EventArgs e)
        {
            pnl_Students.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tBox_Content.Text.Length != 0) {
                pnl_Students.Enabled = true;
                pnl_Labels.Enabled = true;
            }
            
        }
    }
}