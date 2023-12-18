
using tabuleiro;

namespace xadrez;
internal class Torre : Peca {
    public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {

    }

    public override string ToString() {
        return "T";
    }
    private bool podeMover(Posicao pos) {
        Peca p = tab.Peca(pos);
        return p == null || p.Cor != Cor;
    }
    public override bool[,] MovimentosPossiveis() {
        bool[,] mat = new bool[tab.Linhas, tab.Colunas];
        Posicao pos = new Posicao(0, 0);

        //acima
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        while (tab.PosicaoValida(pos) && podeMover(pos)) {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                break;
            }
            pos.Linha--;
        }

        //abaixo
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        while (tab.PosicaoValida(pos) && podeMover(pos)) {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                break;
            }
            pos.Linha++;
        }
        //esquerda 
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        while (tab.PosicaoValida(pos) && podeMover(pos)) {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                break;
            }
            pos.Coluna--;
        }
        //direita 
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        while (tab.PosicaoValida(pos) && podeMover(pos)) {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.Peca(pos) != null && tab.Peca(pos).Cor != Cor) {
                break;
            }
            pos.Coluna++;
        }

        return mat;
    }
}
