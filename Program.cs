using System;
using tabuleiro;
using XadrezConsole;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}