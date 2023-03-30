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
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.manuellerTextLocation = RestoreBounds.Location;
                Properties.Settings.Default.manuellerTextSize = RestoreBounds.Size;
                Properties.Settings.Default.manuellerTextMaximised = true;
                Properties.Settings.Default.manuellerTextMinimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.manuellerTextLocation = Location;
                Properties.Settings.Default.manuellerTextSize = Size;
                Properties.Settings.Default.manuellerTextMaximised = false;
                Properties.Settings.Default.manuellerTextMinimised = false;
            }
            else
            {
                Properties.Settings.Default.manuellerTextLocation = RestoreBounds.Location;
                Properties.Settings.Default.manuellerTextSize = RestoreBounds.Size;
                Properties.Settings.Default.manuellerTextMaximised = false;
                Properties.Settings.Default.manuellerTextMinimised = true;
            }
            Properties.Settings.Default.Save();

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

        private void manuellerText_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.bilderFormMaximised)
            {
                Location = Properties.Settings.Default.manuellerTextLocation;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.manuellerTextSize;
            }
            else if (Properties.Settings.Default.manuellerTextMinimised)
            {
                Location = Properties.Settings.Default.manuellerTextLocation;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.manuellerTextSize;
            }
            else
            {
                Location = Properties.Settings.Default.manuellerTextLocation;
                Size = Properties.Settings.Default.manuellerTextSize;
            }
        }
    }
}
