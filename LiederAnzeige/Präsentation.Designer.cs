namespace LiederAnzeige
{
    partial class Präsentation
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
            this.la_titel = new System.Windows.Forms.Label();
            this.la_text = new System.Windows.Forms.Label();
            this.la_akVers = new System.Windows.Forms.Label();
            this.pbHintergrund = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHintergrund)).BeginInit();
            this.pbHintergrund.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_titel
            // 
            this.la_titel.BackColor = System.Drawing.Color.Transparent;
            this.la_titel.Dock = System.Windows.Forms.DockStyle.Top;
            this.la_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_titel.ForeColor = System.Drawing.Color.White;
            this.la_titel.Location = new System.Drawing.Point(0, 0);
            this.la_titel.Name = "la_titel";
            this.la_titel.Size = new System.Drawing.Size(1000, 100);
            this.la_titel.TabIndex = 0;
            this.la_titel.Text = "Titel";
            this.la_titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_text
            // 
            this.la_text.BackColor = System.Drawing.Color.Transparent;
            this.la_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.la_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_text.ForeColor = System.Drawing.Color.White;
            this.la_text.Location = new System.Drawing.Point(0, 100);
            this.la_text.Name = "la_text";
            this.la_text.Size = new System.Drawing.Size(1000, 500);
            this.la_text.TabIndex = 1;
            this.la_text.Text = "Vers";
            this.la_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // la_akVers
            // 
            this.la_akVers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.la_akVers.AutoSize = true;
            this.la_akVers.BackColor = System.Drawing.Color.Transparent;
            this.la_akVers.ForeColor = System.Drawing.Color.Transparent;
            this.la_akVers.Location = new System.Drawing.Point(890, 578);
            this.la_akVers.Name = "la_akVers";
            this.la_akVers.Size = new System.Drawing.Size(98, 13);
            this.la_akVers.TabIndex = 2;
            this.la_akVers.Text = "1 / 2 / 3 / 4 / 5 / 6";
            this.la_akVers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbHintergrund
            // 
            this.pbHintergrund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHintergrund.BackColor = System.Drawing.Color.Transparent;
            this.pbHintergrund.Controls.Add(this.la_text);
            this.pbHintergrund.Controls.Add(this.la_titel);
            this.pbHintergrund.ErrorImage = null;
            this.pbHintergrund.InitialImage = null;
            this.pbHintergrund.Location = new System.Drawing.Point(0, 0);
            this.pbHintergrund.Name = "pbHintergrund";
            this.pbHintergrund.Size = new System.Drawing.Size(1000, 600);
            this.pbHintergrund.TabIndex = 3;
            this.pbHintergrund.TabStop = false;
            // 
            // Präsentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.la_akVers);
            this.Controls.Add(this.pbHintergrund);
            this.Name = "Präsentation";
            this.Text = "Präsentation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Präsentation_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Präsentation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbHintergrund)).EndInit();
            this.pbHintergrund.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_titel;
        private System.Windows.Forms.Label la_text;
        private System.Windows.Forms.Label la_akVers;
        private System.Windows.Forms.PictureBox pbHintergrund;
    }
}