using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextPaster
{
    public partial class Form1 : Form
    {
        StringBuilder StringCreator = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Times = numericUpDown1.Value;

            for(decimal x = 0; x < Times; x++)
            {
                StringCreator.Append(TextToAddTextBox.Text);
            }

            TextListTextBox.Text = Convert.ToString(StringCreator);
            TextToAddTextBox.Text = string.Empty;

        }
    }
}
