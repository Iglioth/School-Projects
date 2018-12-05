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
            PopulateListBox(LBC, @"C:\", "");
        }

        private void LBC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
/*string path = @"c:\Test1234.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        LBC.Items.Add(s);
                    }*/
