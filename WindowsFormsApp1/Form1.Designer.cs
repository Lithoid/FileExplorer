
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownArchive = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripAddToArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownCipher = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeСipher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(646, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDesc,
            this.columnDate,
            this.columnSize});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 355);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 175;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Description";
            this.columnDesc.Width = 104;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date modified";
            this.columnDate.Width = 110;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.Width = 53;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownArchive,
            this.toolStripDropDownCipher});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
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
            this.toolStripAddToArchive.Size = new System.Drawing.Size(224, 26);
            this.toolStripAddToArchive.Text = "Додати до архіву";
            this.toolStripAddToArchive.Click += new System.EventHandler(this.toolStripAddToArchive_Click);
            // 
            // toolStripDeArchive
            // 
            this.toolStripDeArchive.Name = "toolStripDeArchive";
            this.toolStripDeArchive.Size = new System.Drawing.Size(224, 26);
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
            this.toolStripMenuCipher.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuCipher.Text = "Шифрувати";
            this.toolStripMenuCipher.Click += new System.EventHandler(this.toolStripMenuCipher_Click);
            // 
            // toolStripMenuDeСipher
            // 
            this.toolStripMenuDeСipher.Name = "toolStripMenuDeСipher";
            this.toolStripMenuDeСipher.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuDeСipher.Text = "Дешифрувати";
            this.toolStripMenuDeСipher.Click += new System.EventHandler(this.toolStripMenuDeСipher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddToArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeArchive;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownCipher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCipher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeСipher;
    }
}

