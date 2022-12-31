
namespace LiederAnzeige
{
    partial class Hauptfenster
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
            this.HauptfensterMenueleiste = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.präsentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_suche = new System.Windows.Forms.GroupBox();
            this.lb_ergebnis = new System.Windows.Forms.ListBox();
            this.tb_suchfeld = new System.Windows.Forms.TextBox();
            this.cb_Liederbuecher = new System.Windows.Forms.ComboBox();
            this.gb_schrift = new System.Windows.Forms.GroupBox();
            this.bt_Text_kleiner = new System.Windows.Forms.Button();
            this.bt_Text_groeßer = new System.Windows.Forms.Button();
            this.gb_live_info = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_folien_einfach = new System.Windows.Forms.GroupBox();
            this.bt_naechste_folie = new System.Windows.Forms.Button();
            this.bt_folien_anzeigen_oder_ausblenden = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_folien_erweitert = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bt_naechste_Seite = new System.Windows.Forms.Button();
            this.bt_vorherige_Seite = new System.Windows.Forms.Button();
            this.la_aktuelle_Seite = new System.Windows.Forms.Label();
            this.textgrößenSteuerungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfacheFoliensteuerungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erweiterteFoliensteuerungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachUpdatesSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HauptfensterMenueleiste.SuspendLayout();
            this.gb_suche.SuspendLayout();
            this.gb_schrift.SuspendLayout();
            this.gb_live_info.SuspendLayout();
            this.gb_folien_einfach.SuspendLayout();
            this.gb_folien_erweitert.SuspendLayout();
            this.SuspendLayout();
            // 
            // HauptfensterMenueleiste
            // 
            this.HauptfensterMenueleiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.präsentationToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.liveToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.HauptfensterMenueleiste.Location = new System.Drawing.Point(0, 0);
            this.HauptfensterMenueleiste.Name = "HauptfensterMenueleiste";
            this.HauptfensterMenueleiste.Size = new System.Drawing.Size(721, 24);
            this.HauptfensterMenueleiste.TabIndex = 0;
            this.HauptfensterMenueleiste.Text = "Hauptmenü";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // präsentationToolStripMenuItem
            // 
            this.präsentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.leerToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.präsentationToolStripMenuItem.Name = "präsentationToolStripMenuItem";
            this.präsentationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.präsentationToolStripMenuItem.Text = "Präsentation";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.liveToolStripMenuItem.Text = "Live";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachUpdatesSuchenToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textgrößenSteuerungToolStripMenuItem,
            this.liveInfoToolStripMenuItem,
            this.einfacheFoliensteuerungToolStripMenuItem,
            this.erweiterteFoliensteuerungToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // gb_suche
            // 
            this.gb_suche.Controls.Add(this.lb_ergebnis);
            this.gb_suche.Controls.Add(this.tb_suchfeld);
            this.gb_suche.Controls.Add(this.cb_Liederbuecher);
            this.gb_suche.Location = new System.Drawing.Point(12, 27);
            this.gb_suche.Name = "gb_suche";
            this.gb_suche.Size = new System.Drawing.Size(455, 193);
            this.gb_suche.TabIndex = 1;
            this.gb_suche.TabStop = false;
            this.gb_suche.Text = "Suche";
            // 
            // lb_ergebnis
            // 
            this.lb_ergebnis.FormattingEnabled = true;
            this.lb_ergebnis.Location = new System.Drawing.Point(7, 48);
            this.lb_ergebnis.Name = "lb_ergebnis";
            this.lb_ergebnis.Size = new System.Drawing.Size(440, 134);
            this.lb_ergebnis.TabIndex = 2;
            // 
            // tb_suchfeld
            // 
            this.tb_suchfeld.Location = new System.Drawing.Point(242, 20);
            this.tb_suchfeld.Name = "tb_suchfeld";
            this.tb_suchfeld.Size = new System.Drawing.Size(205, 20);
            this.tb_suchfeld.TabIndex = 1;
            // 
            // cb_Liederbuecher
            // 
            this.cb_Liederbuecher.FormattingEnabled = true;
            this.cb_Liederbuecher.Location = new System.Drawing.Point(7, 20);
            this.cb_Liederbuecher.Name = "cb_Liederbuecher";
            this.cb_Liederbuecher.Size = new System.Drawing.Size(229, 21);
            this.cb_Liederbuecher.TabIndex = 0;
            // 
            // gb_schrift
            // 
            this.gb_schrift.Controls.Add(this.bt_Text_kleiner);
            this.gb_schrift.Controls.Add(this.bt_Text_groeßer);
            this.gb_schrift.Location = new System.Drawing.Point(474, 28);
            this.gb_schrift.Name = "gb_schrift";
            this.gb_schrift.Size = new System.Drawing.Size(115, 126);
            this.gb_schrift.TabIndex = 2;
            this.gb_schrift.TabStop = false;
            this.gb_schrift.Text = "Schrift";
            // 
            // bt_Text_kleiner
            // 
            this.bt_Text_kleiner.Location = new System.Drawing.Point(6, 72);
            this.bt_Text_kleiner.Name = "bt_Text_kleiner";
            this.bt_Text_kleiner.Size = new System.Drawing.Size(101, 47);
            this.bt_Text_kleiner.TabIndex = 4;
            this.bt_Text_kleiner.Text = "Text kleiner";
            this.bt_Text_kleiner.UseVisualStyleBackColor = true;
            this.bt_Text_kleiner.Click += new System.EventHandler(this.bt_Text_kleiner_Click);
            // 
            // bt_Text_groeßer
            // 
            this.bt_Text_groeßer.Location = new System.Drawing.Point(6, 19);
            this.bt_Text_groeßer.Name = "bt_Text_groeßer";
            this.bt_Text_groeßer.Size = new System.Drawing.Size(101, 47);
            this.bt_Text_groeßer.TabIndex = 3;
            this.bt_Text_groeßer.Text = "Text größer";
            this.bt_Text_groeßer.UseVisualStyleBackColor = true;
            this.bt_Text_groeßer.Click += new System.EventHandler(this.bt_Text_groeßer_Click);
            // 
            // gb_live_info
            // 
            this.gb_live_info.Controls.Add(this.label3);
            this.gb_live_info.Controls.Add(this.label2);
            this.gb_live_info.Controls.Add(this.label1);
            this.gb_live_info.Location = new System.Drawing.Point(13, 227);
            this.gb_live_info.Name = "gb_live_info";
            this.gb_live_info.Size = new System.Drawing.Size(454, 101);
            this.gb_live_info.TabIndex = 7;
            this.gb_live_info.TabStop = false;
            this.gb_live_info.Text = "Live Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liederbuch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titelnummer:";
            // 
            // gb_folien_einfach
            // 
            this.gb_folien_einfach.Controls.Add(this.listBox1);
            this.gb_folien_einfach.Controls.Add(this.bt_folien_anzeigen_oder_ausblenden);
            this.gb_folien_einfach.Controls.Add(this.bt_naechste_folie);
            this.gb_folien_einfach.Location = new System.Drawing.Point(474, 160);
            this.gb_folien_einfach.Name = "gb_folien_einfach";
            this.gb_folien_einfach.Size = new System.Drawing.Size(224, 135);
            this.gb_folien_einfach.TabIndex = 8;
            this.gb_folien_einfach.TabStop = false;
            this.gb_folien_einfach.Text = "Folien";
            // 
            // bt_naechste_folie
            // 
            this.bt_naechste_folie.Location = new System.Drawing.Point(6, 19);
            this.bt_naechste_folie.Name = "bt_naechste_folie";
            this.bt_naechste_folie.Size = new System.Drawing.Size(101, 47);
            this.bt_naechste_folie.TabIndex = 9;
            this.bt_naechste_folie.Text = "Nächste Folie";
            this.bt_naechste_folie.UseVisualStyleBackColor = true;
            // 
            // bt_folien_anzeigen_oder_ausblenden
            // 
            this.bt_folien_anzeigen_oder_ausblenden.Location = new System.Drawing.Point(6, 72);
            this.bt_folien_anzeigen_oder_ausblenden.Name = "bt_folien_anzeigen_oder_ausblenden";
            this.bt_folien_anzeigen_oder_ausblenden.Size = new System.Drawing.Size(101, 47);
            this.bt_folien_anzeigen_oder_ausblenden.TabIndex = 9;
            this.bt_folien_anzeigen_oder_ausblenden.Text = "Folien anzeigen";
            this.bt_folien_anzeigen_oder_ausblenden.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(113, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 108);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 137);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gb_folien_erweitert
            // 
            this.gb_folien_erweitert.Controls.Add(this.la_aktuelle_Seite);
            this.gb_folien_erweitert.Controls.Add(this.bt_vorherige_Seite);
            this.gb_folien_erweitert.Controls.Add(this.bt_naechste_Seite);
            this.gb_folien_erweitert.Controls.Add(this.button9);
            this.gb_folien_erweitert.Controls.Add(this.button8);
            this.gb_folien_erweitert.Controls.Add(this.button7);
            this.gb_folien_erweitert.Controls.Add(this.button6);
            this.gb_folien_erweitert.Controls.Add(this.button5);
            this.gb_folien_erweitert.Controls.Add(this.button4);
            this.gb_folien_erweitert.Controls.Add(this.button3);
            this.gb_folien_erweitert.Controls.Add(this.button2);
            this.gb_folien_erweitert.Controls.Add(this.button1);
            this.gb_folien_erweitert.Location = new System.Drawing.Point(13, 335);
            this.gb_folien_erweitert.Name = "gb_folien_erweitert";
            this.gb_folien_erweitert.Size = new System.Drawing.Size(697, 480);
            this.gb_folien_erweitert.TabIndex = 10;
            this.gb_folien_erweitert.TabStop = false;
            this.gb_folien_erweitert.Text = "Folien";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 137);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 137);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 137);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 137);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(469, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 137);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(222, 137);
            this.button7.TabIndex = 15;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(241, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 137);
            this.button8.TabIndex = 16;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(469, 305);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 137);
            this.button9.TabIndex = 17;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // bt_naechste_Seite
            // 
            this.bt_naechste_Seite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_naechste_Seite.Location = new System.Drawing.Point(616, 448);
            this.bt_naechste_Seite.Name = "bt_naechste_Seite";
            this.bt_naechste_Seite.Size = new System.Drawing.Size(75, 23);
            this.bt_naechste_Seite.TabIndex = 18;
            this.bt_naechste_Seite.Text = "nächste Seite";
            this.bt_naechste_Seite.UseVisualStyleBackColor = true;
            // 
            // bt_vorherige_Seite
            // 
            this.bt_vorherige_Seite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_vorherige_Seite.Location = new System.Drawing.Point(461, 448);
            this.bt_vorherige_Seite.Name = "bt_vorherige_Seite";
            this.bt_vorherige_Seite.Size = new System.Drawing.Size(75, 23);
            this.bt_vorherige_Seite.TabIndex = 19;
            this.bt_vorherige_Seite.Text = "zurück";
            this.bt_vorherige_Seite.UseVisualStyleBackColor = true;
            // 
            // la_aktuelle_Seite
            // 
            this.la_aktuelle_Seite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.la_aktuelle_Seite.AutoSize = true;
            this.la_aktuelle_Seite.Location = new System.Drawing.Point(542, 453);
            this.la_aktuelle_Seite.Name = "la_aktuelle_Seite";
            this.la_aktuelle_Seite.Size = new System.Drawing.Size(68, 13);
            this.la_aktuelle_Seite.TabIndex = 20;
            this.la_aktuelle_Seite.Text = "Seite x von y";
            // 
            // textgrößenSteuerungToolStripMenuItem
            // 
            this.textgrößenSteuerungToolStripMenuItem.Checked = true;
            this.textgrößenSteuerungToolStripMenuItem.CheckOnClick = true;
            this.textgrößenSteuerungToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textgrößenSteuerungToolStripMenuItem.Name = "textgrößenSteuerungToolStripMenuItem";
            this.textgrößenSteuerungToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.textgrößenSteuerungToolStripMenuItem.Text = "Textgrößen Steuerung";
            this.textgrößenSteuerungToolStripMenuItem.ToolTipText = "zeigt die Buttons zum ändern der Schriftgröße an";
            this.textgrößenSteuerungToolStripMenuItem.Click += new System.EventHandler(this.textgrößenSteuerungToolStripMenuItem_Click);
            // 
            // liveInfoToolStripMenuItem
            // 
            this.liveInfoToolStripMenuItem.Checked = true;
            this.liveInfoToolStripMenuItem.CheckOnClick = true;
            this.liveInfoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.liveInfoToolStripMenuItem.Name = "liveInfoToolStripMenuItem";
            this.liveInfoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.liveInfoToolStripMenuItem.Text = "Live Info";
            this.liveInfoToolStripMenuItem.ToolTipText = "zeigt die Informationen des Liedes an";
            this.liveInfoToolStripMenuItem.Click += new System.EventHandler(this.liveInfoToolStripMenuItem_Click);
            // 
            // einfacheFoliensteuerungToolStripMenuItem
            // 
            this.einfacheFoliensteuerungToolStripMenuItem.Checked = true;
            this.einfacheFoliensteuerungToolStripMenuItem.CheckOnClick = true;
            this.einfacheFoliensteuerungToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.einfacheFoliensteuerungToolStripMenuItem.Name = "einfacheFoliensteuerungToolStripMenuItem";
            this.einfacheFoliensteuerungToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.einfacheFoliensteuerungToolStripMenuItem.Text = "einfache Foliensteuerung";
            this.einfacheFoliensteuerungToolStripMenuItem.ToolTipText = "zeigt die einfache Foliensteuerung an";
            this.einfacheFoliensteuerungToolStripMenuItem.Click += new System.EventHandler(this.einfacheFoliensteuerungToolStripMenuItem_Click);
            // 
            // erweiterteFoliensteuerungToolStripMenuItem
            // 
            this.erweiterteFoliensteuerungToolStripMenuItem.Checked = true;
            this.erweiterteFoliensteuerungToolStripMenuItem.CheckOnClick = true;
            this.erweiterteFoliensteuerungToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.erweiterteFoliensteuerungToolStripMenuItem.Name = "erweiterteFoliensteuerungToolStripMenuItem";
            this.erweiterteFoliensteuerungToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.erweiterteFoliensteuerungToolStripMenuItem.Text = "erweiterte Foliensteuerung";
            this.erweiterteFoliensteuerungToolStripMenuItem.ToolTipText = "zeigt die einzelnen Folien an";
            this.erweiterteFoliensteuerungToolStripMenuItem.Click += new System.EventHandler(this.erweiterteFoliensteuerungToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // leerToolStripMenuItem
            // 
            this.leerToolStripMenuItem.Name = "leerToolStripMenuItem";
            this.leerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leerToolStripMenuItem.Text = "Leer";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen...";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // nachUpdatesSuchenToolStripMenuItem
            // 
            this.nachUpdatesSuchenToolStripMenuItem.Name = "nachUpdatesSuchenToolStripMenuItem";
            this.nachUpdatesSuchenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nachUpdatesSuchenToolStripMenuItem.Text = "Nach Updates suchen";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 852);
            this.Controls.Add(this.gb_folien_erweitert);
            this.Controls.Add(this.gb_folien_einfach);
            this.Controls.Add(this.gb_live_info);
            this.Controls.Add(this.gb_schrift);
            this.Controls.Add(this.gb_suche);
            this.Controls.Add(this.HauptfensterMenueleiste);
            this.MainMenuStrip = this.HauptfensterMenueleiste;
            this.Name = "Hauptfenster";
            this.Text = "LiederAnzeige";
            this.HauptfensterMenueleiste.ResumeLayout(false);
            this.HauptfensterMenueleiste.PerformLayout();
            this.gb_suche.ResumeLayout(false);
            this.gb_suche.PerformLayout();
            this.gb_schrift.ResumeLayout(false);
            this.gb_live_info.ResumeLayout(false);
            this.gb_live_info.PerformLayout();
            this.gb_folien_einfach.ResumeLayout(false);
            this.gb_folien_erweitert.ResumeLayout(false);
            this.gb_folien_erweitert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HauptfensterMenueleiste;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem präsentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_suche;
        private System.Windows.Forms.ListBox lb_ergebnis;
        private System.Windows.Forms.TextBox tb_suchfeld;
        private System.Windows.Forms.ComboBox cb_Liederbuecher;
        private System.Windows.Forms.GroupBox gb_schrift;
        private System.Windows.Forms.Button bt_Text_kleiner;
        private System.Windows.Forms.Button bt_Text_groeßer;
        private System.Windows.Forms.GroupBox gb_live_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_folien_einfach;
        private System.Windows.Forms.ToolStripMenuItem textgrößenSteuerungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfacheFoliensteuerungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erweiterteFoliensteuerungToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_folien_anzeigen_oder_ausblenden;
        private System.Windows.Forms.Button bt_naechste_folie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_folien_erweitert;
        private System.Windows.Forms.Label la_aktuelle_Seite;
        private System.Windows.Forms.Button bt_vorherige_Seite;
        private System.Windows.Forms.Button bt_naechste_Seite;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachUpdatesSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

