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
    public partial class Cano_simples : UserControl
    {
        private bool temliguido;
        private bool posicao;
        public Cano_simples()
        {
            InitializeComponent();
            temliguido = false;
            posicao = false;
        }

        public bool PosicaoCano
        {
            set {
                posicao = value;

                if (value) //vertical
                {
                    if (temliguido) //com liguido
                        picBoxCano.Image = Super.Properties.Resources.cano_agua;
                    else //sem liguido
                        picBoxCano.Image = Super.Properties.Resources.cano_vazio;
                }
                else //horizontal
                {
                    if (temliguido) //com liguido
                        picBoxCano.Image = Super.Properties.Resources.cano_agua___Copia;
                    else // sem liguido
                        picBoxCano.Image = Super.Properties.Resources.cano_vazio___Copia;
                }
            }
            get { return posicao; }
        }

        public bool TemLiguido
        {
            set {
                if (value)//tem liguido
                {
                    if (posicao) //vertical
                        picBoxCano.Image = Super.Properties.Resources.cano_agua;
                    else //horizontal
                        picBoxCano.Image = Super.Properties.Resources.cano_agua___Copia;
                }
                else
                {
                    //nao tem linguido
                     if( posicao ) //vertical
                        picBoxCano.Image = Super.Properties.Resources.cano_vazio;
                     else //horizontal
                         picBoxCano.Image = Super.Properties.Resources.cano_vazio___Copia;
                }
                temliguido = value;
            }
            get { return temliguido; }
        }

        private void Cano_simples_Load(object sender, EventArgs e)
        {

        }
    }
}
