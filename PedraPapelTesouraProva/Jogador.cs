using System;
using System.Collections.Generic;

namespace PedraPapelTesouraProva
{
    public class Jogador
    {
        String jogada;
        String nome;

        public string getJogada()
        {
            return this.jogada;
        }

        public String getNome()
        {
            return this.nome;
        }

        public string setJogada(String jogadaParametro)
        {
            this.jogada = jogadaParametro;
            return jogada;
        }

        public string setNome(String nomeParametro)
        {
            this.nome = nomeParametro;
            return nomeParametro;
        }
    }
}
  
    