using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryBackup_GUI_Application
{
    public partial class Form1 : Form
    {
        private string UserSelectedBARPath;

        FolderBrowserDialog FBD = new FolderBrowserDialog();

        string[] pathArray = new string[4];  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void getFilePath() {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                UserSelectedBARPath = FBD.SelectedPath;
            }
            else {
                MessageBox.Show("Please set a file directory to backup");
            }

        }

        private void btnPath1_Click(object sender, EventArgs e)
        {
            try
            {
                getFilePath();
                lblPath1.Text = UserSelectedBARPath;
                pathArray[0] = lblPath1.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnPath2_Click(object sender, EventArgs e)
        {
            try
            {
                getFilePath();
                lblPath2.Text = UserSelectedBARPath;
                pathArray[1] = lblPath2.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnPath3_Click(object sender, EventArgs e)
        {
            try
            {
                getFilePath();
                lblPath3.Text = UserSelectedBARPath;
                pathArray[2] = lblPath3.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnPath4_Click(object sender, EventArgs e)
        {
            try
            {
                getFilePath();
                lblPath4.Text = UserSelectedBARPath;
                pathArray[3] = lblPath4.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void writeFile() {

         
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\ab.user\Desktop\DirectoryBackup\DirectoryBackup_GUI_Application\FilePathContainer\paths.txt");
            
            foreach (string path in pathArray)
            {
                file.WriteLine(path);
            }
            file.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                writeFile();
                MessageBox.Show("Selected backup paths have been saved...");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
