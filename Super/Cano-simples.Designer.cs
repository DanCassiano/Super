namespace Super
{
    partial class Cano_simples
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
            this.picBoxCano = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCano)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCano
            // 
            this.picBoxCano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxCano.Image = global::Super.Properties.Resources.cano_vazio___Copia;
            this.picBoxCano.Location = new System.Drawing.Point(0, 0);
            this.picBoxCano.Name = "picBoxCano";
            this.picBoxCano.Size = new System.Drawing.Size(44, 477);
            this.picBoxCano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCano.TabIndex = 0;
            this.picBoxCano.TabStop = false;
            // 
            // Cano_simples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxCano);
            this.Name = "Cano_simples";
            this.Size = new System.Drawing.Size(44, 477);
            this.Load += new System.EventHandler(this.Cano_simples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCano;
    }
}
