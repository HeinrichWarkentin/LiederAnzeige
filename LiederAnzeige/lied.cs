using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LiederAnzeige
{
    internal class Lied
    {
        private string Titel = "";
        private string Komponist = "";
        private string Texter = "";
        private string Übersetzer = "";
        private bool passtAlles = true;
        
        private List<string[]> l_MetaDaten = new List<string[]>();

        private string[] vers_refrain_reihenfolge;
        private List<string[]> l_Strophen = new List<string[]>();

        public Lied(string pTextformSNGfile) 
        {
            string[] splitVerseUNDMetaData = pTextformSNGfile.Split(new string[] { "---" }, StringSplitOptions.None);
            //Metadaten
            string[] splitMetaDatabyNewline = splitVerseUNDMetaData[0].Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int g = 0; g < splitMetaDatabyNewline.Length; g++)
            {
                if (splitMetaDatabyNewline[g].Contains("="))
                {
                    string TMP_MdataName = splitMetaDatabyNewline[g].Split('=')[0];
                    string TMP_MdataWert = splitMetaDatabyNewline[g].Split('=')[1];

                    switch (TMP_MdataName){
                        case "#Title": Titel = TMP_MdataWert;
                            break;
                        case "#Author": Komponist= TMP_MdataWert;
                            break;

                        case "#VerseOrder": vers_refrain_reihenfolge = TMP_MdataWert.Split(',');
                            break;
                    }
                    l_MetaDaten.Add(new string[] { TMP_MdataName, TMP_MdataWert });

                }
            }


            //LiedText
            for (int i = 1; i < splitVerseUNDMetaData.Length; i++)
            {
                string[] splitTextbyNewline = splitVerseUNDMetaData[i].Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                string VersText = "";
                for (int j = 0; j < splitTextbyNewline.Length; j++)
                {
                    if (!splitTextbyNewline[0].Contains("Vers") || !splitTextbyNewline[0].Contains("Refrain"))
                    {
                        passtAlles = false;
                    }
                    if (j == 0)
                    {
                        VersText += splitTextbyNewline[j];
                    }
                    else
                    {
                        VersText += Environment.NewLine + splitTextbyNewline[j];
                    }
                }
                l_Strophen.Add(new string[] { splitTextbyNewline[0], VersText });
            }
        }

        public string GetStrophe(string pText)
        {
            string tmpreturn = "ERROR: Strophe "+ pText + " exestiert nicht";
            for (int i = 0; i < l_Strophen.Count; i++)
            {
                if (l_Strophen[i][0].Contains(pText))
                {
                    tmpreturn = l_Strophen[i][1];
                }
            }
            return tmpreturn;
        }

        public string GetMetaData(string pText)
        {
            string tmpreturn = "ERROR: MetaData "+ pText + " exestiert nicht";
            for (int i = 0; i < l_Strophen.Count; i++)
            {
                if (l_Strophen[i][0].Contains(pText))
                {
                    tmpreturn = l_Strophen[i][1];
                }
            }
            return tmpreturn;
        }

        public string[] Getvers_refrain_reihenfolge()
        {
            return vers_refrain_reihenfolge;
        }

        public string GetTitel()
        {
            return Titel;
        }

        public string GetKomponist()
        {
            return Komponist;
        }
        public string GetTexter()
        {
            return Texter;
        }
        public string GetÜbersetzer()
        {
            return Übersetzer;
        }
    }
}
