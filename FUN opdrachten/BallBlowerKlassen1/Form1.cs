using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallBlowerKlassen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bal BlauweBal = new Bal(0.50, Color.Blue);

        private void BBal_Click(object sender, EventArgs e)
        {
            BlauweBal.VerderOpblazen(0.10);

            if(BlauweBal.VerderOpblazen(0) == false)
            {
                LBal.Text = "De bal is geklapt! Uh Oh!";
            }
            else if(BlauweBal.VerderOpblazen(0) == true)
            {
                LBal.Text = "De bal is " + BlauweBal.diameter.ToString() +" meter groot in diameter";
            }
        }
    }
}
