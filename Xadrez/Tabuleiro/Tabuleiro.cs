﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        public void ColocarPeca(Peca p, Posicao pos) 
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos; 
        }
    }
}
