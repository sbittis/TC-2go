namespace TCAbmeldung2.GUI
{
    partial class TnNameBox
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
            this.txtTnId = new System.Windows.Forms.TextBox();
            this.lbTnScannen = new System.Windows.Forms.Label();
            this.btZurueck = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTnId
            // 
            this.txtTnId.Location = new System.Drawing.Point(515, 9);
            this.txtTnId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTnId.Name = "txtTnId";
            this.txtTnId.Size = new System.Drawing.Size(121, 26);
            this.txtTnId.TabIndex = 10;
            this.txtTnId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTnId_KeyDown);
            // 
            // lbTnScannen
            // 
            this.lbTnScannen.AutoSize = true;
            this.lbTnScannen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTnScannen.ForeColor = System.Drawing.Color.Red;
            this.lbTnScannen.Location = new System.Drawing.Point(13, 9);
            this.lbTnScannen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTnScannen.Name = "lbTnScannen";
            this.lbTnScannen.Size = new System.Drawing.Size(520, 55);
            this.lbTnScannen.TabIndex = 9;
            this.lbTnScannen.Text = "Teilnehmer scannen...";
            // 
            // btZurueck
            // 
            this.btZurueck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZurueck.Location = new System.Drawing.Point(389, 157);
            this.btZurueck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btZurueck.Name = "btZurueck";
            this.btZurueck.Size = new System.Drawing.Size(249, 126);
            this.btZurueck.TabIndex = 8;
            this.btZurueck.Text = "Zurück";
            this.btZurueck.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Enabled = false;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(176, 157);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(204, 126);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(176, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 35);
            this.txtName.TabIndex = 6;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(84, 110);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 29);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "erfasst";
            // 
            // TnNameBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 292);
            this.ControlBox = false;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtTnId);
            this.Controls.Add(this.lbTnScannen);
            this.Controls.Add(this.btZurueck);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtName);
            this.Name = "TnNameBox";
            this.ShowInTaskbar = false;
            this.Text = "Teilnehmer...";
            this.Load += new System.EventHandler(this.TnNameBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTnId;
        private System.Windows.Forms.Label lbTnScannen;
        private System.Windows.Forms.Button btZurueck;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
    }
}