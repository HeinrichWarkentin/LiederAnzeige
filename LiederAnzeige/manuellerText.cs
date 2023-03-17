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
    public partial class manuellerText : Form
    {
        public manuellerText(Präsentation ppräsentation)
        {
            InitializeComponent();
            präsentation = ppräsentation;
        }
        Präsentation präsentation;

        private void manuellerText_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void bt_anzeigen_Click(object sender, EventArgs e)
        {
            if (tb_ueberschrift.Text == null)
            {
                präsentation.setTitel("");
            }
            else
            {
                präsentation.setTitel(tb_ueberschrift.Text);
            }
            präsentation.setText(rtb_text.Text);
            präsentation.setakVers("");
        }
    }
}
