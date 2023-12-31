﻿using System;
using tabuleiro;


namespace Xadrez {
    class Dama : Peca {

        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }
        public override string ToString() {
            return "D";
        }

        private bool PodeMover(Posicao pos) {
            Peca p = tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);


            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.Linha--;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.Linha++;
            }
            //esquerda 
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.Coluna--;
            }
            //direita 
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.Coluna++;
            }

            //NO

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //SE

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            //SO

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            while (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}
