using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGetallenAKlassen1
{
    public partial class OddForm : Form
    {
        public OddForm()
        {
            InitializeComponent();
        }

        public void OddForm_Load(object sender, EventArgs e)
        {

        }
        public void User(string UserName)
        {
            OddLabel.Text = UserName;
        }
    }
}
