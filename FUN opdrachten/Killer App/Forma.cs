using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer_App
{
    class Forma
    {

        public void ChangeForms(System.Windows.Forms.Form formHide, System.Windows.Forms.Form formShow)
        {
            formHide.Visible = false;
            formShow.Visible = true;
        }

    }
}
