using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_batalha
{
    public partial class FrRecordes : Form
    {
        public int jogador_1_venceu = 1;

        public FrRecordes()
        


        {
            InitializeComponent();
            string[] linhas = File.ReadAllLines("Recordes_de_pontos.txt");
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Trim().Split('|');
                string recorde_1 = linha[0] + "   |   " + linha[1] +"   |   " + linha[4];
                string recorde_2 = linha[2] +
                    "   |   " + linha[3] + "   |   " + linha[4];
                ListBox_1.Items.Add(recorde_1);
                listBox2.Items.Add(recorde_2);
            }
        }
    }
}
