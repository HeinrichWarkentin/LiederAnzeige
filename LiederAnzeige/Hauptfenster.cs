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

        private void BT_Text_groeßer_Click(object sender, EventArgs e)
        {

        }

        private void BT_Text_kleiner_Click(object sender, EventArgs e)
        {

        }

        //Hauptfenster Menüleiste Ansichten ein und ausblenden
        private void TextgrößenSteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;
            
            if (TextgrößenSteuerungToolStripMenuItem.Checked)
            {
                gb_schrift.Visible = true;
            }
            else
            {
                gb_schrift.Visible = false;
            }
            
        }

        private void LiveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (LiveInfoToolStripMenuItem.Checked)
            {
                Gb_live_info.Visible = true;
            }
            else
            {
                Gb_live_info.Visible = false;
            }
        }

        private void EinfacheFoliensteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (EinfacheFoliensteuerungToolStripMenuItem.Checked)
            {
                gb_folien_einfach.Visible = true;
            }
            else
            {
                gb_folien_einfach.Visible = false;
            }
        }

        private void ErweiterteFoliensteuerungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansichtToolStripMenuItem.DropDown.Visible = true;

            if (ErweiterteFoliensteuerungToolStripMenuItem.Checked)
            {
                gb_folien_erweitert.Visible = true;
            }
            else
            {
                gb_folien_erweitert.Visible = false;
            }
        }


        private void Automatische_anpassung_der_gp()
        {   
            GroupBox[] gp_show = { this.gb_suche, this.Gb_live_info, this.gb_schrift, this.gb_folien_einfach, this.gb_folien_erweitert };
            int abstand = 12;
            //gb_suche.Top = 27;
            //gb_suche.Left = 12;
            gb_suche.Width = 454;
            //gb_suche.Height = 192;
            Gb_live_info.Width = 454;

            int[] temp_next_point = { abstand, HauptfensterMenueleiste.Height };

            
            for (int i = 0; i < gp_show.Length; i++)
            {
                if (gp_show[i].Visible)
                {
                    //nextpoint x
                    gp_show[i].Left = temp_next_point[0];
                    if (i + 1 < gp_show.Length)
                    {
                        if (gp_show[i].Width + abstand * 3 + gp_show[i + 1].Width >= this.Width)
                        {
                            temp_next_point[0] = abstand;
                            //nextpoint y
                            gp_show[i].Top = temp_next_point[1];
                            temp_next_point[1] = temp_next_point[1] + gp_show[i].Height + abstand;
                        }
                        else
                        {
                            temp_next_point[0] = temp_next_point[0] + abstand + gp_show[i].Width;
                        }
                    }
                    
                }
            }
            /*
            if (abstand + gb_suche.Width + abstand + gb_folien_einfach.Width + abstand >= this.Width )
            {
                //Breites Fenster
                if (Gb_live_info.Visible)
                {
                    Gb_live_info.Top = gb_suche.Top + gb_suche.Height + abstand;
                    Gb_live_info.Left = abstand;
                    

                }
                else
                {
                    {
                        
                    }
                }


            }
            else
            {
                //dünnes Fenster
                
            }*/


            gb_Folien_Skalieren(this.Width - abstand * 2, this.Height - (abstand + temp_next_point[1]));

            //gb_Folien_Skalieren();

            void gb_Folien_Skalieren(int max_height,int max_width)
            {
                Button[] bt_folien = { this.bt_folien_1, this.bt_folien_2, this.bt_folien_3, this.bt_folien_4, this.bt_folien_5, this.bt_folien_6, this.bt_folien_7, this.bt_folien_8, this.bt_folien_9 };

                int auflösung_height = 1080;
                int auflösung_widht = 1920;
                int temp_abstand = 12;

                double seitenverhaeltnis = auflösung_widht / auflösung_height;

                int tmp_bt_breite;
                int tmp_bt_hoehe;

                if (max_height*seitenverhaeltnis > max_width)
                {
                    //an breite orientieren
                    tmp_bt_breite = Convert.ToInt32((max_width - (temp_abstand * 4)) / 3);
                    tmp_bt_hoehe = Convert.ToInt32(tmp_bt_breite / seitenverhaeltnis);
                }
                else
                {
                    //an höhe orientieren
                    tmp_bt_hoehe = Convert.ToInt32((max_height - (temp_abstand * 4)) / 3);
                    tmp_bt_breite = Convert.ToInt32(max_height * seitenverhaeltnis);
                }

                for (int i = 0; i < bt_folien.Length; i++)
                {
                    bt_folien[i].Width = tmp_bt_breite;
                    bt_folien[i].Height = tmp_bt_hoehe;
                    if (i>4)
                    {
                        bt_folien[i].Top = temp_abstand;
                        bt_folien[i].Left = temp_abstand * (1 + i) + tmp_bt_breite * i;
                    }
                    else if (i<3 && i > 7)
                    {
                        bt_folien[i].Top = temp_abstand*2 + tmp_bt_hoehe;
                        bt_folien[i].Left = temp_abstand * (1 + i) + tmp_bt_breite * i;
                    }
                    else
                    {
                        bt_folien[i].Top = temp_abstand * 3 + tmp_bt_hoehe * 2;
                        bt_folien[i].Left = temp_abstand * (1 + i) + tmp_bt_breite * i;
                    }
                }
            }
        }

        private void Folien_schrift_groesse_skalieren()
        {
            Font praesentation_Font = new Font("Times New Roman", 72f);


        }

        private void Hauptfenster_ResizeEnd(object sender, EventArgs e)
        {
            Automatische_anpassung_der_gp();
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {

        }
    }
}
