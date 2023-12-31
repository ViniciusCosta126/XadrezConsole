﻿using tabuleiro;


namespace xadrez {
    class Rei : Peca {

        private PartidaDeXadrez Partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor) {
            Partida = partida;
        }
        public override string ToString() {
            return "R";
        }
        private bool PodeMover(Posicao pos) {
            Peca p = tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao pos) {
            Peca p = tab.Peca(pos);
            return p != null && p is Torre && p.Cor == Cor && QteMovimentos == 0;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // #jogada especial - Roque
            if (QteMovimentos == 0 && !Partida.xeque) {
                // Roque pequeno
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (tab.Peca(p1) == null && tab.Peca(p2) == null) {
                        mat[Posicao.Linha, pos.Coluna + 2] = true;
                    }
                }

                //Roque Grande

                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posT2)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (tab.Peca(p1) == null && tab.Peca(p2) == null && tab.Peca(p3) == null) {
                        mat[Posicao.Linha, pos.Coluna - 2] = true;
                    }
                }
            }


            return mat;
        }
    }
}