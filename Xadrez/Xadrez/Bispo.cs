﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab,cor)
        {}

        public override string ToString()
        {
            return "B";
        }
    }
}