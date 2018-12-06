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
<<<<<<< HEAD
            PopulateListBox(LBCFurther, @"C:\" + LBC.SelectedItem + @"\", "", "File");
=======
            LBCFurther.Items.Clear();
            PopulateListBox(LBCFurther, @"C:\" + LBC.SelectedItem.ToString(), "");
>>>>>>> f5ff8ced138a86cabfc6bdb8786edfb4c89d58e5
        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType, string type)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
<<<<<<< HEAD
            if (type == "Directory")
=======
            DirectoryInfo[] Maps = dinfo.GetDirectories();
            foreach (DirectoryInfo file in Maps)
>>>>>>> f5ff8ced138a86cabfc6bdb8786edfb4c89d58e5
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
    }
}
