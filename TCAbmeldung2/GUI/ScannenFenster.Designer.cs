namespace TCAbmeldung2.GUI
{
    partial class ScannenFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannenFenster));
            this.lbScannen = new System.Windows.Forms.Label();
            this.btManuell = new System.Windows.Forms.Button();
            this.btFertig = new System.Windows.Forms.Button();
            this.lvAuswahl = new System.Windows.Forms.ListView();
            this.chEntfernen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZelt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtScan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbScannen
            // 
            this.lbScannen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScannen.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScannen.ForeColor = System.Drawing.Color.Firebrick;
            this.lbScannen.Location = new System.Drawing.Point(12, 9);
            this.lbScannen.Name = "lbScannen";
            this.lbScannen.Size = new System.Drawing.Size(935, 78);
            this.lbScannen.TabIndex = 0;
            this.lbScannen.Text = "Bitte Teilnehmer scannen";
            this.lbScannen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbScannen.Click += new System.EventHandler(this.lbScannen_Click);
            // 
            // btManuell
            // 
            this.btManuell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btManuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManuell.Location = new System.Drawing.Point(12, 579);
            this.btManuell.Name = "btManuell";
            this.btManuell.Size = new System.Drawing.Size(426, 108);
            this.btManuell.TabIndex = 1;
            this.btManuell.Text = "Manuelle Eingabe";
            this.btManuell.UseVisualStyleBackColor = true;
            this.btManuell.Click += new System.EventHandler(this.btManuell_Click);
            // 
            // btFertig
            // 
            this.btFertig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFertig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btFertig.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFertig.Location = new System.Drawing.Point(444, 579);
            this.btFertig.Name = "btFertig";
            this.btFertig.Size = new System.Drawing.Size(503, 108);
            this.btFertig.TabIndex = 2;
            this.btFertig.Text = "Fertig";
            this.btFertig.UseVisualStyleBackColor = true;
            this.btFertig.Click += new System.EventHandler(this.btFertig_Click);
            // 
            // lvAuswahl
            // 
            this.lvAuswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAuswahl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEntfernen,
            this.chNachname,
            this.chVorname,
            this.chZelt});
            this.lvAuswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAuswahl.Location = new System.Drawing.Point(12, 90);
            this.lvAuswahl.Name = "lvAuswahl";
            this.lvAuswahl.Size = new System.Drawing.Size(935, 483);
            this.lvAuswahl.TabIndex = 3;
            this.lvAuswahl.UseCompatibleStateImageBehavior = false;
            this.lvAuswahl.View = System.Windows.Forms.View.Details;
            this.lvAuswahl.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAuswahl_ColumnClick);
            this.lvAuswahl.Click += new System.EventHandler(this.lvAuswahl_Click);
            this.lvAuswahl.Enter += new System.EventHandler(this.lvAuswahl_Enter);
            // 
            // chEntfernen
            // 
            this.chEntfernen.Text = "X";
            this.chEntfernen.Width = 38;
            // 
            // chNachname
            // 
            this.chNachname.Text = "Nachname";
            this.chNachname.Width = 176;
            // 
            // chVorname
            // 
            this.chVorname.Text = "Vorname";
            this.chVorname.Width = 297;
            // 
            // chZelt
            // 
            this.chZelt.Text = "Zelt";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(730, 64);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(217, 20);
            this.txtScan.TabIndex = 4;
            this.txtScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScan_KeyDown);
            // 
            // ScannenFenster
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 699);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.lvAuswahl);
            this.Controls.Add(this.btFertig);
            this.Controls.Add(this.btManuell);
            this.Controls.Add(this.lbScannen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScannenFenster";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scannen...";
            this.Load += new System.EventHandler(this.ScannenFenster_Load);
            this.SizeChanged += new System.EventHandler(this.ScannenFenster_SizeChanged);
            this.Click += new System.EventHandler(this.ScannenFenster_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScannen;
        private System.Windows.Forms.Button btManuell;
        private System.Windows.Forms.Button btFertig;
        private System.Windows.Forms.ListView lvAuswahl;
        private System.Windows.Forms.ColumnHeader chEntfernen;
        private System.Windows.Forms.ColumnHeader chNachname;
        private System.Windows.Forms.ColumnHeader chVorname;
        private System.Windows.Forms.ColumnHeader chZelt;
        private System.Windows.Forms.TextBox txtScan;
    }
}