﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 1).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 1).toPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('b', 1).toPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('g', 1).toPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('f', 1).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 1).toPosicao());
            tab.ColocarPeca(new Rainha(tab, Cor.Preta), new PosicaoXadrez('e', 1).toPosicao());


            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 8).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 8).toPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('b', 8).toPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('g', 8).toPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('c', 8).toPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('f', 8).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 8).toPosicao());
            tab.ColocarPeca(new Rainha(tab, Cor.Branca), new PosicaoXadrez('e', 8).toPosicao());
           
        }

    }
}
