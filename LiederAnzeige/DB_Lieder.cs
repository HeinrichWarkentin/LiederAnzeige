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
    public partial class DBLieder : Form
    {
        public DBLieder()
        {
            InitializeComponent();
        }

        private void liederBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.liederBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_LiederAnzeigeDataSet);

        }

        private void DB_Lieder_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_LiederAnzeigeDataSet.Liederbücher". Sie können sie bei Bedarf verschieben oder entfernen.
            this.liederbücherTableAdapter.Fill(this.dB_LiederAnzeigeDataSet.Liederbücher);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dB_LiederAnzeigeDataSet.Lieder". Sie können sie bei Bedarf verschieben oder entfernen.
            this.liederTableAdapter.Fill(this.dB_LiederAnzeigeDataSet.Lieder);

        }

        private void DB_Lieder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void DBLieder_Activated(object sender, EventArgs e)
        {
            // Aktualisieren Sie den TableAdapter, um die Daten in der Tabelle 2 zu aktualisieren
            this.liederbücherTableAdapter.Update(this.dB_LiederAnzeigeDataSet.Liederbücher);

            // Nach dem Update können Sie die ComboBox-Datenquelle neu laden, um die neuen Daten anzuzeigen
            this.liederbücherTableAdapter.Fill(this.dB_LiederAnzeigeDataSet.Liederbücher);

            // DataGridView neu zeichnen, um die ComboBox-Daten anzuzeigen
            liederDataGridView.Refresh();
        }
        
        private void liederDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }
    }
}
