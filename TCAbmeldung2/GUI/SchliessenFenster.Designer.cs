namespace TCAbmeldung2.GUI
{
    partial class SchliessenFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchliessenFenster));
            this.lbBeenden = new System.Windows.Forms.Label();
            this.btJa = new System.Windows.Forms.Button();
            this.btNein = new System.Windows.Forms.Button();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBeenden
            // 
            this.lbBeenden.AutoSize = true;
            this.lbBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeenden.Location = new System.Drawing.Point(12, 18);
            this.lbBeenden.Name = "lbBeenden";
            this.lbBeenden.Size = new System.Drawing.Size(524, 20);
            this.lbBeenden.TabIndex = 0;
            this.lbBeenden.Text = "Möchten Sie die Teilnehmerdaten vorm Beenden noch einmal speichern?";
            // 
            // btJa
            // 
            this.btJa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJa.Location = new System.Drawing.Point(16, 55);
            this.btJa.Name = "btJa";
            this.btJa.Size = new System.Drawing.Size(166, 48);
            this.btJa.TabIndex = 1;
            this.btJa.Text = "Ja (empfohlen)";
            this.btJa.UseVisualStyleBackColor = true;
            // 
            // btNein
            // 
            this.btNein.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btNein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNein.Location = new System.Drawing.Point(188, 55);
            this.btNein.Name = "btNein";
            this.btNein.Size = new System.Drawing.Size(166, 48);
            this.btNein.TabIndex = 2;
            this.btNein.Text = "Nein";
            this.btNein.UseVisualStyleBackColor = true;
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbbrechen.Location = new System.Drawing.Point(360, 55);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(166, 48);
            this.btAbbrechen.TabIndex = 3;
            this.btAbbrechen.Text = "Nicht beenden";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            // 
            // SchliessenFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 113);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.btNein);
            this.Controls.Add(this.btJa);
            this.Controls.Add(this.lbBeenden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchliessenFenster";
            this.Text = "Beenden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBeenden;
        private System.Windows.Forms.Button btJa;
        private System.Windows.Forms.Button btNein;
        private System.Windows.Forms.Button btAbbrechen;
    }
}