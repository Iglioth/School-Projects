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
    public partial class RegisterScreenPersonal : Form
    {
        Database database;

        public RegisterScreenPersonal()
        {
            InitializeComponent();
            database = new Database();
        }

         

        private void BCreateAccount_Click(object sender, EventArgs e)
        {
            //Checks of alles ingevuld is en gaat dan terug naar het login scherm. Methode om in database te gooien moet nog gemaakt worden.
            if(TBFirstName != null && TBLastName != null && (RBGenderMale.Checked || RBGenderFemale.Checked) && TBPassword.Text == TBRepeatPassword.Text && TBEmail.Text == TBRepeatEmail.Text && RBGenderMale.Checked )
            {
                database.AddAccount(TBUsername.Text, TBPassword.Text, DTPBirth.Value, TBFirstName.Text, TBLastName.Text, "M" );
                MessageBox.Show("Account Created!");
                FormLogIn2 LogIn = new FormLogIn2();
                LogIn.Visible = true;
                this.Hide();
            }
            else if(TBFirstName != null && TBLastName != null && (RBGenderMale.Checked || RBGenderFemale.Checked) && TBPassword.Text == TBRepeatPassword.Text && TBEmail.Text == TBRepeatEmail.Text && RBGenderFemale.Checked)
            {
                database.AddAccount(TBUsername.Text, TBPassword.Text, DTPBirth.Value, TBFirstName.Text, TBLastName.Text, "F");
                MessageBox.Show("Account Created!");
                FormLogIn2 LogIn = new FormLogIn2();
                LogIn.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: Missing Data and/or Data Incorrect");
            }
        }

        
    }
}
