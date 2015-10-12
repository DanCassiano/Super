namespace Super
{
    partial class valvula
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
            this.ptValvula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptValvula)).BeginInit();
            this.SuspendLayout();
            // 
            // ptValvula
            // 
            this.ptValvula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptValvula.Image = global::Super.Properties.Resources.valvula_off;
            this.ptValvula.Location = new System.Drawing.Point(0, 0);
            this.ptValvula.Name = "ptValvula";
            this.ptValvula.Size = new System.Drawing.Size(32, 44);
            this.ptValvula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptValvula.TabIndex = 0;
            this.ptValvula.TabStop = false;
            // 
            // valvula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptValvula);
            this.Name = "valvula";
            this.Size = new System.Drawing.Size(32, 44);
            this.Load += new System.EventHandler(this.valvula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptValvula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptValvula;
    }
}
