using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using System.IO.Compression;
using static System.Net.WebRequestMethods;
using System.Diagnostics;

namespace LiederAnzeige_Updater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            logError = new LogToFile(1,"Debug");
            logWarning = new LogToFile(2, "Debug");
            logInfo = new LogToFile(3, "Debug");

            suche_nach_Updates();
        }
        LogToFile logError;
        LogToFile logWarning;
        LogToFile logInfo;

        Asset asset;
        Author author;
        Root root;
        Uploader uploader;

        private void suche_nach_Updates()
        {
            pB_ichArbeite.Visible = true;
            lb_info.Visible = false;
            pB_ichArbeite.Value = 1;
            string installierte_Version = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LiederAnzeige", "version",null);

            if (installierte_Version == null)
            {
                pB_ichArbeite.Value = 50;
                la_installierteVersion.Text = "nicht installiert";
                la_aktuellsteVersion.Text = suche_aktuelle_Version();
                pB_ichArbeite.Value = 90;
                ist_aktuelle_v_neuer_als_installierte("0.0.0", la_aktuellsteVersion.Text);
                bt_installiereUpdates.Visible = true;
                DialogResult result = MessageBox.Show("LiederAnzeige ist nicht installiert. Soll es installiert werden?", "Hinweis", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    updates_herunterladen_und_installieren();
                }
                pB_ichArbeite.Value = 100;

            }
            else
            {
                pB_ichArbeite.Value = 50;
                la_installierteVersion.Text = installierte_Version;
                la_aktuellsteVersion.Text = suche_aktuelle_Version();
                if (la_aktuellsteVersion.Text != "Fehler")
                {
                    pB_ichArbeite.Value = 90;
                    if (ist_aktuelle_v_neuer_als_installierte(la_installierteVersion.Text, la_aktuellsteVersion.Text))
                    {
                        bt_installiereUpdates.Visible = true;
                    }
                }
                pB_ichArbeite.Value = 100;

            }
        }
        
        
        
        
        private void bt_action_Click(object sender, EventArgs e)
        {
            suche_nach_Updates();
        }

        private string suche_aktuelle_Version()
        {
            string rückgabe = "Fehler";

            Exception e = frageGithubAPI();
            if (e == null)
            {
                rückgabe = root.tag_name;
            }
            return rückgabe;

        }

        private Exception frageGithubAPI()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://api.github.com/repos/HeinrichWarkentin/LiederAnzeige/releases/latest");
            request.UserAgent = "request";

            try
            {
                WebResponse response = request.GetResponse();
                StreamReader stream = new StreamReader(response.GetResponseStream());

                string Joke_JSON = stream.ReadToEnd();

                asset = Newtonsoft.Json.JsonConvert.DeserializeObject<Asset>(Joke_JSON);
                author = Newtonsoft.Json.JsonConvert.DeserializeObject<Author>(Joke_JSON);
                root = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(Joke_JSON);
                uploader = Newtonsoft.Json.JsonConvert.DeserializeObject<Uploader>(Joke_JSON);
                logInfo.log("Abfrage auf "+request.RequestUri+" erfolgreich");
                return null;
            }
            catch (Exception e)
            {
                logError.log(e.Message);
                zeigeInfo("Fehler: "+ e.Message);
                return e;
            }
        }
        
        public class Asset
        {
            public string url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string name { get; set; }
            public object label { get; set; }
            public Uploader uploader { get; set; }
            public string content_type { get; set; }
            public string state { get; set; }
            public int size { get; set; }
            public int download_count { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string browser_download_url { get; set; }
        }

        public class Author
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        public class Root
        {
            public string url { get; set; }
            public string assets_url { get; set; }
            public string upload_url { get; set; }
            public string html_url { get; set; }
            public int id { get; set; }
            public Author author { get; set; }
            public string node_id { get; set; }
            public string tag_name { get; set; }
            public string target_commitish { get; set; }
            public string name { get; set; }
            public bool draft { get; set; }
            public bool prerelease { get; set; }
            public DateTime created_at { get; set; }
            public DateTime published_at { get; set; }
            public List<Asset> assets { get; set; }
            public string tarball_url { get; set; }
            public string zipball_url { get; set; }
            public string body { get; set; }
        }

        public class Uploader
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }




        private bool ist_aktuelle_v_neuer_als_installierte(string installierteVersion, string aktuellsteVersion)
        {   
            bool rückgabe = false;
            string[] installierteVersion_Split = installierteVersion.Split('.');
            string[] aktuellsteVersion_Split = aktuellsteVersion.Split('.');
            if (Convert.ToInt32(aktuellsteVersion_Split[0]) == Convert.ToInt32(installierteVersion_Split[0]))
            {
                if (Convert.ToInt32(aktuellsteVersion_Split[1]) == Convert.ToInt32(installierteVersion_Split[1]))
                { 

                    if (Convert.ToInt32(aktuellsteVersion_Split[2]) == Convert.ToInt32(installierteVersion_Split[2]))
                    {
                        rückgabe = false;
                    }
                    else if (Convert.ToInt32(aktuellsteVersion_Split[2]) < Convert.ToInt32(installierteVersion_Split[2]))
                    {
                        rückgabe = false;
                    }
                    else
                    {
                        rückgabe = true;
                    }

                }
                else if (Convert.ToInt32(aktuellsteVersion_Split[1]) < Convert.ToInt32(installierteVersion_Split[1]))
                {
                    rückgabe = false;
                }
                else
                {
                    rückgabe = true;
                }
            }
            else if(Convert.ToInt32(aktuellsteVersion_Split[0]) < Convert.ToInt32(installierteVersion_Split[0])) 
            {
                rückgabe = false;
            }
            else
            {
                rückgabe = true;
            }

            return rückgabe;
        }

        private void bt_installiereUpdates_Click(object sender, EventArgs e)
        {
            DialogResult warnung_das_progamm_geschlossen_wird = MessageBox.Show("Achtung die LiederAnzeige wird während der Installation geschlossen, führen Sie das Update nicht während dem Livebetrieb durch. Soll die Installation gestartet werden?","Hinweis", MessageBoxButtons.YesNo);
            if (warnung_das_progamm_geschlossen_wird == DialogResult.Yes)
            {
                updates_herunterladen_und_installieren();
            }
            
        }

        private void zeigeInfo(string text)
        {
            lb_info.Text = text;
            lb_info.Visible = true;
            pB_ichArbeite.Visible = false;
        }
        private void updates_herunterladen_und_installieren()
        {
            lb_info.Visible = false;
            pB_ichArbeite.Visible = true;
            pB_ichArbeite.Value = 1;
            string downloadLink = "https://github.com/HeinrichWarkentin/LiederAnzeige/releases/download/"+root.tag_name+"/LiederAnzeige.Setup.msi";
            Directory.CreateDirectory(@".\updates");
            string destinationPath = @".\updates\LiederAnzeige.Setup.msi";

            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "MyRSSReader/1.0");
                client.DownloadFile(downloadLink, destinationPath);
                pB_ichArbeite.Value = 99;
                Process.Start(destinationPath);
                Application.Exit();

            }
        }

    }

}
