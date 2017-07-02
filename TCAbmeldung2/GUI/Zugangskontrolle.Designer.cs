namespace TCAbmeldung2.GUI
{
    partial class Zugangskontrolle
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
            this.lbPasswort = new System.Windows.Forms.Label();
            this.lbTitel = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPasswort
            // 
            this.lbPasswort.AutoSize = true;
            this.lbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswort.Location = new System.Drawing.Point(12, 83);
            this.lbPasswort.Name = "lbPasswort";
            this.lbPasswort.Size = new System.Drawing.Size(112, 29);
            this.lbPasswort.TabIndex = 0;
            this.lbPasswort.Text = "Passwort";
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.Location = new System.Drawing.Point(146, 9);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(327, 46);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Sani-Verwaltung";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(154, 80);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(431, 35);
            this.txtPasswort.TabIndex = 2;
            this.txtPasswort.UseSystemPasswordChar = true;
            this.txtPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswort_KeyDown);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(17, 137);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(281, 101);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbbrechen.Location = new System.Drawing.Point(304, 137);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(281, 101);
            this.btAbbrechen.TabIndex = 4;
            this.btAbbrechen.Text = "Zurück";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            this.btAbbrechen.Click += new System.EventHandler(this.btAbbrechen_Click);
            // 
            // Zugangskontrolle
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.lbPasswort);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zugangskontrolle";
            this.ShowInTaskbar = false;
            this.Text = "Authentifizieren...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPasswort;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btAbbrechen;
    }
}