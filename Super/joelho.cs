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
    public partial class joelho : UserControl
    {
        string posicao;
        bool status;
        public joelho()
        {
            InitializeComponent();
            posicao = "left-top";
            status = false;
        }

        public bool Status
        {
            get { return status; }
            set {

                status = value;
                Posicao = posicao;
            }
        }

        public string Posicao
        {
            get { return posicao; }
            set
            {
                posicao = value;

                if (value == "left-top")
                {
                    if (status)
                    {
                        ptJoelho.Image = Super.Properties.Resources.joelho_left_top_agua;
                    }
                    else
                        ptJoelho.Image = Super.Properties.Resources.joelho_left_top_vazio;
                }
                else
                {
                    if (value == "left-bottom")
                    {
                        if (status)
                            ptJoelho.Image = Super.Properties.Resources.joelho_left_bottom_agua;
                        else
                            ptJoelho.Image = Super.Properties.Resources.joelho_left_bottomvazio;
                    }
                    else
                    {
                        if (value == "right-top")
                        {
                            if (status)
                                ptJoelho.Image = Super.Properties.Resources.joelho_right_top_agua;
                            else
                                ptJoelho.Image = Super.Properties.Resources.joelho_right_top_vazio;
                        }
                        else
                        {
                            if (status)
                                ptJoelho.Image = Super.Properties.Resources.joelho_right_bottom_agua;
                            else
                                ptJoelho.Image = Super.Properties.Resources.joelho_right_bottom_vazio;
                        }
                    }
                }
            }
        }

        private void joelho_Load(object sender, EventArgs e)
        {

        }
    }
}
