using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Overloading : Form
    {
        public Overloading()
        {
            InitializeComponent();

        }
        public Overloading(string ABC)
        {

        }
        public enum Titles
        {
            TheNarniaChronicles,
            TheGreatGatsby,
            TheHuntersApprentice
        }
        Book book = new Book();
        Book book2 = new Book("Harry Potter", "Adventure");
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Titles.TheGreatGatsby);
        }
    }
}
