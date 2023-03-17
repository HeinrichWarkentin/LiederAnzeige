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
    public partial class MainForm : Form
    {
        Präsentation präsentation;
        manuellerText manuelleTexteingabe;
        bilderForm bilderAnzeige;

        public MainForm()
        {
            InitializeComponent();
            scaliereFolien();
            präsentation = new Präsentation();
            manuelleTexteingabe = new manuellerText(präsentation);
            bilderAnzeige = new bilderForm(präsentation);
        }
        

        private void scaliereFolien()
        {
            
            int p_auflösung_b = Screen.AllScreens[1].Bounds.Width;
            int p_auflösung_h = Screen.AllScreens[1].Bounds.Height;


            int breite = gB_Folien.Width;
            int höhe = gB_Folien.Height;
            int abstand = 5;

            int scalierungsFaktor = 1;
            Button[] btns_Folien = { this.bt_folie_1, this.bt_folie_2, this.bt_folie_3, this.bt_folie_4, this.bt_folie_5, this.bt_folie_6, this.bt_folie_7, this.bt_folie_8, this.bt_folie_9 };

            double buttonHöhe;
            double buttonBreite;

            if (p_auflösung_h / höhe > p_auflösung_b/breite)
            {
                scalierungsFaktor = p_auflösung_h / höhe;
                buttonHöhe = (höhe - 4 * abstand) / 3;
                buttonBreite = buttonHöhe * (p_auflösung_b / p_auflösung_h);
                
            }
            else
            {
                scalierungsFaktor = p_auflösung_b / breite;

                buttonBreite = (breite - 4 * abstand) / 3;
                buttonHöhe = buttonBreite * (Convert.ToDouble(p_auflösung_h) / Convert.ToDouble(p_auflösung_b));
                
            }
            

            for (int i = 0; i < btns_Folien.Length; i++)
            {
                btns_Folien[i].Width = Convert.ToInt32(buttonBreite);
                btns_Folien[i].Height = Convert.ToInt32(buttonHöhe);

                if (i < 3)
                {
                    btns_Folien[i].Location = new Point(abstand * (i + 1) + btns_Folien[i].Width * i, abstand + 10);
                }
                else if (i < 6)
                {
                    btns_Folien[i].Location = new Point(abstand * (i - 3 + 1) + btns_Folien[i].Width * (i - 3), 10 + abstand * 2 + btns_Folien[i].Height);
                }
                else
                {
                    btns_Folien[i].Location = new Point(abstand * (i - 6 + 1) + btns_Folien[i].Width * (i - 6), 10 +abstand * 3 + btns_Folien[i].Height * 2);
                }

                if (i == 8)
                {
                    this.gB_Folien.Height = 10 + abstand * 5 + btns_Folien[i].Height * 3 + 25;
                    //this.gB_Folien.Width = 
                }
            }

            
        }

        //präsentation
        private void präsentationStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                präsentation.DesktopBounds = Screen.AllScreens[1].Bounds;
                präsentation.TopMost = true;
                präsentation.FormBorderStyle = FormBorderStyle.None;
                präsentation.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Bitte verwenden sie einen zweiten Bildschirm");
            }
            präsentation.Show();
        }

        private void präsentationStoppenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.Hide();
        }

        private void leerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setText("");
            präsentation.setTitel("");
            präsentation.setakVers("");
            präsentation.setBild(null);
        }

        private void nurBildLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setBild(null);
        }

        private void nurTextLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setText("");
            präsentation.setTitel("");
            präsentation.setakVers("");
        }
        //präsentation ende
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void manuellerTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manuelleTexteingabe.Show();
        }

        private void bilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilderAnzeige.Show();
        }
    }
}
