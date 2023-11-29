namespace LiederAnzeige
{
    partial class settingsForm
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
            this.bt_show_bildschirme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Bildschirme = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_initialText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_vorschau = new System.Windows.Forms.Button();
            this.bt_hintergrundfrabeändern = new System.Windows.Forms.Button();
            this.bt_schriftfarbeändern = new System.Windows.Forms.Button();
            this.la_hintergrundfarbe = new System.Windows.Forms.Label();
            this.la_schriftfarbe = new System.Windows.Forms.Label();
            this.bt_Fontändern = new System.Windows.Forms.Button();
            this.la_font = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_show_bildschirme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Bildschirme);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leinwand";
            // 
            // bt_show_bildschirme
            // 
            this.bt_show_bildschirme.Location = new System.Drawing.Point(6, 51);
            this.bt_show_bildschirme.Name = "bt_show_bildschirme";
            this.bt_show_bildschirme.Size = new System.Drawing.Size(293, 23);
            this.bt_show_bildschirme.TabIndex = 2;
            this.bt_show_bildschirme.Text = "Bildschrimnummern einblenden";
            this.bt_show_bildschirme.UseVisualStyleBackColor = true;
            this.bt_show_bildschirme.Click += new System.EventHandler(this.bt_show_bildschirme_Click);
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
            // cb_Bildschirme
            // 
            this.cb_Bildschirme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Bildschirme.FormattingEnabled = true;
            this.cb_Bildschirme.Items.AddRange(new object[] {
            "1: 1920 x 1080"});
            this.cb_Bildschirme.Location = new System.Drawing.Point(165, 24);
            this.cb_Bildschirme.Name = "cb_Bildschirme";
            this.cb_Bildschirme.Size = new System.Drawing.Size(134, 21);
            this.cb_Bildschirme.TabIndex = 0;
            this.cb_Bildschirme.DropDown += new System.EventHandler(this.cb_Bildschirme_DropDown);
            this.cb_Bildschirme.SelectedIndexChanged += new System.EventHandler(this.cb_Bildschirme_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtb_initialText);
            this.groupBox2.Location = new System.Drawing.Point(13, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Text";
            // 
            // rtb_initialText
            // 
            this.rtb_initialText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_initialText.Location = new System.Drawing.Point(6, 20);
            this.rtb_initialText.Name = "rtb_initialText";
            this.rtb_initialText.Size = new System.Drawing.Size(296, 79);
            this.rtb_initialText.TabIndex = 0;
            this.rtb_initialText.Text = "Lobet den HERRN";
            this.rtb_initialText.TextChanged += new System.EventHandler(this.rtb_initialText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_vorschau);
            this.groupBox3.Controls.Add(this.bt_hintergrundfrabeändern);
            this.groupBox3.Controls.Add(this.bt_schriftfarbeändern);
            this.groupBox3.Controls.Add(this.la_hintergrundfarbe);
            this.groupBox3.Controls.Add(this.la_schriftfarbe);
            this.groupBox3.Controls.Add(this.bt_Fontändern);
            this.groupBox3.Controls.Add(this.la_font);
            this.groupBox3.Location = new System.Drawing.Point(13, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schrift und Farbe";
            // 
            // bt_vorschau
            // 
            this.bt_vorschau.Location = new System.Drawing.Point(10, 102);
            this.bt_vorschau.Name = "bt_vorschau";
            this.bt_vorschau.Size = new System.Drawing.Size(292, 23);
            this.bt_vorschau.TabIndex = 6;
            this.bt_vorschau.Text = "Vorschau";
            this.bt_vorschau.UseVisualStyleBackColor = true;
            this.bt_vorschau.Click += new System.EventHandler(this.bt_vorschau_Click);
            // 
            // bt_hintergrundfrabeändern
            // 
            this.bt_hintergrundfrabeändern.Location = new System.Drawing.Point(227, 73);
            this.bt_hintergrundfrabeändern.Name = "bt_hintergrundfrabeändern";
            this.bt_hintergrundfrabeändern.Size = new System.Drawing.Size(75, 23);
            this.bt_hintergrundfrabeändern.TabIndex = 5;
            this.bt_hintergrundfrabeändern.Text = "ändern";
            this.bt_hintergrundfrabeändern.UseVisualStyleBackColor = true;
            this.bt_hintergrundfrabeändern.Click += new System.EventHandler(this.bt_hintergrundfrabeändern_Click);
            // 
            // bt_schriftfarbeändern
            // 
            this.bt_schriftfarbeändern.Location = new System.Drawing.Point(227, 44);
            this.bt_schriftfarbeändern.Name = "bt_schriftfarbeändern";
            this.bt_schriftfarbeändern.Size = new System.Drawing.Size(75, 23);
            this.bt_schriftfarbeändern.TabIndex = 4;
            this.bt_schriftfarbeändern.Text = "ändern";
            this.bt_schriftfarbeändern.UseVisualStyleBackColor = true;
            this.bt_schriftfarbeändern.Click += new System.EventHandler(this.bt_schriftfarbeändern_Click);
            // 
            // la_hintergrundfarbe
            // 
            this.la_hintergrundfarbe.AutoSize = true;
            this.la_hintergrundfarbe.Location = new System.Drawing.Point(7, 78);
            this.la_hintergrundfarbe.Name = "la_hintergrundfarbe";
            this.la_hintergrundfarbe.Size = new System.Drawing.Size(89, 13);
            this.la_hintergrundfarbe.TabIndex = 3;
            this.la_hintergrundfarbe.Text = "Hintergrundfarbe:";
            // 
            // la_schriftfarbe
            // 
            this.la_schriftfarbe.AutoSize = true;
            this.la_schriftfarbe.Location = new System.Drawing.Point(7, 49);
            this.la_schriftfarbe.Name = "la_schriftfarbe";
            this.la_schriftfarbe.Size = new System.Drawing.Size(64, 13);
            this.la_schriftfarbe.TabIndex = 2;
            this.la_schriftfarbe.Text = "Schriftfarbe:";
            // 
            // bt_Fontändern
            // 
            this.bt_Fontändern.Location = new System.Drawing.Point(227, 15);
            this.bt_Fontändern.Name = "bt_Fontändern";
            this.bt_Fontändern.Size = new System.Drawing.Size(75, 23);
            this.bt_Fontändern.TabIndex = 1;
            this.bt_Fontändern.Text = "ändern";
            this.bt_Fontändern.UseVisualStyleBackColor = true;
            this.bt_Fontändern.Click += new System.EventHandler(this.bt_Fontändern_Click);
            // 
            // la_font
            // 
            this.la_font.AutoSize = true;
            this.la_font.Location = new System.Drawing.Point(7, 20);
            this.la_font.Name = "la_font";
            this.la_font.Size = new System.Drawing.Size(164, 13);
            this.la_font.TabIndex = 0;
            this.la_font.Text = "Font: Microsoft Sans Serif; 8,25pt";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(350, 393);
            this.MinimumSize = new System.Drawing.Size(350, 393);
            this.Name = "settingsForm";
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_show_bildschirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Bildschirme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_initialText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Fontändern;
        private System.Windows.Forms.Label la_font;
        private System.Windows.Forms.Button bt_vorschau;
        private System.Windows.Forms.Button bt_hintergrundfrabeändern;
        private System.Windows.Forms.Button bt_schriftfarbeändern;
        private System.Windows.Forms.Label la_hintergrundfarbe;
        private System.Windows.Forms.Label la_schriftfarbe;
    }
}