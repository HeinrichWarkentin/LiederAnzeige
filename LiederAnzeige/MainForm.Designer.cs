
namespace LiederAnzeige
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.präsentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.präsentationStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.präsentationStoppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurBildLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurTextLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_suchergebnis = new System.Windows.Forms.ListBox();
            this.tb_suchefeld = new System.Windows.Forms.TextBox();
            this.cb_Liederbuecher = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_schriftgroesse_speichern = new System.Windows.Forms.Button();
            this.bt_text_kleiner = new System.Windows.Forms.Button();
            this.bt_text_groesser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.la_liederbuch = new System.Windows.Forms.Label();
            this.la_titel = new System.Windows.Forms.Label();
            this.la_titelnummer = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_folien_anzeigen = new System.Windows.Forms.Button();
            this.bt_naechsteFolie = new System.Windows.Forms.Button();
            this.lb_Folien = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_Folienseite_zurück = new System.Windows.Forms.Button();
            this.bt_Folienseite_vor = new System.Windows.Forms.Button();
            this.bt_folie_1 = new System.Windows.Forms.Button();
            this.bt_folie_2 = new System.Windows.Forms.Button();
            this.bt_folie_3 = new System.Windows.Forms.Button();
            this.bt_folie_4 = new System.Windows.Forms.Button();
            this.bt_folie_5 = new System.Windows.Forms.Button();
            this.bt_folie_6 = new System.Windows.Forms.Button();
            this.bt_folie_7 = new System.Windows.Forms.Button();
            this.bt_folie_8 = new System.Windows.Forms.Button();
            this.bt_folie_9 = new System.Windows.Forms.Button();
            this.la_folienseiten = new System.Windows.Forms.Label();
            this.gB_Folien = new System.Windows.Forms.GroupBox();
            this.manuellerTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gB_Folien.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.präsentationToolStripMenuItem,
            this.liveToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // präsentationToolStripMenuItem
            // 
            this.präsentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.präsentationStartenToolStripMenuItem,
            this.präsentationStoppenToolStripMenuItem,
            this.leerenToolStripMenuItem,
            this.nurBildLeerenToolStripMenuItem,
            this.nurTextLeerenToolStripMenuItem});
            this.präsentationToolStripMenuItem.Name = "präsentationToolStripMenuItem";
            this.präsentationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.präsentationToolStripMenuItem.Text = "Präsentation";
            // 
            // präsentationStartenToolStripMenuItem
            // 
            this.präsentationStartenToolStripMenuItem.Name = "präsentationStartenToolStripMenuItem";
            this.präsentationStartenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.präsentationStartenToolStripMenuItem.Text = "Start";
            this.präsentationStartenToolStripMenuItem.Click += new System.EventHandler(this.präsentationStartenToolStripMenuItem_Click);
            // 
            // präsentationStoppenToolStripMenuItem
            // 
            this.präsentationStoppenToolStripMenuItem.Name = "präsentationStoppenToolStripMenuItem";
            this.präsentationStoppenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.präsentationStoppenToolStripMenuItem.Text = "Stop";
            this.präsentationStoppenToolStripMenuItem.Click += new System.EventHandler(this.präsentationStoppenToolStripMenuItem_Click);
            // 
            // leerenToolStripMenuItem
            // 
            this.leerenToolStripMenuItem.Name = "leerenToolStripMenuItem";
            this.leerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leerenToolStripMenuItem.Text = "Alles Leeren";
            this.leerenToolStripMenuItem.Click += new System.EventHandler(this.leerenToolStripMenuItem_Click);
            // 
            // nurBildLeerenToolStripMenuItem
            // 
            this.nurBildLeerenToolStripMenuItem.Name = "nurBildLeerenToolStripMenuItem";
            this.nurBildLeerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nurBildLeerenToolStripMenuItem.Text = "Nur Bild Leeren";
            this.nurBildLeerenToolStripMenuItem.Click += new System.EventHandler(this.nurBildLeerenToolStripMenuItem_Click);
            // 
            // nurTextLeerenToolStripMenuItem
            // 
            this.nurTextLeerenToolStripMenuItem.Name = "nurTextLeerenToolStripMenuItem";
            this.nurTextLeerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nurTextLeerenToolStripMenuItem.Text = "Nur Text Leeren";
            this.nurTextLeerenToolStripMenuItem.Click += new System.EventHandler(this.nurTextLeerenToolStripMenuItem_Click);
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuellerTextToolStripMenuItem,
            this.bilderToolStripMenuItem,
            this.videoToolStripMenuItem});
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.liveToolStripMenuItem.Text = "Live";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_suchergebnis);
            this.groupBox1.Controls.Add(this.tb_suchefeld);
            this.groupBox1.Controls.Add(this.cb_Liederbuecher);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suche";
            // 
            // lb_suchergebnis
            // 
            this.lb_suchergebnis.FormattingEnabled = true;
            this.lb_suchergebnis.Location = new System.Drawing.Point(7, 48);
            this.lb_suchergebnis.Name = "lb_suchergebnis";
            this.lb_suchergebnis.Size = new System.Drawing.Size(360, 95);
            this.lb_suchergebnis.TabIndex = 2;
            // 
            // tb_suchefeld
            // 
            this.tb_suchefeld.Location = new System.Drawing.Point(161, 20);
            this.tb_suchefeld.Name = "tb_suchefeld";
            this.tb_suchefeld.Size = new System.Drawing.Size(206, 20);
            this.tb_suchefeld.TabIndex = 1;
            // 
            // cb_Liederbuecher
            // 
            this.cb_Liederbuecher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Liederbuecher.Location = new System.Drawing.Point(7, 20);
            this.cb_Liederbuecher.Name = "cb_Liederbuecher";
            this.cb_Liederbuecher.Size = new System.Drawing.Size(148, 21);
            this.cb_Liederbuecher.Sorted = true;
            this.cb_Liederbuecher.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_schriftgroesse_speichern);
            this.groupBox2.Controls.Add(this.bt_text_kleiner);
            this.groupBox2.Controls.Add(this.bt_text_groesser);
            this.groupBox2.Location = new System.Drawing.Point(396, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schriftgröße";
            // 
            // bt_schriftgroesse_speichern
            // 
            this.bt_schriftgroesse_speichern.Location = new System.Drawing.Point(6, 66);
            this.bt_schriftgroesse_speichern.Name = "bt_schriftgroesse_speichern";
            this.bt_schriftgroesse_speichern.Size = new System.Drawing.Size(91, 40);
            this.bt_schriftgroesse_speichern.TabIndex = 2;
            this.bt_schriftgroesse_speichern.Text = "Schriftgröße speichern";
            this.bt_schriftgroesse_speichern.UseVisualStyleBackColor = true;
            // 
            // bt_text_kleiner
            // 
            this.bt_text_kleiner.Location = new System.Drawing.Point(104, 20);
            this.bt_text_kleiner.Name = "bt_text_kleiner";
            this.bt_text_kleiner.Size = new System.Drawing.Size(91, 40);
            this.bt_text_kleiner.TabIndex = 1;
            this.bt_text_kleiner.Text = "Text kleiner";
            this.bt_text_kleiner.UseVisualStyleBackColor = true;
            // 
            // bt_text_groesser
            // 
            this.bt_text_groesser.Location = new System.Drawing.Point(6, 20);
            this.bt_text_groesser.Name = "bt_text_groesser";
            this.bt_text_groesser.Size = new System.Drawing.Size(91, 40);
            this.bt_text_groesser.TabIndex = 0;
            this.bt_text_groesser.Text = "Text größer";
            this.bt_text_groesser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.la_liederbuch);
            this.groupBox3.Controls.Add(this.la_titel);
            this.groupBox3.Controls.Add(this.la_titelnummer);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daten";
            // 
            // la_liederbuch
            // 
            this.la_liederbuch.AutoSize = true;
            this.la_liederbuch.Location = new System.Drawing.Point(11, 70);
            this.la_liederbuch.Name = "la_liederbuch";
            this.la_liederbuch.Size = new System.Drawing.Size(63, 13);
            this.la_liederbuch.TabIndex = 2;
            this.la_liederbuch.Text = "Liederbuch:";
            // 
            // la_titel
            // 
            this.la_titel.AutoSize = true;
            this.la_titel.Location = new System.Drawing.Point(44, 45);
            this.la_titel.Name = "la_titel";
            this.la_titel.Size = new System.Drawing.Size(30, 13);
            this.la_titel.TabIndex = 1;
            this.la_titel.Text = "Titel:";
            // 
            // la_titelnummer
            // 
            this.la_titelnummer.AutoSize = true;
            this.la_titelnummer.Location = new System.Drawing.Point(7, 20);
            this.la_titelnummer.Name = "la_titelnummer";
            this.la_titelnummer.Size = new System.Drawing.Size(67, 13);
            this.la_titelnummer.TabIndex = 0;
            this.la_titelnummer.Text = "Titelnummer:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_folien_anzeigen);
            this.groupBox4.Controls.Add(this.bt_naechsteFolie);
            this.groupBox4.Controls.Add(this.lb_Folien);
            this.groupBox4.Location = new System.Drawing.Point(396, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Folienliste";
            // 
            // bt_folien_anzeigen
            // 
            this.bt_folien_anzeigen.Location = new System.Drawing.Point(6, 65);
            this.bt_folien_anzeigen.Name = "bt_folien_anzeigen";
            this.bt_folien_anzeigen.Size = new System.Drawing.Size(91, 40);
            this.bt_folien_anzeigen.TabIndex = 6;
            this.bt_folien_anzeigen.Text = "Folien anzeigen";
            this.bt_folien_anzeigen.UseVisualStyleBackColor = true;
            // 
            // bt_naechsteFolie
            // 
            this.bt_naechsteFolie.Location = new System.Drawing.Point(6, 19);
            this.bt_naechsteFolie.Name = "bt_naechsteFolie";
            this.bt_naechsteFolie.Size = new System.Drawing.Size(91, 40);
            this.bt_naechsteFolie.TabIndex = 6;
            this.bt_naechsteFolie.Text = "Nächste Folie";
            this.bt_naechsteFolie.UseVisualStyleBackColor = true;
            // 
            // lb_Folien
            // 
            this.lb_Folien.FormattingEnabled = true;
            this.lb_Folien.Location = new System.Drawing.Point(103, 19);
            this.lb_Folien.Name = "lb_Folien";
            this.lb_Folien.Size = new System.Drawing.Size(90, 108);
            this.lb_Folien.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_Folienseite_zurück
            // 
            this.bt_Folienseite_zurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Folienseite_zurück.Location = new System.Drawing.Point(346, 395);
            this.bt_Folienseite_zurück.Name = "bt_Folienseite_zurück";
            this.bt_Folienseite_zurück.Size = new System.Drawing.Size(75, 25);
            this.bt_Folienseite_zurück.TabIndex = 5;
            this.bt_Folienseite_zurück.Text = "zurück";
            this.bt_Folienseite_zurück.UseVisualStyleBackColor = true;
            // 
            // bt_Folienseite_vor
            // 
            this.bt_Folienseite_vor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Folienseite_vor.Location = new System.Drawing.Point(501, 395);
            this.bt_Folienseite_vor.Name = "bt_Folienseite_vor";
            this.bt_Folienseite_vor.Size = new System.Drawing.Size(75, 25);
            this.bt_Folienseite_vor.TabIndex = 6;
            this.bt_Folienseite_vor.Text = "vor";
            this.bt_Folienseite_vor.UseVisualStyleBackColor = true;
            // 
            // bt_folie_1
            // 
            this.bt_folie_1.BackColor = System.Drawing.Color.Black;
            this.bt_folie_1.ForeColor = System.Drawing.Color.White;
            this.bt_folie_1.Location = new System.Drawing.Point(10, 19);
            this.bt_folie_1.Name = "bt_folie_1";
            this.bt_folie_1.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_1.TabIndex = 7;
            this.bt_folie_1.Text = "Folie 1";
            this.bt_folie_1.UseVisualStyleBackColor = false;
            // 
            // bt_folie_2
            // 
            this.bt_folie_2.BackColor = System.Drawing.Color.Black;
            this.bt_folie_2.ForeColor = System.Drawing.Color.White;
            this.bt_folie_2.Location = new System.Drawing.Point(198, 19);
            this.bt_folie_2.Name = "bt_folie_2";
            this.bt_folie_2.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_2.TabIndex = 8;
            this.bt_folie_2.Text = "Folie 2";
            this.bt_folie_2.UseVisualStyleBackColor = false;
            // 
            // bt_folie_3
            // 
            this.bt_folie_3.BackColor = System.Drawing.Color.Black;
            this.bt_folie_3.ForeColor = System.Drawing.Color.White;
            this.bt_folie_3.Location = new System.Drawing.Point(390, 19);
            this.bt_folie_3.Name = "bt_folie_3";
            this.bt_folie_3.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_3.TabIndex = 9;
            this.bt_folie_3.Text = "Folie 3";
            this.bt_folie_3.UseVisualStyleBackColor = false;
            // 
            // bt_folie_4
            // 
            this.bt_folie_4.BackColor = System.Drawing.Color.Black;
            this.bt_folie_4.ForeColor = System.Drawing.Color.White;
            this.bt_folie_4.Location = new System.Drawing.Point(10, 125);
            this.bt_folie_4.Name = "bt_folie_4";
            this.bt_folie_4.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_4.TabIndex = 10;
            this.bt_folie_4.Text = "Folie 4";
            this.bt_folie_4.UseVisualStyleBackColor = false;
            // 
            // bt_folie_5
            // 
            this.bt_folie_5.BackColor = System.Drawing.Color.Black;
            this.bt_folie_5.ForeColor = System.Drawing.Color.White;
            this.bt_folie_5.Location = new System.Drawing.Point(198, 125);
            this.bt_folie_5.Name = "bt_folie_5";
            this.bt_folie_5.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_5.TabIndex = 11;
            this.bt_folie_5.Text = "Folie 5";
            this.bt_folie_5.UseVisualStyleBackColor = false;
            // 
            // bt_folie_6
            // 
            this.bt_folie_6.BackColor = System.Drawing.Color.Black;
            this.bt_folie_6.ForeColor = System.Drawing.Color.White;
            this.bt_folie_6.Location = new System.Drawing.Point(390, 125);
            this.bt_folie_6.Name = "bt_folie_6";
            this.bt_folie_6.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_6.TabIndex = 12;
            this.bt_folie_6.Text = "Folie 6";
            this.bt_folie_6.UseVisualStyleBackColor = false;
            // 
            // bt_folie_7
            // 
            this.bt_folie_7.BackColor = System.Drawing.Color.Black;
            this.bt_folie_7.ForeColor = System.Drawing.Color.White;
            this.bt_folie_7.Location = new System.Drawing.Point(7, 231);
            this.bt_folie_7.Name = "bt_folie_7";
            this.bt_folie_7.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_7.TabIndex = 13;
            this.bt_folie_7.Text = "Folie 7";
            this.bt_folie_7.UseVisualStyleBackColor = false;
            // 
            // bt_folie_8
            // 
            this.bt_folie_8.BackColor = System.Drawing.Color.Black;
            this.bt_folie_8.ForeColor = System.Drawing.Color.White;
            this.bt_folie_8.Location = new System.Drawing.Point(198, 231);
            this.bt_folie_8.Name = "bt_folie_8";
            this.bt_folie_8.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_8.TabIndex = 14;
            this.bt_folie_8.Text = "Folie 8";
            this.bt_folie_8.UseVisualStyleBackColor = false;
            // 
            // bt_folie_9
            // 
            this.bt_folie_9.BackColor = System.Drawing.Color.Black;
            this.bt_folie_9.ForeColor = System.Drawing.Color.White;
            this.bt_folie_9.Location = new System.Drawing.Point(390, 231);
            this.bt_folie_9.Name = "bt_folie_9";
            this.bt_folie_9.Size = new System.Drawing.Size(180, 100);
            this.bt_folie_9.TabIndex = 15;
            this.bt_folie_9.Text = "Folie 9";
            this.bt_folie_9.UseVisualStyleBackColor = false;
            // 
            // la_folienseiten
            // 
            this.la_folienseiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.la_folienseiten.AutoSize = true;
            this.la_folienseiten.Location = new System.Drawing.Point(427, 401);
            this.la_folienseiten.Name = "la_folienseiten";
            this.la_folienseiten.Size = new System.Drawing.Size(70, 13);
            this.la_folienseiten.TabIndex = 16;
            this.la_folienseiten.Text = "Seite 1 von 1";
            // 
            // gB_Folien
            // 
            this.gB_Folien.Controls.Add(this.bt_folie_1);
            this.gB_Folien.Controls.Add(this.la_folienseiten);
            this.gB_Folien.Controls.Add(this.bt_folie_3);
            this.gB_Folien.Controls.Add(this.bt_folie_2);
            this.gB_Folien.Controls.Add(this.bt_Folienseite_vor);
            this.gB_Folien.Controls.Add(this.bt_Folienseite_zurück);
            this.gB_Folien.Controls.Add(this.bt_folie_9);
            this.gB_Folien.Controls.Add(this.bt_folie_6);
            this.gB_Folien.Controls.Add(this.bt_folie_8);
            this.gB_Folien.Controls.Add(this.bt_folie_4);
            this.gB_Folien.Controls.Add(this.bt_folie_7);
            this.gB_Folien.Controls.Add(this.bt_folie_5);
            this.gB_Folien.Location = new System.Drawing.Point(12, 288);
            this.gB_Folien.Name = "gB_Folien";
            this.gB_Folien.Size = new System.Drawing.Size(584, 426);
            this.gB_Folien.TabIndex = 17;
            this.gB_Folien.TabStop = false;
            this.gB_Folien.Text = "Folien";
            // 
            // manuellerTextToolStripMenuItem
            // 
            this.manuellerTextToolStripMenuItem.Name = "manuellerTextToolStripMenuItem";
            this.manuellerTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manuellerTextToolStripMenuItem.Text = "Manueller Text";
            this.manuellerTextToolStripMenuItem.Click += new System.EventHandler(this.manuellerTextToolStripMenuItem_Click);
            // 
            // bilderToolStripMenuItem
            // 
            this.bilderToolStripMenuItem.Name = "bilderToolStripMenuItem";
            this.bilderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bilderToolStripMenuItem.Text = "Bilder";
            this.bilderToolStripMenuItem.Click += new System.EventHandler(this.bilderToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 722);
            this.Controls.Add(this.gB_Folien);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LiederAnzeige";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gB_Folien.ResumeLayout(false);
            this.gB_Folien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem präsentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_suchergebnis;
        private System.Windows.Forms.TextBox tb_suchefeld;
        private System.Windows.Forms.ComboBox cb_Liederbuecher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem präsentationStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem präsentationStoppenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerenToolStripMenuItem;
        private System.Windows.Forms.Button bt_schriftgroesse_speichern;
        private System.Windows.Forms.Button bt_text_kleiner;
        private System.Windows.Forms.Button bt_text_groesser;
        private System.Windows.Forms.Label la_liederbuch;
        private System.Windows.Forms.Label la_titel;
        private System.Windows.Forms.Label la_titelnummer;
        private System.Windows.Forms.Button bt_folien_anzeigen;
        private System.Windows.Forms.Button bt_naechsteFolie;
        private System.Windows.Forms.ListBox lb_Folien;
        private System.Windows.Forms.ToolStripMenuItem nurBildLeerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurTextLeerenToolStripMenuItem;
        private System.Windows.Forms.Button bt_Folienseite_zurück;
        private System.Windows.Forms.Button bt_Folienseite_vor;
        private System.Windows.Forms.Button bt_folie_1;
        private System.Windows.Forms.Button bt_folie_2;
        private System.Windows.Forms.Button bt_folie_3;
        private System.Windows.Forms.Button bt_folie_4;
        private System.Windows.Forms.Button bt_folie_5;
        private System.Windows.Forms.Button bt_folie_6;
        private System.Windows.Forms.Button bt_folie_7;
        private System.Windows.Forms.Button bt_folie_8;
        private System.Windows.Forms.Button bt_folie_9;
        private System.Windows.Forms.Label la_folienseiten;
        private System.Windows.Forms.GroupBox gB_Folien;
        private System.Windows.Forms.ToolStripMenuItem manuellerTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
    }
}

