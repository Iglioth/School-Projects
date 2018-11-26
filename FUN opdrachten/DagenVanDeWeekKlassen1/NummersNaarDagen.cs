using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DagenVanDeWeekKlassen1
{
    public partial class NummersNaarDagen : Form
    {
        public NummersNaarDagen()
        {
            InitializeComponent();
        }

        private void VanIntNaarStringButton_Click(object sender, EventArgs e)
        {
            VanGetalNaarDag(Convert.ToInt32(VanInstNaarStringTextBox.Text));
        }

        private void VanGetalNaarDag(int DagGetal)
        {
            string Dag;

            if(DagGetal == 1)
            {
                Dag = "Maandag";
            }
            else if (DagGetal == 2)
            {
                Dag = "Dinsdag";
            }
            else if (DagGetal == 3)
            {
                Dag = "Woensdag";
            }
            else if (DagGetal == 4)
            {
                Dag = "Donderdag";
            }
            else if (DagGetal == 5)
            {
                Dag = "Vrijdag";
            }
            else if (DagGetal == 6)
            {
                Dag = "Zaterdag";
            }
            else if (DagGetal == 7)
            {
                Dag = "Zondag";
            }
            else
            {
                Dag = "Error - Dag onbekend";
            }
            MessageBox.Show(Dag);
        }
    }
}
