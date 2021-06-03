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
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();
        }
        Form1 F;
        public MoveForm(Form1 f)
        {
            InitializeComponent();
            F = f;
        }


        private void MoveForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(DataBank.DestDir.FullName);
            foreach (var dir in DataBank.DestDir.GetDirectories())
            {
                comboBox1.Items.Add(dir.FullName);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            foreach (string item in DataBank.SelectedFiles )
            {
                
                if (Directory.Exists(new DirectoryInfo(item).FullName))
                {
                    FileSystem.MoveDirectory(new DirectoryInfo(item).FullName, comboBox1.SelectedItem.ToString() + "\\" + new DirectoryInfo(item).Name);
                }
                else
                {
                    FileSystem.MoveFile(new DirectoryInfo(item).FullName, comboBox1.SelectedItem.ToString() + "\\" + new DirectoryInfo(item).Name);
                }
            }
            
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DataBank.Clear();
            this.Close();
        }

        private void MoveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.RefreshLists();
            F.Enabled = true;
        }
    }
}
