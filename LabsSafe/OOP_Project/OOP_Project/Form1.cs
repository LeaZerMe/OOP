using System;
using System.Windows.Forms;

namespace OOP_Project
{

    public delegate Student StudentInfoTransfer();

    public partial class Form1 : Form
    {

        private University _university = new University();
        private Student _student;
        private bool _loggedIn = false;

        public Form1()
        {
            InitializeComponent();
            _university.InitializeWorkUnity(new WorkUnity());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void systemLoginBtn_Click(object sender, EventArgs e)
        {
            Func<Login> ReturnLoginForm = () => new Login();
            Login loginForm = ReturnLoginForm();







            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                _student = new Student(loginForm.textBox1.Text, loginForm.textBox2.Text, loginForm.textBox3.Text);
                _loggedIn = true;

                RefreshPage();
            }
            else
            {

            }
            loginForm.Dispose();
        }


        private void studInfoBtn_Click(object sender, EventArgs e)
        {
            StudentInfoTransfer TransferStudentInfo = delegate () {
                return _student;
            };
            StudentInfo studentInfo = new StudentInfo(TransferStudentInfo);


            if (studentInfo.ShowDialog(this) == DialogResult.OK)
            {
                _student = null;
                _loggedIn = false;

                RefreshPage();
            }
            else
            {

            }

            studentInfo.Dispose();
        }


        private void RefreshPage()
        {
            if(!_loggedIn)
            {
                systemLoginBtn.Visible = true;
                studInfoBtn.Visible = false;
            }
            else {
                systemLoginBtn.Visible = false;
                studInfoBtn.Visible = true;
            }
            
        }

        private void travelDestinationBtn_Click(object sender, EventArgs e)
        {
            TourPreview tourPreview = new TourPreview();

            if (tourPreview.ShowDialog(this) == DialogResult.OK)
            {

                //_student = null;
                //_loggedIn = false;

               // RefreshPage();
            }
            else
            {

            }

            tourPreview.Dispose();
        }

        private void workUnitySignUpBtn_Click(object sender, EventArgs e)
        {
            if(_student != null)
            {
                _university.workUnity.SignUpNewMember(_student);
                label2.Visible = false;
                workUnitySignUpBtn.Visible = false;

                bookTicketBtn.Visible = true;
            }
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {

            _university.DisplayMaxAmountOfTickets();

            Func<Login> ReturnLoginForm = () => new Login();
            bool s =_university.workUnity.IsPersonRegistered(_student);
            Console.WriteLine(s);
        }
    }
}
