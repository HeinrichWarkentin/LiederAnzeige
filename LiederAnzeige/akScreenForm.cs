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
    public partial class AKScreenForm : Form
    {
        public AKScreenForm()
        {
            InitializeComponent();
        }
        public void SetNumber(int pNum)
        {
            Label1.Text = pNum.ToString();
        }

        private void AKScreenForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
