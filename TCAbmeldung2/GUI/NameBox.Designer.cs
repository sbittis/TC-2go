namespace TCAbmeldung2.GUI
{
    partial class NameBox
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btZurueck = new System.Windows.Forms.Button();
            this.lbTeamerScannen = new System.Windows.Forms.Label();
            this.txtTeamerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 76);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "gemeldet bei";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(118, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 26);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Enabled = false;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(118, 105);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(136, 82);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btZurueck
            // 
            this.btZurueck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZurueck.Location = new System.Drawing.Point(260, 105);
            this.btZurueck.Name = "btZurueck";
            this.btZurueck.Size = new System.Drawing.Size(166, 82);
            this.btZurueck.TabIndex = 3;
            this.btZurueck.Text = "Zurück";
            this.btZurueck.UseVisualStyleBackColor = true;
            // 
            // lbTeamerScannen
            // 
            this.lbTeamerScannen.AutoSize = true;
            this.lbTeamerScannen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamerScannen.ForeColor = System.Drawing.Color.Red;
            this.lbTeamerScannen.Location = new System.Drawing.Point(9, 9);
            this.lbTeamerScannen.Name = "lbTeamerScannen";
            this.lbTeamerScannen.Size = new System.Drawing.Size(301, 37);
            this.lbTeamerScannen.TabIndex = 4;
            this.lbTeamerScannen.Text = "Teamer scannen...";
            // 
            // txtTeamerId
            // 
            this.txtTeamerId.Location = new System.Drawing.Point(344, 9);
            this.txtTeamerId.Name = "txtTeamerId";
            this.txtTeamerId.Size = new System.Drawing.Size(82, 20);
            this.txtTeamerId.TabIndex = 5;
            this.txtTeamerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeamerId_KeyDown);
            // 
            // NameBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 192);
            this.ControlBox = false;
            this.Controls.Add(this.txtTeamerId);
            this.Controls.Add(this.lbTeamerScannen);
            this.Controls.Add(this.btZurueck);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teamer...";
            this.Load += new System.EventHandler(this.NameBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btZurueck;
        private System.Windows.Forms.Label lbTeamerScannen;
        private System.Windows.Forms.TextBox txtTeamerId;
    }
}