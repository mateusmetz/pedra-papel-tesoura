using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PedraPapelTesouraProva
{
    public class ListaJogador
    {
        public List<Jogador> ContadorJogadores(int totalJogadoresDigitados)
        {
            int numeroJogadores = totalJogadoresDigitados;
            List<Jogador> jogadores = new List<Jogador>();

            if (!(numeroJogadores == 2))
            {
                Console.WriteLine("WrongNumberOfPlayers");
            }

            else if (numeroJogadores == 2)
            {
                for (var i = 0; i < numeroJogadores; i++)
                {
                    Jogador novoJogador = new Jogador();
                    Console.WriteLine("Digite o nome do Jogador");
                    string nomeJogador = Console.ReadLine();
                    novoJogador.setNome(nomeJogador);
                    jogadores.Add(novoJogador);
                }
            }
            return jogadores;
         }
    }
}