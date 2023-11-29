namespace LiederAnzeige
{
    partial class simpleEditor
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
            this.RTB_textfield = new System.Windows.Forms.RichTextBox();
            this.BT_save = new System.Windows.Forms.Button();
            this.BT_abort = new System.Windows.Forms.Button();
            this.BT_akLied_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_textfield
            // 
            this.RTB_textfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_textfield.Location = new System.Drawing.Point(12, 41);
            this.RTB_textfield.Name = "RTB_textfield";
            this.RTB_textfield.Size = new System.Drawing.Size(536, 503);
            this.RTB_textfield.TabIndex = 0;
            this.RTB_textfield.Text = "";
            this.RTB_textfield.TextChanged += new System.EventHandler(this.RTB_textfield_TextChanged);
            // 
            // BT_save
            // 
            this.BT_save.Location = new System.Drawing.Point(392, 12);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(75, 23);
            this.BT_save.TabIndex = 1;
            this.BT_save.Text = "Speichern";
            this.BT_save.UseVisualStyleBackColor = true;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // BT_abort
            // 
            this.BT_abort.Location = new System.Drawing.Point(473, 12);
            this.BT_abort.Name = "BT_abort";
            this.BT_abort.Size = new System.Drawing.Size(75, 23);
            this.BT_abort.TabIndex = 2;
            this.BT_abort.Text = "Abbrechen";
            this.BT_abort.UseVisualStyleBackColor = true;
            this.BT_abort.Click += new System.EventHandler(this.BT_abort_Click);
            // 
            // BT_akLied_edit
            // 
            this.BT_akLied_edit.Location = new System.Drawing.Point(12, 12);
            this.BT_akLied_edit.Name = "BT_akLied_edit";
            this.BT_akLied_edit.Size = new System.Drawing.Size(118, 23);
            this.BT_akLied_edit.TabIndex = 3;
            this.BT_akLied_edit.Text = "Aktuelles Lied laden";
            this.BT_akLied_edit.UseVisualStyleBackColor = true;
            // 
            // simpleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 556);
            this.Controls.Add(this.BT_akLied_edit);
            this.Controls.Add(this.BT_abort);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.RTB_textfield);
            this.Name = "simpleEditor";
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_textfield;
        private System.Windows.Forms.Button BT_save;
        private System.Windows.Forms.Button BT_abort;
        private System.Windows.Forms.Button BT_akLied_edit;
    }
}