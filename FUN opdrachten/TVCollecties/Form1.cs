using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TVCollecties
{
    public partial class FTV : Form
    {
        private TV Tv = new TV(false, 1);
        public FTV()
        {
            InitializeComponent();
            
        }
      
        private List<Channel> Channels = new List<Channel>();
       

        private void BAdd_Click(object sender, EventArgs e)
        {
            
            Channels.Add(new Channel(TBAdd.Text));
            
        }

        private void BPower_Click(object sender, EventArgs e)
        {
            Tv.TVStateChange();
            LON.Visible = Tv.On;
        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            
           
        }
        
        private void BRight_Click(object sender, EventArgs e)
        {
            Tv.ActiveChannel = Tv.ActiveChannel + 1;
            ChannelError();
            ChannelInfo();
        }

        private void BLeft_Click(object sender, EventArgs e)
        {
            Tv.ActiveChannel = Tv.ActiveChannel - 1;
            ChannelError();
            ChannelInfo();
        }

        private void ChannelInfo()
        {
            int Y = Tv.ActiveChannel - 1;
            LCurrentChannel.Text = "Current channel: " + Tv.ActiveChannel.ToString();
            LName.Text = "Name: " + Channels[Y].ChannelName;
        }

        private void ChannelError()
        {
            if (Tv.ActiveChannel > Channels.Count)
            {
                Tv.ActiveChannel = Tv.ActiveChannel - 1;
                LError.Text = "Maximum Channel Reached";
                LError.Visible = true;
            }

            else if(Tv.ActiveChannel < 1)
            {
                Tv.ActiveChannel = Tv.ActiveChannel + 1;
                LError.Text = "Minimal Channel Reached";
                LError.Visible = true;
            }
            else
            {
                LError.Visible = false;
            }
        }
    }
}
