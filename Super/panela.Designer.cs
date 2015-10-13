namespace Super
{
    partial class panela
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
            this.lblPanela = new System.Windows.Forms.Label();
            this.picBoxMotor = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPanela
            // 
            this.lblPanela.BackColor = System.Drawing.Color.Transparent;
            this.lblPanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPanela.Location = new System.Drawing.Point(22, 89);
            this.lblPanela.Name = "lblPanela";
            this.lblPanela.Size = new System.Drawing.Size(74, 37);
            this.lblPanela.TabIndex = 5;
            this.lblPanela.Text = "Panela";
            this.lblPanela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPanela.UseCompatibleTextRendering = true;
            this.lblPanela.Click += new System.EventHandler(this.lblPanela_Click);
            // 
            // picBoxMotor
            // 
            this.picBoxMotor.Image = global::Super.Properties.Resources.motor_off;
            this.picBoxMotor.Location = new System.Drawing.Point(33, 10);
            this.picBoxMotor.Name = "picBoxMotor";
            this.picBoxMotor.Size = new System.Drawing.Size(64, 45);
            this.picBoxMotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMotor.TabIndex = 3;
            this.picBoxMotor.TabStop = false;
            this.picBoxMotor.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Super.Properties.Resources.panela;
            this.pictureBox3.Location = new System.Drawing.Point(3, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPanela);
            this.Controls.Add(this.picBoxMotor);
            this.Controls.Add(this.pictureBox3);
            this.Name = "panela";
            this.Size = new System.Drawing.Size(115, 159);
            this.Load += new System.EventHandler(this.panela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.Label lblPanela;
        internal System.Windows.Forms.PictureBox picBoxMotor;
    }
}
