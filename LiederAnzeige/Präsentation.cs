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

        public void setBild(Image pImage)
        {
            this.BackgroundImage = pImage;
        }

        private void Präsentation_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            e.Cancel = true;
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
