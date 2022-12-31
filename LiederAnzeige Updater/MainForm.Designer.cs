
namespace LiederAnzeige_Updater
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sucheUpdates = new System.Windows.Forms.Button();
            this.pB_ichArbeite = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.la_installierteVersion = new System.Windows.Forms.Label();
            this.la_aktuellsteVersion = new System.Windows.Forms.Label();
            this.bt_installiereUpdates = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "LiederAnzeige Updater";
            // 
            // bt_sucheUpdates
            // 
            this.bt_sucheUpdates.Location = new System.Drawing.Point(181, 192);
            this.bt_sucheUpdates.Name = "bt_sucheUpdates";
            this.bt_sucheUpdates.Size = new System.Drawing.Size(157, 33);
            this.bt_sucheUpdates.TabIndex = 1;
            this.bt_sucheUpdates.Text = "Nach Updates suchen";
            this.bt_sucheUpdates.UseVisualStyleBackColor = true;
            this.bt_sucheUpdates.Click += new System.EventHandler(this.bt_action_Click);
            // 
            // pB_ichArbeite
            // 
            this.pB_ichArbeite.Location = new System.Drawing.Point(15, 160);
            this.pB_ichArbeite.Name = "pB_ichArbeite";
            this.pB_ichArbeite.Size = new System.Drawing.Size(501, 21);
            this.pB_ichArbeite.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pB_ichArbeite.TabIndex = 2;
            this.pB_ichArbeite.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Installierte Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuellste Version:";
            // 
            // la_installierteVersion
            // 
            this.la_installierteVersion.AutoSize = true;
            this.la_installierteVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_installierteVersion.Location = new System.Drawing.Point(177, 80);
            this.la_installierteVersion.Name = "la_installierteVersion";
            this.la_installierteVersion.Size = new System.Drawing.Size(44, 20);
            this.la_installierteVersion.TabIndex = 5;
            this.la_installierteVersion.Text = "0.0.1";
            // 
            // la_aktuellsteVersion
            // 
            this.la_aktuellsteVersion.AutoSize = true;
            this.la_aktuellsteVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_aktuellsteVersion.Location = new System.Drawing.Point(177, 122);
            this.la_aktuellsteVersion.Name = "la_aktuellsteVersion";
            this.la_aktuellsteVersion.Size = new System.Drawing.Size(44, 20);
            this.la_aktuellsteVersion.TabIndex = 6;
            this.la_aktuellsteVersion.Text = "0.0.1";
            // 
            // bt_installiereUpdates
            // 
            this.bt_installiereUpdates.Location = new System.Drawing.Point(359, 192);
            this.bt_installiereUpdates.Name = "bt_installiereUpdates";
            this.bt_installiereUpdates.Size = new System.Drawing.Size(157, 33);
            this.bt_installiereUpdates.TabIndex = 7;
            this.bt_installiereUpdates.Text = "Aktuellste Version installieren";
            this.bt_installiereUpdates.UseVisualStyleBackColor = true;
            this.bt_installiereUpdates.Visible = false;
            this.bt_installiereUpdates.Click += new System.EventHandler(this.bt_installiereUpdates_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.Location = new System.Drawing.Point(12, 160);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(31, 17);
            this.lb_info.TabIndex = 8;
            this.lb_info.Text = "Info";
            this.lb_info.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 237);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_installiereUpdates);
            this.Controls.Add(this.la_aktuellsteVersion);
            this.Controls.Add(this.la_installierteVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pB_ichArbeite);
            this.Controls.Add(this.bt_sucheUpdates);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "LiederAnzeige Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sucheUpdates;
        private System.Windows.Forms.ProgressBar pB_ichArbeite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label la_installierteVersion;
        private System.Windows.Forms.Label la_aktuellsteVersion;
        private System.Windows.Forms.Button bt_installiereUpdates;
        private System.Windows.Forms.Label lb_info;
    }
}

