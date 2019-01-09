using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Killer_App
{
    class Forma
    {

        public void ChangeForms(Form formHide, Form formShow)
        {
            formHide.Visible = false;
            formShow.Visible = true;
        }

    }
}
