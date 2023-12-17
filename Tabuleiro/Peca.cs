
namespace XadrezConsole.tabuleiro
{
    internal class Peca
    {

        public Posicao? Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos += 1;
        }
    }
}
