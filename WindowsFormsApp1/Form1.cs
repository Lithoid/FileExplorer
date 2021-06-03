using Microsoft.VisualBasic.FileIO;
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
        private ImageList imageList1;
        private Crypto crypt = new Crypto("a");
        private WorkZip workZip = new WorkZip();

        public Form1()
        {

            InitializeComponent();
            imageList1 = new ImageList();

            listViewLeft.SmallImageList = imageList1;
            listViewRight.SmallImageList = imageList1;
            listViewLeft.StatmentBox = textBoxLeft;
            listViewRight.StatmentBox = textBoxRight;


        }
        private MyListView GetActiveList()//повертає активний список
        {
            MyListView listView = null;
            if (listViewLeft.IsActive == true)
                listView = listViewLeft;
            else if (listViewRight.IsActive == true)
                listView = listViewRight;
            return listView;
        }
        private MyListView GetInActiveList()//повертає неактивний список
        {
            MyListView listView = null;
            if (listViewLeft.IsActive == false)
                listView = listViewLeft;
            else if (listViewRight.IsActive == false)
                listView = listViewRight;
            return listView;
        }
        private void GetFilesAndDirs(MyListView listView)//отримуємо всі файли та директорії
        {


            listView.BeginUpdate();
            listView.Items.Clear();
            try
            {
                ListViewItem item = new ListViewItem();
                item.ImageKey = "PREVIOUSFOLDER";
                item.SubItems.Add("<DIR>");
                item.SubItems.Add("UP");
                item.Text = "...";
                if (listView.currentDirectory.Parent != null)
                {
                    listView.Items.Add(item);
                }

                foreach (DirectoryInfo dir in listView.currentDirectory.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 1);
                    item.ImageKey = "dir";
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(dir.LastWriteTime.ToString());
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in listView.currentDirectory.GetFiles())
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
                    listView.Items.Add(item);

                }

            }
            catch (Exception) { }
            listView.StatmentBox.Text = listView.currentDirectory.FullName;

            listView.EndUpdate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon dirIcon = new Icon("..\\..\\Assets\\folder.ico");
            imageList1.Images.Add("dir", dirIcon);
            dirIcon = new Icon("..\\..\\Assets\\up.ico");
            imageList1.Images.Add("PREVIOUSFOLDER", dirIcon);




            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                comboBoxLeft.Items.Add(drive.Name);
                comboBoxRight.Items.Add(drive.Name);
            }
            comboBoxLeft.SelectedIndex = 0;
            comboBoxRight.SelectedIndex = 0;
        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)//відкриває файл або робить перехід на вищий рівень якщо можна
        {
            MyListView listView = (MyListView)sender;
            ListViewItem item = listView.SelectedItems[0];
            if (item.ImageKey == "PREVIOUSFOLDER")
            {
                listView.currentDirectory = listView.currentDirectory.Parent;
                this.Text = listView.currentDirectory.FullName;
                GetFilesAndDirs(listView);

            }
            else if (new DirectoryInfo(listView.currentDirectory.FullName + "\\" + item.Text).Exists)
            {
                listView.currentDirectory = new DirectoryInfo(listView.currentDirectory.FullName + "\\" + item.Text);
                GetFilesAndDirs(listView);
            }
            else
            {
                Process.Start(listView.currentDirectory.FullName + "\\" + item.Text);
            }

        }
        private void comboBox_SelectedValueChanged(object sender, EventArgs e)//оновлює лісти при зміні на інший диск
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox == comboBoxLeft)
            {
                listViewLeft.Items.Clear();
                string currDriver = comboBox.SelectedItem.ToString();
                listViewLeft.currentDirectory = new DirectoryInfo(currDriver);
                GetFilesAndDirs(listViewLeft);


            }
            else if (comboBox == comboBoxRight)
            {
                listViewRight.Items.Clear();
                string currDriver = comboBox.SelectedItem.ToString();
                listViewRight.currentDirectory = new DirectoryInfo(currDriver);

                GetFilesAndDirs(listViewRight);

            }
        }
        private void toolStripMenuCipher_Click(object sender, EventArgs e)//шифрування
        {
            MyListView listView = GetActiveList();

            ListViewItem item = new ListViewItem();
            item = listViewLeft.SelectedItems[0];
            crypt.Encrypt(listView.currentDirectory.FullName + "/" + item.Text, listView.currentDirectory.FullName + "/" + item.Text + ".crypt");
            RefreshLists();
        }//
        private void toolStripMenuDeСipher_Click(object sender, EventArgs e)//дешифрування
        {
            MyListView listView = GetActiveList();



            ListViewItem item = new ListViewItem();
            item = listViewLeft.SelectedItems[0];

            if (item.Text.Contains(".crypt"))
            {
                crypt.Decrypt(listView.currentDirectory.FullName + "/" + item.Text, listView.currentDirectory.FullName + "/" + item.Text.Replace(".crypt", ""));
            }
            RefreshLists();

        }
        private void toolStripAddToArchive_Click(object sender, EventArgs e)//архівування
        {
            MyListView listView = GetActiveList();

            DirectoryInfo dir = Directory.CreateDirectory(listView.currentDirectory.FullName + "\\" + "TEMPDIRZIP");
            foreach (ListViewItem item in listView.SelectedItems)
            {
                Directory.Move(listView.currentDirectory.FullName + "\\" + item.Text, dir.FullName + "\\" + item.Text);
            }

            workZip.CreateSample(listView.currentDirectory.FullName + "\\" + "NewZip.zip", null, dir.FullName);
            if (dir.Exists)
            {
                dir.Delete(true);
            }
            this.Enabled = false;
            DataBank.CurrDir = GetActiveList().currentDirectory;
            DataBank.SelectedFiles.Add(GetActiveList().currentDirectory.FullName + "\\" + "NewZip.zip");

            RenameForm renameForm = new RenameForm(this);
            renameForm.Show();

        }
        private void toolStripDeArchive_Click(object sender, EventArgs e)//деархівування
        {
            MyListView listView = GetActiveList();


            ListViewItem item = new ListViewItem();
            item = listView.SelectedItems[0];

            if (item.Text.Contains(".zip"))
            {
                this.Text = listView.currentDirectory.FullName + item.Text;
                workZip.ExtractZipFile(listView.currentDirectory.FullName + "\\" + item.Text, null, listView.currentDirectory.FullName);
            }
            else
            {
                MessageBox.Show("Виберіть ZIP файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;

            }
            RefreshLists();
        }

        private void listView_DragEnter(object sender, DragEventArgs e)//метод на вхід курсору
        {
            try
            {
                if (e.Data.GetDataPresent(typeof(string[])) || e.Data.GetDataPresent(DataFormats.FileDrop)) ;
                e.Effect = DragDropEffects.Move;
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void listView_DragDrop(object sender, DragEventArgs e)//метод на кидання файлів
        {
            MyListView listView = (MyListView)sender;
            try
            {
                string[] data = (string[])e.Data.GetData(typeof(string[]));
                if (e.Data.GetDataPresent(typeof(string[])))
                {
                    data = (string[])e.Data.GetData(typeof(string[]));
                }
                else
                {
                    data = (string[])e.Data.GetData(DataFormats.FileDrop);
                }
                foreach (string dat in data)
                {
                    DirectoryInfo dir = new DirectoryInfo(dat);
                    if (dir.Exists)
                    {
                        FileSystem.MoveDirectory(dir.FullName, listView.currentDirectory.FullName + "\\" + dir.Name);
                    }
                    else
                    {
                        FileSystem.MoveFile(dir.FullName, listView.currentDirectory.FullName + "\\" + dir.Name);
                    }


                }
            }
            catch (Exception)
            {
            }

            RefreshLists();

        }

        public void RefreshLists()
        {
            GetFilesAndDirs(listViewLeft);
            GetFilesAndDirs(listViewRight);
        }

        private void listView_ItemDrag(object sender, ItemDragEventArgs e)//метод на спробу перетягнути файл
        {
            MyListView listView = (MyListView)sender;
            try
            {
                List<string> data = new List<string>();
                foreach (ListViewItem lvi in listView.SelectedItems)
                {
                    data.Add(listView.currentDirectory.FullName + "\\" + lvi.Text);
                }
                string[] dat = data.ToArray();
                listView.DoDragDrop(dat, DragDropEffects.Move);

            }
            catch (Exception)
            {

            }

        }
        private void listView_Click(object sender, EventArgs e)
        {
            MyListView listView = (MyListView)sender;
            try
            {
                if (listView == listViewLeft)
                {
                    listViewRight.IsActive = false;
                    listViewRight.StatmentBox.BackColor = Color.LightBlue;
                }
                else
                {

                    listViewLeft.IsActive = false;
                    listViewLeft.StatmentBox.BackColor = Color.LightBlue;
                }
                listView.IsActive = true;
                listView.StatmentBox.BackColor = Color.DodgerBlue;
            }
            catch (Exception)
            {

                throw;
            }


        }//метод на клік по елементу списку

        private void toolStripButtonEdit_Click(object sender, EventArgs e)//виконуемо файл
        {
            try
            {
                MyListView listView = GetActiveList();
                if (Directory.Exists(listView.currentDirectory.FullName + "\\" + listView.SelectedItems[0].Text))
                {
                    MessageBox.Show("Виберіть файл");
                }
                else
                {
                    Process.Start(listView.currentDirectory.FullName + "\\" + listView.SelectedItems[0].Text);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Виберіть файл", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
            RefreshLists();

        }

        private void toolStripButtonMove_Click(object sender, EventArgs e)//переміщаемо файл
        {
            try
            {
                this.Enabled = false;
                DataBank.DestDir = GetInActiveList().currentDirectory;
                DataBank.CurrDir = GetActiveList().currentDirectory;
                foreach (ListViewItem item in GetActiveList().SelectedItems)
                    DataBank.SelectedFiles.Add(GetActiveList().currentDirectory.FullName + "\\" + item.Text);
                MoveForm moveForm = new MoveForm(this);
                moveForm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Виберіть файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
            RefreshLists();

        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)//викликаемо форму копіювання
        {
            try
            {
                this.Enabled = false;
                DataBank.DestDir = GetInActiveList().currentDirectory;
                DataBank.CurrDir = GetActiveList().currentDirectory;
                foreach (ListViewItem item in GetActiveList().SelectedItems)
                    DataBank.SelectedFiles.Add(GetActiveList().currentDirectory.FullName + "\\" + item.Text);
                CopyForm copyForm = new CopyForm(this);
                copyForm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Виберіть файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
            RefreshLists();
        }



        private void toolStripButtonDelete_Click(object sender, EventArgs e)//видалення
        {
            try
            {


                DialogResult result = MessageBox.Show(
           "Видалити файл?",
           "Підтвердження ",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in GetActiveList().SelectedItems)
                    {
                        if (Directory.Exists(GetActiveList().currentDirectory.FullName + "\\" + item.Text))
                            FileSystem.DeleteDirectory(GetActiveList().currentDirectory.FullName + "\\" + item.Text, DeleteDirectoryOption.DeleteAllContents);
                        else
                            File.Delete(GetActiveList().currentDirectory.FullName + "\\" + item.Text);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виберіть файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
            RefreshLists();
        }

        private void toolStripButtonFolder_Click(object sender, EventArgs e)//створюемо папку
        {
            try
            {
                if (GetActiveList() == null)
                {
                    MessageBox.Show("Виберіть вікно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                }
                Directory.CreateDirectory(GetActiveList().currentDirectory.FullName + "\\" + "New Folder");
                DataBank.CurrDir = GetActiveList().currentDirectory;
                DataBank.SelectedFiles.Add(GetActiveList().currentDirectory.FullName + "\\" + "New Folder");
                RenameForm renameForm = new RenameForm(this);
                renameForm.Show();
                RefreshLists();
            }
            catch (Exception)
            {

                MessageBox.Show("Виберіть файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }

        }

        private void toolStripButtonRename_Click(object sender, EventArgs e)//викликаемо форму перейменування
        {
            try
            {
                this.Enabled = false;
                DataBank.CurrDir = GetActiveList().currentDirectory;
                DataBank.SelectedFiles.Add(GetActiveList().currentDirectory.FullName + "\\" + GetActiveList().SelectedItems[0].Text);

                RenameForm renameForm = new RenameForm(this);
                renameForm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Виберіть файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true; RefreshLists();
            }

        }
    }
}

