namespace Super
{
    partial class painel_botoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeComponente = new System.Windows.Forms.Label();
            this.btnOnOF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNomeComponente);
            this.panel1.Controls.Add(this.btnOnOF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 99);
            this.panel1.TabIndex = 0;
            // 
            // lblNomeComponente
            // 
            this.lblNomeComponente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeComponente.Location = new System.Drawing.Point(3, 55);
            this.lblNomeComponente.Name = "lblNomeComponente";
            this.lblNomeComponente.Size = new System.Drawing.Size(141, 42);
            this.lblNomeComponente.TabIndex = 1;
            this.lblNomeComponente.Text = "Componente";
            this.lblNomeComponente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnOF
            // 
            this.btnOnOF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnOF.BackColor = System.Drawing.Color.Yellow;
            this.btnOnOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOF.Location = new System.Drawing.Point(2, 3);
            this.btnOnOF.Name = "btnOnOF";
            this.btnOnOF.Size = new System.Drawing.Size(142, 49);
            this.btnOnOF.TabIndex = 0;
            this.btnOnOF.Text = "Ligar";
            this.btnOnOF.UseVisualStyleBackColor = false;
            this.btnOnOF.Click += new System.EventHandler(this.btnOnOF_Click);
            // 
            // painel_botoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "painel_botoes";
            this.Size = new System.Drawing.Size(150, 99);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnOnOF;
        internal System.Windows.Forms.Label lblNomeComponente;
    }
}
