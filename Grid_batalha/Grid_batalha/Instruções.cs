using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_batalha
{
    public partial class Instruções : Form
    {
        public Instruções()
        {
            InitializeComponent();
            txtjogador1.Focus();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            if((txtjogador1.Text).Trim().Length == 0)
            {
                errorProvider1.SetError(txtjogador1, "Por favor digite um nome corretamente");
                erro = true;
            }
            if (txtjogador2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtjogador2, "Por favor digite um nome corretamente");
                erro = true;
            }

            if (erro == true)
                return;
            else
                Close();

        }

        private void btn_regras_Click(object sender, EventArgs e)
        {
            FrRegras regras = new FrRegras();
            regras.ShowDialog();
        }

        private void btn_recordes_Click(object sender, EventArgs e)
        {
            FrRecordes Tela_Recorde = new FrRecordes();
            Tela_Recorde.ShowDialog();
        }

        private void sobre_Click(object sender, EventArgs e)
        {
            FrSobre Tela_Recorde = new FrSobre();
            Tela_Recorde.ShowDialog();
        }
    }
}
