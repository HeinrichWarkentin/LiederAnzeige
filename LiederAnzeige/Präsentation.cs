﻿using System;
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

        public void SetTitel(string pTitel)
        {
            if (pTitel == "")
            {
                LA_titel.Height = 0;
            }
            else
            {
                LA_titel.Height = LA_titel.Font.Height * 2;
            }
            LA_titel.Text = pTitel;
        }
        public void SetText(string pText)
        {
            LA_text.Text = pText;
        }
        public void SetakVers(string pVersInfo)
        {
            LA_akVers.Text = pVersInfo;
        }

        public void SetBild(Image pImage, PictureBoxSizeMode pMode)
        {
            this.pbHintergrund.Image = pImage;
            this.pbHintergrund.SizeMode= pMode;
        }

        private void Präsentation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void SetFont(Font pFont)
        {
            LA_text.Font = pFont;
            LA_titel.Font = pFont;
        }
        public void SetBackgroundColor(Color pColor)
        {
            LA_titel.BackColor = Color.Transparent;
            LA_text.BackColor = Color.Transparent;
            LA_akVers.BackColor = Color.Transparent;
            this.BackColor = pColor;
        }
        public void SetFontColor(Color pColor)
        {
            LA_akVers.ForeColor = pColor;
            LA_text.ForeColor = pColor;
            LA_titel.ForeColor = pColor;

        }

        public Font GetFont()
        {
            return LA_text.Font;
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
