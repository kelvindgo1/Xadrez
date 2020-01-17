using System;
using tabuleiro;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();







            //try { 

            //Tabuleiro tab = new Tabuleiro(8, 8);

            //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 1));
            //tab.ColocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 2));
            //tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
            //tab.ColocarPeca(new Rainha(tab, Cor.Preta), new Posicao(0, 4));
            //tab.ColocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 5));
            //tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 6));
            //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 0));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 1));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 2));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 3));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 4));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 5));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 6));
            //tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 7));
           

            //Tela.ImprimirTabuleiro(tab);
            //}

            //catch(TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}           
        }
    }
}
