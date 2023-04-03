using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiederAnzeige
{
    public partial class akScreenForm : Form
    {
        public akScreenForm()
        {
            InitializeComponent();
        }
        public void setNumber(int pNum)
        {
            label1.Text = pNum.ToString();
        }

        private void akScreenForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
