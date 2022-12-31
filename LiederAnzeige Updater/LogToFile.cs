using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LiederAnzeige_Updater
{
    class LogToFile
    {
        private string LogType = "Costum";
        private string FilePath;
        private string SessionID = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
        private StreamWriter File;

        public LogToFile(int type, string ordner)
        {
            
            switch (type){
                case 1: 
                    LogType = "Error";
                    FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString("yyyy_MM_dd") + "_" + SessionID + ".txt";
                    break;
                case 2: 
                    LogType = "Warning";
                    FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString("yyyy_MM_dd") + "_" + SessionID + ".txt";
                    break;
                case 3:
                    LogType = "Info";
                    FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString("yyyy_MM_dd") + "_" + SessionID + ".txt";
                    break;
                default:
                    LogType = "Ungültiger Log-Type-Code";
                    FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString("yyyy_MM_dd") + "_" + SessionID + ".txt";
                    break;
            }
            Directory.CreateDirectory(@"./" + ordner);


        }
        public LogToFile(string type, string ordner, bool session, string timeSting)
        {
            try
            {
                DateTime.Now.ToString(timeSting);
            }
            catch (Exception)
            {
                timeSting = "yyyy_MM_dd";
                //throw;
            }

            LogType = type;
            if (session)
            {
                //yyyy_MM_dd
                FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString(timeSting) + "_" + SessionID + ".txt";

            }
            else
            {
                FilePath = @"./" + ordner + "/log_" + DateTime.Now.ToString(timeSting) + ".txt";

            }
            Directory.CreateDirectory(@"./" + ordner);
        }

        public void log(string text)
        {
            File = new StreamWriter(FilePath, true, Encoding.UTF8);
            File.WriteLine(DateTime.Now.ToString("G")+" "+ LogType + ": "+ text);
            File.Close();
        }
    }
}
