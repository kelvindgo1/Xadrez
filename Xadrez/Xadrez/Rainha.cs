using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    class Rainha : Peca 
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        { }

        public override string ToString()
        {
            return "D";
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            return mat;
        }
    }
}
