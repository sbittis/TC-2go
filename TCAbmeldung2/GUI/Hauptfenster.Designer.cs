namespace TCAbmeldung2.GUI
{
    partial class Hauptfenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptfenster));
            this.msHauptfenster = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verlaufDateiAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceDateiAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeltteamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatischesSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zugriffskontrolleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerdatenLesenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerdatenSchreibenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamerdatenLesenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAbmelden = new System.Windows.Forms.Button();
            this.btAnmelden = new System.Windows.Forms.Button();
            this.lvAbwesend = new System.Windows.Forms.ListView();
            this.chLeer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZelt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKommentar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAbwesend = new System.Windows.Forms.Label();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lbSuche = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerMonitoring = new System.Windows.Forms.Timer(this.components);
            this.pnNotify = new System.Windows.Forms.Panel();
            this.lbNotify = new System.Windows.Forms.Label();
            this.btSani = new System.Windows.Forms.Button();
            this.btAddKommentar = new System.Windows.Forms.Button();
            this.btListe = new System.Windows.Forms.Button();
            this.btZelt = new System.Windows.Forms.Button();
            this.btTeamListe = new System.Windows.Forms.Button();
            this.infomonitorVerbindungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHauptfenster.SuspendLayout();
            this.pnNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHauptfenster
            // 
            this.msHauptfenster.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msHauptfenster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.anzeigeToolStripMenuItem,
            this.datenToolStripMenuItem});
            this.msHauptfenster.Location = new System.Drawing.Point(0, 0);
            this.msHauptfenster.Name = "msHauptfenster";
            this.msHauptfenster.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msHauptfenster.Size = new System.Drawing.Size(1130, 35);
            this.msHauptfenster.TabIndex = 0;
            this.msHauptfenster.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1,
            this.einstellungenToolStripMenuItem1,
            this.schließenToolStripMenuItem1});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.infoToolStripMenuItem.Text = "Anwendung";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // einstellungenToolStripMenuItem1
            // 
            this.einstellungenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verlaufDateiAuswählenToolStripMenuItem,
            this.sourceDateiAuswählenToolStripMenuItem,
            this.zeltteamerToolStripMenuItem,
            this.automatischesSpeichernToolStripMenuItem,
            this.zugriffskontrolleToolStripMenuItem,
            this.infomonitorVerbindungToolStripMenuItem});
            this.einstellungenToolStripMenuItem1.Name = "einstellungenToolStripMenuItem1";
            this.einstellungenToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.einstellungenToolStripMenuItem1.Text = "Einstellungen";
            // 
            // verlaufDateiAuswählenToolStripMenuItem
            // 
            this.verlaufDateiAuswählenToolStripMenuItem.Name = "verlaufDateiAuswählenToolStripMenuItem";
            this.verlaufDateiAuswählenToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.verlaufDateiAuswählenToolStripMenuItem.Text = "Verlauf-Datei auswählen...";
            this.verlaufDateiAuswählenToolStripMenuItem.Click += new System.EventHandler(this.verlaufDateiAuswählenToolStripMenuItem_Click);
            // 
            // sourceDateiAuswählenToolStripMenuItem
            // 
            this.sourceDateiAuswählenToolStripMenuItem.Name = "sourceDateiAuswählenToolStripMenuItem";
            this.sourceDateiAuswählenToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.sourceDateiAuswählenToolStripMenuItem.Text = "Teilnehmer-Datei auswählen...";
            this.sourceDateiAuswählenToolStripMenuItem.Click += new System.EventHandler(this.sourceDateiAuswählenToolStripMenuItem_Click);
            // 
            // zeltteamerToolStripMenuItem
            // 
            this.zeltteamerToolStripMenuItem.Name = "zeltteamerToolStripMenuItem";
            this.zeltteamerToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.zeltteamerToolStripMenuItem.Text = "Teamer-Datei auswählen...";
            this.zeltteamerToolStripMenuItem.Click += new System.EventHandler(this.zeltteamerToolStripMenuItem_Click);
            // 
            // automatischesSpeichernToolStripMenuItem
            // 
            this.automatischesSpeichernToolStripMenuItem.Name = "automatischesSpeichernToolStripMenuItem";
            this.automatischesSpeichernToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.automatischesSpeichernToolStripMenuItem.Text = "Automatisches Speichern";
            this.automatischesSpeichernToolStripMenuItem.Click += new System.EventHandler(this.automatischesSpeichernToolStripMenuItem_Click);
            // 
            // zugriffskontrolleToolStripMenuItem
            // 
            this.zugriffskontrolleToolStripMenuItem.Name = "zugriffskontrolleToolStripMenuItem";
            this.zugriffskontrolleToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.zugriffskontrolleToolStripMenuItem.Text = "Zugriffskontrolle";
            this.zugriffskontrolleToolStripMenuItem.Click += new System.EventHandler(this.zugriffskontrolleToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem1
            // 
            this.schließenToolStripMenuItem1.Name = "schließenToolStripMenuItem1";
            this.schließenToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.schließenToolStripMenuItem1.Text = "Beenden";
            this.schließenToolStripMenuItem1.Click += new System.EventHandler(this.schließenToolStripMenuItem1_Click);
            // 
            // anzeigeToolStripMenuItem
            // 
            this.anzeigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem});
            this.anzeigeToolStripMenuItem.Name = "anzeigeToolStripMenuItem";
            this.anzeigeToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.anzeigeToolStripMenuItem.Text = "Anzeige";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.historyToolStripMenuItem.Text = "Verlauf";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // datenToolStripMenuItem
            // 
            this.datenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerdatenLesenToolStripMenuItem,
            this.teilnehmerdatenSchreibenToolStripMenuItem,
            this.teamerdatenLesenToolStripMenuItem});
            this.datenToolStripMenuItem.Name = "datenToolStripMenuItem";
            this.datenToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.datenToolStripMenuItem.Text = "Daten";
            // 
            // teilnehmerdatenLesenToolStripMenuItem
            // 
            this.teilnehmerdatenLesenToolStripMenuItem.Name = "teilnehmerdatenLesenToolStripMenuItem";
            this.teilnehmerdatenLesenToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.teilnehmerdatenLesenToolStripMenuItem.Text = "Teilnehmerdaten lesen";
            this.teilnehmerdatenLesenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerdatenLesenToolStripMenuItem_Click);
            // 
            // teilnehmerdatenSchreibenToolStripMenuItem
            // 
            this.teilnehmerdatenSchreibenToolStripMenuItem.Name = "teilnehmerdatenSchreibenToolStripMenuItem";
            this.teilnehmerdatenSchreibenToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.teilnehmerdatenSchreibenToolStripMenuItem.Text = "Teilnehmerdaten schreiben";
            this.teilnehmerdatenSchreibenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerdatenSchreibenToolStripMenuItem_Click);
            // 
            // teamerdatenLesenToolStripMenuItem
            // 
            this.teamerdatenLesenToolStripMenuItem.Name = "teamerdatenLesenToolStripMenuItem";
            this.teamerdatenLesenToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.teamerdatenLesenToolStripMenuItem.Text = "Teamerdaten lesen";
            this.teamerdatenLesenToolStripMenuItem.Click += new System.EventHandler(this.teamerdatenLesenToolStripMenuItem_Click);
            // 
            // btAbmelden
            // 
            this.btAbmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbmelden.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btAbmelden.Location = new System.Drawing.Point(18, 42);
            this.btAbmelden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAbmelden.Name = "btAbmelden";
            this.btAbmelden.Size = new System.Drawing.Size(507, 206);
            this.btAbmelden.TabIndex = 1;
            this.btAbmelden.Text = "Abmelden";
            this.btAbmelden.UseVisualStyleBackColor = true;
            this.btAbmelden.Click += new System.EventHandler(this.btAbmelden_Click);
            // 
            // btAnmelden
            // 
            this.btAnmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnmelden.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btAnmelden.Location = new System.Drawing.Point(534, 42);
            this.btAnmelden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAnmelden.Name = "btAnmelden";
            this.btAnmelden.Size = new System.Drawing.Size(578, 206);
            this.btAnmelden.TabIndex = 2;
            this.btAnmelden.Text = "Anmelden";
            this.btAnmelden.UseVisualStyleBackColor = true;
            this.btAnmelden.Click += new System.EventHandler(this.btAnmelden_Click);
            // 
            // lvAbwesend
            // 
            this.lvAbwesend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAbwesend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLeer,
            this.chNachname,
            this.chVorname,
            this.chZelt,
            this.chKommentar});
            this.lvAbwesend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAbwesend.FullRowSelect = true;
            this.lvAbwesend.Location = new System.Drawing.Point(18, 408);
            this.lvAbwesend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvAbwesend.MultiSelect = false;
            this.lvAbwesend.Name = "lvAbwesend";
            this.lvAbwesend.Size = new System.Drawing.Size(1092, 399);
            this.lvAbwesend.TabIndex = 3;
            this.lvAbwesend.UseCompatibleStateImageBehavior = false;
            this.lvAbwesend.View = System.Windows.Forms.View.Details;
            this.lvAbwesend.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAbwesend_ColumnClick);
            // 
            // chLeer
            // 
            this.chLeer.Text = "";
            this.chLeer.Width = 20;
            // 
            // chNachname
            // 
            this.chNachname.Text = "Nachname";
            this.chNachname.Width = 283;
            // 
            // chVorname
            // 
            this.chVorname.Text = "Vorname";
            this.chVorname.Width = 214;
            // 
            // chZelt
            // 
            this.chZelt.Text = "Zelt";
            // 
            // chKommentar
            // 
            this.chKommentar.Text = "Anmerkung";
            this.chKommentar.Width = 120;
            // 
            // lbAbwesend
            // 
            this.lbAbwesend.AutoSize = true;
            this.lbAbwesend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbwesend.Location = new System.Drawing.Point(18, 323);
            this.lbAbwesend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAbwesend.Name = "lbAbwesend";
            this.lbAbwesend.Size = new System.Drawing.Size(474, 32);
            this.lbAbwesend.TabIndex = 4;
            this.lbAbwesend.Text = "Liste der abwesenden Teilnehmer";
            // 
            // txtSuche
            // 
            this.txtSuche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuche.Location = new System.Drawing.Point(303, 362);
            this.txtSuche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(806, 35);
            this.txtSuche.TabIndex = 5;
            this.txtSuche.TextChanged += new System.EventHandler(this.txtSuche_TextChanged);
            // 
            // lbSuche
            // 
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(18, 366);
            this.lbSuche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(282, 29);
            this.lbSuche.TabIndex = 6;
            this.lbSuche.Text = "Nach Teilnehmer suchen";
            // 
            // timerMonitoring
            // 
            this.timerMonitoring.Interval = 60000;
            this.timerMonitoring.Tick += new System.EventHandler(this.timerMonitoring_Tick);
            // 
            // pnNotify
            // 
            this.pnNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNotify.BackColor = System.Drawing.Color.Coral;
            this.pnNotify.Controls.Add(this.lbNotify);
            this.pnNotify.Location = new System.Drawing.Point(502, 637);
            this.pnNotify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnNotify.Name = "pnNotify";
            this.pnNotify.Size = new System.Drawing.Size(609, 172);
            this.pnNotify.TabIndex = 7;
            this.pnNotify.Visible = false;
            // 
            // lbNotify
            // 
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.Location = new System.Drawing.Point(4, 0);
            this.lbNotify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(598, 142);
            this.lbNotify.TabIndex = 0;
            this.lbNotify.Text = "Achtung:";
            // 
            // btSani
            // 
            this.btSani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSani.BackgroundImage = global::TCAbmeldung2.Properties.Resources.Surgeon;
            this.btSani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSani.Location = new System.Drawing.Point(401, 257);
            this.btSani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSani.Name = "btSani";
            this.btSani.Size = new System.Drawing.Size(121, 95);
            this.btSani.TabIndex = 12;
            this.btSani.UseVisualStyleBackColor = true;
            this.btSani.Click += new System.EventHandler(this.btSani_Click);
            // 
            // btAddKommentar
            // 
            this.btAddKommentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddKommentar.BackgroundImage = global::TCAbmeldung2.Properties.Resources.File_edit;
            this.btAddKommentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddKommentar.Location = new System.Drawing.Point(984, 257);
            this.btAddKommentar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddKommentar.Name = "btAddKommentar";
            this.btAddKommentar.Size = new System.Drawing.Size(123, 95);
            this.btAddKommentar.TabIndex = 11;
            this.btAddKommentar.UseVisualStyleBackColor = true;
            this.btAddKommentar.Click += new System.EventHandler(this.btAddKommentar_Click);
            // 
            // btListe
            // 
            this.btListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListe.BackgroundImage = global::TCAbmeldung2.Properties.Resources.User_Group;
            this.btListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListe.Location = new System.Drawing.Point(538, 257);
            this.btListe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListe.Name = "btListe";
            this.btListe.Size = new System.Drawing.Size(213, 95);
            this.btListe.TabIndex = 9;
            this.btListe.UseVisualStyleBackColor = true;
            this.btListe.Click += new System.EventHandler(this.btListe_Click);
            // 
            // btZelt
            // 
            this.btZelt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btZelt.BackgroundImage = global::TCAbmeldung2.Properties.Resources.Tent_01;
            this.btZelt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btZelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZelt.Location = new System.Drawing.Point(760, 257);
            this.btZelt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btZelt.Name = "btZelt";
            this.btZelt.Size = new System.Drawing.Size(200, 95);
            this.btZelt.TabIndex = 8;
            this.btZelt.UseVisualStyleBackColor = true;
            this.btZelt.Click += new System.EventHandler(this.btZelt_Click);
            // 
            // btTeamListe
            // 
            this.btTeamListe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTeamListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTeamListe.Font = new System.Drawing.Font("HandelGothic BT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTeamListe.Location = new System.Drawing.Point(581, 258);
            this.btTeamListe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTeamListe.Name = "btTeamListe";
            this.btTeamListe.Size = new System.Drawing.Size(213, 95);
            this.btTeamListe.TabIndex = 13;
            this.btTeamListe.Text = "Team";
            this.btTeamListe.UseVisualStyleBackColor = true;
            this.btTeamListe.Click += new System.EventHandler(this.btTeamListe_Click);
            // 
            // infomonitorVerbindungToolStripMenuItem
            // 
            this.infomonitorVerbindungToolStripMenuItem.Name = "infomonitorVerbindungToolStripMenuItem";
            this.infomonitorVerbindungToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.infomonitorVerbindungToolStripMenuItem.Text = "Infomonitor-Verbindung...";
            this.infomonitorVerbindungToolStripMenuItem.Click += new System.EventHandler(this.infomonitorVerbindungToolStripMenuItem_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1130, 828);
            this.ControlBox = false;
            this.Controls.Add(this.btTeamListe);
            this.Controls.Add(this.btSani);
            this.Controls.Add(this.btAddKommentar);
            this.Controls.Add(this.btListe);
            this.Controls.Add(this.btZelt);
            this.Controls.Add(this.pnNotify);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.lbAbwesend);
            this.Controls.Add(this.lvAbwesend);
            this.Controls.Add(this.btAnmelden);
            this.Controls.Add(this.btAbmelden);
            this.Controls.Add(this.msHauptfenster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msHauptfenster;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hauptfenster";
            this.Text = "TC-2go";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hauptfenster_FormClosing);
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.SizeChanged += new System.EventHandler(this.Hauptfenster_SizeChanged);
            this.msHauptfenster.ResumeLayout(false);
            this.msHauptfenster.PerformLayout();
            this.pnNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msHauptfenster;
        private System.Windows.Forms.Button btAbmelden;
        private System.Windows.Forms.Button btAnmelden;
        private System.Windows.Forms.ListView lvAbwesend;
        private System.Windows.Forms.ColumnHeader chNachname;
        private System.Windows.Forms.ColumnHeader chVorname;
        private System.Windows.Forms.ColumnHeader chZelt;
        private System.Windows.Forms.ColumnHeader chLeer;
        private System.Windows.Forms.Label lbAbwesend;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lbSuche;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verlaufDateiAuswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerdatenLesenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerdatenSchreibenToolStripMenuItem;
        private System.Windows.Forms.Timer timerMonitoring;
        private System.Windows.Forms.Panel pnNotify;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.ToolStripMenuItem automatischesSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceDateiAuswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeltteamerToolStripMenuItem;
        private System.Windows.Forms.Button btZelt;
        private System.Windows.Forms.Button btListe;
        private System.Windows.Forms.ToolStripMenuItem teamerdatenLesenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chKommentar;
        private System.Windows.Forms.Button btAddKommentar;
        private System.Windows.Forms.Button btSani;
        private System.Windows.Forms.Button btTeamListe;
        private System.Windows.Forms.ToolStripMenuItem zugriffskontrolleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomonitorVerbindungToolStripMenuItem;
    }
}