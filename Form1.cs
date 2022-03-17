using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WriteArrayForms
{
    public partial class Form1 : Form
    {
        string[] names = new string[] { "Marthe", "Per", "Ola", "Kari", "Jonas" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmptyTxtshow_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
        }

        private void ShowArrayintxtshow_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
            foreach (string name in names)
            {
                txtShow.AppendText(name);
                txtShow.AppendText("\r\n"); //Return Line and New Line
            }
        }

        private void FillWithEmptyStrings_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                names[i] = "w";
            }
        }

        private void FillWithNames_Click(object sender, EventArgs e)
        {
            names = new string[] { "Marthe", "Per", "Ola", "Kari", "Jonas" };
        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "myfile.txt";
                FileStream outputstream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter streamwriter = new StreamWriter(outputstream);
                foreach (var name in names)
                {
                    streamwriter.WriteLine(name);
                }
                streamwriter.Close();
            }
            catch { }
        }

        private void ReadFromArray_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "myfile.txt";
                FileStream inputstream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(inputstream);
                for (int i = 0; i <= names.GetUpperBound(0); i++)
                {
                   names[i] = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch
            {

            }
        }

        private void ReadFromtxtShow_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                txtShow.Clear();

                string filename = "myfile.txt";
                FileStream inputstream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(inputstream);
                while ((line = streamReader.ReadLine()) != null)
                {
                    txtShow.AppendText(line + "\r\n");
                }
                streamReader.Close();
            }
            catch
            {

            }
        }
    }
}
