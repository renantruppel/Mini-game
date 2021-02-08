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

    public partial class Ataque : Form
    {
        public string arma_usada;
        public int range_min = 0;
        public int range_max = 0;
        public int dano_min = 0;
        public int dano_max = 0;
        public int dano = 0;

        public bool atk_selecionado = false;

        public Ataque()
        {
            InitializeComponent();
            atk_selecionado = false;
        }

        private void btn_lança_Click_1(object sender, EventArgs e)
        {
            arma_usada = "lança";
            range_min = 1;
            range_max = 1;
            dano_min = 1;
            dano_max = 7;
            atk_selecionado = true;
            Close();
        }

        private void btn_espada_Grande_Click_1(object sender, EventArgs e)
        {
            arma_usada = "espada_grande";
            range_min = 1;
            range_max = 1;
            dano_min = 1;
            dano_max = 9;
            atk_selecionado = true;
            Close();
        }

        private void btn_espada_curta_Click_1(object sender, EventArgs e)
        {
            arma_usada = "espada_curta";
            range_min = 1;
            range_max = 1;
            dano_min = 1;
            dano_max = 7;
            atk_selecionado = true;
            Close();
        }

        private void btn_arco_flexa_Click_1(object sender, EventArgs e)
        {
            arma_usada = "arco_flexa";
            range_min = 2;
            range_max = 9;
            dano_min = 1;
            dano_max = 7;
            atk_selecionado = true;
            Close();
        }

        private void btn_adaga_Click_1(object sender, EventArgs e)
        {
            arma_usada = "adaga";
            range_min = 1;
            range_max = 5;
            dano_min = 1;
            dano_max = 6;
            atk_selecionado = true;
            Close();
        }

        private void btn_Flexa_balista_Click(object sender, EventArgs e)
        {
            arma_usada = "flexa_balista";
            range_min = 4;
            range_max = 15;
            dano_min = 6;
            dano_max = 14;
            atk_selecionado = true;
            Close();
        }

        private void btn_Bola_fogo_Click(object sender, EventArgs e)
        {
            arma_usada = "bola_fogo";
            range_min = 2;
            range_max = 8;
            dano_min = 6;
            dano_max = 13;
            atk_selecionado = true;
            Close();
        }


        
    }
}
