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
    public partial class valvula : UserControl
    {
        private bool status;
        private string tipo;
        public valvula()
        {
            InitializeComponent();
            status = false;
            tipo = "vertical";
        }

        public string Posicao
        {
            set { 
                tipo = value;

                if (status)
                {
                    if (tipo == "vertical")
                        ptValvula.Image = Super.Properties.Resources.valvula_on;
                    else
                        ptValvula.Image = Super.Properties.Resources.valvula_on_horizontal;
                        
                }
                else
                {
                    if (tipo == "vertical")
                        ptValvula.Image = Super.Properties.Resources.valvula_off;
                    else
                        ptValvula.Image = Super.Properties.Resources.valvula_off_horizontal;
                        
                }
            }
            get { return tipo; }
        }

        public bool StatusDaValvula
        {
            set {

                status = value;

                if (status)
                {
                    if (tipo == "vertical")
                        ptValvula.Image = Super.Properties.Resources.valvula_on;
                    else
                        ptValvula.Image = Super.Properties.Resources.valvula_on_horizontal;

                }
                else
                {
                    if (tipo == "vertical")
                        ptValvula.Image = Super.Properties.Resources.valvula_off;
                    else
                        ptValvula.Image = Super.Properties.Resources.valvula_off_horizontal;

                }
            }
            get { return status; }
        }

        private void valvula_Load(object sender, EventArgs e)
        {

        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x20;
        //        return cp;
        //    }
        //}

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //}

        private void valvula_Paint(object sender, PaintEventArgs e)
        {
            //OnPaintBackground(e);
        }
    }
}
