namespace LiederAnzeige
{
    partial class bilderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bilderhinzufügen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_bilder = new System.Windows.Forms.ListBox();
            this.pb_vorschau = new System.Windows.Forms.PictureBox();
            this.bt_bildanzeigen = new System.Windows.Forms.Button();
            this.bt_bildlöschen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_anzeigeArt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vorschau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilder hinzufügen";
            // 
            // bt_bilderhinzufügen
            // 
            this.bt_bilderhinzufügen.Location = new System.Drawing.Point(106, 4);
            this.bt_bilderhinzufügen.Name = "bt_bilderhinzufügen";
            this.bt_bilderhinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bt_bilderhinzufügen.TabIndex = 1;
            this.bt_bilderhinzufügen.Text = "hinzufügen";
            this.bt_bilderhinzufügen.UseVisualStyleBackColor = true;
            this.bt_bilderhinzufügen.Click += new System.EventHandler(this.bt_bilderhinzufügen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lb_bilder
            // 
            this.lb_bilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bilder.FormattingEnabled = true;
            this.lb_bilder.ItemHeight = 20;
            this.lb_bilder.Location = new System.Drawing.Point(15, 64);
            this.lb_bilder.Name = "lb_bilder";
            this.lb_bilder.Size = new System.Drawing.Size(166, 264);
            this.lb_bilder.TabIndex = 2;
            // 
            // pb_vorschau
            // 
            this.pb_vorschau.Location = new System.Drawing.Point(187, 4);
            this.pb_vorschau.Name = "pb_vorschau";
            this.pb_vorschau.Size = new System.Drawing.Size(383, 295);
            this.pb_vorschau.TabIndex = 3;
            this.pb_vorschau.TabStop = false;
            // 
            // bt_bildanzeigen
            // 
            this.bt_bildanzeigen.Location = new System.Drawing.Point(495, 305);
            this.bt_bildanzeigen.Name = "bt_bildanzeigen";
            this.bt_bildanzeigen.Size = new System.Drawing.Size(75, 23);
            this.bt_bildanzeigen.TabIndex = 4;
            this.bt_bildanzeigen.Text = "anzeigen";
            this.bt_bildanzeigen.UseVisualStyleBackColor = true;
            this.bt_bildanzeigen.Click += new System.EventHandler(this.bt_bildanzeigen_Click);
            // 
            // bt_bildlöschen
            // 
            this.bt_bildlöschen.Location = new System.Drawing.Point(187, 305);
            this.bt_bildlöschen.Name = "bt_bildlöschen";
            this.bt_bildlöschen.Size = new System.Drawing.Size(75, 23);
            this.bt_bildlöschen.TabIndex = 5;
            this.bt_bildlöschen.Text = "löschen";
            this.bt_bildlöschen.UseVisualStyleBackColor = true;
            this.bt_bildlöschen.Click += new System.EventHandler(this.bt_bildlöschen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bilder:";
            // 
            // cb_anzeigeArt
            // 
            this.cb_anzeigeArt.FormattingEnabled = true;
            this.cb_anzeigeArt.Location = new System.Drawing.Point(340, 307);
            this.cb_anzeigeArt.Name = "cb_anzeigeArt";
            this.cb_anzeigeArt.Size = new System.Drawing.Size(149, 21);
            this.cb_anzeigeArt.TabIndex = 7;
            this.cb_anzeigeArt.SelectedIndexChanged += new System.EventHandler(this.cb_anzeigeArt_SelectedIndexChanged);
            // 
            // bilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.cb_anzeigeArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_bildlöschen);
            this.Controls.Add(this.bt_bildanzeigen);
            this.Controls.Add(this.pb_vorschau);
            this.Controls.Add(this.lb_bilder);
            this.Controls.Add(this.bt_bilderhinzufügen);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "bilderForm";
            this.Text = "Bilder anzeigen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_vorschau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bilderhinzufügen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lb_bilder;
        private System.Windows.Forms.PictureBox pb_vorschau;
        private System.Windows.Forms.Button bt_bildanzeigen;
        private System.Windows.Forms.Button bt_bildlöschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_anzeigeArt;
    }
}