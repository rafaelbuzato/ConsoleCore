using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Ronando está chutando \n";
        }

        public string Corre()
        {
            return "Ronaldo está Correndo \n";
        }

        public string Passe()
        {
            return "Ronaldo está passando \n";
        }
    }
}