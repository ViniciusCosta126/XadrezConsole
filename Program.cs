using System;
using tabuleiro;
using xadrez;
using XadrezConsole;
using XadrezConsole.tabuleiro;
using XadrezConsole.Xadrez;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new ('a',1);
            System.Console.WriteLine(pos);
            System.Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}