using System;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class StudentInfo : Form
    {
        Student _studentInfo;
 
        public StudentInfo(StudentInfoTransfer func)
        {
            InitializeComponent();

            _studentInfo = func();
            InitializeInformation();
        }

        private void InitializeInformation()
        {
            label1.Text = _studentInfo.GetName();
            label2.Text = _studentInfo.GetSurname();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
