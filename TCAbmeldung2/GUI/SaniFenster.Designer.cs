namespace TCAbmeldung2.GUI
{
    partial class SaniFenster
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
            this.btNeu = new System.Windows.Forms.Button();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.lbSuche = new System.Windows.Forms.Label();
            this.lvBehandlungen = new System.Windows.Forms.ListView();
            this.chZeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbBehandlungDurch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btNeu
            // 
            this.btNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNeu.Location = new System.Drawing.Point(12, 12);
            this.btNeu.Name = "btNeu";
            this.btNeu.Size = new System.Drawing.Size(466, 126);
            this.btNeu.TabIndex = 0;
            this.btNeu.Text = "Neue Behandlung";
            this.btNeu.UseVisualStyleBackColor = true;
            this.btNeu.Click += new System.EventHandler(this.btNeu_Click);
            // 
            // txtSuche
            // 
            this.txtSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuche.Location = new System.Drawing.Point(798, 94);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(458, 44);
            this.txtSuche.TabIndex = 1;
            this.txtSuche.TextChanged += new System.EventHandler(this.txtSuche_TextChanged);
            // 
            // lbSuche
            // 
            this.lbSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuche.AutoSize = true;
            this.lbSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuche.Location = new System.Drawing.Point(685, 97);
            this.lbSuche.Name = "lbSuche";
            this.lbSuche.Size = new System.Drawing.Size(107, 37);
            this.lbSuche.TabIndex = 2;
            this.lbSuche.Text = "Suche";
            // 
            // lvBehandlungen
            // 
            this.lvBehandlungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBehandlungen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chZeit,
            this.chNachname,
            this.chVorname,
            this.chText});
            this.lvBehandlungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBehandlungen.FullRowSelect = true;
            this.lvBehandlungen.Location = new System.Drawing.Point(13, 145);
            this.lvBehandlungen.Name = "lvBehandlungen";
            this.lvBehandlungen.Size = new System.Drawing.Size(1243, 340);
            this.lvBehandlungen.TabIndex = 3;
            this.lvBehandlungen.UseCompatibleStateImageBehavior = false;
            this.lvBehandlungen.View = System.Windows.Forms.View.Details;
            this.lvBehandlungen.DoubleClick += new System.EventHandler(this.lvBehandlungen_DoubleClick);
            // 
            // chZeit
            // 
            this.chZeit.Text = "erfasst";
            this.chZeit.Width = 200;
            // 
            // chNachname
            // 
            this.chNachname.Text = "Nachname";
            this.chNachname.Width = 350;
            // 
            // chVorname
            // 
            this.chVorname.Text = "Vorname";
            this.chVorname.Width = 350;
            // 
            // chText
            // 
            this.chText.Text = "Text";
            this.chText.Width = 300;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::TCAbmeldung2.Properties.Resources.CloseX;
            this.pictureBox1.Location = new System.Drawing.Point(1180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "saniFile";
            // 
            // lbBehandlungDurch
            // 
            this.lbBehandlungDurch.AutoSize = true;
            this.lbBehandlungDurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBehandlungDurch.Location = new System.Drawing.Point(485, 13);
            this.lbBehandlungDurch.Name = "lbBehandlungDurch";
            this.lbBehandlungDurch.Size = new System.Drawing.Size(296, 37);
            this.lbBehandlungDurch.TabIndex = 5;
            this.lbBehandlungDurch.Text = "Behandlung durch: ";
            // 
            // SaniFenster
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 497);
            this.ControlBox = false;
            this.Controls.Add(this.lbBehandlungDurch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvBehandlungen);
            this.Controls.Add(this.lbSuche);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.btNeu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaniFenster";
            this.Text = "Behandlungs-Verwaltung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaniFenster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNeu;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label lbSuche;
        private System.Windows.Forms.ListView lvBehandlungen;
        private System.Windows.Forms.ColumnHeader chNachname;
        private System.Windows.Forms.ColumnHeader chZeit;
        private System.Windows.Forms.ColumnHeader chVorname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ColumnHeader chText;
        private System.Windows.Forms.Label lbBehandlungDurch;
    }
}