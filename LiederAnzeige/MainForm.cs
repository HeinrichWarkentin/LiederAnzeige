using LiederAnzeige.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class MainForm : Form
    {
        private readonly Präsentation präsentation;
        private readonly manuellerText manuelleTexteingabe;
        private readonly bilderForm bilderAnzeige;
        private readonly neuesLiedForm neuesLiederstellen;
        private readonly settingsForm einstellungen;
        private readonly DBLiederbücherForm liederbücherForm;
        private readonly DBLieder liederDatenbank;
        private readonly MSSQLDatenbank Datenbank;
        private readonly simpleEditor simpleEditor;

        public readonly string akTitel;
        public readonly int akTitelNR;
        public readonly string akSongPfad;
        public readonly int akLiederbuch;

        private readonly List<(int, string, string, string)> Suchergebnis;

        public MainForm()
        {
            InitializeComponent();
           
            ScaliereFolien();
            präsentation = new Präsentation();
            manuelleTexteingabe = new manuellerText(präsentation);
            bilderAnzeige = new bilderForm(präsentation);
            einstellungen = new settingsForm();
            Datenbank = new MSSQLDatenbank(Properties.Settings.Default.DB_LiederAnzeigeConnectionString);
            liederbücherForm = new DBLiederbücherForm();
            liederDatenbank = new DBLieder();
            simpleEditor = new simpleEditor(this);


            Add_default_Liederbuch();
            Load_Liederbücher();
            neuesLiederstellen = new neuesLiedForm();
            Suchergebnis = new List<(int, string, string, string)>();

            //Aktuelles Lied
            //akTitel = 
            //akTitelNR = 
            //akSongPfad =
            //akLiederbuch
    }
        

        private void ScaliereFolien()
        {
            
            int p_auflösung_b = Screen.AllScreens[1].Bounds.Width;
            int p_auflösung_h = Screen.AllScreens[1].Bounds.Height;


            int breite = gB_Folien.Width;
            int höhe = gB_Folien.Height;
            int abstand = 5;

            int scalierungsFaktor = 1;
            Button[] btns_Folien = { this.BT_folie_1, this.BT_folie_2, this.BT_folie_3, this.BT_folie_4, this.BT_folie_5, this.BT_folie_6, this.BT_folie_7, this.BT_folie_8, this.BT_folie_9 };

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
        private void PräsentationStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                if (Properties.Settings.Default.anzeigeMonitor >= Screen.AllScreens.Length || Properties.Settings.Default.anzeigeMonitor < 1)
                {
                    präsentation.DesktopBounds = Screen.AllScreens[1].Bounds;
                }
                else
                {
                    präsentation.DesktopBounds = Screen.AllScreens[Properties.Settings.Default.anzeigeMonitor].Bounds;
                }
                präsentation.TopMost = true;
                präsentation.FormBorderStyle = FormBorderStyle.None;
                präsentation.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Bitte verwenden sie einen zweiten Bildschirm");
            }
            präsentation.Select();
            präsentation.Show();
        }

        private void PräsentationStoppenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.Hide();
        }

        private void LeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setText("");
            präsentation.setTitel("");
            präsentation.setakVers("");
            präsentation.setBild(null, PictureBoxSizeMode.Zoom);
        }

        private void NurBildLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setBild(null, PictureBoxSizeMode.Zoom);
        }

        private void NurTextLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            präsentation.setText("");
            präsentation.setTitel("");
            präsentation.setakVers("");
        }
        //präsentation ende
        

        private void ManuellerTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manuelleTexteingabe.Show();
            manuelleTexteingabe.Select();

        }

        private void BilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilderAnzeige.Show();
            bilderAnzeige.Select();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MainFormMaximised)
            {
                Location = Properties.Settings.Default.MainFormLocation;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.MainFormSize;
            }
            else if (Properties.Settings.Default.MainFormMinimised)
            {
                Location = Properties.Settings.Default.MainFormLocation;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.MainFormSize;
            }
            else
            {
                Location = Properties.Settings.Default.MainFormLocation;
                Size = Properties.Settings.Default.MainFormSize;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.MainFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.MainFormSize = RestoreBounds.Size;
                Properties.Settings.Default.MainFormMaximised = true;
                Properties.Settings.Default.MainFormMinimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.MainFormLocation = Location;
                Properties.Settings.Default.MainFormSize = Size;
                Properties.Settings.Default.MainFormMaximised = false;
                Properties.Settings.Default.MainFormMinimised = false;
            }
            else
            {
                Properties.Settings.Default.MainFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.MainFormSize = RestoreBounds.Size;
                Properties.Settings.Default.MainFormMaximised = false;
                Properties.Settings.Default.MainFormMinimised = true;
            }
            Properties.Settings.Default.Save();
        }

        private void NeuesLiedErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neuesLiederstellen.Show();
            neuesLiederstellen.Select();
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            einstellungen.Show();
            einstellungen.Select();
        }

        private void NachUpdatesSuchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(".\\LiederAnzeige Updater.exe");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CB_Liederbuecher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Load_Liederbücher()
        {
            SqlCommand command = new SqlCommand("SELECT Name FROM [dbo].Liederbücher");
            CB_Liederbuecher.Items.Clear();
            CB_Liederbuecher.Items.AddRange(Datenbank.returningCommandListString(command, 0).ToArray());
            CB_Liederbuecher.Items.Add("@ Alle");
        }

        private void Add_default_Liederbuch()
        {
            string commandstring = "INSERT INTO [dbo].Liederbücher (Name, Verlag) VALUES ('@ kein Liederbuch', 'None');";
            SqlCommand command = new SqlCommand(commandstring);
            Datenbank.nonReturningCommand(command);
        }

        private void LiederbücherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liederbücherForm.Show();
            liederbücherForm.Select();
        }

        private void CB_Liederbuecher_DropDown(object sender, EventArgs e)
        {
            Load_Liederbücher();
        }

        private void TB_suchefeld_TextChanged(object sender, EventArgs e)
        {

        }

        private List<string> Suche_nach_Lied(string pLiederbuch, string pSuchtext)
        {
            List<string> Rückgabeliste = new List<string>();
            string SQLCommandstring;
            if (pLiederbuch == "@ Alle")
            {
                //Durchsuche alle Liederbücher
                SQLCommandstring = "SELECT Titelnummer, Titel, Liederbuch, DateiPfad FROM dbo.Lieder WHERE (Titelnummer = " + pSuchtext + " OR Titel = '" + pSuchtext + "');";
            }
            else
            {
                SQLCommandstring = "SELECT Titelnummer, Titel, Liederbuch, DateiPfad FROM dbo.Lieder WHERE (Titelnummer = " + pSuchtext + " OR Titel = '" + pSuchtext + "') AND Liederbuch = '" + pLiederbuch + "';";
            }
            SqlCommand SQLcommand = new SqlCommand(SQLCommandstring);
            Datenbank.returningCommandmultiColumntoCache(SQLcommand);

            List<int> SuchergebnisTitelnummer = Datenbank.readfromCachedDataInt(0);
            List<string> SuchergebnisTitel= Datenbank.readfromCachedDataString(1);
            List<string> SuchergebnisLiedebuch = Datenbank.readfromCachedDataString(2);
            List<string> SuchergebnisDateiPfad = Datenbank.readfromCachedDataString(3);
            
            if (SuchergebnisTitelnummer.Count == SuchergebnisTitel.Count && SuchergebnisLiedebuch.Count == SuchergebnisTitel.Count && SuchergebnisLiedebuch.Count == SuchergebnisDateiPfad.Count)
            {
                for (int i = 0; i < SuchergebnisTitelnummer.Count; i++)
                {
                    // Erstellen eines neuen Person-Objekts und Hinzufügen zur Datenliste
                    Suchergebnis.Add((SuchergebnisTitelnummer[i], SuchergebnisTitel[i], SuchergebnisLiedebuch[i], SuchergebnisDateiPfad[i]));
                    Rückgabeliste.Add(SuchergebnisTitelnummer[i].ToString() + " | "+ SuchergebnisTitel[i] + " | " + SuchergebnisLiedebuch[i]);
                }
            }
            else
            {
                Console.WriteLine("Die Listen haben unterschiedliche Längen.");
            }
            //Ausgabe
            


            return Rückgabeliste;
        }

        private void LiederDatenbankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liederDatenbank.Show();
            liederDatenbank.Select();
        }

        private void EditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleEditor.Show();
            simpleEditor.Select();
        }

        public void AktuellesLiedBearbeitet()
        {

        }
    }
}
