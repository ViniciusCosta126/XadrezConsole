﻿using System;
using XadrezConsole;
using XadrezConsole.tabuleiro;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

        }
    }
}