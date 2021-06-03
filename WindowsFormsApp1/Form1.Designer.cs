
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownArchive = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripAddToArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownCipher = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeСipher = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.listViewRight = new WindowsFormsApp1.Additional.MyListView();
            this.columnName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewLeft = new WindowsFormsApp1.Additional.MyListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRename = new System.Windows.Forms.ToolStripButton();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownArchive,
            this.toolStripDropDownCipher});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownArchive
            // 
            this.toolStripDropDownArchive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownArchive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddToArchive,
            this.toolStripDeArchive});
            this.toolStripDropDownArchive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownArchive.Name = "toolStripDropDownArchive";
            this.toolStripDropDownArchive.Size = new System.Drawing.Size(61, 24);
            this.toolStripDropDownArchive.Text = "Архів";
            // 
            // toolStripAddToArchive
            // 
            this.toolStripAddToArchive.Name = "toolStripAddToArchive";
            this.toolStripAddToArchive.Size = new System.Drawing.Size(210, 26);
            this.toolStripAddToArchive.Text = "Додати до архіву";
            this.toolStripAddToArchive.Click += new System.EventHandler(this.toolStripAddToArchive_Click);
            // 
            // toolStripDeArchive
            // 
            this.toolStripDeArchive.Name = "toolStripDeArchive";
            this.toolStripDeArchive.Size = new System.Drawing.Size(210, 26);
            this.toolStripDeArchive.Text = "Розрахівувати";
            this.toolStripDeArchive.Click += new System.EventHandler(this.toolStripDeArchive_Click);
            // 
            // toolStripDropDownCipher
            // 
            this.toolStripDropDownCipher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownCipher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCipher,
            this.toolStripMenuDeСipher});
            this.toolStripDropDownCipher.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownCipher.Image")));
            this.toolStripDropDownCipher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownCipher.Name = "toolStripDropDownCipher";
            this.toolStripDropDownCipher.Size = new System.Drawing.Size(114, 24);
            this.toolStripDropDownCipher.Text = "Шифрування";
            // 
            // toolStripMenuCipher
            // 
            this.toolStripMenuCipher.Name = "toolStripMenuCipher";
            this.toolStripMenuCipher.Size = new System.Drawing.Size(188, 26);
            this.toolStripMenuCipher.Text = "Шифрувати";
            this.toolStripMenuCipher.Click += new System.EventHandler(this.toolStripMenuCipher_Click);
            // 
            // toolStripMenuDeСipher
            // 
            this.toolStripMenuDeСipher.Name = "toolStripMenuDeСipher";
            this.toolStripMenuDeСipher.Size = new System.Drawing.Size(188, 26);
            this.toolStripMenuDeСipher.Text = "Дешифрувати";
            this.toolStripMenuDeСipher.Click += new System.EventHandler(this.toolStripMenuDeСipher_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Головецький Євгеній ІПЗ-20-1";
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Location = new System.Drawing.Point(3, 3);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(65, 24);
            this.comboBoxLeft.TabIndex = 1;
            this.comboBoxLeft.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Location = new System.Drawing.Point(397, 3);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(65, 24);
            this.comboBoxRight.TabIndex = 6;
            this.comboBoxRight.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStripBottom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.96482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 516);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // textBoxRight
            // 
            this.textBoxRight.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRight.Location = new System.Drawing.Point(397, 33);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.ReadOnly = true;
            this.textBoxRight.Size = new System.Drawing.Size(389, 22);
            this.textBoxRight.TabIndex = 11;
            // 
            // listViewRight
            // 
            this.listViewRight.AllowDrop = true;
            this.listViewRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName2,
            this.columnDesc2,
            this.columnDate2,
            this.columnSize2});
            this.listViewRight.currentDirectory = null;
            this.listViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRight.HideSelection = false;
            this.listViewRight.IsActive = false;
            this.listViewRight.Location = new System.Drawing.Point(397, 60);
            this.listViewRight.Name = "listViewRight";
            this.listViewRight.Size = new System.Drawing.Size(389, 428);
            this.listViewRight.StatmentBox = null;
            this.listViewRight.TabIndex = 7;
            this.listViewRight.UseCompatibleStateImageBehavior = false;
            this.listViewRight.View = System.Windows.Forms.View.Details;
            this.listViewRight.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            this.listViewRight.Click += new System.EventHandler(this.listView_Click);
            this.listViewRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listViewRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listViewRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnName2
            // 
            this.columnName2.Text = "Name";
            this.columnName2.Width = 89;
            // 
            // columnDesc2
            // 
            this.columnDesc2.Text = "Description";
            this.columnDesc2.Width = 85;
            // 
            // columnDate2
            // 
            this.columnDate2.Text = "Date modified";
            this.columnDate2.Width = 113;
            // 
            // columnSize2
            // 
            this.columnSize2.Text = "Size";
            this.columnSize2.Width = 63;
            // 
            // listViewLeft
            // 
            this.listViewLeft.AllowDrop = true;
            this.listViewLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewLeft.currentDirectory = null;
            this.listViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLeft.HideSelection = false;
            this.listViewLeft.IsActive = false;
            this.listViewLeft.Location = new System.Drawing.Point(3, 60);
            this.listViewLeft.Name = "listViewLeft";
            this.listViewLeft.Size = new System.Drawing.Size(388, 428);
            this.listViewLeft.StatmentBox = null;
            this.listViewLeft.TabIndex = 8;
            this.listViewLeft.UseCompatibleStateImageBehavior = false;
            this.listViewLeft.View = System.Windows.Forms.View.Details;
            this.listViewLeft.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            this.listViewLeft.Click += new System.EventHandler(this.listView_Click);
            this.listViewLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listViewLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listViewLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date modified";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 63;
            // 
            // toolStripBottom
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStripBottom, 2);
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEdit,
            this.toolStripButtonMove,
            this.toolStripButtonCopy,
            this.toolStripButtonFolder,
            this.toolStripButtonDelete,
            this.toolStripButtonRename});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 491);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(789, 25);
            this.toolStripBottom.TabIndex = 9;
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonEdit.Text = "Виконати";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonMove
            // 
            this.toolStripButtonMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMove.Name = "toolStripButtonMove";
            this.toolStripButtonMove.Size = new System.Drawing.Size(101, 22);
            this.toolStripButtonMove.Text = "Перемістити";
            this.toolStripButtonMove.Click += new System.EventHandler(this.toolStripButtonMove_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonCopy.Text = "Копіювати";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonFolder
            // 
            this.toolStripButtonFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFolder.Name = "toolStripButtonFolder";
            this.toolStripButtonFolder.Size = new System.Drawing.Size(94, 22);
            this.toolStripButtonFolder.Text = "Нова папка";
            this.toolStripButtonFolder.Click += new System.EventHandler(this.toolStripButtonFolder_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonDelete.Text = "Видалити";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRename
            // 
            this.toolStripButtonRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRename.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRename.Image")));
            this.toolStripButtonRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRename.Name = "toolStripButtonRename";
            this.toolStripButtonRename.Size = new System.Drawing.Size(124, 22);
            this.toolStripButtonRename.Text = "Перейменувати";
            this.toolStripButtonRename.Click += new System.EventHandler(this.toolStripButtonRename_Click);
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLeft.Location = new System.Drawing.Point(3, 33);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.ReadOnly = true;
            this.textBoxLeft.Size = new System.Drawing.Size(388, 22);
            this.textBoxLeft.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Файловий менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddToArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeArchive;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownCipher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCipher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeСipher;
        private System.Windows.Forms.Label label1;
        private Additional.MyListView listViewLeft;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private Additional.MyListView listViewRight;
        private System.Windows.Forms.ColumnHeader columnName2;
        private System.Windows.Forms.ColumnHeader columnDesc2;
        private System.Windows.Forms.ColumnHeader columnDate2;
        private System.Windows.Forms.ColumnHeader columnSize2;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonMove;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonRename;
    }
}

