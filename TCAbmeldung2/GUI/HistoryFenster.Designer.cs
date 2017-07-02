namespace TCAbmeldung2.GUI
{
    partial class HistoryFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryFenster));
            this.lvVerlauf = new System.Windows.Forms.ListView();
            this.chDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUhrzeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeilnehmer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAktion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeamer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAlleZeiten = new System.Windows.Forms.CheckBox();
            this.cbHeute = new System.Windows.Forms.CheckBox();
            this.cbAlle = new System.Windows.Forms.CheckBox();
            this.cbAbmeldungen = new System.Windows.Forms.CheckBox();
            this.cbAnmeldungen = new System.Windows.Forms.CheckBox();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVerlauf
            // 
            this.lvVerlauf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVerlauf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDatum,
            this.chUhrzeit,
            this.chTeilnehmer,
            this.chAktion,
            this.chTeamer});
            this.lvVerlauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVerlauf.Location = new System.Drawing.Point(12, 142);
            this.lvVerlauf.Name = "lvVerlauf";
            this.lvVerlauf.Size = new System.Drawing.Size(984, 437);
            this.lvVerlauf.TabIndex = 0;
            this.lvVerlauf.UseCompatibleStateImageBehavior = false;
            this.lvVerlauf.View = System.Windows.Forms.View.Details;
            this.lvVerlauf.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvVerlauf_ColumnClick);
            // 
            // chDatum
            // 
            this.chDatum.Text = "Datum";
            this.chDatum.Width = 134;
            // 
            // chUhrzeit
            // 
            this.chUhrzeit.Text = "Uhrzeit";
            this.chUhrzeit.Width = 145;
            // 
            // chTeilnehmer
            // 
            this.chTeilnehmer.Text = "Teilnehmer";
            this.chTeilnehmer.Width = 307;
            // 
            // chAktion
            // 
            this.chAktion.Text = "Aktion";
            this.chAktion.Width = 163;
            // 
            // chTeamer
            // 
            this.chTeamer.Text = "Teamer";
            this.chTeamer.Width = 212;
            // 
            // cbAlleZeiten
            // 
            this.cbAlleZeiten.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAlleZeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlleZeiten.Location = new System.Drawing.Point(12, 96);
            this.cbAlleZeiten.Name = "cbAlleZeiten";
            this.cbAlleZeiten.Size = new System.Drawing.Size(183, 46);
            this.cbAlleZeiten.TabIndex = 6;
            this.cbAlleZeiten.Text = "Ganzer Zeitraum";
            this.cbAlleZeiten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAlleZeiten.UseVisualStyleBackColor = true;
            this.cbAlleZeiten.Click += new System.EventHandler(this.cb_Click);
            // 
            // cbHeute
            // 
            this.cbHeute.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbHeute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeute.Location = new System.Drawing.Point(194, 96);
            this.cbHeute.Name = "cbHeute";
            this.cbHeute.Size = new System.Drawing.Size(183, 46);
            this.cbHeute.TabIndex = 7;
            this.cbHeute.Text = "Heute";
            this.cbHeute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbHeute.UseVisualStyleBackColor = true;
            this.cbHeute.Click += new System.EventHandler(this.cb_Click);
            // 
            // cbAlle
            // 
            this.cbAlle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlle.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlle.Location = new System.Drawing.Point(449, 96);
            this.cbAlle.Name = "cbAlle";
            this.cbAlle.Size = new System.Drawing.Size(183, 46);
            this.cbAlle.TabIndex = 8;
            this.cbAlle.Text = "Alle";
            this.cbAlle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAlle.UseVisualStyleBackColor = true;
            this.cbAlle.Click += new System.EventHandler(this.cb_Click);
            // 
            // cbAbmeldungen
            // 
            this.cbAbmeldungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbmeldungen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAbmeldungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAbmeldungen.Location = new System.Drawing.Point(631, 96);
            this.cbAbmeldungen.Name = "cbAbmeldungen";
            this.cbAbmeldungen.Size = new System.Drawing.Size(183, 46);
            this.cbAbmeldungen.TabIndex = 9;
            this.cbAbmeldungen.Text = "Abmeldungen";
            this.cbAbmeldungen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAbmeldungen.UseVisualStyleBackColor = true;
            this.cbAbmeldungen.Click += new System.EventHandler(this.cb_Click);
            // 
            // cbAnmeldungen
            // 
            this.cbAnmeldungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAnmeldungen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAnmeldungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnmeldungen.Location = new System.Drawing.Point(813, 96);
            this.cbAnmeldungen.Name = "cbAnmeldungen";
            this.cbAnmeldungen.Size = new System.Drawing.Size(183, 46);
            this.cbAnmeldungen.TabIndex = 10;
            this.cbAnmeldungen.Text = "Anmeldungen";
            this.cbAnmeldungen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnmeldungen.UseVisualStyleBackColor = true;
            this.cbAnmeldungen.Click += new System.EventHandler(this.cb_Click);
            // 
            // txtSuche
            // 
            this.txtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuche.Location = new System.Drawing.Point(12, 64);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(365, 26);
            this.txtSuche.TabIndex = 12;
            this.txtSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuche_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(813, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Verlauf schließen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryFenster
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.cbAnmeldungen);
            this.Controls.Add(this.cbAbmeldungen);
            this.Controls.Add(this.cbAlle);
            this.Controls.Add(this.cbHeute);
            this.Controls.Add(this.cbAlleZeiten);
            this.Controls.Add(this.lvVerlauf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryFenster";
            this.ShowInTaskbar = false;
            this.Text = "Verlauf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HistoryFenster_Load);
            this.SizeChanged += new System.EventHandler(this.HistoryFenster_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVerlauf;
        private System.Windows.Forms.ColumnHeader chDatum;
        private System.Windows.Forms.ColumnHeader chUhrzeit;
        private System.Windows.Forms.ColumnHeader chTeilnehmer;
        private System.Windows.Forms.ColumnHeader chAktion;
        private System.Windows.Forms.ColumnHeader chTeamer;
        private System.Windows.Forms.CheckBox cbAlleZeiten;
        private System.Windows.Forms.CheckBox cbHeute;
        private System.Windows.Forms.CheckBox cbAlle;
        private System.Windows.Forms.CheckBox cbAbmeldungen;
        private System.Windows.Forms.CheckBox cbAnmeldungen;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Button button1;
    }
}