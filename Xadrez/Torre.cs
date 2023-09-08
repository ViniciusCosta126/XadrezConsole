﻿
using XadrezConsole.tabuleiro;

namespace XadrezConsole.Xadrez; 
internal class Torre:Peca{
    public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {

    }

    public override string ToString() {
        return "T";
    }
}
