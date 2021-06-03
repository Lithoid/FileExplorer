using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Additional;


namespace WindowsFormsApp1
{
    public partial class CopyForm : Form
    {
        public CopyForm()
        {
            InitializeComponent();
        }
        Form1 F;
        public CopyForm(Form1 f)
        {
            
            InitializeComponent();
            F = f;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            foreach (string item in DataBank.SelectedFiles)
            {
                if (new DirectoryInfo(item).Exists)
                    FileSystem.CopyDirectory(item, DataBank.DestDir.FullName,true);
                else
                    FileSystem.CopyFile(item, DataBank.DestDir.FullName + "\\" + (new DirectoryInfo(item).Name));
                
            }
            this.Close();
        } 

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(DataBank.DestDir.FullName);
            foreach (var dir in DataBank.DestDir.GetDirectories())
            {
                comboBox1.Items.Add(dir.FullName);
            }
        }
       

        private void CopyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Enabled = true;
          
        }
    }
}
