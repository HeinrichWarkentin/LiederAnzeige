using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class neuesLiedForm : Form
    {
        public neuesLiedForm()
        {
            InitializeComponent();
        }

        private void cb_addToLiederbuch_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_addToLiederbuch.Checked)
            {
                gb_addToLiederbuch.Enabled = true;
            }
            else
            {
                gb_addToLiederbuch.Enabled = false;
            }
        }
    }
}
