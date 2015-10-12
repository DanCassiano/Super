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
    public partial class painel_botoes : UserControl
    {
        public painel_botoes()
        {
            InitializeComponent();
        }

        private string nomeComponente;

        public string NomeComponente
        {
            get { return nomeComponente; }
            set { 
                    lblNomeComponente.Text = value;
                    nomeComponente = value;                    
            }
        }

        private bool status = true ;
        private void btnOnOF_Click(object sender, EventArgs e)
        {
            status = !status;

            if (status)
            {
                btnOnOF.Text = "Ligar";
                btnOnOF.BackColor = Color.Yellow;
            }
            else
            {
                btnOnOF.Text = "Desligar";
                btnOnOF.BackColor = Color.Red;
            }
        }
    }
}
