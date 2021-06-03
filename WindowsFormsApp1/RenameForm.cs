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
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }
        Form1 F;
        public RenameForm(Form1 f)
        {

            InitializeComponent();
            F = f;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
          

         
            if (Directory.Exists(DataBank.SelectedFiles[0]))
            {
                new DirectoryInfo(DataBank.SelectedFiles[0]).MoveTo(DataBank.CurrDir + "\\" + textBox1.Text);
            }else
            {
                string ext = new FileInfo(DataBank.SelectedFiles[0]).Extension;
                File.Move(DataBank.SelectedFiles[0], DataBank.CurrDir + "\\"+textBox1.Text+ext);
            }
               
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RenameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Enabled = true;
            F.RefreshLists();
        }
    }
}
