using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaFlutuante
{
    public partial class TelaFlutuante : Form
    {
        public bool saveScreenLocation = false;
        public TelaFlutuante()
        {
            InitializeComponent();
        }

        public TelaFlutuante(string text)
        {
            InitializeComponent();
            lblMsg.Text = text;
            this.Text = text;
            this.Name = text;
        }

        public TelaFlutuante(string text, bool SaveLocation)
        {
            InitializeComponent();
            lblMsg.Text = text;
            this.Text = text;
            this.Name = text;
        }

        private void TelaFlutuante_Load(object sender, EventArgs e)
        {
          

        }

        private void TelaFlutuante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveScreenLocation)
            {
                FormLocation.SaveFormLocation(sender, e);
            }
        }

        
    }
}
