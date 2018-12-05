using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCollecties
{
    class TV
    {

        public TV(bool on, int activechannel)
        {
            this.On = on;
            this.ActiveChannel = activechannel;
        }

        public bool On { get; set; }

        public int ActiveChannel { get; set; }

        public void TVStateChange()
        {
            if(On == false)
            {
                On = true;
            }
            else if (On == true)
            {
                On = false;
            }

            
        }


    }
}
