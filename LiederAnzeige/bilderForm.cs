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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace LiederAnzeige
{
    public partial class bilderForm : Form
    {
        
        public bilderForm(Präsentation ppräsentation)
        {
            präsentation = ppräsentation;
            //bilderListe1 = new Config_Bilder_Root();
            InitializeComponent();
            configEinlesen(configSpecherort);
        }
        Präsentation präsentation;
        Config_Bilder_Root bilderListe1;
        string configSpecherort = @".\config\bilder.json";

        private void configEinlesen(string pfad)
        {
            if (File.Exists(pfad))
            {
                string json = File.ReadAllText(pfad);
                bilderListe1 = JsonSerializer.Deserialize<Config_Bilder_Root>(json);
                for (int i = 0; i < bilderListe1.bilder.Count; i++)
                {
                    lb_bilder.Items.Add(bilderListe1.bilder[i].bildername.ToString());
                }
            }          
            
        }
        private void configSpeichern(string pfad, object Config_Bilder)
        {
            string json = JsonSerializer.Serialize(Config_Bilder, typeof(Object),new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(pfad, json);
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
                    File.Copy(bilddatei, @".\Bilder\" + bildDialog.SafeFileName);
                    Bilder newbild = new Bilder(bildDialog.SafeFileName, bilddatei);
                    bilderListe1.bilder.Add(newbild);
                    configSpeichern(configSpecherort, bilderListe1);
                    configEinlesen(configSpecherort);
                }
            }
        }

        private void bt_bildlöschen_Click(object sender, EventArgs e)
        {

        }

        private void bt_bildanzeigen_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_anzeigeArt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Bilder
    {
        public Bilder(string pName, string pPfad)
        {
            bildername = pName;
            pfad = pPfad;
        }
        public string bildername { get; set; }
        public string pfad { get; set; }
    }

    public class Config_Bilder_Root
    {
        public List<Bilder> bilder { get; set; }
    }
}
