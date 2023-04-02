using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace LiederAnzeige
{
    public partial class bilderForm : Form
    {

        public bilderForm(Präsentation ppräsentation)
        {
            präsentation = ppräsentation;
            InitializeComponent();
            ordnerEinlesen(ordnerBilderPfad);

        }
        Präsentation präsentation;
        string ordnerBilderPfad = @".\Bilder";
        string[] bilderListe = null;

        private void ordnerEinlesen(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            bilderListe = Directory.GetFiles(path, "*.*").Where(file => file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("gif")).ToArray();
            lb_bilder.Items.Clear();
            for (int i = 0; i < bilderListe.Length; i++)
            {
                lb_bilder.Items.Add(bilderListe[i].Split('\\')[bilderListe[i].Split('\\').Length -1]);
            }
            
        }

        private void bt_bilderhinzufügen_Click(object sender, EventArgs e)
        {
            OpenFileDialog bildDialog = new OpenFileDialog();
            bildDialog.Filter = "Bilder | *.jpeg;*.png;*.jpg;*.gif";

            DialogResult result = bildDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string bilddatei = bildDialog.FileName;

                if (File.Exists(bilddatei))
                {
                    File.Copy(bilddatei, ordnerBilderPfad +"\\"+ bildDialog.SafeFileName, true);
                }
            }
            ordnerEinlesen(ordnerBilderPfad);
        }

        private void bt_bildlöschen_Click(object sender, EventArgs e)
        {
            // Überprüfe, ob ein Bild in der PictureBox-Kontrolle geladen ist und freigebe das Image-Objekt
            if (pb_vorschau.Image != null)
            {
                pb_vorschau.Image.Dispose();
                pb_vorschau.Image = null;
            }
            if (! Directory.Exists(ordnerBilderPfad + "\\deletedItems"))
            {
                Directory.CreateDirectory(ordnerBilderPfad + "\\deletedItems");
            }

            // Verschiebe die Datei
            File.Move(ordnerBilderPfad + "\\" + lb_bilder.SelectedItem.ToString(), ordnerBilderPfad + "\\deletedItems\\" + lb_bilder.SelectedItem.ToString());

            // Lade die Liste neu
            ordnerEinlesen(ordnerBilderPfad);
        }

        private void bt_bildanzeigen_Click(object sender, EventArgs e)
        {
            if (!cB_mitText.Checked)
            {
                präsentation.setText("");
                präsentation.setTitel("");
            }
            präsentation.setBild(pb_vorschau.Image, pb_vorschau.SizeMode);
        }

        private void cb_anzeigeArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_anzeigeArt.SelectedIndex)
            {
                case 0:
                    pb_vorschau.SizeMode = PictureBoxSizeMode.Normal;
                    break;

                case 1: 
                    pb_vorschau.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    pb_vorschau.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 3:
                    pb_vorschau.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                default: 
                    pb_vorschau.SizeMode = PictureBoxSizeMode.Normal;
                    break;
            }
        }

        private void lb_bilder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pb_vorschau.Image != null)
            {
                pb_vorschau.Image.Dispose();
            }
                pb_vorschau.Image = Image.FromFile(bilderListe[lb_bilder.SelectedIndex]);
        }

        private void bilderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.bilderFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.bilderFormSize = RestoreBounds.Size;
                Properties.Settings.Default.bilderFormMaximised = true;
                Properties.Settings.Default.bilderFormMinimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.bilderFormLocation = Location;
                Properties.Settings.Default.bilderFormSize = Size;
                Properties.Settings.Default.bilderFormMaximised = false;
                Properties.Settings.Default.bilderFormMinimised = false;
            }
            else
            {
                Properties.Settings.Default.bilderFormLocation = RestoreBounds.Location;
                Properties.Settings.Default.bilderFormSize = RestoreBounds.Size;
                Properties.Settings.Default.bilderFormMaximised = false;
                Properties.Settings.Default.bilderFormMinimised = true;
            }
            Properties.Settings.Default.bilderFormcb_anzeigeArtSelectedIndex = cb_anzeigeArt.SelectedIndex;
            Properties.Settings.Default.Save();

            this.Hide();
            e.Cancel = true;
        }

        private void bilderForm_Load(object sender, EventArgs e)
        {
            if (cb_anzeigeArt.Items.Count - 1 < Properties.Settings.Default.bilderFormcb_anzeigeArtSelectedIndex)
            {
                cb_anzeigeArt.SelectedIndex = 0;
            }
            else
            {
                cb_anzeigeArt.SelectedIndex = Properties.Settings.Default.bilderFormcb_anzeigeArtSelectedIndex;
            }
            


            if (Properties.Settings.Default.bilderFormMaximised)
            {
                Location = Properties.Settings.Default.bilderFormLocation;
                WindowState = FormWindowState.Maximized;
                Size = Properties.Settings.Default.bilderFormSize;
            }
            else if (Properties.Settings.Default.bilderFormMinimised)
            {
                Location = Properties.Settings.Default.bilderFormLocation;
                WindowState = FormWindowState.Minimized;
                Size = Properties.Settings.Default.bilderFormSize;
            }
            else
            {
                Location = Properties.Settings.Default.bilderFormLocation;
                Size = Properties.Settings.Default.bilderFormSize;
            }
        }

    }
}
