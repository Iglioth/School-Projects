using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_App { 

    public partial class FChallenges : Form
    {
        Database database = new Database();
        Forma forma = new Forma();
        
        
        public FChallenges()
        {
            InitializeComponent();
            LBChallenges.Text = string.Empty;
        }

        private void BHomeUpperLeft_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LBChallenges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
