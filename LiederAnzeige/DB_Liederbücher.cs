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
    public partial class DBLiederbücherForm : Form
    {
        public DBLiederbücherForm()
        {
            InitializeComponent();
        }

        private void liederbücherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.liederbücherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_LiederAnzeigeDataSet);

        }

        private void DB_Liederbücher_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_LiederAnzeigeDataSet.Liederbücher". Sie können sie bei Bedarf verschieben oder entfernen.
            this.liederbücherTableAdapter.Fill(this.dB_LiederAnzeigeDataSet.Liederbücher);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_LiederAnzeigeDataSet1.Liederbücher". Sie können sie bei Bedarf verschieben oder entfernen.
            this.liederbücherTableAdapter.Fill(this.dB_LiederAnzeigeDataSet.Liederbücher);

        }

        private void DBLiederbücherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void liederbücherBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.liederbücherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_LiederAnzeigeDataSet);

        }
    }
}
