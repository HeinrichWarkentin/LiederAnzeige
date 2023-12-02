using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class SettingsForm : Form
    {
        private readonly Präsentation testpräsi;
        public SettingsForm()
        {
            InitializeComponent();
            testpräsi = new Präsentation();
        }

        private void CB_Bildschirme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.anzeigeMonitor = CB_Bildschirme.SelectedIndex;
            if (Screen.AllScreens.Length > 1)
                testpräsi.Location = Screen.AllScreens[CB_Bildschirme.SelectedIndex].WorkingArea.Location;
        }

        private void CB_Bildschirme_DropDown(object sender, EventArgs e)
        {
            CB_Bildschirme.Items.Clear();
            Screen[] screens = Screen.AllScreens;

            for (int i = 0; i < screens.Length; i++)
            {
                CB_Bildschirme.Items.Add((i+1) +": "+ Screen.AllScreens[i].Bounds.Width.ToString() + " x " + Screen.AllScreens[i].Bounds.Height.ToString());
            }
        }

        private void BT_show_bildschirme_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;

            for (int i = 0; i < screens.Length; i++)
            {
                AKScreenForm akScreen = new AKScreenForm();
                int monitorNummer = i + 1;
                akScreen.SetNumber(monitorNummer);
                akScreen.Location = screens[i].WorkingArea.Location;
                akScreen.Select();
                akScreen.Show();
            }


        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.settingsFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.settingsFormSize = RestoreBounds.Size;
                Properties.Settings.Default.settingsFormMaximised = true;
                Properties.Settings.Default.settingsFormMinimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.settingsFormLocation = Location;
                Properties.Settings.Default.settingsFormSize = Size;
                Properties.Settings.Default.settingsFormMaximised = false;
                Properties.Settings.Default.settingsFormMinimised = false;
            }
            else
            {
                Properties.Settings.Default.settingsFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.settingsFormSize = RestoreBounds.Size;
                Properties.Settings.Default.settingsFormMaximised = false;
                Properties.Settings.Default.settingsFormMinimised = true;
            }
            Properties.Settings.Default.anzeigeMonitor = CB_Bildschirme.SelectedIndex;
            Properties.Settings.Default.Save();

            this.Hide();
            e.Cancel = true;

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (CB_Bildschirme.Items.Count - 1 < Properties.Settings.Default.anzeigeMonitor)
            {
                CB_Bildschirme.SelectedIndex = 0;
            }
            else
            {
                CB_Bildschirme.SelectedIndex = Properties.Settings.Default.anzeigeMonitor;
            }

            if (Properties.Settings.Default.settingsFormMaximised)
            {
                Location = Properties.Settings.Default.settingsFormLocation;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.settingsFormSize;
            }
            else if (Properties.Settings.Default.settingsFormMinimised)
            {
                Location = Properties.Settings.Default.settingsFormLocation;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.settingsFormSize;
            }
            else
            {
                Location = Properties.Settings.Default.settingsFormLocation;
                Size = Properties.Settings.Default.settingsFormSize;
            }

            RTB_initialText.Text = Properties.Settings.Default.initalText;
            LA_font.Text = "Font: " + Properties.Settings.Default.TextFont.Name +"; "+ Properties.Settings.Default.TextFont.Size +"pt";
            LA_schriftfarbe.Text = "Schriftfarbe: " + Properties.Settings.Default.TextSchriftFarbe.ToString();
            LA_hintergrundfarbe.Text = "Hintergrundfarbe: " + Properties.Settings.Default.TextHintergrundFarbe.ToString();
        }

        private void RTB_initialText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.initalText = RTB_initialText.Text;
            VorschauAktualliesieren();
        }

        private void BT_Fontändern_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextFont = fd.Font;
                VorschauAktualliesieren();
            }
            LA_font.Text = "Font: " + Properties.Settings.Default.TextFont.Name + "; " + Properties.Settings.Default.TextFont.Size + "pt";
        }

        private void BT_hintergrundfrabeändern_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextHintergrundFarbe = cd.Color;
                VorschauAktualliesieren();
            }
            LA_hintergrundfarbe.Text = "Hintergrundfarbe: " + Properties.Settings.Default.TextHintergrundFarbe.ToString();
        }

        private void BT_schriftfarbeändern_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextSchriftFarbe = cd.Color;
                VorschauAktualliesieren();
            }
            LA_schriftfarbe.Text = "Schriftfarbe: " + Properties.Settings.Default.TextSchriftFarbe.ToString();
        }


        

        private void VorschauAktualliesieren()
        {
            testpräsi.SetText(Properties.Settings.Default.initalText);

            testpräsi.SetTitel("Beispiel Titel");
            testpräsi.SetFont(Properties.Settings.Default.TextFont);


            testpräsi.SetFontColor(Properties.Settings.Default.TextSchriftFarbe);
            testpräsi.SetBackgroundColor(Properties.Settings.Default.TextHintergrundFarbe);
        }
        private void BT_vorschau_Click(object sender, EventArgs e)
        {
            if (BT_vorschau.Text == "Vorschau")
            {
                BT_vorschau.Text = "Vorschau beenden";
                testpräsi.SetText(Properties.Settings.Default.initalText);

                testpräsi.SetTitel("Beispiel Titel");
                testpräsi.SetFont(Properties.Settings.Default.TextFont);


                testpräsi.SetFontColor(Properties.Settings.Default.TextSchriftFarbe);
                testpräsi.SetBackgroundColor(Properties.Settings.Default.TextHintergrundFarbe);
                testpräsi.Show();
                
            }
            else if (BT_vorschau.Text == "Vorschau beenden")
            {
                BT_vorschau.Text = "Vorschau";
                testpräsi.Hide();
            }
            else
            {
                BT_vorschau.Text = "Vorschau";
            }
            

            
        }
    }
}
