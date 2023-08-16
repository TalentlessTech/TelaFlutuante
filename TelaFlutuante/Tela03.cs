using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaFlutuante
{
    public partial class Tela03 : Form
    {
         public Tela03()
        {
            InitializeComponent();
        }

        private void Tela03_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormLocation.saveScreenLocationConfig)
            {
                FormLocation.SaveFormLocation(sender, e);
            }
        }
    }
}
