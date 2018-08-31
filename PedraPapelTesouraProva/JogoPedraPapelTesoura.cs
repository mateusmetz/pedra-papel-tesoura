using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesouraProva
{
    public class JogoPedraPapelTesoura
    {
        public Jogador RPG_Game_Winner(Jogador jogador1, Jogador jogador2)
        {
            Jogador jogadorVencedor = new Jogador();

            Console.WriteLine(jogador1.getNome() + " Rock (R) Paper (P) Scissors(S)");
            String opcaoJogador1 = Console.ReadLine().ToUpperInvariant();

            Console.WriteLine(jogador2.getNome() + " Rock (R) Paper (P) Scissors(S)");
            String opcaoJogador2 = Console.ReadLine().ToUpperInvariant();

            if (!((opcaoJogador2.ToUpper().Equals("R") || opcaoJogador2.ToUpper().Equals("S") || opcaoJogador2.ToUpper().Equals("P")) && (opcaoJogador1.ToUpper().Equals("R") || opcaoJogador1.ToUpper().Equals("S") || opcaoJogador1.ToUpper().Equals("P"))))
            {
                Console.WriteLine("NoSuchStrategyError.");
            }

            else if ((opcaoJogador2.ToUpper().Equals("R") || opcaoJogador2.ToUpper().Equals("S") || opcaoJogador2.ToUpper().Equals("P")) && (opcaoJogador1.ToUpper().Equals("R") || opcaoJogador1.ToUpper().Equals("S") || opcaoJogador1.ToUpper().Equals("P")))
            {
                jogador1.setJogada(opcaoJogador1);
                jogador2.setJogada(opcaoJogador2);

                switch (jogador1.getJogada())
                {
                    case "R":
                        switch (jogador2.getJogada())
                        {
                            case "R":
                                return jogadorVencedor = jogador1;
                            case "P":
                                return jogadorVencedor = jogador2;
                            case "S":
                                return jogadorVencedor = jogador1;
                        }
                        break;
                    case "P":
                        switch (jogador2.getJogada())
                        {
                            case "P":
                                return jogadorVencedor = jogador1;
                            case "R":
                                return jogadorVencedor = jogador1;
                            case "S":
                                return jogadorVencedor = jogador2;
                        }
                        break;
                    case "S":
                        switch (jogador2.getJogada())
                        {
                            case "S":
                                return jogadorVencedor = jogador1;
                            case "P":
                                return jogadorVencedor = jogador1;
                            case "R":
                                return jogadorVencedor = jogador2;
                        }
                        break;
                }
            }
            return jogadorVencedor;
        }
    }
}