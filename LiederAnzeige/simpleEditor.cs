using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class simpleEditor : Form
    {
        public simpleEditor(MainForm pMainform)
        {
            InitializeComponent();
            MainForm = pMainform;
            vRTB_bearbeitet = false;
        }
        private readonly MainForm MainForm;
        private string bearbeitungsPfad;
        private bool vRTB_bearbeitet;


        private void DateiEinlesen(string ppfad)
        {
            if (ppfad != null)
            {
                StreamReader sr = new StreamReader(ppfad);
                RTB_textfield.Text = sr.ReadToEnd();
            }
        }

        private void DateiSpeichern()
        {
            if (bearbeitungsPfad != null)
            {
                File.WriteAllText(bearbeitungsPfad, RTB_textfield.Text, Encoding.UTF8);
                MainForm.AktuellesLiedBearbeitet();
            }
        }

        private void BT_save_Click(object sender, EventArgs e)
        {
            DateiSpeichern();
        }

        private void BT_abort_Click(object sender, EventArgs e)
        {
            DateiEinlesen(bearbeitungsPfad);
        }

        public void Neues_ak_Lied()
        {
            DialogResult spechernFrage = DialogResult.No;

            if (vRTB_bearbeitet)
            {
                spechernFrage = MessageBox.Show("Wollen Sie die änderungen Speichern?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if (vRTB_bearbeitet && spechernFrage == DialogResult.Yes)
            {
                DateiSpeichern();
            }
            bearbeitungsPfad = MainForm.akSongPfad;
            DateiEinlesen(bearbeitungsPfad);


        }

        private void RTB_textfield_TextChanged(object sender, EventArgs e)
        {
            vRTB_bearbeitet = true;
        }
    }
}
