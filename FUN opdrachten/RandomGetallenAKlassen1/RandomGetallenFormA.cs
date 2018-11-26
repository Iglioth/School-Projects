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
    public partial class RandomGetallenFormA : Form
    {
        public RandomGetallenFormA()
        {
            InitializeComponent();
        }

        public void RandomButton_Click(object sender, EventArgs e)
        {
            string PickedNumber = RandomNumberGenerator(Convert.ToInt32(MinTextBox.Text), Convert.ToInt32(MaxTextBox.Text));
            if((GetalEvenofOneven(Convert.ToInt32(PickedNumber)) == true))
            {
                EvenOrOddLabel.Text = "The number is Even";
            }
            else
            {
                var NewWindow = new OddForm();
                NewWindow.User(UserTextbox.Text);
                NewWindow.Show();
            }
            EvenOrOddLabel.Visible = true;
            MessageBox.Show(PickedNumber);
        }

        private string RandomNumberGenerator(int min, int max)
        {
            Random getal = new Random();
            int RandomGetal = getal.Next(min, max);
            
            return Convert.ToString(RandomGetal);
        }

        private bool GetalEvenofOneven(int RandomGetal)
        {
            int getal = RandomGetal;
            if (getal % 2 == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
