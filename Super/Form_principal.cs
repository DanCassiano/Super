using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Super
{
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();

        }

        private void moagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_moagem();
            f.MdiParent = this;
            f.Show();
        }

        private void pesagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_pesagem();
            f.MdiParent = this;
            f.Show();
        }

        private void galao_agua1_Load(object sender, EventArgs e)
        {

        }

        private void painel_botoes1_Load(object sender, EventArgs e)
        {
           
        }

        private void form_principal_Load(object sender, EventArgs e)
        {
            painelBrasagem.btnOnOF.Click +=new EventHandler(ligaMotorBrasagem);
            painelFervura.btnOnOF.Click += new EventHandler(ligaMotorFervura);
            painelBonbaAgua.btnOnOF.Click += new EventHandler(LigaBombaAgua);
            painelValvulaBrasagem.btnOnOF.Click += new EventHandler(AcionaValvulaBrassagem);
            painelValvulaFervura.btnOnOF.Click += new EventHandler(AcionaValvulaFervura);
        }

        public void AcionaValvulaFervura(object sender, EventArgs e)
        {
            bool status = !valvula3.StatusDaValvula;
            valvula3.StatusDaValvula = status;
            cano_simples6.TemLiguido = status;
            joelho4.Status = status;
        }

        public void AcionaValvulaBrassagem(object sender, EventArgs e)
        {
            bool status = !valvulaBrasagem.StatusDaValvula;
            valvulaBrasagem.StatusDaValvula = status;
            
            joelho3.Status = status;            
            cano_simples5.TemLiguido = status;
        }

        public void LigaBombaAgua(object sender, EventArgs e)
        {
            bool status = !valvulaAgua.StatusDaValvula;
            valvulaAgua.StatusDaValvula = status;

            jAgua.Status = status;
            cano1.TemLiguido = status;
            j2.Status = status;
            cano2.TemLiguido = status;
            joelho5.Status = status;
            cano_simples4.TemLiguido = status;
            cano_simples3.TemLiguido = status;

        }

        public void ligaMotorBrasagem(object sender, EventArgs e)
        {
            bool status = panelaBrasagem.LigatMotor;
            panelaBrasagem.LigatMotor = !status;
        }

        public void ligaMotorFervura(object sender, EventArgs e)
        {
            bool status = panelaFervura.LigatMotor;
            panelaFervura.LigatMotor = !status;
        }

        private void cano_simples3_Load(object sender, EventArgs e)
        {

        }

        private void painelBonbaAgua_Load(object sender, EventArgs e)
        {
            painelBonbaAgua.lblNomeComponente.Text = "Valvula geral de água";
        }

        private void painelValvulaBrasagem_Load(object sender, EventArgs e)
        {
            painelValvulaBrasagem.lblNomeComponente.Text = "Valvula água Brasagem";
        }

        private void painelValvulaFervura_Load(object sender, EventArgs e)
        {
            painelValvulaFervura.lblNomeComponente.Text = "Valvula água Fervura";
        }
    }
}
