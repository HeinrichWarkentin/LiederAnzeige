namespace LiederAnzeige
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_show_bildschirme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Bildschirme = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RTB_initialText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_vorschau = new System.Windows.Forms.Button();
            this.BT_hintergrundfrabeändern = new System.Windows.Forms.Button();
            this.BT_schriftfarbeändern = new System.Windows.Forms.Button();
            this.LA_hintergrundfarbe = new System.Windows.Forms.Label();
            this.LA_schriftfarbe = new System.Windows.Forms.Label();
            this.BT_Fontändern = new System.Windows.Forms.Button();
            this.LA_font = new System.Windows.Forms.Label();
            this.LB_info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_show_bildschirme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_Bildschirme);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leinwand";
            // 
            // BT_show_bildschirme
            // 
            this.BT_show_bildschirme.Location = new System.Drawing.Point(6, 51);
            this.BT_show_bildschirme.Name = "BT_show_bildschirme";
            this.BT_show_bildschirme.Size = new System.Drawing.Size(293, 23);
            this.BT_show_bildschirme.TabIndex = 2;
            this.BT_show_bildschirme.Text = "Bildschrimnummern einblenden";
            this.BT_show_bildschirme.UseVisualStyleBackColor = true;
            this.BT_show_bildschirme.Click += new System.EventHandler(this.BT_show_bildschirme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bildschrim für die Präsentation";
            // 
            // CB_Bildschirme
            // 
            this.CB_Bildschirme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Bildschirme.FormattingEnabled = true;
            this.CB_Bildschirme.Items.AddRange(new object[] {
            "1: 1920 x 1080"});
            this.CB_Bildschirme.Location = new System.Drawing.Point(165, 24);
            this.CB_Bildschirme.Name = "CB_Bildschirme";
            this.CB_Bildschirme.Size = new System.Drawing.Size(134, 21);
            this.CB_Bildschirme.TabIndex = 0;
            this.CB_Bildschirme.DropDown += new System.EventHandler(this.CB_Bildschirme_DropDown);
            this.CB_Bildschirme.SelectedIndexChanged += new System.EventHandler(this.CB_Bildschirme_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTB_initialText);
            this.groupBox2.Location = new System.Drawing.Point(13, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Text";
            // 
            // RTB_initialText
            // 
            this.RTB_initialText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_initialText.Location = new System.Drawing.Point(6, 20);
            this.RTB_initialText.Name = "RTB_initialText";
            this.RTB_initialText.Size = new System.Drawing.Size(296, 79);
            this.RTB_initialText.TabIndex = 0;
            this.RTB_initialText.Text = "Lobet den HERRN";
            this.RTB_initialText.TextChanged += new System.EventHandler(this.RTB_initialText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_vorschau);
            this.groupBox3.Controls.Add(this.BT_hintergrundfrabeändern);
            this.groupBox3.Controls.Add(this.BT_schriftfarbeändern);
            this.groupBox3.Controls.Add(this.LA_hintergrundfarbe);
            this.groupBox3.Controls.Add(this.LA_schriftfarbe);
            this.groupBox3.Controls.Add(this.BT_Fontändern);
            this.groupBox3.Controls.Add(this.LA_font);
            this.groupBox3.Location = new System.Drawing.Point(13, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schrift und Farbe";
            // 
            // BT_vorschau
            // 
            this.BT_vorschau.Location = new System.Drawing.Point(10, 102);
            this.BT_vorschau.Name = "BT_vorschau";
            this.BT_vorschau.Size = new System.Drawing.Size(292, 23);
            this.BT_vorschau.TabIndex = 6;
            this.BT_vorschau.Text = "Vorschau";
            this.BT_vorschau.UseVisualStyleBackColor = true;
            this.BT_vorschau.Click += new System.EventHandler(this.BT_vorschau_Click);
            // 
            // BT_hintergrundfrabeändern
            // 
            this.BT_hintergrundfrabeändern.Location = new System.Drawing.Point(227, 73);
            this.BT_hintergrundfrabeändern.Name = "BT_hintergrundfrabeändern";
            this.BT_hintergrundfrabeändern.Size = new System.Drawing.Size(75, 23);
            this.BT_hintergrundfrabeändern.TabIndex = 5;
            this.BT_hintergrundfrabeändern.Text = "ändern";
            this.BT_hintergrundfrabeändern.UseVisualStyleBackColor = true;
            this.BT_hintergrundfrabeändern.Click += new System.EventHandler(this.BT_hintergrundfrabeändern_Click);
            // 
            // BT_schriftfarbeändern
            // 
            this.BT_schriftfarbeändern.Location = new System.Drawing.Point(227, 44);
            this.BT_schriftfarbeändern.Name = "BT_schriftfarbeändern";
            this.BT_schriftfarbeändern.Size = new System.Drawing.Size(75, 23);
            this.BT_schriftfarbeändern.TabIndex = 4;
            this.BT_schriftfarbeändern.Text = "ändern";
            this.BT_schriftfarbeändern.UseVisualStyleBackColor = true;
            this.BT_schriftfarbeändern.Click += new System.EventHandler(this.BT_schriftfarbeändern_Click);
            // 
            // LA_hintergrundfarbe
            // 
            this.LA_hintergrundfarbe.AutoSize = true;
            this.LA_hintergrundfarbe.Location = new System.Drawing.Point(7, 78);
            this.LA_hintergrundfarbe.Name = "LA_hintergrundfarbe";
            this.LA_hintergrundfarbe.Size = new System.Drawing.Size(89, 13);
            this.LA_hintergrundfarbe.TabIndex = 3;
            this.LA_hintergrundfarbe.Text = "Hintergrundfarbe:";
            // 
            // LA_schriftfarbe
            // 
            this.LA_schriftfarbe.AutoSize = true;
            this.LA_schriftfarbe.Location = new System.Drawing.Point(7, 49);
            this.LA_schriftfarbe.Name = "LA_schriftfarbe";
            this.LA_schriftfarbe.Size = new System.Drawing.Size(64, 13);
            this.LA_schriftfarbe.TabIndex = 2;
            this.LA_schriftfarbe.Text = "Schriftfarbe:";
            // 
            // BT_Fontändern
            // 
            this.BT_Fontändern.Location = new System.Drawing.Point(227, 15);
            this.BT_Fontändern.Name = "BT_Fontändern";
            this.BT_Fontändern.Size = new System.Drawing.Size(75, 23);
            this.BT_Fontändern.TabIndex = 1;
            this.BT_Fontändern.Text = "ändern";
            this.BT_Fontändern.UseVisualStyleBackColor = true;
            this.BT_Fontändern.Click += new System.EventHandler(this.BT_Fontändern_Click);
            // 
            // LA_font
            // 
            this.LA_font.AutoSize = true;
            this.LA_font.Location = new System.Drawing.Point(7, 20);
            this.LA_font.Name = "LA_font";
            this.LA_font.Size = new System.Drawing.Size(164, 13);
            this.LA_font.TabIndex = 0;
            this.LA_font.Text = "Font: Microsoft Sans Serif; 8,25pt";
            // 
            // LB_info
            // 
            this.LB_info.AutoSize = true;
            this.LB_info.Location = new System.Drawing.Point(16, 342);
            this.LB_info.Name = "LB_info";
            this.LB_info.Size = new System.Drawing.Size(227, 39);
            this.LB_info.TabIndex = 3;
            this.LB_info.Text = "Info:\r\nÄnderungen werden erst nach einem Neustart \r\nder LiederAnzeige wirksam.";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 391);
            this.Controls.Add(this.LB_info);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(350, 430);
            this.MinimumSize = new System.Drawing.Size(350, 430);
            this.Name = "settingsForm";
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_show_bildschirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Bildschirme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RTB_initialText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BT_Fontändern;
        private System.Windows.Forms.Label LA_font;
        private System.Windows.Forms.Button BT_vorschau;
        private System.Windows.Forms.Button BT_hintergrundfrabeändern;
        private System.Windows.Forms.Button BT_schriftfarbeändern;
        private System.Windows.Forms.Label LA_hintergrundfarbe;
        private System.Windows.Forms.Label LA_schriftfarbe;
        private System.Windows.Forms.Label LB_info;
    }
}