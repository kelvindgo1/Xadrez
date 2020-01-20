using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {}

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(pos.Linha - 1, pos.Coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }

            //ne
            pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }

            //direita
            pos.definirValores(pos.Linha, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }
            //se
            pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }

            //abaixo
            pos.definirValores(pos.Linha - 1, pos.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }

            //so
            pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }
            //esquerda
            pos.definirValores(pos.Linha, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }
            //no
            pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Coluna, pos.Linha] = true;
            }

            return mat;
        }
    }
}
