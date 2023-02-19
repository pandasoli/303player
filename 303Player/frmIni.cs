using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _303Player
{
    public partial class frmIni : Form
    {
        public frmIni()
        {
            InitializeComponent();
            FormShadow.SetShadowForm(this);
        }
        int Temp = 0;

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            if (Temp <= 3)
            {
                Temp++;
            }
            else
            {
                Close();
                tmTimer.Enabled = false;
            }
        }
    }
}
