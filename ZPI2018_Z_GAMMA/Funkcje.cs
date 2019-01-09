using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPI2018_Z_GAMMA
{
    class Funkcje
    {
        public void myMessage(string v)
        {
            MessageBox.Show(v,
              "Important Note",
              MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button1); 
        }

    }
}
