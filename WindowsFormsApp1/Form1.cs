using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Additional;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        ImageList imageList1;
        DirectoryInfo currenDirectory;
        Crypto crypt = new Crypto("a");
        WorkZip workZip = new WorkZip();
        public Form1()
        {

            InitializeComponent();
            imageList1 = new ImageList();
            listView1.SmallImageList = imageList1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            Icon dirIcon = new Icon("../../Assets/folder.ico");
            imageList1.Images.Add("dir", dirIcon);

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                comboBox1.Items.Add(drive.Name);
            }

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string currDriver = comboBox1.SelectedItem.ToString();
            ListViewItem item = listView1.SelectedItems[0];

            if (new DirectoryInfo(currenDirectory.FullName + "/" + item.Text).Exists)
            {
                listView1.Items.Clear();
                currenDirectory = new DirectoryInfo(currenDirectory.FullName + "/" + item.Text);
                this.Text = currenDirectory.FullName;
                GetFilesAndDirs(currenDirectory);
            }
            else
            {

                currenDirectory = new DirectoryInfo(currenDirectory.FullName);
            }

        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string currDriver = comboBox1.SelectedItem.ToString();
            currenDirectory = new DirectoryInfo(currDriver);
            this.Text = currenDirectory.FullName;
            DriveInfo drive = new DriveInfo(currDriver);
            ListViewItem item = new ListViewItem();
            DirectoryInfo dirs = new DirectoryInfo(currDriver);
            GetFilesAndDirs(dirs);
        }
        private void GetFilesAndDirs(DirectoryInfo directoryInfo)
        {
            
            listView1.BeginUpdate();
            listView1.Items.Clear();
            try
            {
                ListViewItem item = new ListViewItem();
                foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 1);
                    item.ImageKey = "dir";
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(dir.LastWriteTime.ToString());
                    listView1.Items.Add(item);
                }

                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    Icon iconForFile = SystemIcons.WinLogo;
                    item = new ListViewItem(file.Name, 1);
                    if (!imageList1.Images.ContainsKey(file.Extension))
                    {
                        iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                        imageList1.Images.Add(file.FullName + file.Extension, iconForFile);
                    }
                    item.ImageKey = file.FullName + file.Extension;
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.SubItems.Add(file.Length.ToString());
                    listView1.Items.Add(item);

                }

            }
            catch (Exception)
            {

            }

            listView1.EndUpdate();

        }
        private void toolStripMenuCipher_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = listView1.SelectedItems[0];
            crypt.Encrypt(currenDirectory.FullName + "/" + item.Text, currenDirectory.FullName + "/" + item.Text + ".crypt");
            
        }
        private void toolStripMenuDeСipher_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item = listView1.SelectedItems[0];

            if (item.Text.Contains(".crypt"))
            {
                crypt.Decrypt(currenDirectory.FullName + "/" + item.Text, currenDirectory.FullName + "/" + item.Text.Replace(".crypt", ""));
            }
            
        }

        private  void toolStripAddToArchive_Click(object sender, EventArgs e)
        {

            DirectoryInfo dir = Directory.CreateDirectory(currenDirectory.FullName + "/" + "TEMPDIRZIP");
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                File.Move(currenDirectory.FullName+"/"+item.Text, dir.FullName+ "/" + item.Text);
            }

            workZip.CreateSample(currenDirectory.FullName + "/" + "NewZip.zip", null,dir.FullName);
            if (dir.Exists)
            {
                dir.Delete(true);
            }
           
            
        }

        private void toolStripDeArchive_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = listView1.SelectedItems[0];

            if (item.Text.Contains(".zip"))
            {
                this.Text = currenDirectory.FullName + item.Text;
                workZip.ExtractZipFile(currenDirectory.FullName + item.Text, null, currenDirectory.FullName);
            }
           
        }
    

       
    }
}

