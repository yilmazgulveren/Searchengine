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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string strSearchDirectory;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSearchDirectory = fbd.SelectedPath;
                txtSearchDirectory.Text = strSearchDirectory;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strSearchDirectory = txtSearchDirectory.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(strSearchDirectory);
            FileInfo[] fi = di.GetFiles();

            if (txtSearchSubstring.Text != "")
            {
                string strSearchString = txtSearchSubstring.Text;
                IbxResults.Items.Clear();
                foreach (FileInfo curfile in fi)
                {
                    if (curfile.Name.ToUpper().IndexOf(strSearchString.ToUpper()) != -1)
                    {
                        IbxResults.Items.Add(curfile.Name);
                    }//if
                }//foreach
                txtSearchSubstring.Clear();
                txtSearchSubstring.Focus();
            }//if
        }//buttonclick

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
