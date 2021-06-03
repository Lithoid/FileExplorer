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
    public static class DataBank
    {

        public static DirectoryInfo CurrDir { get; set; }//поточна директорія
        public static DirectoryInfo DestDir { get; set; }//кінцева директорія

        public static List<string> SelectedFiles { get; set; } = new List<string>();//список вибраних файлів 

        public static void Clear()//метод для очистки обєкту
        {
            CurrDir = null;
            DestDir = null;
            SelectedFiles = null;
        }
    }
}
