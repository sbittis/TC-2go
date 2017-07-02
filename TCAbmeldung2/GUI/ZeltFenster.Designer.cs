namespace TCAbmeldung2.GUI
{
    partial class ZeltFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeltFenster));
            this.lbTeamer = new System.Windows.Forms.Label();
            this.lbTeilnehmer = new System.Windows.Forms.Label();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTeamer
            // 
            this.lbTeamer.AutoSize = true;
            this.lbTeamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamer.Location = new System.Drawing.Point(18, 46);
            this.lbTeamer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeamer.Name = "lbTeamer";
            this.lbTeamer.Size = new System.Drawing.Size(251, 47);
            this.lbTeamer.TabIndex = 0;
            this.lbTeamer.Text = "Zeltteamer: ";
            // 
            // lbTeilnehmer
            // 
            this.lbTeilnehmer.AutoSize = true;
            this.lbTeilnehmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeilnehmer.Location = new System.Drawing.Point(18, 149);
            this.lbTeilnehmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeilnehmer.Name = "lbTeilnehmer";
            this.lbTeilnehmer.Size = new System.Drawing.Size(197, 40);
            this.lbTeilnehmer.TabIndex = 1;
            this.lbTeilnehmer.Text = "Teilnehmer";
            // 
            // btSchliessen
            // 
            this.btSchliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSchliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(730, 698);
            this.btSchliessen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(354, 148);
            this.btSchliessen.TabIndex = 2;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // ZeltFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 865);
            this.Controls.Add(this.btSchliessen);
            this.Controls.Add(this.lbTeilnehmer);
            this.Controls.Add(this.lbTeamer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZeltFenster";
            this.ShowInTaskbar = false;
            this.Text = "ZeltFenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTeamer;
        private System.Windows.Forms.Label lbTeilnehmer;
        private System.Windows.Forms.Button btSchliessen;
    }
}