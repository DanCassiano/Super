namespace Super
{
    partial class bomba
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
            this.picBoxBomba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBomba)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBomba
            // 
            this.picBoxBomba.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_right_botom;
            this.picBoxBomba.Location = new System.Drawing.Point(0, 0);
            this.picBoxBomba.Name = "picBoxBomba";
            this.picBoxBomba.Size = new System.Drawing.Size(115, 87);
            this.picBoxBomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxBomba.TabIndex = 0;
            this.picBoxBomba.TabStop = false;
            // 
            // bomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxBomba);
            this.Name = "bomba";
            this.Size = new System.Drawing.Size(115, 87);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBomba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox picBoxBomba;

    }
}
