namespace LiederAnzeige
{
    partial class DBLieder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLieder));
            this.dB_LiederAnzeigeDataSet = new LiederAnzeige.DB_LiederAnzeigeDataSet();
            this.liederBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liederTableAdapter = new LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.LiederTableAdapter();
            this.tableAdapterManager = new LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager();
            this.liederBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.liederBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.liederDataGridView = new System.Windows.Forms.DataGridView();
            this.liederbücherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLiederAnzeigeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liederbücherTableAdapter = new LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.LiederbücherTableAdapter();
            this.Titelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liederbuch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateiPfad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LiederAnzeigeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederBindingNavigator)).BeginInit();
            this.liederBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liederDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLiederAnzeigeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_LiederAnzeigeDataSet
            // 
            this.dB_LiederAnzeigeDataSet.DataSetName = "DB_LiederAnzeigeDataSet";
            this.dB_LiederAnzeigeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // liederBindingSource
            // 
            this.liederBindingSource.DataMember = "Lieder";
            this.liederBindingSource.DataSource = this.dB_LiederAnzeigeDataSet;
            // 
            // liederTableAdapter
            // 
            this.liederTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LiederbücherTableAdapter = null;
            this.tableAdapterManager.LiederTableAdapter = this.liederTableAdapter;
            this.tableAdapterManager.UpdateOrder = LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // liederBindingNavigator
            // 
            this.liederBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.liederBindingNavigator.BindingSource = this.liederBindingSource;
            this.liederBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.liederBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.liederBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.liederBindingNavigatorSaveItem});
            this.liederBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.liederBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.liederBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.liederBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.liederBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.liederBindingNavigator.Name = "liederBindingNavigator";
            this.liederBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.liederBindingNavigator.Size = new System.Drawing.Size(1027, 25);
            this.liederBindingNavigator.TabIndex = 0;
            this.liederBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // liederBindingNavigatorSaveItem
            // 
            this.liederBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.liederBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("liederBindingNavigatorSaveItem.Image")));
            this.liederBindingNavigatorSaveItem.Name = "liederBindingNavigatorSaveItem";
            this.liederBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.liederBindingNavigatorSaveItem.Text = "Daten speichern";
            this.liederBindingNavigatorSaveItem.Click += new System.EventHandler(this.liederBindingNavigatorSaveItem_Click);
            // 
            // liederDataGridView
            // 
            this.liederDataGridView.AutoGenerateColumns = false;
            this.liederDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liederDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titelnummer,
            this.Titel,
            this.Liederbuch,
            this.DateiPfad});
            this.liederDataGridView.DataSource = this.liederBindingSource;
            this.liederDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liederDataGridView.Location = new System.Drawing.Point(0, 25);
            this.liederDataGridView.Name = "liederDataGridView";
            this.liederDataGridView.Size = new System.Drawing.Size(1027, 499);
            this.liederDataGridView.TabIndex = 1;
            this.liederDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.liederDataGridView_EditingControlShowing);
            // 
            // liederbücherBindingSource
            // 
            this.liederbücherBindingSource.AllowNew = false;
            this.liederbücherBindingSource.DataMember = "Liederbücher";
            this.liederbücherBindingSource.DataSource = this.dBLiederAnzeigeDataSetBindingSource;
            // 
            // dBLiederAnzeigeDataSetBindingSource
            // 
            this.dBLiederAnzeigeDataSetBindingSource.AllowNew = false;
            this.dBLiederAnzeigeDataSetBindingSource.DataSource = this.dB_LiederAnzeigeDataSet;
            this.dBLiederAnzeigeDataSetBindingSource.Position = 0;
            // 
            // liederbücherTableAdapter
            // 
            this.liederbücherTableAdapter.ClearBeforeFill = true;
            // 
            // Titelnummer
            // 
            this.Titelnummer.DataPropertyName = "Titelnummer";
            this.Titelnummer.HeaderText = "Titelnummer";
            this.Titelnummer.Name = "Titelnummer";
            this.Titelnummer.Width = 70;
            // 
            // Titel
            // 
            this.Titel.DataPropertyName = "Titel";
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            this.Titel.Width = 200;
            // 
            // Liederbuch
            // 
            this.Liederbuch.DataPropertyName = "Liederbuch";
            this.Liederbuch.DataSource = this.liederbücherBindingSource;
            this.Liederbuch.DisplayMember = "Name";
            this.Liederbuch.HeaderText = "Liederbuch";
            this.Liederbuch.MaxDropDownItems = 40;
            this.Liederbuch.Name = "Liederbuch";
            this.Liederbuch.ValueMember = "Name";
            this.Liederbuch.Width = 200;
            // 
            // DateiPfad
            // 
            this.DateiPfad.DataPropertyName = "DateiPfad";
            this.DateiPfad.HeaderText = "DateiPfad";
            this.DateiPfad.Name = "DateiPfad";
            this.DateiPfad.Width = 500;
            // 
            // DBLieder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.liederDataGridView);
            this.Controls.Add(this.liederBindingNavigator);
            this.Name = "DBLieder";
            this.Text = "Lieder Datenbank";
            this.Activated += new System.EventHandler(this.DBLieder_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DB_Lieder_FormClosing);
            this.Load += new System.EventHandler(this.DB_Lieder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_LiederAnzeigeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederBindingNavigator)).EndInit();
            this.liederBindingNavigator.ResumeLayout(false);
            this.liederBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liederDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLiederAnzeigeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_LiederAnzeigeDataSet dB_LiederAnzeigeDataSet;
        private System.Windows.Forms.BindingSource liederBindingSource;
        private DB_LiederAnzeigeDataSetTableAdapters.LiederTableAdapter liederTableAdapter;
        private DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator liederBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton liederBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView liederDataGridView;
        private System.Windows.Forms.BindingSource dBLiederAnzeigeDataSetBindingSource;
        private System.Windows.Forms.BindingSource liederbücherBindingSource;
        private DB_LiederAnzeigeDataSetTableAdapters.LiederbücherTableAdapter liederbücherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Liederbuch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateiPfad;
    }
}