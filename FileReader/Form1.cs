using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class Form1 : Form
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        
        private string filePath2;

        public string FilePath2
        {
            get { return filePath2; }
            set { filePath2 = value; }
        }

        public Form1()
        {
            InitializeComponent();
            FilePath = "stringtable.sta";
            FilePath2 = "items.xml";
        }

        private void FileMenu1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileopener = new OpenFileDialog();
            fileopener.ShowDialog();
            if (fileopener.FileName != "")
            {
                FilePath = fileopener.FileName;
                lblFile1Location.Text = $"The opened lang files path is : {filePath}";
            }
        }

        private void StartConsole_Click(object sender, EventArgs e)
        {
            Listing NewForm = new Listing(FilePath,FilePath2);
            NewForm.ShowDialog();
        }

        private void FileMenu2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileopener = new OpenFileDialog();
            fileopener.ShowDialog();
            if (fileopener.FileName != "")
            {
                FilePath2 = fileopener.FileName;
                lblFile2Location.Text = $"The opened destination files path is : {filePath2}";
            }
        }
    }
}
