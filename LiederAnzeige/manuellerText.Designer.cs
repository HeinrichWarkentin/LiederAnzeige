namespace LiederAnzeige
{
    partial class manuellerText
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
            this.tb_ueberschrift = new System.Windows.Forms.TextBox();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_anzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ueberschrift
            // 
            this.tb_ueberschrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ueberschrift.Location = new System.Drawing.Point(77, 9);
            this.tb_ueberschrift.Name = "tb_ueberschrift";
            this.tb_ueberschrift.Size = new System.Drawing.Size(630, 20);
            this.tb_ueberschrift.TabIndex = 0;
            // 
            // rtb_text
            // 
            this.rtb_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_text.Location = new System.Drawing.Point(13, 51);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(775, 387);
            this.rtb_text.TabIndex = 1;
            this.rtb_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Überschrift:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // bt_anzeigen
            // 
            this.bt_anzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_anzeigen.Location = new System.Drawing.Point(713, 7);
            this.bt_anzeigen.Name = "bt_anzeigen";
            this.bt_anzeigen.Size = new System.Drawing.Size(75, 23);
            this.bt_anzeigen.TabIndex = 4;
            this.bt_anzeigen.Text = "Anzeigen";
            this.bt_anzeigen.UseVisualStyleBackColor = true;
            this.bt_anzeigen.Click += new System.EventHandler(this.bt_anzeigen_Click);
            // 
            // manuellerText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_anzeigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.tb_ueberschrift);
            this.Name = "manuellerText";
            this.Text = "Manuelle Texteingabe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manuellerText_FormClosing);
            this.Load += new System.EventHandler(this.manuellerText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ueberschrift;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_anzeigen;
    }
}