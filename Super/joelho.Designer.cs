namespace Super
{
    partial class joelho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptJoelho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptJoelho)).BeginInit();
            this.SuspendLayout();
            // 
            // ptJoelho
            // 
            this.ptJoelho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptJoelho.Image = global::Super.Properties.Resources.joelho_left_bottomvazio;
            this.ptJoelho.Location = new System.Drawing.Point(0, 0);
            this.ptJoelho.Name = "ptJoelho";
            this.ptJoelho.Size = new System.Drawing.Size(70, 52);
            this.ptJoelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptJoelho.TabIndex = 0;
            this.ptJoelho.TabStop = false;
            // 
            // joelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ptJoelho);
            this.Name = "joelho";
            this.Size = new System.Drawing.Size(70, 52);
            this.Load += new System.EventHandler(this.joelho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptJoelho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptJoelho;
    }
}
