using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class Präsentation : Form
    {
        public Präsentation()
        {
            InitializeComponent();
        }

        public void setTitel(string pTitel)
        {
            if (pTitel == "")
            {
                la_titel.Height = 0;
            }
            else
            {
                la_titel.Height = la_titel.Font.Height * 2;
            }
            la_titel.Text = pTitel;
        }
        public void setText(string pText)
        {
            la_text.Text = pText;
        }
        public void setakVers(string pVersInfo)
        {
            la_akVers.Text = pVersInfo;
        }

        public void setBild(Image pImage, PictureBoxSizeMode pMode)
        {
            this.pbHintergrund.Image = pImage;
            this.pbHintergrund.SizeMode= pMode;
        }

        private void Präsentation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void setFont(Font pFont)
        {
            la_text.Font = pFont;
            la_titel.Font = pFont;
        }
        public void setBackgroundColor(Color pColor)
        {
            la_titel.BackColor = Color.Transparent;
            la_text.BackColor = Color.Transparent;
            la_akVers.BackColor = Color.Transparent;
            this.BackColor = pColor;
        }
        public void setFontColor(Color pColor)
        {
            la_akVers.ForeColor = pColor;
            la_text.ForeColor = pColor;
            la_titel.ForeColor = pColor;

        }

        private void Präsentation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.TopMost = true;
                    this.WindowState = FormWindowState.Maximized;
                }
                
            }
        }

    }
}
