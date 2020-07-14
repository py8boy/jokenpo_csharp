using System;
using System.Threading;
namespace jokenpo_game
{
    class Program
    {
        static void Main(string[] args)
        {

            // criação das variáves utilizadas no programa
            string iniciar = "null";                 // variavel para iniciar o jogo
            string continuar = "null";                    // variável para sair do jogo

            string player = "null";                  // armazena a jogada do usuário
            string computador = "null";              // armazena a jogada do computador

            int vitorias = 0;                        // contabiliza as vitórias do usuário
            int derrotas = 0;                        // contabiliza as derrotas do usuário
            int total = 0;                           // pontuação total = vitorias - derrotas
            
            // este laço while vai rodar e mostrar o "manual" do jogo enquanto o usuário não comecar o jogo
            while (true)
            {
                Console.WriteLine("               [LEIA ANTES DE JOGAR]        \n" +
                                  "     O jogo funciona da seguinte forma, você deverá \n" +
                                  "     escolher PEDRA, PAPEL ou TESOURA. O computador \n" +
                                  "     também fará a sua jogada. Por cada vitória você \n" +
                                  "     ganha 1 ponto e a cada derrota você perde 1 ponto.\n"); ;
                Console.Write("     Você entendeu? [Y/n] ");
                iniciar = Console.ReadLine();

                // verifica se o usuário quer jogar ou não
                if (iniciar == "Y" || iniciar == "y")
                {
                    break;
                }
            }

            // laço infinito que irá rodar a parte mais importante do software, vai ficar rodando enquanto
            // o usuário disser que ainda quer jogar
            while (true)
            {
                Console.WriteLine("\n --------------------------------------------------------- \n");

                Console.WriteLine("Ok. Vamos jogar! ");

                // entrada da jogada do usuário
                Console.Write("Qual é a sua jogada? [pedra/papel/tesoura] ");
                player = Console.ReadLine();

                // randomização da jogada do computador
                Random num = new
                Random();

                // categoriza a jogada do computador como PEDRA, PAPEL ou TESOURA
                int num_computador = num.Next(1, 3);
                switch (num_computador)
                {
                    case 1:
                        computador = "pedra";
                        break;
                    case 2:
                        computador = "papel";
                        break;
                    case 3:
                        computador = "tesoura";
                        break;
                }


                // verifica quem foi o vencedor da partida
                if (computador == "pedra" && player == "pedra")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Empatamos \n");
                }
                else if (computador == "papel" && player == "papel")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Empatamos \n");
                }
                else if (computador == "tesoura" && player == "tesoura")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Empatamos \n");
                }

                else if (computador == "pedra" && player == "tesoura")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Ganhei \n");
                    derrotas += 1;
                }
                else if (computador == "papel" && player == "pedra")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Ganhei \n");
                    derrotas += 1;
                }
                else if (computador == "tesoura" && player == "pedra")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Ganhei \n");
                    derrotas += 1;
                }

                else if (player == "pedra" && computador == "tesoura")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Você ganhou \n");
                    vitorias += 1;
                }
                else if (player == "papel" && computador == "pedra")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Você ganhou \n");
                    vitorias += 1;
                }
                else if (player == "tesoura" && computador == "pedra")
                {
                    Console.WriteLine($"Eu escolhi {computador}. Você ganhou \n");
                    vitorias += 1;
                }


                // pergunta se o usuário ainda quer continuar a jogar
                Console.Write("Jogar novamente? [Y/n]\n");
                continuar = Console.ReadLine();

                if (continuar == "N" || continuar == "n")
                {
                    break;
                }
            }

            // contabiliza a pontuação total e caso ela seja negativa passa a ser 0
            total = (vitorias - derrotas);
            if (total < 0)
            {
                total = 0;
            }

            // finalização do programa e impressão dos resultados da partidas
            Console.WriteLine("\n\n---------------------------------------------\n\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Ahh, você já parou de jogar?");

            Thread.Sleep(1000);
            Console.WriteLine($"Sem problemas amigo, estou ansioso \n" +
                              $"para a nossa partida :)");

            Thread.Sleep(1000);
            Console.WriteLine($"Mas olha seus resultados: ");
            Console.WriteLine($"                          VITÓRIAS:   {vitorias} \n" +
                              $"                          DERROTAS:   {derrotas} \n" +
                              $"                          PONTUAÇÃO:  {total} pontos");

            // criei essa READKEY para o programa não fechar automaticamente
            Console.Write("\n\n <enter para sair>");
            Console.ReadKey();
        }
    }
}

