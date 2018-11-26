using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandAKlassen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Band ImagineDragons = new Band("Imagine Dragons", "Pop", 5000, 4);
        Band Slipknot = new Band("Imagine Dragons", "Metal", 3612, 6);
        Band Passenger = new Band("Passenger", "Folk", 9000, 1);
        Band HeadAndTheHeart = new Band("Head and the Heart", "Indie", 2500, 5);



        private void BCalculate_Click(object sender, EventArgs e)
        {
            if (RBImagineDragons.Checked)
            {
                LCost.Text = "Cost:" + ImagineDragons.Optreden(Convert.ToDouble(NUPBand.Value)) + ImagineDragons.MuziekSchrijvenTarief(LSong.Text);
                LCost.Visible = true;
            }
            else if (RBHeadAndTheHeart.Checked)
            {
                LCost.Text = "Cost:" + HeadAndTheHeart.Optreden(Convert.ToDouble(NUPBand.Value)) + HeadAndTheHeart.MuziekSchrijvenTarief(LSong.Text);
                LCost.Visible = true;
            }
            else if (RBPassenger.Checked)
            {
                LCost.Text = "Cost:" + Passenger.Optreden(Convert.ToDouble(NUPBand.Value)) + Passenger.MuziekSchrijvenTarief(LSong.Text);
                LCost.Visible = true;
            }
            else if (RBSlipknot.Checked)
            {
                LCost.Text = "Cost:" + Slipknot.Optreden(Convert.ToDouble(NUPBand.Value)) + Slipknot.MuziekSchrijvenTarief(LSong.Text);
                LCost.Visible = true;
            }
            else if (RBCompare.Checked)
            {
                double CostImagineDragons = ImagineDragons.Optreden(Convert.ToDouble(NUPBand.Value)) + ImagineDragons.MuziekSchrijvenTarief(LSong.Text);
                double CostSlipknot = Slipknot.Optreden(Convert.ToDouble(NUPBand.Value)) + Slipknot.MuziekSchrijvenTarief(LSong.Text); ;
                double CostHeadAndTheHeart = HeadAndTheHeart.Optreden(Convert.ToDouble(NUPBand.Value)) + HeadAndTheHeart.MuziekSchrijvenTarief(LSong.Text);
                double CostPassenger = Passenger.Optreden(Convert.ToDouble(NUPBand.Value)) + Passenger.MuziekSchrijvenTarief(LSong.Text);

                double[] Cost = new double[] { CostImagineDragons, CostSlipknot, CostPassenger, CostHeadAndTheHeart };

                Array.Sort(Cost);
                LBBands.Items.Add(Cost[3]);
                LBBands.Items.Add(Cost[2]);
                LBBands.Items.Add(Cost[1]);
                LBBands.Items.Add(Cost[0]);
            }
        }

        private void RBImagineDragons_CheckedChanged(object sender, EventArgs e)
        {
            LBBands.Visible = false;
            LName.Text = "Name:" + ImagineDragons.Naam;
            LGenre.Text = "Genre" + ImagineDragons.Genre;
            LHourPay.Text = "Pay per hour:" + ImagineDragons.UurTarief;
            LPlayers.Text = "Musicians:" + ImagineDragons.AantalBandleden;
            
        }

        private void RBPassenger_CheckedChanged(object sender, EventArgs e)
        {
            LBBands.Visible = false;
            LName.Text = "Name:" + Passenger.Naam;
            LGenre.Text = "Genre" + Passenger.Genre;
            LHourPay.Text = "Pay per hour:" + Passenger.UurTarief;
            LPlayers.Text = "Musicians:" + Passenger.AantalBandleden;
        }

        private void RBHeadAndTheHeart_CheckedChanged(object sender, EventArgs e)
        {
            LBBands.Visible = false;
            LName.Text = "Name:" + HeadAndTheHeart.Naam;
            LGenre.Text = "Genre" + HeadAndTheHeart.Genre;
            LHourPay.Text = "Pay per hour:" + HeadAndTheHeart.UurTarief;
            LPlayers.Text = "Musicians:" + HeadAndTheHeart.AantalBandleden;
        }

        private void RBSlipknot_CheckedChanged(object sender, EventArgs e)
        {
            LBBands.Visible = false;
            LName.Text = "Name:" + Slipknot.Naam;
            LGenre.Text = "Genre" + Slipknot.Genre;
            LHourPay.Text = "Pay per hour:" + Slipknot.UurTarief;
            LPlayers.Text = "Musicians:" + Slipknot.AantalBandleden;
        }

        private void RBCompare_CheckedChanged(object sender, EventArgs e)
        {
            LBBands.Visible = true;
        }
    }
}
