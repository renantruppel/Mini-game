using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_batalha
{
    public partial class Form1 : Form
    {
        public int i_atk_an = 0;
        public int i_def_an = 0;
        public PictureBox Img_an;
        public PictureBox Img_an2;
        public bool img_Left = false;
        public bool img_Top = false;
        public int contador_an = 0;
        public Double relaçao_2 = 0;
        public bool ataque_no_obstaculo = false;
        public int numero_obstaculo;

        public int tempoemSegundos = 0;

        public string jogador_1 = "";
        public string jogador_2 = "";

        public int turno_ = 1;

        public struct Personagem
        {
            public PictureBox Img;
            public int Posiçao;
            public int Força;
            public int Des;
            public int Intel;
            public int Vida;
            public int Armad;
            public int Mod_Ataque;
            public int Armad_Temporario;
            public int Mod_Ataque_Temporario;
            public bool Arco_Flexa;
            public bool Lança;
            public bool Espada_Grande;
            public bool Espada_Curta;
            public bool Adaga;
            public bool Flexa_Balista;
            public bool Bola_Fogo;
            public bool Cura;
            public int MT;
            public int MR;
            public bool Mod_Concentraçao;
            public bool Mod_Postura_Defensiva;
            public bool ModAçao;
        }

        public struct Obstaculo
        {
            public PictureBox Img_Obstaculo;
            public int Posiçao_Obstaculo;
        }

        Obstaculo[] Obstaculos = new Obstaculo[21];

        /* Informações dos personagens*/
        Personagem[] Personagens = new Personagem[20];

        int[] posicoes = { 109, 53, 82, 81, 110, 54, 17, 13, 5, 10, 142, 170, 319, 347, 312, 340, 368, 198, 292, 404 };
        int[] forca = {5,1,1,5,5,0,0,0,0,0,3,3,3,3,3,3,3,0,0,0};
        int[] des = { 3, 5, 5, 1, 1, 0, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0 };
        int[] intel = { 2, 1, 1, 2, 2, 5, 1, 1, 1, 4, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3 };

        int[] vida_ = { 28, 18, 18, 28, 28, 15, 12, 12, 12, 15, 18, 18, 18, 18, 18, 18, 18, 12, 12, 12 };
        int[] armad = { 3, 1, 1, 5, 5, 0, 5, 5, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        int[] mod_ataque = { 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] armad_temporario = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] mod_ataque_temporario = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bool[] arco_e_flexa = {false,true,true,false,false,false, true, true, true, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] lança = {false,false,false,true,true,false, false, false, false, false, true, true,
        true,true,true,true,true,false,false,false};
        bool[] espada_grande = {true,false,false,false,false,false, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] espada_curta = {false,true,true,false,false,true, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] adaga = {true,false,false,true,true,false, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] flexa_balista = {false,false,false,false,false,false, false, false, false, false, false, false,
        false,false,false,false,false,true,true,true};
        bool[] bola_fogo = {false,false,false,false,false,true, false, false, false, true, false, false,
        false,false,false,false,false,false,false,false};
        bool[] cura = {false,false,false,false,false,true, false, false, false, true, false, false,
        false,false,false,false,false,false,false,false};
        int[] mt = { 7, 7, 7, 5, 5, 6, 0, 0, 0, 0, 8, 8, 8, 8, 8, 8, 8, 1, 1, 1 };
        int[] mr = { 7, 7, 7, 5, 5, 6, 0, 0, 0, 0, 8, 8, 8, 8, 8, 8, 8, 1, 1, 1 };
        bool[] mod_concentraçao = {false,false,false,false,false,false, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] mod_postura_defensiva = {false,false,false,false,false,false, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};
        bool[] mod_açao = {false,false,false,false,false,false, false, false, false, false, false, false,
        false,false,false,false,false,false,false,false};





        bool vez_do_jogador = true;
        string personagem_selecionado = "";
        bool atk_selecionado = false;
        string ArmaUsada = "";
        int RangeMin = 0;
        int RangeMax = 0;
        int Dano_Min = 0;
        int Dano_Max = 0;
        int fuga_ok = 0;
        int aliados_mortos = 0;
        int tempo_total_jogador1 = 0;
        int tempo_total_jogador2 = 0;

        int[] posicao = new int[600];

        int[] pos_modificadores = new int[600];

        Stopwatch cronometro = new Stopwatch();

        SoundPlayer s = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            /* Informações dos obstáculos*/
            PictureBox[] lista_img_obstaculos = { pictureBox6 , pictureBox7, pictureBox8, pictureBox9 ,
            pictureBox10, pictureBox11, pictureBox12,pictureBox13, pictureBox14, pictureBox15,pictureBox20,
            pictureBox19, pictureBox18, pictureBox17,pictureBox16,pictureBox25, pictureBox24,
            pictureBox23,pictureBox22, pictureBox21,pictureBox26};

            int[] posiçao_obstaculos = {147, 123, 128, 231,232,259,260,233,234,235,236,237,238,239,
                240,241,242,243,244,245,246};

            for(int i = 0; i < 21; i++)
            {
                Obstaculos[i].Img_Obstaculo = lista_img_obstaculos[i];
                Obstaculos[i].Posiçao_Obstaculo = posiçao_obstaculos[i];
            }


            PictureBox[] lista_img = { heroi, arqueiro1, arqueiro2, vanguarda1, vanguarda2, mago, elfo1,
            elfo2, elfo3, feiticeiro, cavaleiro1, cavaleiro2, cavaleiro3, cavaleiro4, cavaleiro5,
            cavaleiro6, cavaleiro7, balista1, balista2, balista3 };
            
            for (int i = 0; i < 560; i++)
                posicao[i] = 1;

            posicao[0] = 0; posicao[1] = 0; posicao[2] = 0; posicao[3] = 0; posicao[4] = 0; posicao[5] = 0; posicao[6] = 0; posicao[7] = 0; posicao[8] = 0; posicao[9] = 0;
            posicao[10] = 0; posicao[11] = 0; posicao[12] = 0; posicao[13] = 0; posicao[14] = 0; posicao[15] = 0; posicao[16] = 0; posicao[17] = 0; posicao[18] = 0; posicao[19] = 0;
            posicao[20] = 0; posicao[21] = 0; posicao[22] = 0; posicao[23] = 0; posicao[24] = 0; posicao[25] = 0; posicao[26] = 0; posicao[27] = 0; posicao[28] = 0; posicao[33] = 0;
            posicao[34] = 0; posicao[35] = 0; posicao[36] = 0; posicao[37] = 0; posicao[38] = 0; posicao[39] = 0; posicao[40] = 0; posicao[41] = 0; posicao[42] = 0; posicao[43] = 0;
            posicao[44] = 0; posicao[45] = 0; posicao[46] = 0; posicao[47] = 0; posicao[48] = 0;

            //bordas
            posicao[56] = 0; posicao[84] = 0; posicao[112] = 0; posicao[140] = 0; posicao[168] = 0; posicao[196] = 0; posicao[224] = 0; posicao[252] = 0;
            posicao[420] = 0; posicao[448] = 0; posicao[476] = 0; posicao[504] = 0; posicao[532] = 0;
            posicao[55] = 0; posicao[83] = 0; posicao[111] = 0; posicao[139] = 0; posicao[167] = 0; posicao[195] = 0; posicao[223] = 0; posicao[251] = 0; posicao[279] = 0;
            posicao[307] = 0; posicao[335] = 0; posicao[363] = 0; posicao[391] = 0; posicao[419] = 0; posicao[447] = 0; posicao[475] = 0; posicao[503] = 0;
            posicao[531] = 0; posicao[559] = 0;
            posicao[533] = 0; posicao[534] = 0; posicao[535] = 0; posicao[536] = 0; posicao[537] = 0; posicao[538] = 0; posicao[539] = 0; posicao[540] = 0;
            posicao[541] = 0; posicao[542] = 0; posicao[543] = 0; posicao[544] = 0; posicao[545] = 0; posicao[546] = 0; posicao[547] = 0; posicao[548] = 0;
            posicao[549] = 0; posicao[550] = 0; posicao[551] = 0; posicao[552] = 0; posicao[553] = 0; posicao[554] = 0; posicao[555] = 0; posicao[556] = 0;
            posicao[557] = 0; posicao[558] = 0;

            //água
            posicao[51] = 0; posicao[52] = 0; posicao[79] = 0; posicao[80] = 0; posicao[163] = 0;
            posicao[164] = 0; posicao[191] = 0; posicao[192] = 0; posicao[219] = 0; posicao[220] = 0; posicao[247] = 0; posicao[248] = 0; posicao[275] = 0; posicao[276] = 0;
            posicao[331] = 0; posicao[332] = 0; posicao[387] = 0; posicao[388] = 0; posicao[415] = 0; posicao[416] = 0;
            posicao[443] = 0; posicao[444] = 0; posicao[471] = 0; posicao[472] = 0; posicao[499] = 0; posicao[500] = 0; posicao[527] = 0; posicao[528] = 0;

            //pedras e árvores
            posicao[123] = 0; posicao[128] = 0; posicao[147] = 0; posicao[231] = 0; posicao[232] = 0; posicao[233] = 0; posicao[234] = 0; posicao[235] = 0; posicao[236] = 0;
            posicao[237] = 0; posicao[238] = 0; posicao[239] = 0; posicao[240] = 0; posicao[241] = 0; posicao[242] = 0; posicao[243] = 0; posicao[244] = 0; posicao[245] = 0;
            posicao[246] = 0; posicao[259] = 0; posicao[260] = 0;

            //posição inicial dos personagens
            posicao[53] = 0; posicao[54] = 0; posicao[81] = 0; posicao[82] = 0; posicao[109] = 0; posicao[110] = 0; posicao[142] = 0; posicao[170] = 0; posicao[198] = 0; posicao[292] = 0;
            posicao[312] = 0; posicao[319] = 0; posicao[340] = 0; posicao[347] = 0; posicao[368] = 0; posicao[404] = 0;





            for (int i = 0; i < 560; i++)
                pos_modificadores[i] = 1;

            pos_modificadores[31] = 2; pos_modificadores[32] = 2; pos_modificadores[59] = 2; pos_modificadores[60] = 2; pos_modificadores[87] = 2; pos_modificadores[88] = 2;
            pos_modificadores[115] = 2; pos_modificadores[116] = 2; pos_modificadores[143] = 2; pos_modificadores[144] = 2; pos_modificadores[171] = 2; pos_modificadores[172] = 2;
            pos_modificadores[199] = 2; pos_modificadores[200] = 2; pos_modificadores[227] = 2; pos_modificadores[228] = 2; pos_modificadores[255] = 2; pos_modificadores[256] = 2;
            pos_modificadores[255] = 2; pos_modificadores[256] = 2; pos_modificadores[229] = 2; pos_modificadores[230] = 2; pos_modificadores[257] = 2; pos_modificadores[258] = 2;

            pos_modificadores[285] = 3; pos_modificadores[286] = 3; pos_modificadores[287] = 3; pos_modificadores[288] = 3; pos_modificadores[289] = 3;
            pos_modificadores[313] = 3; pos_modificadores[314] = 3; pos_modificadores[315] = 3; pos_modificadores[316] = 3; pos_modificadores[317] = 3;
            pos_modificadores[341] = 3; pos_modificadores[342] = 3; pos_modificadores[343] = 3; pos_modificadores[344] = 3; pos_modificadores[345] = 3;
            pos_modificadores[369] = 3; pos_modificadores[370] = 3; pos_modificadores[371] = 3; pos_modificadores[372] = 3; pos_modificadores[373] = 3;
            pos_modificadores[397] = 3; pos_modificadores[398] = 3; pos_modificadores[399] = 3; pos_modificadores[400] = 3; pos_modificadores[401] = 3;
            pos_modificadores[425] = 3; pos_modificadores[426] = 3; pos_modificadores[427] = 3; pos_modificadores[428] = 3; pos_modificadores[429] = 3;
            pos_modificadores[451] = 3; pos_modificadores[452] = 3; pos_modificadores[453] = 3; pos_modificadores[454] = 3; pos_modificadores[455] = 3;
            pos_modificadores[479] = 3; pos_modificadores[480] = 3; pos_modificadores[481] = 3; pos_modificadores[482] = 3; pos_modificadores[483] = 3;
            pos_modificadores[507] = 3; pos_modificadores[508] = 3; pos_modificadores[509] = 3; pos_modificadores[510] = 3; pos_modificadores[511] = 3;

            pos_modificadores[266] = -3; pos_modificadores[267] = -3; pos_modificadores[268] = -3; pos_modificadores[269] = -3; pos_modificadores[270] = -3;
            pos_modificadores[294] = -3; pos_modificadores[295] = -3; pos_modificadores[296] = -3; pos_modificadores[297] = -3; pos_modificadores[298] = -3;
            pos_modificadores[323] = -3; pos_modificadores[324] = -3; pos_modificadores[325] = -3; pos_modificadores[326] = -3; pos_modificadores[327] = -3;
            pos_modificadores[351] = -3; pos_modificadores[352] = -3; pos_modificadores[353] = -3; pos_modificadores[354] = -3; pos_modificadores[355] = -3;
            pos_modificadores[379] = -3; pos_modificadores[380] = -3; pos_modificadores[381] = -3; pos_modificadores[382] = -3; pos_modificadores[383] = -3;
            pos_modificadores[407] = -3; pos_modificadores[408] = -3; pos_modificadores[409] = -3; pos_modificadores[410] = -3; pos_modificadores[411] = -3;
            pos_modificadores[435] = -3; pos_modificadores[436] = -3; pos_modificadores[437] = -3; pos_modificadores[438] = -3; pos_modificadores[439] = -3;
            pos_modificadores[463] = -3; pos_modificadores[464] = -3; pos_modificadores[465] = -3; pos_modificadores[466] = -3; pos_modificadores[467] = -3;
            pos_modificadores[494] = -3; pos_modificadores[495] = -3; pos_modificadores[496] = -3; pos_modificadores[497] = -3; pos_modificadores[498] = -3;
            pos_modificadores[522] = -3; pos_modificadores[523] = -3; pos_modificadores[524] = -3; pos_modificadores[525] = -3; pos_modificadores[526] = -3;

            pos_modificadores[280] = 5; pos_modificadores[308] = 5; pos_modificadores[336] = 5; pos_modificadores[364] = 5; pos_modificadores[392] = 5;

            pos_modificadores[123] = 4; pos_modificadores[128] = 4; pos_modificadores[147] = 4;

            pos_modificadores[231] = 6; pos_modificadores[232] = 6; pos_modificadores[233] = 6; pos_modificadores[234] = 6;pos_modificadores[235] = 6;
            pos_modificadores[236] = 6;pos_modificadores[237] = 6; pos_modificadores[238] = 6; pos_modificadores[239] = 6; pos_modificadores[240] = 6; pos_modificadores[241] = 6;
            pos_modificadores[242] = 6; pos_modificadores[243] = 6; pos_modificadores[244] = 6; pos_modificadores[245] = 6; pos_modificadores[246] = 6;
            pos_modificadores[259] = 6; pos_modificadores[260] = 6;



            for (int i = 0; i < posicoes.Length; i++)
            {
                Personagens[i].Img = lista_img[i];
                Personagens[i].Posiçao = posicoes[i];
                Personagens[i].Força = forca[i];
                Personagens[i].Des = des[i];
                Personagens[i].Intel = intel[i];
                Personagens[i].Vida = vida_[i];
                Personagens[i].Armad = armad[i];
                Personagens[i].Mod_Ataque = mod_ataque[i];
                Personagens[i].Armad_Temporario = armad_temporario[i];
                Personagens[i].Mod_Ataque_Temporario = mod_ataque_temporario[i];
                Personagens[i].MT = mt[i];
                Personagens[i].MR = mr[i];
                Personagens[i].ModAçao = mod_açao[i];
                Personagens[i].Arco_Flexa = arco_e_flexa[i];
                Personagens[i].Lança = lança[i];
                Personagens[i].Espada_Grande = espada_grande[i];
                Personagens[i].Espada_Curta = espada_curta[i];
                Personagens[i].Adaga = adaga[i];
                Personagens[i].Flexa_Balista = flexa_balista[i];
                Personagens[i].Bola_Fogo = bola_fogo[i];
                Personagens[i].Cura = cura[i];
                Personagens[i].Mod_Concentraçao = mod_concentraçao[i];
                Personagens[i].Mod_Postura_Defensiva = mod_postura_defensiva[i];
            }
            s.SoundLocation = "entrada.wav";
            s.PlayLooping();

            Instruções entrada = new Instruções();
            entrada.ShowDialog();
            jogador_1 = entrada.txtjogador1.Text;
            jogador_2 = entrada.txtjogador2.Text;
            if (jogador_1 == "" || jogador_2 == "")
                Environment.Exit(1);
            FrRegras regras = new FrRegras();
            regras.ShowDialog();
            s.Stop();
            s.SoundLocation = "som_jogo_.wav";
            s.PlayLooping();
            cronometro.Start();
            timer6.Start();
        }


        private void Menu(Personagem[] vetor, int i)
        {
            personagem.Text = vetor[i].Img.Name;
            movimento_restante.Text = ".";
            vida2.Text = vetor[i].Vida.ToString();
            força.Text = vetor[i].Força.ToString();
            destreza.Text = vetor[i].Des.ToString();
            inteligencia.Text = vetor[i].Intel.ToString();
            atk.Visible = false;
            btn_correr.Visible = false;
            btn_concentraçao.Visible = false;
            btn_Postura_defensiva.Visible = false;
            personagem_selecionado = "";
        }

        private int LocalizarPersonagem(Personagem[] vetor, string nome)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Img.Name == nome)
                    return i;
            }
            return 0;
        }

        private void elfo1_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens,"elfo1"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "elfo1");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "elfo1";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "elfo1"));
            }
        }

        private void elfo2_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "elfo2"));
            else if(atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens,"elfo2");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "elfo2";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "elfo2"));
            }
        }

        private void elfo3_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "elfo3"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "elfo3");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "elfo3";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "elfo3"));
            }
        }

        private void feiticeiro_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "feiticeiro"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "feiticeiro");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "feiticeiro";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "feiticeiro"));
            }
        }

        private void cavaleiro1_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro1"));

            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro1");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro1";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro1"));
            }
        }

        private void cavaleiro2_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro2"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro2");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro2";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro2"));
            }
        }

        private void cavaleiro3_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro3"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro3");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro3";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro3"));
            }
        }

        private void cavaleiro4_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro4"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro4");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro4";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro4"));
            }
        }

        private void cavaleiro5_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro5"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro5");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro5";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro5"));
            }
        }

        private void cavaleiro6_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro6"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro6");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro6";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro6"));
            }
        }

        private void cavaleiro7_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "cavaleiro7"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "cavaleiro7");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "cavaleiro7";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "cavaleiro7"));
            }
        }

        private void balista1_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "balista1"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "balista1");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "balista1";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "balista1"));
            }
        }

        private void balista2_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "balista2"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "balista2");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "balista2";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "balista2"));
            }
        }

        private void balista3_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == true)
                Menu(Personagens, LocalizarPersonagem(Personagens, "balista3"));
            else if (atk_selecionado == true && vez_do_jogador == true)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "balista3");

            else if (atk_selecionado == false && vez_do_jogador == false)
            {
                personagem_selecionado = "balista3";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "balista3"));
            }
        }

        private void MenuJogador(Personagem[] vetor, int i)
        {
            personagem.Text = vetor[i].Img.Name;
            movimento_restante.Text = vetor[i].MR.ToString();
            vida2.Text = vetor[i].Vida.ToString();
            força.Text = vetor[i].Força.ToString();
            destreza.Text = vetor[i].Des.ToString();
            inteligencia.Text = vetor[i].Intel.ToString();
            if (Personagens[i].ModAçao == true)
            {
                atk.Visible = false;
                btn_correr.Visible = false;
                btn_concentraçao.Visible = false;
                btn_Postura_defensiva.Visible = false;
            }
            else
            {
                atk.Visible = true;
                btn_correr.Visible = true;
                btn_concentraçao.Visible = true;
                btn_Postura_defensiva.Visible = true;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cancelar.Visible = false;
            atk_selecionado = false;
        }

        private void heroi_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "heroi"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "heroi");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "heroi";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "heroi"));
            }
        }

        private void vanguarda1_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "vanguarda1"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "vanguarda1");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "vanguarda1";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "vanguarda1"));
            }
        }

        private void vanguarda2_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "vanguarda2"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "vanguarda2");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "vanguarda2";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "vanguarda2"));
            }
        }

        private void arqueiro1_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "arqueiro1"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "arqueiro1");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "arqueiro1";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "arqueiro1"));
            }
        }

        private void arqueiro2_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "arqueiro2"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "arqueiro2");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "arqueiro2";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "arqueiro2"));
            }
        }

        private void mago_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false && vez_do_jogador == false)
                Menu(Personagens, LocalizarPersonagem(Personagens, "mago"));
            else if (atk_selecionado == true && vez_do_jogador == false)
                ataque(ArmaUsada, RangeMin, RangeMax, Dano_Min, Dano_Max, personagem_selecionado, Personagens, "mago");

            else if (atk_selecionado == false && vez_do_jogador == true)
            {
                personagem_selecionado = "mago";
                MenuJogador(Personagens, LocalizarPersonagem(Personagens, "mago"));
            }
        }

        private void esquerda_Click_1(object sender, EventArgs e)
        {
            if (personagem_selecionado == "")
                return;
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);
            bool ok = false;
            if (atk_selecionado == false && posicao[Personagens[i].Posiçao - 1] == 1)
            {
                if (pos_modificadores[Personagens[i].Posiçao - 1] == 2 && Personagens[i].MR >= 3)
                {
                    Personagens[i].MR = Personagens[i].MR - 3;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao - 1] == -3 && Personagens[i].MR >= 2)
                {
                    Personagens[i].MR = Personagens[i].MR - 2;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao - 1] != -3 &&
                    pos_modificadores[Personagens[i].Posiçao - 1] != 2 && Personagens[i].MR >= 1)
                {
                    Personagens[i].MR = Personagens[i].MR - 1;
                    ok = true;
                }
            }
            if (ok == true)
            {
                Personagens[i].Posiçao -= 1;
                posicao[Personagens[i].Posiçao] = 0;
                posicao[Personagens[i].Posiçao + 1] = 1;
                Personagens[i].Img.Left = Personagens[i].Img.Left - 31;
                movimento_restante.Text = Personagens[i].MR.ToString();
                if (pos_modificadores[Personagens[i].Posiçao] == 5 && i <= 5)
                {
                    Personagens[i].Img.Visible = false;
                    fuga_ok += 1;
                    posicao[Personagens[i].Posiçao] = 1;
                    if (fuga_ok >= 3)
                    {
                        FimDeJogo();
                    }

                }
                FinalDeTurno();
            }
        }

            private void baixo_Click_1(object sender, EventArgs e)
            {
            if (personagem_selecionado == "")
                return;
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);
            bool ok = false;

            if(atk_selecionado == false && posicao[Personagens[i].Posiçao + 28] == 1)
            {
                if (pos_modificadores[Personagens[i].Posiçao + 28] == 2 && Personagens[i].MR >= 3)
                {
                    Personagens[i].MR = Personagens[i].MR - 3;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao + 28] != 2 && Personagens[i].MR >= 1)
                {
                    Personagens[i].MR = Personagens[i].MR - 1;
                    ok = true;
                }
            }
            if (ok == true)
            {
                Personagens[i].Posiçao += 28;
                posicao[Personagens[i].Posiçao] = 0;
                posicao[Personagens[i].Posiçao - 28] = 1;
                Personagens[i].Img.Top = Personagens[i].Img.Top + 35;
                movimento_restante.Text = Personagens[i].MR.ToString();
                if (pos_modificadores[Personagens[i].Posiçao] == 5 && i <= 5)
                {
                    Personagens[i].Img.Visible = false;
                    fuga_ok += 1;
                    posicao[Personagens[i].Posiçao] = 1;
                    if (fuga_ok >= 3)
                    {
                        FimDeJogo();
                    }
                }
                FinalDeTurno();
            }
        }

        private void direita_Click_1(object sender, EventArgs e)
        {
            if (personagem_selecionado == "")
                return;
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);
            bool ok = false;
            if (atk_selecionado == false && posicao[Personagens[i].Posiçao + 1] == 1)
            {
                if (pos_modificadores[Personagens[i].Posiçao + 1] == 2 && Personagens[i].MR >= 3)
                {
                    Personagens[i].MR = Personagens[i].MR - 3;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao + 1] == 3 && Personagens[i].MR >= 2)
                {
                    Personagens[i].MR = Personagens[i].MR - 2;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao + 1] != 2 &&
                    pos_modificadores[Personagens[i].Posiçao + 1] != 3 && Personagens[i].MR >= 1)
                {
                    Personagens[i].MR = Personagens[i].MR - 1;
                    ok = true;
                }
            }
            if (ok == true)
            {
                Personagens[i].Posiçao += 1;
                posicao[Personagens[i].Posiçao] = 0;
                posicao[Personagens[i].Posiçao - 1] = 1;
                Personagens[i].Img.Left = Personagens[i].Img.Left + 31;
                movimento_restante.Text = Personagens[i].MR.ToString();
                if (pos_modificadores[Personagens[i].Posiçao] == 5 && i <= 5)
                {
                    Personagens[i].Img.Visible = false;
                    fuga_ok += 1;
                    posicao[Personagens[i].Posiçao] = 1;
                    if (fuga_ok >= 3)
                    {
                        FimDeJogo();
                    }
                }
                FinalDeTurno();
            }
        }

        private void encima_Click_1(object sender, EventArgs e)
        {
            if (personagem_selecionado == "")
                return;
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);
            bool ok = false;

            if (atk_selecionado == false && posicao[Personagens[i].Posiçao - 28] == 1)
            {
                if (pos_modificadores[Personagens[i].Posiçao - 28] == 2 && Personagens[i].MR >= 3)
                {
                    Personagens[i].MR = Personagens[i].MR - 3;
                    ok = true;
                }
                else if (pos_modificadores[Personagens[i].Posiçao - 28] != 2 && Personagens[i].MR >= 1)
                {
                    Personagens[i].MR = Personagens[i].MR - 1;
                    ok = true;
                }
            }
            if (ok == true)
            {
                Personagens[i].Posiçao -= 28;
                posicao[Personagens[i].Posiçao] = 0;
                posicao[Personagens[i].Posiçao + 28] = 1;
                Personagens[i].Img.Top = Personagens[i].Img.Top - 35;
                movimento_restante.Text = Personagens[i].MR.ToString();
                if (pos_modificadores[Personagens[i].Posiçao] == 5 && i <= 5)
                {
                    Personagens[i].Img.Visible = false;
                    fuga_ok += 1;
                    posicao[Personagens[i].Posiçao] = 1;
                    if (fuga_ok >= 3)
                    {
                        FimDeJogo();
                    }
                }
                FinalDeTurno();
            }
        }

        private void atk_Click(object sender, EventArgs e)
        {
            if (atk_selecionado == false)
            {
                for (int i = 0; i < Personagens.Length; i++)
                {
                    if (Personagens[i].Img.Name == personagem_selecionado)
                    {
                        Ataque tela = new Ataque();
                        if (Personagens[i].Arco_Flexa == false)
                            tela.btn_arco_flexa.Visible = false;
                        if (Personagens[i].Lança == false)
                            tela.btn_lança.Visible = false;
                        if (Personagens[i].Espada_Grande == false)
                            tela.btn_espada_Grande.Visible = false;
                        if (Personagens[i].Espada_Curta == false)
                            tela.btn_espada_curta.Visible = false;
                        if (Personagens[i].Adaga == false)
                            tela.btn_adaga.Visible = false;
                        if (Personagens[i].Flexa_Balista == false)
                            tela.btn_Flexa_balista.Visible = false;
                        if (Personagens[i].Bola_Fogo == false)
                            tela.btn_Bola_fogo.Visible = false;

                        tela.ShowDialog();
                        if (tela.atk_selecionado == true)
                        {
                            atk_selecionado = true;
                            ArmaUsada = tela.arma_usada;
                            RangeMin = tela.range_min;
                            RangeMax = tela.range_max;
                            Dano_Min = tela.dano_min;
                            Dano_Max = tela.dano_max;
                            cancelar.Visible = true;
                        }
                    }
                }
            }
        }

        private Double NumPositivo(Double num)
        {
            if (num < 0)
            {
                return (num * -1);
            }
            else
            {
                return num;
            }
        }

        private int NumPositivoInteiro(int num)
        {
            if (num < 0)
                return (num * -1);
            else
                return num;
        }

        private void animaçao(Personagem[] Personagens, string atacante, string inimigo)
        {
            img_Top = false;
            img_Left = false;
            i_atk_an = LocalizarPersonagem(Personagens, personagem_selecionado);
            i_def_an = LocalizarPersonagem(Personagens, inimigo);
            Img_an.Visible = false;
            Img_an.Left = Personagens[i_atk_an].Img.Left;
            Img_an.Top = Personagens[i_atk_an].Img.Top;
            Img_an.Visible = true;
 
            if (Personagens[i_def_an].Img.Left - Personagens[i_atk_an].Img.Left == 0
                || Personagens[i_def_an].Img.Top - Personagens[i_atk_an].Img.Top == 0)
                relaçao_2 = 1;
            else
            relaçao_2 = 1.01*(NumPositivoInteiro(Personagens[i_def_an].Img.Left - Personagens[i_atk_an].Img.Left))
                / NumPositivoInteiro(Personagens[i_def_an].Img.Top - Personagens[i_atk_an].Img.Top);
            relaçao_2 = relaçao_2 / 1.01;   

            timer1.Start();
        }


        private void CarregarArma(int linha_atk, int coluna_atk, int linha_def, int coluna_def, string arma)
        {
            if (arma == "arco_flexa")
            {
                if (coluna_def - coluna_atk <= 0)
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "Arrow_esquerda.Png";
                        Img_an = pictureBox2;
                    }
                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "Arrow_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "Arrow_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
                else
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "Arrow_direita.Png";
                        Img_an = pictureBox2;
                    }
                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "Arrow_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "Arrow_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
            }
            if (arma == "flexa_balista")
            {
                if (coluna_def - coluna_atk <= 0)
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "balista_esquerda.Png";
                        Img_an = pictureBox2;
                    }
                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "balista_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "balista_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
                else
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "balista_direita.Png";
                        Img_an = pictureBox2;
                    }

                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "balista_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "balista_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
            }

            if (arma == "bola_fogo")
                Img_an = pictureBox5;


            if (arma == "adaga")
            {
                if (coluna_def - coluna_atk <= 0)
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "dagger_esquerda.Png";
                        Img_an = pictureBox2;
                    }
                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "dagger_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "dagger_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
                else
                {
                    if (NumPositivo(coluna_def - coluna_atk) >= NumPositivo(linha_def - linha_atk))
                    {
                        pictureBox2.ImageLocation = "Dagger_direita.Png";
                        Img_an = pictureBox2;
                    }

                    else if (linha_def - linha_atk < 0)
                    {
                        pictureBox3.ImageLocation = "dagger_encima.Png";
                        Img_an = pictureBox3;
                    }
                    else
                    {
                        pictureBox3.ImageLocation = "dagger_abaixo.Png";
                        Img_an = pictureBox3;
                    }
                }
            }
        }

        private int BonusAtaque(int distancia, int linha_inimigo, int coluna_inimigo, int linha_amigo,
            int coluna_amigo, int atacante, int defensor)
        {
            int bonus = 0;
            if(distancia > 1)
                bonus += Personagens[atacante].Des + Personagens[atacante].Mod_Ataque +
                Personagens[atacante].Mod_Ataque_Temporario + Personagens[atacante].Intel;

            if (distancia == 1)
                bonus += Personagens[atacante].Força + Personagens[atacante].Mod_Ataque +
                Personagens[atacante].Mod_Ataque_Temporario;


            bool terreno_superior = false;
            bool terreno_inferior = false;
            int bonus_parcial = 0;
            for(int i = 0; i <= NumPositivoInteiro(coluna_inimigo - coluna_amigo); i++)
            {
                if((coluna_inimigo - coluna_amigo) < 0)
                {
                    if (pos_modificadores[Personagens[atacante].Posiçao - i] == 3)
                    {
                        if (i > 1 && terreno_superior == false)
                            break;
                        terreno_superior = true;
                        bonus_parcial += 1;
                    }
                    else if (pos_modificadores[Personagens[atacante].Posiçao - i] != 3
                        && terreno_superior == true)
                        break;
                    else if(pos_modificadores[Personagens[atacante].Posiçao - i] == -3)
                    {
                        bonus_parcial -= 1;
                        terreno_inferior = true;
                    }
                    else if(pos_modificadores[Personagens[atacante].Posiçao - i] != -3 &&
                        terreno_inferior == true)
                        bonus_parcial -= 1;
                }

                else if((coluna_inimigo - coluna_amigo) > 0)
                {
                    if (pos_modificadores[Personagens[atacante].Posiçao + i] == -3)
                    {
                        if (i > 1 && terreno_superior == false)
                            break;
                        terreno_superior = true;
                        bonus_parcial += 1;
                    }
                    else if (pos_modificadores[Personagens[atacante].Posiçao + i] != -3
                        && terreno_superior == true)
                        break;
                    else if (pos_modificadores[Personagens[atacante].Posiçao + i] == 3)
                    {
                        bonus_parcial -= 1;
                        terreno_inferior = true;
                    }
                    else if (pos_modificadores[Personagens[atacante].Posiçao + i] != 3 &&
                        terreno_inferior == true)
                        bonus_parcial -= 1;
                }
            }
            if (NumPositivoInteiro(coluna_inimigo - coluna_amigo) == 1)
                bonus += 2 * bonus_parcial;
            else
                bonus += bonus_parcial;


            ataque_no_obstaculo = false;
            int reduçao_parcial = 0;

            if (NumPositivoInteiro(coluna_inimigo - coluna_amigo) > NumPositivoInteiro(linha_inimigo - linha_amigo))
            {
                int fator_linha = 0;
                int fator_coluna = 0;
                if (coluna_inimigo - coluna_amigo == 0)
                    fator_coluna = 0;
                else
                    fator_coluna = (coluna_inimigo - coluna_amigo) / NumPositivoInteiro(coluna_inimigo - coluna_amigo);
                if (linha_inimigo - linha_amigo == 0)
                    fator_linha = 0;
                else
                    fator_linha = (linha_inimigo - linha_amigo) / NumPositivoInteiro(linha_inimigo - linha_amigo);
                for (int i = 1; i <= NumPositivoInteiro(coluna_inimigo - coluna_amigo) - 1; i++)
                {
                    for (int j = 0; j <= NumPositivoInteiro(linha_inimigo - linha_amigo); j++)
                    {
                        int posiçao_obstaculo = Personagens[atacante].Posiçao + (i * fator_coluna) + ((j * 28) * (fator_linha));

                        if (pos_modificadores[posiçao_obstaculo] == 4 || pos_modificadores[posiçao_obstaculo] == 6)
                        {
                            Double tangente_1 = (10.01 * j) / (10.01 * i);
                            Double tangente_2 = (10.01*(NumPositivoInteiro(linha_inimigo - linha_amigo) - j))
                                / (10.01 * (NumPositivoInteiro(coluna_inimigo - coluna_amigo) - i));

                            if ((tangente_1 - tangente_2 <= 0.15) && (pos_modificadores[posiçao_obstaculo] == 4))
                            {
                                reduçao_parcial -= 20;
                                ataque_no_obstaculo = true;
                                break;
                            }
                            if (tangente_1 - tangente_2 <= 0.5 && pos_modificadores[posiçao_obstaculo] == 6)
                            {
                                reduçao_parcial -= 20;
                                ataque_no_obstaculo = true;
                                break;
                            }
                                /*
                                else if ((tangente_1 - tangente_2 <= 0.15) && ataque_no_obstaculo == false)
                                {
                                    reduçao_parcial -= 8;
                                    if (reduçao_parcial <= -20)
                                    {
                                        ataque_no_obstaculo = true;
                                        break;
                                    }
                                }

                                else if ((tangente_1 - tangente_2 <= 0.20) && ataque_no_obstaculo == false)
                                {
                                    reduçao_parcial -= 5;
                                    if (reduçao_parcial <= -20)
                                    {
                                        ataque_no_obstaculo = true;
                                        break;
                                    }
                                }
                                else if ((tangente_1 - tangente_2 <= 0.25) && ataque_no_obstaculo == false)
                                {
                                    reduçao_parcial -= 3;
                                    if (reduçao_parcial <= -20)
                                    {
                                        ataque_no_obstaculo = true;
                                        break;
                                    }
                                }*/

                        }
                    }
                }
            }

            if (NumPositivoInteiro(linha_inimigo - linha_amigo) >= NumPositivoInteiro(coluna_inimigo - coluna_amigo))
            {
                int fator_linha = 0;
                int fator_coluna = 0;
                if (coluna_inimigo - coluna_amigo == 0)
                    fator_coluna = 0;
                else
                    fator_coluna = (coluna_inimigo - coluna_amigo) / NumPositivoInteiro(coluna_inimigo - coluna_amigo);
                if (linha_inimigo - linha_amigo == 0)
                    fator_linha = 0;
                else
                    fator_linha = (linha_inimigo - linha_amigo) / NumPositivoInteiro(linha_inimigo - linha_amigo);
                for (int i = 1; i <= NumPositivoInteiro(linha_inimigo - linha_amigo) - 1; i++)
                {
                    for (int j = 0; j <= NumPositivoInteiro(coluna_inimigo - coluna_amigo); j++)
                    {
                        int posiçao_obstaculo = Personagens[atacante].Posiçao + (j * fator_coluna) + ((i * 28) * (fator_linha));

                        if (pos_modificadores[posiçao_obstaculo] == 4 || (pos_modificadores[posiçao_obstaculo] == 6))
                        {
                            Double tangente_1 = (10.01*j) / (i*10.01);
                            Double tangente_2 = (10.01 * (NumPositivoInteiro(coluna_inimigo - coluna_amigo) - j))
                                / (10.01 * (NumPositivoInteiro(linha_inimigo - linha_amigo) - i));
                            if ((tangente_1 - tangente_2 <= 0.15) && pos_modificadores[posiçao_obstaculo] == 4)
                            {
                                reduçao_parcial -= 20;
                                ataque_no_obstaculo = true;
                                break;
                            }
                            else if((tangente_1 - tangente_2 <= 0.5) && pos_modificadores[posiçao_obstaculo] == 6)
                            {
                                reduçao_parcial -= 20;
                                ataque_no_obstaculo = true;
                                break;
                            }
                            /*else if ((tangente_1 - tangente_2 <= 0.15) && ataque_no_obstaculo == false)
                            {
                                reduçao_parcial -= 8;
                                if (reduçao_parcial <= -20)
                                {
                                    ataque_no_obstaculo = true;
                                    break;
                                }
                            }

                            else if ((tangente_1 - tangente_2 <= 0.20) && ataque_no_obstaculo == false)
                            {
                                reduçao_parcial -= 4;
                                if (reduçao_parcial <= -20)
                                {
                                    ataque_no_obstaculo = true;
                                    break;
                                }
                            }
                            else if ((tangente_1 - tangente_2 <= 0.25) && ataque_no_obstaculo == false)
                            {
                                reduçao_parcial -= 3;
                                if (reduçao_parcial <= -20)
                                {
                                    ataque_no_obstaculo = true;
                                    break;
                                }
                            }*/

                        }
                    }
                }
            }
            bonus += reduçao_parcial;

            if (pos_modificadores[Personagens[defensor].Posiçao] == 2)
                bonus += Personagens[defensor].Des;

            if (distancia >= 9)
                bonus -= 4;
            else if(distancia >= 7)
                bonus -= 3;
            else if (distancia >= 5)
                bonus -= 2;
            else if (distancia >= 3)
                bonus -= 1;
            return bonus;
        }



        private void ataque(string arma, int range_min, int range_max, int Dano_Min, int Dano_Max, string personagem_selecionado,
            Personagem[] Personagens, string inimigo)
        {
            i_atk_an = LocalizarPersonagem(Personagens, personagem_selecionado);
            i_def_an = LocalizarPersonagem(Personagens, inimigo);

            int posiçao_inimigo = Personagens[i_def_an].Posiçao;
            int linha_inimigo = (posiçao_inimigo/28);
            Double coluna_inimigo = ((1.5*posiçao_inimigo/42 - linha_inimigo) * 28);

            int posiçao_Personagem_atacante = Personagens[i_atk_an].Posiçao;
            int linha_atacante = (posiçao_Personagem_atacante / 28);
            Double coluna_atacante = ((1.5* posiçao_Personagem_atacante / 42) - linha_atacante) * 28;

            int dist_ataque = Convert.ToInt16(NumPositivo(coluna_atacante - coluna_inimigo) +
                NumPositivo(linha_atacante - linha_inimigo));

            if (dist_ataque >= range_min && dist_ataque <= range_max)
            {
                Random gerador = new Random();
                if (dist_ataque > 1)
                {
                    int mod_atk = BonusAtaque(dist_ataque, linha_inimigo, Convert.ToInt16(coluna_inimigo),
                        linha_atacante, Convert.ToInt16(coluna_atacante), i_atk_an, i_def_an);
                    int mod_def = 8 + Personagens[i_def_an].Des + Personagens[i_def_an].Armad + Personagens[i_def_an].Armad_Temporario;
                    if (ataque_no_obstaculo == true)
                    {
                        MessageBox.Show("Alvo fora de vista ou de difícil acesso, por favor selecione outro");
                        return;
                    }
                    CarregarArma(linha_atacante, Convert.ToInt16(coluna_atacante), linha_inimigo, Convert.ToInt16(coluna_inimigo), arma);
                    animaçao(Personagens, personagem_selecionado, inimigo);

                    if (gerador.Next(0, 20) + mod_atk >= mod_def)
                    {                                             
                        int dano_sofrido = gerador.Next(Dano_Min, Dano_Max);
                        Personagens[i_def_an].Vida = Personagens[i_def_an].Vida - dano_sofrido - Personagens[i_atk_an].Des;

                        button1.Text = (dano_sofrido + Personagens[i_atk_an].Des).ToString();
                        button1.Left = Personagens[i_def_an].Img.Left;
                        button1.Top = Personagens[i_def_an].Img.Top;
                        timer4.Start();

                        if (Personagens[i_def_an].Vida <= 0)
                        {
                            posicao[Personagens[i_def_an].Posiçao] = 1;
                            Personagens[i_def_an].Img.Visible = false;
                            if (i_def_an <= 5)
                                aliados_mortos += 1;
                            if (aliados_mortos >= 4)
                            {
                                FimDeJogo();
                            }
                        }
                    }
                    else
                    {
                        pictureBox4.Left = Personagens[i_def_an].Img.Left;
                        pictureBox4.Top = Personagens[i_def_an].Img.Top;
                        timer5.Start();
                        pictureBox4.Visible = false;
                    }
                }
                else if (dist_ataque == 1)
                {
                    int mod_atk = BonusAtaque(dist_ataque, linha_inimigo, Convert.ToInt16(coluna_inimigo),
                        linha_atacante, Convert.ToInt16(coluna_atacante), i_atk_an, i_def_an);
                    int mod_def = 8 + Personagens[i_def_an].Des + Personagens[i_def_an].Armad + Personagens[i_def_an].Armad_Temporario;
                    if (gerador.Next(0, 20) + mod_atk >= mod_def)
                    {

                        int dano_sofrido = gerador.Next(Dano_Min, Dano_Max);
                        Personagens[i_def_an].Vida = Personagens[i_def_an].Vida -
                            dano_sofrido - Personagens[i_atk_an].Força;

                        button1.Text = (dano_sofrido + Personagens[i_atk_an].Força).ToString();
                        button1.Left = Personagens[i_def_an].Img.Left;
                        button1.Top = Personagens[i_def_an].Img.Top;
                        timer4.Start();

                        if (Personagens[i_def_an].Vida <= 0)
                        {
                            posicao[Personagens[i_def_an].Posiçao] = 1;
                            Personagens[i_def_an].Img.Visible = false;
                            if (i_def_an <= 5)
                                aliados_mortos += 1;
                            if (aliados_mortos >= 4)
                            {
                                FimDeJogo();
                            }
                        }
                    }
                    else
                    {
                        pictureBox4.Left = Personagens[i_def_an].Img.Left;
                        pictureBox4.Top = Personagens[i_def_an].Img.Top;
                        timer5.Start();
                        pictureBox4.Visible = false;
                    }
                }
                atk_selecionado = false;
                cancelar.Visible = false;
                Personagens[i_atk_an].ModAçao = true;
                MenuJogador(Personagens, i_atk_an);
                FinalDeTurno();
            }
            else
                MessageBox.Show("sem range adequado para o ataque");
        }

        private void passe_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            tempoemSegundos = 0;
            if (vez_do_jogador == true)
            {
                for (int i = 6; i < 20; i++)
                {
                    Personagens[i].MR = Personagens[i].MT;
                    Personagens[i].ModAçao = false;
                    Personagens[i].Img.BackColor = Color.White;
                    if (Personagens[i].Mod_Concentraçao == true)
                    {
                        Personagens[i].Mod_Ataque_Temporario += Personagens[i].Intel + 2;
                        Personagens[i].Img.BackColor = Color.Red;
                        Personagens[i].Mod_Concentraçao = false;
                    }
                    else
                        Personagens[i].Mod_Ataque_Temporario = 0;
                    Personagens[i].Armad_Temporario = 0;
                }
                vez_do_jogador = false;
                cancelar.Visible = false;
                personagem.Text = ".";
                movimento_restante.Text = ".";
                vida2.Text = ".";
                força.Text = ".";
                destreza.Text = ".";
                inteligencia.Text = ".";
                atk_selecionado = false;
                personagem_selecionado = "";
                passador_de_vez.Text = "VEZ DO JOGADOR 2";
                passador_de_vez.Top = 400;
                Sintonizador.Text = "Fase do Jogador 2";
                timer3.Start();
                cronometro.Reset();
                cronometro.Start();
                timer6.Start();
            }
            else
            {
                for (int i = 0; i <= 5; i++)
                {
                    Personagens[i].MR = Personagens[i].MT;
                    Personagens[i].ModAçao = false;
                    Personagens[i].Img.BackColor = Color.White;
                    if (Personagens[i].Mod_Concentraçao == true)
                    {
                        Personagens[i].Mod_Ataque_Temporario += Personagens[i].Intel + 2;
                        Personagens[i].Img.BackColor = Color.Red;
                        Personagens[i].Mod_Concentraçao = false;
                    }
                    else
                        Personagens[i].Mod_Ataque_Temporario = 0;
                    Personagens[i].Armad_Temporario = 0;
                }
                vez_do_jogador = true;
                cancelar.Visible = false;
                personagem.Text = ".";
                movimento_restante.Text = ".";
                vida2.Text = ".";
                força.Text = ".";
                destreza.Text = ".";
                inteligencia.Text = ".";
                atk_selecionado = false;
                personagem_selecionado = "";
                Sintonizador.Text = "Fase do Jogador 1";
                passador_de_vez.Text = "VEZ DO JOGADOR 1";
                passador_de_vez.Top = 400;
                turno_ += 1;
                turno.Text = "Turno" + (turno_).ToString();
                timer3.Start();
                cronometro.Reset();
                cronometro.Start();
                timer6.Start();
            }       
        }

        private void FinalDeTurno()
        {
            bool falta_jogada = false;
            if (vez_do_jogador == true)
            {
                for (int i = 0; i <= 5; i++)
                    if (Personagens[i].MR > 0 || Personagens[i].ModAçao == false)
                        falta_jogada = true;
                if (falta_jogada == false)
                {
                    timer6.Stop();
                    tempoemSegundos = 0;

                    for (int i = 6; i < 20; i++)
                    {
                        Personagens[i].MR = Personagens[i].MT;
                        Personagens[i].ModAçao = false;
                        Personagens[i].Img.BackColor = Color.White;
                        if (Personagens[i].Mod_Concentraçao == true)
                        {
                            Personagens[i].Mod_Ataque_Temporario += Personagens[i].Intel + 2;
                            Personagens[i].Img.BackColor = Color.Red;
                            Personagens[i].Mod_Concentraçao = false;
                        }
                        else
                            Personagens[i].Mod_Ataque_Temporario = 0;
                        Personagens[i].Armad_Temporario = 0;

                    }

                    vez_do_jogador = false;
                    cancelar.Visible = false;
                    personagem.Text = ".";
                    movimento_restante.Text = ".";
                    vida2.Text = ".";
                    força.Text = ".";
                    destreza.Text = ".";
                    inteligencia.Text = ".";
                    atk_selecionado = false;
                    personagem_selecionado = "";
                    Sintonizador.Text = "Fase do Jogador 2";
                    passador_de_vez.Text = "VEZ DO JOGADOR 2";
                    passador_de_vez.Top = 400;
                    timer3.Start();
                    cronometro.Reset();
                    cronometro.Start();
                    timer6.Start();
                }
            }
            else
            {
                for (int i = 6; i < 20; i++)
                    if (Personagens[i].MR > 0 || Personagens[i].ModAçao == false)
                        falta_jogada = true;
                if (falta_jogada == false)
                {
                    timer6.Stop();
                    tempoemSegundos = 0;
                    for (int i = 0; i <= 5; i++)
                    {
                        Personagens[i].MR = Personagens[i].MT;
                        Personagens[i].ModAçao = false;
                        Personagens[i].Img.BackColor = Color.White;

                        if (Personagens[i].Mod_Concentraçao == true)
                        {
                            Personagens[i].Mod_Ataque_Temporario += Personagens[i].Intel + 2;
                            Personagens[i].Img.BackColor = Color.Red;
                            Personagens[i].Mod_Concentraçao = false;
                        }
                        else
                            Personagens[i].Mod_Ataque_Temporario = 0;
                        Personagens[i].Armad_Temporario = 0;
                    }

                    vez_do_jogador = true;
                    cancelar.Visible = false;
                    personagem.Text = ".";
                    movimento_restante.Text = ".";
                    vida2.Text = ".";
                    força.Text = ".";
                    destreza.Text = ".";
                    inteligencia.Text = ".";
                    atk_selecionado = false;
                    personagem_selecionado = "";
                    Sintonizador.Text = "Fase do Jogador 1";
                    passador_de_vez.Text = "VEZ DO JOGADOR 1";
                    passador_de_vez.Top = 400;
                    turno_ += 1;
                    turno.Text = "Turno" + (turno_).ToString();
                    timer3.Start();
                    cronometro.Reset();
                    cronometro.Start();
                    timer6.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (Personagens[i_def_an].Img.Left - Img_an.Left >= 10 ||
                Personagens[i_def_an].Img.Left - Img_an.Left <= -10)
                if (relaçao_2 < 1)
                    Img_an.Left = Img_an.Left + (int)Math.Round(7 * relaçao_2*((Personagens[i_def_an].Img.Left - Img_an.Left) /
                        NumPositivoInteiro(Personagens[i_def_an].Img.Left - Img_an.Left)));
                else
                    Img_an.Left = Img_an.Left + (7 *(Personagens[i_def_an].Img.Left - Img_an.Left) /
                        NumPositivoInteiro(Personagens[i_def_an].Img.Left - Img_an.Left));

            else
                img_Left = true;

            if (Personagens[i_def_an].Img.Top - Img_an.Top >= 10 ||
                Personagens[i_def_an].Img.Top - Img_an.Top <= -10)
                if (relaçao_2 < 1)
                    Img_an.Top = Img_an.Top + 7 * ((Personagens[i_def_an].Img.Top - Img_an.Top) / NumPositivoInteiro(Personagens[i_def_an].Img.Top - Img_an.Top));
                else
                    Img_an.Top = Img_an.Top + (int)Math.Round((7/relaçao_2) * ((Personagens[i_def_an].Img.Top - Img_an.Top) / NumPositivoInteiro(Personagens[i_def_an].Img.Top - Img_an.Top)));
            else
                img_Top = true;


            if (img_Top == true && img_Left == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                img_Left = false;
                img_Top = false;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Img_an.Visible = true;
            contador_an += 1;

            if(contador_an % 2 != 0)
                Img_an.Visible = false;

            if (contador_an >= 10)
            {
                Img_an.Visible = true;
                contador_an = 0;
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            passador_de_vez.Visible = true;
            passador_de_vez.Top = passador_de_vez.Top - 2;
            if (passador_de_vez.Top <= 200)
            {
                passador_de_vez.Visible = false;              
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button1.Visible = true;
            contador_an += 1;

            if (contador_an % 2 != 0)
                button1.Visible = false;

            if (contador_an >= 15)
            {
                contador_an = 0;
                button1.Visible = false;
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            contador_an += 1;

            if (contador_an % 2 != 0)
                pictureBox4.Visible = false;

            if (contador_an >= 10)
            {
                pictureBox4.Visible = false;
                contador_an = 0;
                timer5.Stop();
            }
        }

        private void btn_correr_Click(object sender, EventArgs e)
        {
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);

            if (atk_selecionado == false && Personagens[i].ModAçao == false)
            {
                Personagens[i].MR = Personagens[i].MR + Personagens[i].MT;
                movimento_restante.Text = Personagens[i].MR.ToString();
                Personagens[i].ModAçao = true;
                MenuJogador(Personagens, i);
                FinalDeTurno();
            }
        }

        private void btn_concentraçao_Click(object sender, EventArgs e)
        {
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);

            if (atk_selecionado == false && Personagens[i].ModAçao == false)
            {
                Personagens[i].Mod_Concentraçao = true;
                Personagens[i].ModAçao = true;
                MenuJogador(Personagens, i);
                FinalDeTurno();
            }

        }

        private void btn_Postura_defensiva_Click(object sender, EventArgs e)
        {
            int i = LocalizarPersonagem(Personagens, personagem_selecionado);

            if (atk_selecionado == false && Personagens[i].ModAçao == false)
            {
                Personagens[i].Mod_Postura_Defensiva = true;
                Personagens[i].Armad_Temporario += Personagens[i].Des * Personagens[i].Intel;
                Personagens[i].ModAçao = true;
                Personagens[i].Img.BackColor = Color.Blue;
                MenuJogador(Personagens, i);
                FinalDeTurno();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tempoemSegundos = Convert.ToInt32(cronometro.Elapsed.TotalSeconds);
            if (vez_do_jogador == true)
            {
                tempo.Text = (160 - tempoemSegundos).ToString();
                if (tempoemSegundos == 160)
                {
                    cronometro.Stop();
                    tempoemSegundos = 0;
                    for (int i = 0; i <= 5; i++)
                    {
                        Personagens[i].MR = 0;
                        Personagens[i].ModAçao = true;
                    }
                    tempo_total_jogador1 += Convert.ToInt16(tempo.Text);
                }
            }
            if (vez_do_jogador == false)
            {
                tempo.Text = (200 - tempoemSegundos).ToString();
                if (tempoemSegundos == 200)
                {
                    for (int i = 5; i <= 19; i++)
                    {
                        Personagens[i].MR = 0;
                        Personagens[i].ModAçao = true;
                    }
                    tempo_total_jogador2 += Convert.ToInt16(tempo.Text);
                }
            }
            FinalDeTurno();
       
        }

        private void FimDeJogo()
        {
            Double pontuaçao_pelo_turno = (1000/ turno_);
            pontuaçao_pelo_turno = (1.01*pontuaçao_pelo_turno) / turno_;
            int pontos_jogador_1 = (510 * turno_) - tempo_total_jogador1;
            int pontos_jogador_2 = (510 * turno_) - tempo_total_jogador2;
            int pontuaçao_jogador_1 = (int)Math.Round(pontuaçao_pelo_turno * pontos_jogador_1);
            int pontuaçao_jogador_2 = (int)Math.Round(pontuaçao_pelo_turno * pontos_jogador_2);
            if (vez_do_jogador == true)
            {
                pontuaçao_jogador_2 = 0;
                string recorde = jogador_1 + "  |  " + pontuaçao_jogador_1.ToString() + "  |  " + jogador_2 +
                    "  |  " + pontuaçao_jogador_2.ToString() + "  |  " + "JOGADOR 1" + Environment.NewLine;
                File.AppendAllText("Recordes_de_pontos.txt", recorde);
                s.Stop();
                s.SoundLocation = "som_final.wav";
                s.PlayLooping();
                MessageBox.Show("Vitoria do jogador 1");
                FrRecordes TelaRecorde = new FrRecordes();
                TelaRecorde.ShowDialog();
                TelaRecorde.jogador_1_venceu = 1;
            }
            else
            {
                pontuaçao_jogador_1 = 0;
                string recorde = jogador_1 + "  |  " + pontuaçao_jogador_1.ToString() + "  |  " + jogador_2 + 
                    "  |  " + pontuaçao_jogador_2.ToString() + "  |  " + "JOGADOR 2" + Environment.NewLine;
                File.AppendAllText("Recordes_de_pontos.txt", recorde);
                MessageBox.Show("Vitoria do jogador 2");
                s.Stop();
                s.SoundLocation = "som_final.wav";
                s.PlayLooping();
                FrRecordes TelaRecorde = new FrRecordes();
                TelaRecorde.ShowDialog();
                TelaRecorde.jogador_1_venceu = 0;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrRegras regras = new FrRegras();
            regras.ShowDialog();
        }
    }
}