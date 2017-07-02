namespace TCAbmeldung2.GUI
{
    partial class ManuellFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuellFenster));
            this.lbManuell = new System.Windows.Forms.Label();
            this.lvManuell = new System.Windows.Forms.ListView();
            this.chAuswahl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZelt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lbSuche = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbManuell
            // 
            this.lbManuell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManuell.ForeColor = System.Drawing.Color.Firebrick;
            this.lbManuell.Location = new System.Drawing.Point(12, 9);
            this.lbManuell.Name = "lbManuell";
            this.lbManuell.Size = new System.Drawing.Size(935, 78);
            this.lbManuell.TabIndex = 1;
            this.lbManuell.Text = "Teilnehmer auswählen";
            this.lbManuell.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvManuell
            // 
            this.lvManuell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvManuell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAuswahl,
            this.chNachname,
            this.chVorname,
            this.chZelt});
            this.lvManuell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvManuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvManuell.FullRowSelect = true;
            this.lvManuell.Location = new System.Drawing.Point(12, 128);
            this.lvManuell.MultiSelect = false;
            this.lvManuell.Name = "lvManuell";
            this.lvManuell.Size = new System.Drawing.Size(935, 445);
            this.lvManuell.TabIndex = 4;
            this.lvManuell.UseCompatibleStateImageBehavior = false;
            this.lvManuell.View = System.Windows.Forms.View.Details;
            this.lvManuell.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvManuell_ItemChecked);
            this.lvManuell.Click += new System.EventHandler(this.lvManuell_Click);
            // 
            // chAuswahl
            // 
            this.chAuswahl.Text = "";
            this.chAuswahl.Width = 31;
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
            // txtSuche
            // 
            this.txtSuche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuche.Location = new System.Drawing.Point(231, 90);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(716, 26);
            this.txtSuche.TabIndex = 5;
            this.txtSuche.TextChanged += new System.EventHandler(this.txtSuche_TextChanged);
            // 
            // lbSuche
            // 
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(19, 93);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(206, 20);
            this.lbSuche.TabIndex = 6;
            this.lbSuche.Text = "Nach Teilnehmer suchen";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(12, 579);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(459, 108);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbbrechen.Location = new System.Drawing.Point(477, 579);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(470, 108);
            this.btAbbrechen.TabIndex = 8;
            this.btAbbrechen.Text = "Abbrechen";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            this.btAbbrechen.Click += new System.EventHandler(this.btAbbrechen_Click);
            // 
            // ManuellFenster
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 699);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.lvManuell);
            this.Controls.Add(this.lbManuell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManuellFenster";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuelle Eingabe";
            this.Load += new System.EventHandler(this.ManuellFenster_Load);
            this.SizeChanged += new System.EventHandler(this.ManuellFenster_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManuell;
        private System.Windows.Forms.ListView lvManuell;
        private System.Windows.Forms.ColumnHeader chAuswahl;
        private System.Windows.Forms.ColumnHeader chNachname;
        private System.Windows.Forms.ColumnHeader chVorname;
        private System.Windows.Forms.ColumnHeader chZelt;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lbSuche;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAbbrechen;
    }
}