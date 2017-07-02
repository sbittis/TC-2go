namespace TCAbmeldung2.GUI
{
    partial class InfobeamerFenster
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
            this.cbInfobeamer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZielpfad = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbInfobeamer
            // 
            this.cbInfobeamer.AutoSize = true;
            this.cbInfobeamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInfobeamer.Location = new System.Drawing.Point(13, 13);
            this.cbInfobeamer.Name = "cbInfobeamer";
            this.cbInfobeamer.Size = new System.Drawing.Size(631, 29);
            this.cbInfobeamer.TabIndex = 0;
            this.cbInfobeamer.Text = "Anzahl der abgemeldeten Teilnehmer an den Infobeamer übertragen";
            this.cbInfobeamer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ziel:";
            // 
            // txtZielpfad
            // 
            this.txtZielpfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZielpfad.Location = new System.Drawing.Point(67, 58);
            this.txtZielpfad.Name = "txtZielpfad";
            this.txtZielpfad.Size = new System.Drawing.Size(571, 30);
            this.txtZielpfad.TabIndex = 3;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(397, 107);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(241, 39);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // InfobeamerFenster
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 158);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtZielpfad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbInfobeamer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfobeamerFenster";
            this.Text = "Verbindung zum Info-Beamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbInfobeamer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZielpfad;
        private System.Windows.Forms.Button btOk;
    }
}