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
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void bt_Text_groeßer_Click(object sender, EventArgs e)
        {

        }

        private void bt_Text_kleiner_Click(object sender, EventArgs e)
        {

        }
        //Hauptfenster Menüleiste Ansichten ein und ausblenden

        private void textgrößenSteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;
            
            if (textgrößenSteuerungToolStripMenuItem.Checked)
            {
                gb_schrift.Visible = true;
            }
            else
            {
                gb_schrift.Visible = false;
            }
            
        }

        private void liveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (liveInfoToolStripMenuItem.Checked)
            {
                gb_live_info.Visible = true;
            }
            else
            {
                gb_live_info.Visible = false;
            }
        }

        private void einfacheFoliensteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (einfacheFoliensteuerungToolStripMenuItem.Checked)
            {
                gb_folien_einfach.Visible = true;
            }
            else
            {
                gb_folien_einfach.Visible = false;
            }
        }

        private void erweiterteFoliensteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (erweiterteFoliensteuerungToolStripMenuItem.Checked)
            {
                gb_folien_erweitert.Visible = true;
            }
            else
            {
                gb_folien_erweitert.Visible = false;
            }
        }
    }
}
