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
    public partial class bomba : UserControl
    {
        string posicaoBomba;
        bool statusBomba;
        public bomba()
        {
            InitializeComponent();
            posicaoBomba = "left-top";
            statusBomba = true;
        }

        public bool StatusDaBomba {
            get { return statusBomba; }
            set { statusBomba = value;

                PosicaoDaBomba = posicaoBomba;
            }
        }

        public string PosicaoDaBomba {
            get { return posicaoBomba; }
            set {
                posicaoBomba = value;

                if (value == "left-bottom")
                {
                    if( statusBomba )
                        picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_left_botom;
                    else
                        picBoxBomba.Image = global::Super.Properties.Resources.bomba_off_left_bottom;
                }
                else
                {
                    if (value == "left-top")
                    {
                        if (statusBomba)
                            picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_left;
                        else
                            picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_left;
                    }
                    else
                    {
                        if (value == "right-bottom")
                        {
                            if (statusBomba)
                                picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_right_botom;
                            else
                                picBoxBomba.Image = global::Super.Properties.Resources.bomba_off_right_bottom;
                        }
                        else
                        {
                            if (statusBomba)
                                picBoxBomba.Image = global::Super.Properties.Resources.bomba_on_right;
                            else
                                picBoxBomba.Image = global::Super.Properties.Resources.bomba_off_right;
                        }
                    }
                }
            }
        }
    }
}
