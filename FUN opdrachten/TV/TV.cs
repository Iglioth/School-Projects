using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class TV
    {
        private bool On { get; set; }
        private int CurrentChannel;

        public TV(bool on, int currentchannel)
        {
            this.On = on;
            this.CurrentChannel = currentchannel;
        }
    }
}
