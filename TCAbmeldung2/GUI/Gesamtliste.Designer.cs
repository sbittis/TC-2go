namespace TCAbmeldung2.GUI
{
    partial class Gesamtliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gesamtliste));
            this.lbSuche = new System.Windows.Forms.Label();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.Label();
            this.lvListe = new System.Windows.Forms.ListView();
            this.chLeer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZelt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGemeinde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSuche
            // 
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(12, 62);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(184, 20);
            this.lbSuche.TabIndex = 10;
            this.lbSuche.Text = "Nach Teilnehmer suchen";
            // 
            // txtSuche
            // 
            this.txtSuche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuche.Location = new System.Drawing.Point(202, 59);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(738, 26);
            this.txtSuche.TabIndex = 9;
            this.txtSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuche_KeyDown);
            // 
            // lbListe
            // 
            this.lbListe.AutoSize = true;
            this.lbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListe.Location = new System.Drawing.Point(12, 9);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(296, 44);
            this.lbListe.TabIndex = 8;
            this.lbListe.Text = "Teilnehmerliste";
            // 
            // lvListe
            // 
            this.lvListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLeer,
            this.chId,
            this.chNachname,
            this.chVorname,
            this.chZelt,
            this.chGemeinde});
            this.lvListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListe.Location = new System.Drawing.Point(12, 89);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(928, 481);
            this.lvListe.TabIndex = 7;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            this.lvListe.View = System.Windows.Forms.View.Details;
            this.lvListe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvListe_ColumnClick);
            // 
            // chLeer
            // 
            this.chLeer.Text = "";
            this.chLeer.Width = 20;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.chZelt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chGemeinde
            // 
            this.chGemeinde.Text = "Gemeinde";
            this.chGemeinde.Width = 120;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSchliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(651, 9);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(289, 44);
            this.btSchliessen.TabIndex = 11;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // Gesamtliste
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 577);
            this.Controls.Add(this.btSchliessen);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.lvListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gesamtliste";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gesamtliste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSuche;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lbListe;
        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNachname;
        private System.Windows.Forms.ColumnHeader chVorname;
        private System.Windows.Forms.ColumnHeader chZelt;
        private System.Windows.Forms.ColumnHeader chGemeinde;
        private System.Windows.Forms.ColumnHeader chLeer;
        private System.Windows.Forms.Button btSchliessen;
    }
}