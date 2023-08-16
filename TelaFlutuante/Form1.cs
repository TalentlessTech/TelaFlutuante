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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            TelaFlutuante telaFlutuante = new TelaFlutuante(cmbTelas.SelectedItem.ToString());

            if (checkSaveConfig.Checked)
            {
                telaFlutuante.saveScreenLocation = true;

                int[] savedLocation = FormLocation.LoadFormLocationAndSize(this, cmbTelas.SelectedItem.ToString());

                telaFlutuante.StartPosition = FormStartPosition.Manual;
                telaFlutuante.Location = new Point(savedLocation[0], savedLocation[1]);
                telaFlutuante.Size = new Size(savedLocation[2], savedLocation[3]);
            }
            telaFlutuante.Show();
        }

        private void btnTela01_Click(object sender, EventArgs e)
        {
            Tela01 tela01 = new Tela01();

            if (FormLocation.saveScreenLocationConfig)
            {
                int[] savedLocation = FormLocation.LoadFormLocationAndSize(this, "Tela01");

                tela01.StartPosition = FormStartPosition.Manual;
                tela01.Location = new Point(savedLocation[0], savedLocation[1]);
                tela01.Size = new Size(savedLocation[2], savedLocation[3]);
            }
            tela01.Show();
        }

        private void btnTela02_Click(object sender, EventArgs e)
        {
            Tela02 tela02 = new Tela02();

            if (FormLocation.saveScreenLocationConfig)
            {
                int[] savedLocation = FormLocation.LoadFormLocationAndSize(this, "Tela02");

                tela02.StartPosition = FormStartPosition.Manual;
                tela02.Location = new Point(savedLocation[0], savedLocation[1]);
                tela02.Size = new Size(savedLocation[2], savedLocation[3]);
            }
            tela02.Show();
        }

        private void btnTela03_Click(object sender, EventArgs e)
        {

            Tela03 tela03 = new Tela03();

            if (FormLocation.saveScreenLocationConfig)
            {
                int[] savedLocation = FormLocation.LoadFormLocationAndSize(this, "Tela03");

                tela03.StartPosition = FormStartPosition.Manual;
                tela03.Location = new Point(savedLocation[0], savedLocation[1]);
                tela03.Size = new Size(savedLocation[2], savedLocation[3]);
            }
            tela03.Show();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Marcos\source\repos\TelaFlutuante\TelaFlutuante\bin\Debug2\TelaFlutuante.exe.config";

            ImportScreenConfigLocation.ImportConfig(path);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            while (Application.OpenForms.Count > 1)
            {

                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    Form frm = Application.OpenForms[i];

                    if (frm != this)
                    {
                        frm.Close();
                    }

                }
            }      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLocation.VerificaConfig();

            checkSaveConfig.Checked = FormLocation.saveScreenLocationConfig;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FormLocation.SalvarConfiguracao(checkSaveConfig.Checked.ToString());
        }
    }
}
