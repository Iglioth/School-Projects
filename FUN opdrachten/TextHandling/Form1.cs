using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextHandling
{
    public partial class FileHandlingForm : Form
    {
        public FileHandlingForm()
        {
            InitializeComponent();
            PopulateListBox(LBC, @"C:\", "", "Directory");
        }

        private void LBC_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListBox(LBCFurther, @"C:\" + LBC.SelectedItem + @"\", "", "File");

        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType, string type)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);

            if (type == "Directory")

            {
                
                DirectoryInfo[] Maps = dinfo.GetDirectories();
                foreach (DirectoryInfo map in Maps)
                {
                    lsb.Items.Add(map.Name);
                }
            }
            else if (type == "File")
            {
                FileInfo[] Files = dinfo.GetFiles();
                foreach (FileInfo file in Files)
                {
                    lsb.Items.Add(file.Name);
                }
            }
        }

        private void FileHandlingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
