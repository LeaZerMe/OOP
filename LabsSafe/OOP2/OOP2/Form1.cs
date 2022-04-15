using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentSignUp StudentSignUpDialog = new StudentSignUp();

            if (StudentSignUpDialog.ShowDialog(this) == DialogResult.OK)
            {
                StudentSignUpDialog.Dispose();
            }
            else
            {

            }

            Student stud = new Student(Int32.Parse(StudentSignUpDialog.textBox2.Text),
                StudentSignUpDialog.textBox1.Text, StudentSignUpDialog.textBox3.Text,
                StudentSignUpDialog.textBox4.Text, Int32.Parse(StudentSignUpDialog.textBox5.Text));
            stud.displayInfo();
        }
    }
}
