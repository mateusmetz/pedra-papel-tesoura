using PedraPapelTesouraProva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaJogador novoJogo = new ListaJogador();
            Console.WriteLine("Digite a quantidade de jogadores");
            int totalJogadoresDigitados = int.Parse(Console.ReadLine());

            List<Jogador> lista = new List<Jogador>();
            lista = novoJogo.ContadorJogadores(totalJogadoresDigitados);

            JogoPedraPapelTesoura novoRPS = new JogoPedraPapelTesoura();
            Jogador jogadorVencedor = novoRPS.RPG_Game_Winner(lista[0], lista[1]);
            
            Console.WriteLine(jogadorVencedor.getNome() + " venceu a partida");
            Console.WriteLine(jogadorVencedor.getNome() + " jogou " + jogadorVencedor.getJogada());

            //Tentativa de fazer o torneio.
            //Acaba entrando em Looping infinito de jogadas

            /* List<Jogador> jogadoresVencedores = new List<Jogador>();

             while (lista.Count > 1)
             {
                 for (int i = 0; i < lista.Count-1; i++)
                 {
                     Jogador vencedorPartida = campeonato.Partida(lista[i], lista[i + 1]);
                     jogadoresVencedores.Add(vencedorPartida);
                     i++;
                 }
             }*/
        }
    }
}


