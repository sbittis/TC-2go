namespace TCAbmeldung2.GUI
{
    partial class LoadBox
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
            this.lbLoadBox = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbLoadBox
            // 
            this.lbLoadBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadBox.Location = new System.Drawing.Point(13, 13);
            this.lbLoadBox.Name = "lbLoadBox";
            this.lbLoadBox.Size = new System.Drawing.Size(367, 43);
            this.lbLoadBox.TabIndex = 0;
            this.lbLoadBox.Text = "Information";
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(17, 68);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(363, 23);
            this.pbLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoad.TabIndex = 1;
            // 
            // LoadBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 127);
            this.ControlBox = false;
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.lbLoadBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadBox";
            this.ShowInTaskbar = false;
            this.Text = "Bitte warten...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoadBox;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}