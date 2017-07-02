namespace TCAbmeldung2.GUI
{
    partial class Kommentar
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
            this.lbKommentar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btLoeschen = new System.Windows.Forms.Button();
            this.lbHinweis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKommentar
            // 
            this.lbKommentar.AutoSize = true;
            this.lbKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKommentar.Location = new System.Drawing.Point(18, 74);
            this.lbKommentar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKommentar.Name = "lbKommentar";
            this.lbKommentar.Size = new System.Drawing.Size(202, 37);
            this.lbKommentar.TabIndex = 0;
            this.lbKommentar.Text = "Kommentar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(234, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 43);
            this.textBox1.TabIndex = 1;
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbbrechen.Location = new System.Drawing.Point(466, 126);
            this.btAbbrechen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(432, 98);
            this.btAbbrechen.TabIndex = 2;
            this.btAbbrechen.Text = "Abbrechen";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(18, 126);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(432, 98);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btLoeschen
            // 
            this.btLoeschen.BackgroundImage = global::TCAbmeldung2.Properties.Resources.CloseX;
            this.btLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLoeschen.Location = new System.Drawing.Point(854, 69);
            this.btLoeschen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoeschen.Name = "btLoeschen";
            this.btLoeschen.Size = new System.Drawing.Size(45, 48);
            this.btLoeschen.TabIndex = 4;
            this.btLoeschen.UseVisualStyleBackColor = true;
            this.btLoeschen.Click += new System.EventHandler(this.btLoeschen_Click);
            // 
            // lbHinweis
            // 
            this.lbHinweis.AutoSize = true;
            this.lbHinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinweis.ForeColor = System.Drawing.Color.Red;
            this.lbHinweis.Location = new System.Drawing.Point(18, 13);
            this.lbHinweis.Name = "lbHinweis";
            this.lbHinweis.Size = new System.Drawing.Size(871, 39);
            this.lbHinweis.TabIndex = 5;
            this.lbHinweis.Text = "Wichtig: Ein Kommentar darf KEIN Komma enthalten!";
            // 
            // Kommentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 238);
            this.ControlBox = false;
            this.Controls.Add(this.lbHinweis);
            this.Controls.Add(this.btLoeschen);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbKommentar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kommentar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kommentar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKommentar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAbbrechen;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btLoeschen;
        private System.Windows.Forms.Label lbHinweis;
    }
}