
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
            this.DateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeuesLiedErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiederbücherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiederDatenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PräsentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PräsentationStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PräsentationStoppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NurBildLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NurTextLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuellerTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnsichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachUpdatesSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_suchergebnis = new System.Windows.Forms.ListBox();
            this.TB_suchefeld = new System.Windows.Forms.TextBox();
            this.CB_Liederbuecher = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_schriftgroesse_speichern = new System.Windows.Forms.Button();
            this.BT_text_kleiner = new System.Windows.Forms.Button();
            this.BT_text_groesser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LA_liederbuch = new System.Windows.Forms.Label();
            this.LA_titel = new System.Windows.Forms.Label();
            this.LA_titelnummer = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BT_folien_anzeigen = new System.Windows.Forms.Button();
            this.BT_naechsteFolie = new System.Windows.Forms.Button();
            this.LB_Folien = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BT_Folienseite_zurück = new System.Windows.Forms.Button();
            this.BT_Folienseite_vor = new System.Windows.Forms.Button();
            this.BT_folie_1 = new System.Windows.Forms.Button();
            this.BT_folie_2 = new System.Windows.Forms.Button();
            this.BT_folie_3 = new System.Windows.Forms.Button();
            this.BT_folie_4 = new System.Windows.Forms.Button();
            this.BT_folie_5 = new System.Windows.Forms.Button();
            this.BT_folie_6 = new System.Windows.Forms.Button();
            this.BT_folie_7 = new System.Windows.Forms.Button();
            this.BT_folie_8 = new System.Windows.Forms.Button();
            this.BT_folie_9 = new System.Windows.Forms.Button();
            this.LA_folienseiten = new System.Windows.Forms.Label();
            this.gB_Folien = new System.Windows.Forms.GroupBox();
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
            this.DateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.PräsentationToolStripMenuItem,
            this.LiveToolStripMenuItem,
            this.AnsichtToolStripMenuItem,
            this.HilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DateiToolStripMenuItem
            // 
            this.DateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeuesLiedErstellenToolStripMenuItem,
            this.EinstellungenToolStripMenuItem});
            this.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem";
            this.DateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.DateiToolStripMenuItem.Text = "Datei";
            // 
            // NeuesLiedErstellenToolStripMenuItem
            // 
            this.NeuesLiedErstellenToolStripMenuItem.Name = "NeuesLiedErstellenToolStripMenuItem";
            this.NeuesLiedErstellenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NeuesLiedErstellenToolStripMenuItem.Text = "Neues Lied erstellen";
            this.NeuesLiedErstellenToolStripMenuItem.Click += new System.EventHandler(this.NeuesLiedErstellenToolStripMenuItem_Click);
            // 
            // EinstellungenToolStripMenuItem
            // 
            this.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem";
            this.EinstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EinstellungenToolStripMenuItem.Text = "Einstellungen";
            this.EinstellungenToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LiederbücherToolStripMenuItem,
            this.EditorToolStripMenuItem,
            this.LiederDatenbankToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // LiederbücherToolStripMenuItem
            // 
            this.LiederbücherToolStripMenuItem.Name = "LiederbücherToolStripMenuItem";
            this.LiederbücherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LiederbücherToolStripMenuItem.Text = "Liederbücher";
            this.LiederbücherToolStripMenuItem.Click += new System.EventHandler(this.LiederbücherToolStripMenuItem_Click);
            // 
            // EditorToolStripMenuItem
            // 
            this.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem";
            this.EditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditorToolStripMenuItem.Text = "Editor";
            this.EditorToolStripMenuItem.Click += new System.EventHandler(this.EditorToolStripMenuItem_Click);
            // 
            // LiederDatenbankToolStripMenuItem
            // 
            this.LiederDatenbankToolStripMenuItem.Name = "LiederDatenbankToolStripMenuItem";
            this.LiederDatenbankToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LiederDatenbankToolStripMenuItem.Text = "Lieder Datenbank";
            this.LiederDatenbankToolStripMenuItem.Click += new System.EventHandler(this.LiederDatenbankToolStripMenuItem_Click);
            // 
            // PräsentationToolStripMenuItem
            // 
            this.PräsentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PräsentationStartenToolStripMenuItem,
            this.PräsentationStoppenToolStripMenuItem,
            this.LeerenToolStripMenuItem,
            this.NurBildLeerenToolStripMenuItem,
            this.NurTextLeerenToolStripMenuItem});
            this.PräsentationToolStripMenuItem.Name = "PräsentationToolStripMenuItem";
            this.PräsentationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.PräsentationToolStripMenuItem.Text = "Präsentation";
            // 
            // PräsentationStartenToolStripMenuItem
            // 
            this.PräsentationStartenToolStripMenuItem.Name = "PräsentationStartenToolStripMenuItem";
            this.PräsentationStartenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PräsentationStartenToolStripMenuItem.Text = "Start";
            this.PräsentationStartenToolStripMenuItem.Click += new System.EventHandler(this.PräsentationStartenToolStripMenuItem_Click);
            // 
            // PräsentationStoppenToolStripMenuItem
            // 
            this.PräsentationStoppenToolStripMenuItem.Name = "PräsentationStoppenToolStripMenuItem";
            this.PräsentationStoppenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PräsentationStoppenToolStripMenuItem.Text = "Stop";
            this.PräsentationStoppenToolStripMenuItem.Click += new System.EventHandler(this.PräsentationStoppenToolStripMenuItem_Click);
            // 
            // LeerenToolStripMenuItem
            // 
            this.LeerenToolStripMenuItem.Name = "LeerenToolStripMenuItem";
            this.LeerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LeerenToolStripMenuItem.Text = "Alles Leeren";
            this.LeerenToolStripMenuItem.Click += new System.EventHandler(this.LeerenToolStripMenuItem_Click);
            // 
            // NurBildLeerenToolStripMenuItem
            // 
            this.NurBildLeerenToolStripMenuItem.Name = "NurBildLeerenToolStripMenuItem";
            this.NurBildLeerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NurBildLeerenToolStripMenuItem.Text = "Nur Bild Leeren";
            this.NurBildLeerenToolStripMenuItem.Click += new System.EventHandler(this.NurBildLeerenToolStripMenuItem_Click);
            // 
            // NurTextLeerenToolStripMenuItem
            // 
            this.NurTextLeerenToolStripMenuItem.Name = "NurTextLeerenToolStripMenuItem";
            this.NurTextLeerenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NurTextLeerenToolStripMenuItem.Text = "Nur Text Leeren";
            this.NurTextLeerenToolStripMenuItem.Click += new System.EventHandler(this.NurTextLeerenToolStripMenuItem_Click);
            // 
            // LiveToolStripMenuItem
            // 
            this.LiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManuellerTextToolStripMenuItem,
            this.BilderToolStripMenuItem,
            this.VideoToolStripMenuItem});
            this.LiveToolStripMenuItem.Name = "LiveToolStripMenuItem";
            this.LiveToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.LiveToolStripMenuItem.Text = "Live";
            // 
            // ManuellerTextToolStripMenuItem
            // 
            this.ManuellerTextToolStripMenuItem.Name = "ManuellerTextToolStripMenuItem";
            this.ManuellerTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ManuellerTextToolStripMenuItem.Text = "Manueller Text";
            this.ManuellerTextToolStripMenuItem.Click += new System.EventHandler(this.ManuellerTextToolStripMenuItem_Click);
            // 
            // BilderToolStripMenuItem
            // 
            this.BilderToolStripMenuItem.Name = "BilderToolStripMenuItem";
            this.BilderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BilderToolStripMenuItem.Text = "Bilder";
            this.BilderToolStripMenuItem.Click += new System.EventHandler(this.BilderToolStripMenuItem_Click);
            // 
            // VideoToolStripMenuItem
            // 
            this.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem";
            this.VideoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VideoToolStripMenuItem.Text = "Video";
            // 
            // AnsichtToolStripMenuItem
            // 
            this.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem";
            this.AnsichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.AnsichtToolStripMenuItem.Text = "Ansicht";
            // 
            // HilfeToolStripMenuItem
            // 
            this.HilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachUpdatesSuchenToolStripMenuItem});
            this.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem";
            this.HilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // nachUpdatesSuchenToolStripMenuItem
            // 
            this.nachUpdatesSuchenToolStripMenuItem.Name = "nachUpdatesSuchenToolStripMenuItem";
            this.nachUpdatesSuchenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nachUpdatesSuchenToolStripMenuItem.Text = "Nach Updates suchen";
            this.nachUpdatesSuchenToolStripMenuItem.Click += new System.EventHandler(this.NachUpdatesSuchenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_suchergebnis);
            this.groupBox1.Controls.Add(this.TB_suchefeld);
            this.groupBox1.Controls.Add(this.CB_Liederbuecher);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suche";
            // 
            // LB_suchergebnis
            // 
            this.LB_suchergebnis.FormattingEnabled = true;
            this.LB_suchergebnis.Location = new System.Drawing.Point(7, 48);
            this.LB_suchergebnis.Name = "LB_suchergebnis";
            this.LB_suchergebnis.Size = new System.Drawing.Size(360, 95);
            this.LB_suchergebnis.TabIndex = 2;
            // 
            // TB_suchefeld
            // 
            this.TB_suchefeld.Location = new System.Drawing.Point(161, 20);
            this.TB_suchefeld.Name = "TB_suchefeld";
            this.TB_suchefeld.Size = new System.Drawing.Size(206, 20);
            this.TB_suchefeld.TabIndex = 1;
            this.TB_suchefeld.TextChanged += new System.EventHandler(this.TB_suchefeld_TextChanged);
            // 
            // CB_Liederbuecher
            // 
            this.CB_Liederbuecher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Liederbuecher.Location = new System.Drawing.Point(7, 20);
            this.CB_Liederbuecher.Name = "CB_Liederbuecher";
            this.CB_Liederbuecher.Size = new System.Drawing.Size(148, 21);
            this.CB_Liederbuecher.Sorted = true;
            this.CB_Liederbuecher.TabIndex = 0;
            this.CB_Liederbuecher.DropDown += new System.EventHandler(this.CB_Liederbuecher_DropDown);
            this.CB_Liederbuecher.SelectedIndexChanged += new System.EventHandler(this.CB_Liederbuecher_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_schriftgroesse_speichern);
            this.groupBox2.Controls.Add(this.BT_text_kleiner);
            this.groupBox2.Controls.Add(this.BT_text_groesser);
            this.groupBox2.Location = new System.Drawing.Point(396, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schriftgröße";
            // 
            // BT_schriftgroesse_speichern
            // 
            this.BT_schriftgroesse_speichern.Location = new System.Drawing.Point(6, 66);
            this.BT_schriftgroesse_speichern.Name = "BT_schriftgroesse_speichern";
            this.BT_schriftgroesse_speichern.Size = new System.Drawing.Size(91, 40);
            this.BT_schriftgroesse_speichern.TabIndex = 2;
            this.BT_schriftgroesse_speichern.Text = "Schriftgröße speichern";
            this.BT_schriftgroesse_speichern.UseVisualStyleBackColor = true;
            // 
            // BT_text_kleiner
            // 
            this.BT_text_kleiner.Location = new System.Drawing.Point(104, 20);
            this.BT_text_kleiner.Name = "BT_text_kleiner";
            this.BT_text_kleiner.Size = new System.Drawing.Size(91, 40);
            this.BT_text_kleiner.TabIndex = 1;
            this.BT_text_kleiner.Text = "Text kleiner";
            this.BT_text_kleiner.UseVisualStyleBackColor = true;
            // 
            // BT_text_groesser
            // 
            this.BT_text_groesser.Location = new System.Drawing.Point(6, 20);
            this.BT_text_groesser.Name = "BT_text_groesser";
            this.BT_text_groesser.Size = new System.Drawing.Size(91, 40);
            this.BT_text_groesser.TabIndex = 0;
            this.BT_text_groesser.Text = "Text größer";
            this.BT_text_groesser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LA_liederbuch);
            this.groupBox3.Controls.Add(this.LA_titel);
            this.groupBox3.Controls.Add(this.LA_titelnummer);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daten";
            // 
            // LA_liederbuch
            // 
            this.LA_liederbuch.AutoSize = true;
            this.LA_liederbuch.Location = new System.Drawing.Point(11, 70);
            this.LA_liederbuch.Name = "LA_liederbuch";
            this.LA_liederbuch.Size = new System.Drawing.Size(63, 13);
            this.LA_liederbuch.TabIndex = 2;
            this.LA_liederbuch.Text = "Liederbuch:";
            // 
            // LA_titel
            // 
            this.LA_titel.AutoSize = true;
            this.LA_titel.Location = new System.Drawing.Point(44, 45);
            this.LA_titel.Name = "LA_titel";
            this.LA_titel.Size = new System.Drawing.Size(30, 13);
            this.LA_titel.TabIndex = 1;
            this.LA_titel.Text = "Titel:";
            // 
            // LA_titelnummer
            // 
            this.LA_titelnummer.AutoSize = true;
            this.LA_titelnummer.Location = new System.Drawing.Point(7, 20);
            this.LA_titelnummer.Name = "LA_titelnummer";
            this.LA_titelnummer.Size = new System.Drawing.Size(67, 13);
            this.LA_titelnummer.TabIndex = 0;
            this.LA_titelnummer.Text = "Titelnummer:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BT_folien_anzeigen);
            this.groupBox4.Controls.Add(this.BT_naechsteFolie);
            this.groupBox4.Controls.Add(this.LB_Folien);
            this.groupBox4.Location = new System.Drawing.Point(396, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Folienliste";
            // 
            // BT_folien_anzeigen
            // 
            this.BT_folien_anzeigen.Location = new System.Drawing.Point(6, 65);
            this.BT_folien_anzeigen.Name = "BT_folien_anzeigen";
            this.BT_folien_anzeigen.Size = new System.Drawing.Size(91, 40);
            this.BT_folien_anzeigen.TabIndex = 6;
            this.BT_folien_anzeigen.Text = "Folien anzeigen";
            this.BT_folien_anzeigen.UseVisualStyleBackColor = true;
            // 
            // BT_naechsteFolie
            // 
            this.BT_naechsteFolie.Location = new System.Drawing.Point(6, 19);
            this.BT_naechsteFolie.Name = "BT_naechsteFolie";
            this.BT_naechsteFolie.Size = new System.Drawing.Size(91, 40);
            this.BT_naechsteFolie.TabIndex = 6;
            this.BT_naechsteFolie.Text = "Nächste Folie";
            this.BT_naechsteFolie.UseVisualStyleBackColor = true;
            // 
            // LB_Folien
            // 
            this.LB_Folien.FormattingEnabled = true;
            this.LB_Folien.Location = new System.Drawing.Point(103, 19);
            this.LB_Folien.Name = "LB_Folien";
            this.LB_Folien.Size = new System.Drawing.Size(90, 108);
            this.LB_Folien.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BT_Folienseite_zurück
            // 
            this.BT_Folienseite_zurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Folienseite_zurück.Location = new System.Drawing.Point(346, 395);
            this.BT_Folienseite_zurück.Name = "BT_Folienseite_zurück";
            this.BT_Folienseite_zurück.Size = new System.Drawing.Size(75, 25);
            this.BT_Folienseite_zurück.TabIndex = 5;
            this.BT_Folienseite_zurück.Text = "zurück";
            this.BT_Folienseite_zurück.UseVisualStyleBackColor = true;
            // 
            // BT_Folienseite_vor
            // 
            this.BT_Folienseite_vor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Folienseite_vor.Location = new System.Drawing.Point(501, 395);
            this.BT_Folienseite_vor.Name = "BT_Folienseite_vor";
            this.BT_Folienseite_vor.Size = new System.Drawing.Size(75, 25);
            this.BT_Folienseite_vor.TabIndex = 6;
            this.BT_Folienseite_vor.Text = "vor";
            this.BT_Folienseite_vor.UseVisualStyleBackColor = true;
            // 
            // BT_folie_1
            // 
            this.BT_folie_1.BackColor = System.Drawing.Color.Black;
            this.BT_folie_1.ForeColor = System.Drawing.Color.White;
            this.BT_folie_1.Location = new System.Drawing.Point(10, 19);
            this.BT_folie_1.Name = "BT_folie_1";
            this.BT_folie_1.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_1.TabIndex = 7;
            this.BT_folie_1.Text = "Folie 1";
            this.BT_folie_1.UseVisualStyleBackColor = false;
            // 
            // BT_folie_2
            // 
            this.BT_folie_2.BackColor = System.Drawing.Color.Black;
            this.BT_folie_2.ForeColor = System.Drawing.Color.White;
            this.BT_folie_2.Location = new System.Drawing.Point(198, 19);
            this.BT_folie_2.Name = "BT_folie_2";
            this.BT_folie_2.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_2.TabIndex = 8;
            this.BT_folie_2.Text = "Folie 2";
            this.BT_folie_2.UseVisualStyleBackColor = false;
            // 
            // BT_folie_3
            // 
            this.BT_folie_3.BackColor = System.Drawing.Color.Black;
            this.BT_folie_3.ForeColor = System.Drawing.Color.White;
            this.BT_folie_3.Location = new System.Drawing.Point(390, 19);
            this.BT_folie_3.Name = "BT_folie_3";
            this.BT_folie_3.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_3.TabIndex = 9;
            this.BT_folie_3.Text = "Folie 3";
            this.BT_folie_3.UseVisualStyleBackColor = false;
            // 
            // BT_folie_4
            // 
            this.BT_folie_4.BackColor = System.Drawing.Color.Black;
            this.BT_folie_4.ForeColor = System.Drawing.Color.White;
            this.BT_folie_4.Location = new System.Drawing.Point(10, 125);
            this.BT_folie_4.Name = "BT_folie_4";
            this.BT_folie_4.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_4.TabIndex = 10;
            this.BT_folie_4.Text = "Folie 4";
            this.BT_folie_4.UseVisualStyleBackColor = false;
            // 
            // BT_folie_5
            // 
            this.BT_folie_5.BackColor = System.Drawing.Color.Black;
            this.BT_folie_5.ForeColor = System.Drawing.Color.White;
            this.BT_folie_5.Location = new System.Drawing.Point(198, 125);
            this.BT_folie_5.Name = "BT_folie_5";
            this.BT_folie_5.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_5.TabIndex = 11;
            this.BT_folie_5.Text = "Folie 5";
            this.BT_folie_5.UseVisualStyleBackColor = false;
            // 
            // BT_folie_6
            // 
            this.BT_folie_6.BackColor = System.Drawing.Color.Black;
            this.BT_folie_6.ForeColor = System.Drawing.Color.White;
            this.BT_folie_6.Location = new System.Drawing.Point(390, 125);
            this.BT_folie_6.Name = "BT_folie_6";
            this.BT_folie_6.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_6.TabIndex = 12;
            this.BT_folie_6.Text = "Folie 6";
            this.BT_folie_6.UseVisualStyleBackColor = false;
            // 
            // BT_folie_7
            // 
            this.BT_folie_7.BackColor = System.Drawing.Color.Black;
            this.BT_folie_7.ForeColor = System.Drawing.Color.White;
            this.BT_folie_7.Location = new System.Drawing.Point(7, 231);
            this.BT_folie_7.Name = "BT_folie_7";
            this.BT_folie_7.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_7.TabIndex = 13;
            this.BT_folie_7.Text = "Folie 7";
            this.BT_folie_7.UseVisualStyleBackColor = false;
            // 
            // BT_folie_8
            // 
            this.BT_folie_8.BackColor = System.Drawing.Color.Black;
            this.BT_folie_8.ForeColor = System.Drawing.Color.White;
            this.BT_folie_8.Location = new System.Drawing.Point(198, 231);
            this.BT_folie_8.Name = "BT_folie_8";
            this.BT_folie_8.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_8.TabIndex = 14;
            this.BT_folie_8.Text = "Folie 8";
            this.BT_folie_8.UseVisualStyleBackColor = false;
            // 
            // BT_folie_9
            // 
            this.BT_folie_9.BackColor = System.Drawing.Color.Black;
            this.BT_folie_9.ForeColor = System.Drawing.Color.White;
            this.BT_folie_9.Location = new System.Drawing.Point(390, 231);
            this.BT_folie_9.Name = "BT_folie_9";
            this.BT_folie_9.Size = new System.Drawing.Size(180, 100);
            this.BT_folie_9.TabIndex = 15;
            this.BT_folie_9.Text = "Folie 9";
            this.BT_folie_9.UseVisualStyleBackColor = false;
            // 
            // LA_folienseiten
            // 
            this.LA_folienseiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LA_folienseiten.AutoSize = true;
            this.LA_folienseiten.Location = new System.Drawing.Point(427, 401);
            this.LA_folienseiten.Name = "LA_folienseiten";
            this.LA_folienseiten.Size = new System.Drawing.Size(70, 13);
            this.LA_folienseiten.TabIndex = 16;
            this.LA_folienseiten.Text = "Seite 1 von 1";
            // 
            // gB_Folien
            // 
            this.gB_Folien.Controls.Add(this.BT_folie_1);
            this.gB_Folien.Controls.Add(this.LA_folienseiten);
            this.gB_Folien.Controls.Add(this.BT_folie_3);
            this.gB_Folien.Controls.Add(this.BT_folie_2);
            this.gB_Folien.Controls.Add(this.BT_Folienseite_vor);
            this.gB_Folien.Controls.Add(this.BT_Folienseite_zurück);
            this.gB_Folien.Controls.Add(this.BT_folie_9);
            this.gB_Folien.Controls.Add(this.BT_folie_6);
            this.gB_Folien.Controls.Add(this.BT_folie_8);
            this.gB_Folien.Controls.Add(this.BT_folie_4);
            this.gB_Folien.Controls.Add(this.BT_folie_7);
            this.gB_Folien.Controls.Add(this.BT_folie_5);
            this.gB_Folien.Location = new System.Drawing.Point(12, 288);
            this.gB_Folien.Name = "gB_Folien";
            this.gB_Folien.Size = new System.Drawing.Size(584, 426);
            this.gB_Folien.TabIndex = 17;
            this.gB_Folien.TabStop = false;
            this.gB_Folien.Text = "Folien";
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem DateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PräsentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnsichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HilfeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LB_suchergebnis;
        private System.Windows.Forms.TextBox TB_suchefeld;
        private System.Windows.Forms.ComboBox CB_Liederbuecher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PräsentationStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PräsentationStoppenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeerenToolStripMenuItem;
        private System.Windows.Forms.Button BT_schriftgroesse_speichern;
        private System.Windows.Forms.Button BT_text_kleiner;
        private System.Windows.Forms.Button BT_text_groesser;
        private System.Windows.Forms.Label LA_liederbuch;
        private System.Windows.Forms.Label LA_titel;
        private System.Windows.Forms.Label LA_titelnummer;
        private System.Windows.Forms.Button BT_folien_anzeigen;
        private System.Windows.Forms.Button BT_naechsteFolie;
        private System.Windows.Forms.ListBox LB_Folien;
        private System.Windows.Forms.ToolStripMenuItem NurBildLeerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NurTextLeerenToolStripMenuItem;
        private System.Windows.Forms.Button BT_Folienseite_zurück;
        private System.Windows.Forms.Button BT_Folienseite_vor;
        private System.Windows.Forms.Button BT_folie_1;
        private System.Windows.Forms.Button BT_folie_2;
        private System.Windows.Forms.Button BT_folie_3;
        private System.Windows.Forms.Button BT_folie_4;
        private System.Windows.Forms.Button BT_folie_5;
        private System.Windows.Forms.Button BT_folie_6;
        private System.Windows.Forms.Button BT_folie_7;
        private System.Windows.Forms.Button BT_folie_8;
        private System.Windows.Forms.Button BT_folie_9;
        private System.Windows.Forms.Label LA_folienseiten;
        private System.Windows.Forms.GroupBox gB_Folien;
        private System.Windows.Forms.ToolStripMenuItem ManuellerTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BilderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NeuesLiedErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EinstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachUpdatesSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LiederbücherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LiederDatenbankToolStripMenuItem;
    }
}

