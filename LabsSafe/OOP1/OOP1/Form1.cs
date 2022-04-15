using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            File.WriteAllText("C:\\Users\\sergey\\Desktop\\LabsSafe\\OOP1\\OOP1\\text.txt", "");
            InitializeComponent();
        }

        int n = 0, dataLength = 0;
   
        ArrayList dataContainer = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {

            dataContainer.Add(textBox1.Text);
            dataContainer.Add(textBox2.Text);
            dataContainer.Add(textBox5.Text);
            dataContainer.Add(textBox4.Text);
            dataContainer.Add(textBox7.Text);
            dataContainer.Add(textBox6.Text);
            dataContainer.Add(textBox3.Text);

            WriteToFile();

            label1.Text = "Total: " + ++dataLength;
        }

        private void WriteToFile()
        {

            using (StreamWriter writetext = File.AppendText("C:\\Users\\sergey\\Desktop\\LabsSafe\\OOP1\\OOP1\\text.txt"))
            {
                System.Diagnostics.Debug.WriteLine(dataContainer[0]);
                writetext.WriteLine(dataContainer[0]);
                writetext.WriteLine(dataContainer[1]);
                writetext.WriteLine(dataContainer[2]);
                writetext.WriteLine(dataContainer[3] + "," + dataContainer[4] + "," + dataContainer[5] + "," + dataContainer[6]);
                writetext.WriteLine("//");
            }
            dataContainer.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void ReadFile()
        {
            List<string[]> extractedData = new List<string[]>();

            using (StreamReader sr = File.OpenText("C:\\Users\\sergey\\Desktop\\LabsSafe\\OOP1\\OOP1\\text.txt"))
            {
                string newLine = "";
                string[] userInfo = new string[4];
                int userInfoIndex = 0;

                while ((newLine = sr.ReadLine()) != null)
                {

                    if (newLine != "//")
                    {
                        userInfo[userInfoIndex++] = (newLine);
                    } else
                    {
                        extractedData.Add(userInfo);
                        userInfoIndex = 0;
                    }
                }

                sr.Close();
            }

            Console.WriteLine(extractedData[1][0]);
            FillData(extractedData);
        }

        private void FillData(List<string[]> data)
        {
            DataGridViewRow[] rowList = new DataGridViewRow[data.Count];

            for (int i = 0; i < data.Count; i++)
            {
             
                string[] currentUserInfo = (data[i]);
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                row.Cells[0].Value = currentUserInfo[0];
                row.Cells[1].Value = currentUserInfo[1];
                row.Cells[2].Value = currentUserInfo[2];
                
                string[] marks = currentUserInfo[3].Split(',');
                int markFiveCounter = 0;

                foreach (string five in marks)
                {
                   if(five == "5")
                    {
                        markFiveCounter++;
                    }
                }

                row.Cells[3].Value = markFiveCounter.ToString();

                rowList[i] = row;         
            }

            DataGridViewRow sortedData;

            for (int i = 1; i < data.Count; i++)
            {
                int first = Int32.Parse(rowList[i].Cells[3].Value.ToString());
                int second = Int32.Parse(rowList[i - 1].Cells[3].Value.ToString());

                if (first < second)
                {
                    sortedData = rowList[i];
                    rowList[i] = rowList[i - 1];
                    rowList[i - 1] = sortedData;
                }
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows.Add(rowList[i]);
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
