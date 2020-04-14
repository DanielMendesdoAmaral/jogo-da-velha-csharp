using System;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] velha = new string[10]; //Esta variável é o jogo. Ora armazenando os números de 1-9, ora as jogadas de X e O.
            int jogo = 0, opcao = -1, pontosO = 0, pontosX = 0; //jogo é a posição onde o jogador quer jogar.  opcao são as opções ao decorrer do jogo, como voltar ao menu ou iniciar o jogo. pontos é a variável que armazena os pontos de cada jogador.
            string bar = "██", playerX, playerO, ganhou = "n"; //bar é a barra de carregamento.    player é o nome do jogador.  ganhou indica quem ganhou, e é um auxílio para terminar o jogo.

            for (int contador = 0; contador <= 100; contador++)
            {
                System.Console.WriteLine("                                                                                   Carregando o jogo... \n");
                System.Console.WriteLine("                                       _______________________________________________________________________________________________________");
                bar += "█";
                System.Console.WriteLine("                                       " + bar);
                System.Console.WriteLine("                                       ───────────────────────────────────────────────────────────────────────────────────────────────────────");
                System.Console.Write("                                                                                          " + contador + "%");
                System.Threading.Thread.Sleep(12);
                System.Console.Clear();
            }

            do
            {
                System.Console.WriteLine("                                                                                        MENU PRINCIPAL");
                System.Console.WriteLine("                                                                                 ___________________________");
                System.Console.WriteLine("                                                                                 | [1] Cadastrar jogadores |");
                System.Console.WriteLine("                                                                                 | [0] Sair                |");
                System.Console.WriteLine("                                                                                 ___________________________");
                System.Console.Write("                                                                                    ");
                opcao = Int32.Parse(Console.ReadLine());
                if ((opcao != 0) && (opcao != 1))
                {
                    System.Console.Clear();
                    System.Console.WriteLine("                                                                                 ERRO! ENTRADA INVÁLIDA!");
                    System.Threading.Thread.Sleep(1500);
                    System.Console.Clear();
                }
            } while ((opcao != 0) && (opcao != 1));

            System.Console.Clear();

            if (opcao == 1)
            {
                do
                {
                    System.Console.WriteLine("                                                                                    CADASTRO DE JOGADORES");
                    System.Console.WriteLine("                                                                                 ___________________________");
                    System.Console.Write("                                                                                    PLAYER 1 (X): ");
                    playerX = Console.ReadLine();
                    System.Console.Write("                                                                                    PLAYER 2 (O): ");
                    playerO = Console.ReadLine();
                    System.Console.WriteLine("                                                                                 ___________________________ \n \n");
                    System.Threading.Thread.Sleep(1500);
                    System.Console.Clear();
                    do
                    {
                        System.Console.WriteLine("                                                                                 _____________________________");
                        System.Console.WriteLine("                                                                                 | [2] Jogar                 |");
                        System.Console.WriteLine("                                                                                 | [1] Recadastrar jogadores |");
                        System.Console.WriteLine("                                                                                 | [0] Sair                  |");
                        System.Console.WriteLine("                                                                                 _____________________________");
                        System.Console.Write("                                                                                    ");
                        opcao = Int32.Parse(Console.ReadLine());
                        if ((opcao != 0) && (opcao != 1) && (opcao != 2))
                        {
                            System.Console.Clear();
                            System.Console.WriteLine("                                                                                 ERRO! ENTRADA INVÁLIDA!");
                            System.Threading.Thread.Sleep(1500);
                            System.Console.Clear();
                        }
                    } while ((opcao != 0) && (opcao != 1) && (opcao != 2));
                    System.Console.Clear();
                    if (opcao == 2)
                    {
                        opcao = -1;  
                        do
                        {
                            opcao = -1; //O BLOCO ABAIXO CRIA A PRIMEIRA ESTRUTURA, UMA ESTRUTURA TEMPORÁRIA PARA BASEAR A ESCOLHA DO JOGADOR
                            for (int contador = 1; contador <= 3; contador++)
                            {
                                velha[contador] = Convert.ToString(contador);
                                if (contador == 2)
                                {
                                    System.Console.Write("| " + velha[contador] + " |");
                                }
                                else
                                {
                                    System.Console.Write(" " + velha[contador] + " ");
                                }
                            }
                            System.Console.WriteLine("");
                            System.Console.WriteLine("-----------");
                            for (int contador = 4; contador <= 6; contador++)
                            {
                                velha[contador] = Convert.ToString(contador);
                                if (contador == 5)
                                {
                                    System.Console.Write("| " + velha[contador] + " |");
                                }
                                else
                                {
                                    System.Console.Write(" " + velha[contador] + " ");
                                }
                            }
                            System.Console.WriteLine("");
                            System.Console.WriteLine("-----------");
                            for (int contador = 7; contador <= 9; contador++)
                            {
                                velha[contador] = Convert.ToString(contador);
                                if (contador == 8)
                                {
                                    System.Console.Write("| " + velha[contador] + " |");
                                }
                                else
                                {
                                    System.Console.Write(" " + velha[contador] + " ");
                                }
                            }

                            
                            opcao = -1;
                            do
                            {
                                //O BLOCO ABAIXO CRIA OS JOGOS DE X
                                System.Console.WriteLine("\n \n");
                                do
                                {
                                    System.Console.Write(playerX + ", você quer jogar X em qual posição? ");
                                    jogo = Int32.Parse(Console.ReadLine());
                                    if ((jogo <= 0) || (jogo >= 10))
                                    {
                                        System.Console.WriteLine("ERRO! POSIÇÃO INEXISTENTE! \n");
                                    }
                                } while ((jogo <= 0) || (jogo >= 10));
                                if ((velha[jogo] == "O") || (velha[jogo] == "X"))
                                {
                                    do
                                    {
                                        System.Console.WriteLine("ERRO! ESPAÇO JÁ PREENCHIDO! \n");
                                        System.Console.Write(playerX + ", você quer jogar X em qual posição? ");
                                        jogo = Int32.Parse(Console.ReadLine());
                                    } while ((velha[jogo] == "O") || (velha[jogo] == "X"));
                                    velha[jogo] = "X";
                                }
                                else
                                {
                                    velha[jogo] = "X";
                                }
                                System.Console.Clear();
                                for (int contador = 1; contador <= 3; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                System.Console.WriteLine("");
                                System.Console.WriteLine("-----------");
                                for (int contador = 4; contador <= 6; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                System.Console.WriteLine("");
                                System.Console.WriteLine("-----------");
                                for (int contador = 7; contador <= 9; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                if (((velha[1] == "X") && (velha[2] == "X") && (velha[3] == "X")) || ((velha[4] == "X") && (velha[5] == "X") && (velha[6] == "X")) || ((velha[7] == "X") && (velha[8] == "X") && (velha[9] == "X")) || ((velha[1] == "X") && (velha[4] == "X") && (velha[7] == "X")) || ((velha[2] == "X") && (velha[5] == "X") && (velha[8] == "X")) || ((velha[3] == "X") && (velha[6] == "X") && (velha[9] == "X")) || ((velha[1] == "X") && (velha[5] == "X") && (velha[9] == "X")) || ((velha[3] == "X") && (velha[5] == "X") && (velha[7] == "X")))
                                {
                                    ganhou = "X";
                                    break;
                                }
                                else if ((velha[1] != "1") && (velha[2] != "2") && (velha[3] != "3") && (velha[4] != "4") && (velha[5] != "5") && (velha[6] != "6") && (velha[7] != "7") && (velha[8] != "8") && (velha[9] != "9"))
                                {
                                    ganhou = "E";
                                    break;
                                }

                                //O BLOCO ABAIXO CRIA OS JOGOS DE O
                                System.Console.WriteLine("\n \n");
                                do
                                {
                                    System.Console.Write(playerO + ", você quer jogar O em qual posição? ");
                                    jogo = Int32.Parse(Console.ReadLine());
                                    if ((jogo <= 0) || (jogo >= 10))
                                    {
                                        System.Console.WriteLine("ERRO! POSIÇÃO INEXISTENTE! \n");
                                    }
                                } while ((jogo <= 0) || (jogo >= 10));
                                if ((velha[jogo] == "O") || (velha[jogo] == "X"))
                                {
                                    do
                                    {
                                        System.Console.WriteLine("ERRO! ESPAÇO JÁ PREENCHIDO! \n");
                                        System.Console.Write(playerO + ", você quer jogar O em qual posição? ");
                                        jogo = Int32.Parse(Console.ReadLine());
                                    } while ((velha[jogo] == "O") || (velha[jogo] == "X"));
                                    velha[jogo] = "O";
                                }
                                else
                                {
                                    velha[jogo] = "O";
                                }
                                System.Console.Clear();
                                for (int contador = 1; contador <= 3; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 2)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                System.Console.WriteLine("");
                                System.Console.WriteLine("-----------");
                                for (int contador = 4; contador <= 6; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 5)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                System.Console.WriteLine("");
                                System.Console.WriteLine("-----------");
                                for (int contador = 7; contador <= 9; contador++)
                                {
                                    if (velha[contador] == "X")
                                    {
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else if (velha[contador] == "O")
                                    {
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                    else
                                    {
                                        velha[contador] = Convert.ToString(contador);
                                        if (contador == 8)
                                        {
                                            System.Console.Write("| " + velha[contador] + " |");
                                        }
                                        else
                                        {
                                            System.Console.Write(" " + velha[contador] + " ");
                                        }
                                    }
                                }
                                if (((velha[1] == "O") && (velha[2] == "O") && (velha[3] == "O")) || ((velha[4] == "O") && (velha[5] == "O") && (velha[6] == "O")) || ((velha[7] == "O") && (velha[8] == "O") && (velha[9] == "O")) || ((velha[1] == "O") && (velha[4] == "O") && (velha[7] == "O")) || ((velha[2] == "O") && (velha[5] == "O") && (velha[8] == "O")) || ((velha[3] == "O") && (velha[6] == "O") && (velha[9] == "O")) || ((velha[1] == "O") && (velha[5] == "O") && (velha[9] == "O")) || ((velha[3] == "O") && (velha[5] == "O") && (velha[7] == "O")))
                                {
                                    ganhou = "O";
                                    break;
                                }
                                else if ((velha[1] != "1") && (velha[2] != "2") && (velha[3] != "3") && (velha[4] != "4") && (velha[5] != "5") && (velha[6] != "6") && (velha[7] != "7") && (velha[8] != "8") && (velha[9] != "9"))
                                {
                                    ganhou = "E";
                                    break;
                                }
                            } while ((ganhou != "X") && (ganhou != "O") && (ganhou != "E"));
                            System.Console.Clear();
                            if (ganhou == "X")
                            {
                                pontosX++;
                            }
                            else if (ganhou == "O")
                            {
                                pontosO++;
                            }
                            opcao = -1;
                            System.Console.WriteLine("                                                                                        PLACAR  FINAL");
                            System.Console.WriteLine("                                                                                 ___________________________");
                            System.Console.WriteLine("                                                                                    " + playerX + ": " + pontosX);
                            System.Console.WriteLine("                                                                                    " + playerO + ": " + pontosO);
                            System.Console.WriteLine("                                                                                 ___________________________ \n \n");
                            if (ganhou == "X")
                            {
                                System.Console.WriteLine("                                                                                 Parabéns " + playerX + "! Você ganhou a partida!");
                                System.Console.WriteLine("                                                                                 " + playerO + ", vai querer uma revanche? \n");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.WriteLine("                                                                                 | [1] Revanche              |");
                                System.Console.WriteLine("                                                                                 | [0] Sair                  |");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.Write("                                                                                 ");
                                do
                                {
                                    opcao = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                } while ((opcao != 1) && (opcao != 0));
                            }
                            else if (ganhou == "O")
                            {
                                System.Console.WriteLine("                                                                                 Parabéns " + playerO + "! Você ganhou a partida jogo!");
                                System.Console.WriteLine("                                                                                 " + playerX + ", vai querer uma revanche? \n");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.WriteLine("                                                                                 | [1] Revanche              |");
                                System.Console.WriteLine("                                                                                 | [0] Sair                  |");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.Write("                                                                                 ");
                                do
                                {
                                    opcao = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                } while ((opcao != 1) && (opcao != 0));
                            }
                            else if (ganhou == "E")
                            {
                                System.Console.WriteLine("                                                                                 EMPATE!!! \n");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.WriteLine("                                                                                 | [1] Jogar denovo          |");
                                System.Console.WriteLine("                                                                                 | [0] Sair                  |");
                                System.Console.WriteLine("                                                                                 _____________________________");
                                System.Console.Write("                                                                                 ");
                                do
                                {
                                    opcao = Int32.Parse(Console.ReadLine());
                                    Console.Clear();
                                } while ((opcao != 1) && (opcao != 0));
                            }
                            ganhou = "Void";
                        } while (opcao == 1);
                    }
                    else
                    {
                        opcao = opcao;
                    }
                } while (opcao == 1);
            }
            else
            {
                opcao = opcao;
            }
        }
    }
}