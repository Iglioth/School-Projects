using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_App
{
    public partial class FormLogIn2 : Form
    {
        Database database = new Database();
        public FormLogIn2()
        {
            InitializeComponent();
        }

        
        private void BAccountCreatie_Click(object sender, EventArgs e)
        {
            RegisterScreenPersonal registerScreenpersonal = new RegisterScreenPersonal();
            this.Hide();
            registerScreenpersonal.Show();
        }
    }
}
