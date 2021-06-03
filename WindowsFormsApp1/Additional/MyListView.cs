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


namespace WindowsFormsApp1.Additional
{
    class MyListView:ListView
    {

        public DirectoryInfo currentDirectory { get; set; }// обєкт якій містить поточну відкриту директорію на диску
        public bool IsActive { get; set; }// флаг який показує активність listView 
        public TextBox StatmentBox { get; set; }// відповідний до listView TextBoxякий показуе шлях відкритої диркторії
    }
}
