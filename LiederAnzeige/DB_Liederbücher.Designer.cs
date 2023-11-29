namespace LiederAnzeige
{
    partial class DBLiederbücherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLiederbücherForm));
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dB_LiederAnzeigeDataSet = new LiederAnzeige.DB_LiederAnzeigeDataSet();
            this.liederbücherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liederbücherTableAdapter = new LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.LiederbücherTableAdapter();
            this.tableAdapterManager = new LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager();
            this.liederbücherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.liederbücherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.liederbücherDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LiederAnzeigeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingNavigator)).BeginInit();
            this.liederbücherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Verlag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Verlag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnzahlLieder";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnzahlLieder";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dB_LiederAnzeigeDataSet
            // 
            this.dB_LiederAnzeigeDataSet.DataSetName = "DB_LiederAnzeigeDataSet";
            this.dB_LiederAnzeigeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // liederbücherBindingSource
            // 
            this.liederbücherBindingSource.DataMember = "Liederbücher";
            this.liederbücherBindingSource.DataSource = this.dB_LiederAnzeigeDataSet;
            // 
            // liederbücherTableAdapter
            // 
            this.liederbücherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LiederbücherTableAdapter = this.liederbücherTableAdapter;
            this.tableAdapterManager.LiederTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LiederAnzeige.DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // liederbücherBindingNavigator
            // 
            this.liederbücherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.liederbücherBindingNavigator.BindingSource = this.liederbücherBindingSource;
            this.liederbücherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.liederbücherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.liederbücherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.liederbücherBindingNavigatorSaveItem});
            this.liederbücherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.liederbücherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.liederbücherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.liederbücherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.liederbücherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.liederbücherBindingNavigator.Name = "liederbücherBindingNavigator";
            this.liederbücherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.liederbücherBindingNavigator.Size = new System.Drawing.Size(552, 25);
            this.liederbücherBindingNavigator.TabIndex = 0;
            this.liederbücherBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 15);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // liederbücherBindingNavigatorSaveItem
            // 
            this.liederbücherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.liederbücherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("liederbücherBindingNavigatorSaveItem.Image")));
            this.liederbücherBindingNavigatorSaveItem.Name = "liederbücherBindingNavigatorSaveItem";
            this.liederbücherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.liederbücherBindingNavigatorSaveItem.Text = "Daten speichern";
            this.liederbücherBindingNavigatorSaveItem.Click += new System.EventHandler(this.liederbücherBindingNavigatorSaveItem_Click_1);
            // 
            // liederbücherDataGridView
            // 
            this.liederbücherDataGridView.AutoGenerateColumns = false;
            this.liederbücherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liederbücherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.liederbücherDataGridView.DataSource = this.liederbücherBindingSource;
            this.liederbücherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liederbücherDataGridView.Location = new System.Drawing.Point(0, 25);
            this.liederbücherDataGridView.Name = "liederbücherDataGridView";
            this.liederbücherDataGridView.Size = new System.Drawing.Size(552, 273);
            this.liederbücherDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Verlag";
            this.dataGridViewTextBoxColumn6.HeaderText = "Verlag";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AnzahlLieder";
            this.dataGridViewTextBoxColumn7.HeaderText = "AnzahlLieder";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // DBLiederbücherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 298);
            this.Controls.Add(this.liederbücherDataGridView);
            this.Controls.Add(this.liederbücherBindingNavigator);
            this.Name = "DBLiederbücherForm";
            this.Text = "Liederbücher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBLiederbücherForm_FormClosing);
            this.Load += new System.EventHandler(this.DB_Liederbücher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_LiederAnzeigeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherBindingNavigator)).EndInit();
            this.liederbücherBindingNavigator.ResumeLayout(false);
            this.liederbücherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liederbücherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DB_LiederAnzeigeDataSet dB_LiederAnzeigeDataSet;
        private System.Windows.Forms.BindingSource liederbücherBindingSource;
        private DB_LiederAnzeigeDataSetTableAdapters.LiederbücherTableAdapter liederbücherTableAdapter;
        private DB_LiederAnzeigeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator liederbücherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton liederbücherBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView liederbücherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}