using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Super
{
    public partial class panela : UserControl
    {
        private bool statusMotorPanela;
        public panela()
        {
            InitializeComponent();
            statusMotorPanela = false;
        }

        
        public bool LigatMotor
        {
            get { return statusMotorPanela; }
            set { 
                statusMotorPanela = value;
                if (value == true)
                    picBoxMotor.Image = global::Super.Properties.Resources.motor_on;
                else
                    picBoxMotor.Image = global::Super.Properties.Resources.motor_off;
                    
            }
        }

        public string labelPanela
        {
            get { return lblPanela.Text; }
            set { lblPanela.Text = value;}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panela_Load(object sender, EventArgs e)
        {

        }

        private void lblPanela_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
    }
}
