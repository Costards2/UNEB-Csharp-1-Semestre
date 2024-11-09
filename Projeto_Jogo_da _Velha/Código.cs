/* Amélia gosta de desenvolver pequenos jogos para os seus filhos. O último que ela desenvolveu foi o jogo da velha. Para isso, ela relacionou as regras do jogo a fim de facilitar sua implementação. Haverá sempre um jogador virtual que será o próprio sistema, na figura do computador. O jogador real poderá escolher o nome do seu adversário. Além disso, o jogador real escolhe o símbolo que deseja usar (círculo ou cruz).

As regras são:

Traçam-se duas linhas verticais e duas linhas horizontais, de modo a criar nove quadrados de tamanhos iguais.

Um jogador joga desenhando um círculo e o seu adversário uma cruz.

O objetivo é cada jogador desenhar seu símbolo num quadrado vazio, tentando marcar uma linha de três símbolos iguais na horizontal, vertical ou diagonal; ou evitar que o adversário consiga essa linha de símbolos.

Cenário Principal:

O sistema prepara a lista de todos os jogadores cadastrados.
usuário informa:
O nome do jogador físico, selecionado de uma lista preexistente.
O símbolo usado pelo jogador lísico (círculo ou cruz).
O nome do jogador virtual, selecionado de uma lista preexistente.
O sistema associa automaticamente o símbolo usado pelo jogador virtual (círculo ou cruz).
O sistema define o jogador 1 como sendo o jogador físico e zera seu score.
O sistema define o jogador 2 como sendo o jogador virtual e zera seu score.
Para cada partida, altemadamente, jogador físico e virtual fazem a sua jogada. */


using System;

namespace Jogo_da_velha
{ 

public class Jogador
{
    private string nome;
    private string nomeIA;
    private int XouO;
    private int score;
    private int scoreIA;

    //Construtor
    Jogador(string nome, string nomeIA, int XouO, int score, int scoreIA)
    {
        this.nome = nome;
        this.nomeIA = nomeIA;
        this.XouO = XouO;
        this.score = score;
    }

    //Métodos GET
    public string getNome()
    {
        return (nome);
    }

    public string getNomeIA()
    {
        return (nomeIA);
    }

    public int getXouO()
    {
        return (XouO);
    }

    public int getScore()
    {
        return (score);
    }
    public int getScoreIA()
    {
        return (scoreIA);
    }

    //Métodos SET
    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void setNomeIA(string nomeIA)
    {
        this.nomeIA = nomeIA;
    }

    public void setXouO(int XouO)
    {
        this.XouO = XouO;
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    public void setScoreIA(int scoreIA)
    {
        this.scoreIA = scoreIA;
    }

    //Destrutor

    ~Jogador()
    {

    }

    public static void Main()
    {

        string nome;
        string nomeIA;
        int loop = 0;
        int score = 0, scoreIA = 0;
        int XouO = 0, XouOIA = 0;
        int linha, coluna;
        int[,] matriz = new int[3, 3];
        Random numlinha = new Random();
        Random numColuna = new Random();
        int linhaIA, colunaIA;
        int jogadas = 0;
        char simbolo = 'A';

        try
        {

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o nome de seu oponente? ");
            nomeIA = Console.ReadLine();

            Console.WriteLine("Você quer X ou O (Digite 1 para X ou 2 para 0)? ");
            XouO = int.Parse(Console.ReadLine());

            if (XouO == 1)
            {
                XouOIA = 2;
                simbolo = 'X';
            }
            else if (XouO == 2)
            {
                XouOIA = 1;
                simbolo = '0';
            }

            Jogador jogador1 = new Jogador(nome, nomeIA, XouO, score, scoreIA);

            Console.WriteLine("\nO seu nome é: {0}", jogador1.getNome());
            Console.WriteLine("O nome de seu oponente é: {0}", jogador1.getNomeIA());
            Console.WriteLine($"Você escolheu: {simbolo}\n");

            do
            {

                do
                {

                    Console.Write("\nQual linha sera sua jogada? ");
                    linha = int.Parse(Console.ReadLine());

                    Console.Write("Qual coluna sera sua jogada? ");
                    coluna = int.Parse(Console.ReadLine());

                    linha--;
                    coluna--;

                    Console.Write("\nJogando...\n");

                    if (XouO == 1)
                    {
                        matriz[linha, coluna] = 1;
                    }
                    else if (XouO == 2)
                    {
                        matriz[linha, coluna] = 2;
                    }

                    jogadas = jogadas + 1;

                    do
                    {
                        linhaIA = numlinha.Next(0, 3);
                        colunaIA = numColuna.Next(0, 3);
                    }
                    while ((matriz[linhaIA, colunaIA] == 1) || (matriz[linhaIA, colunaIA] == 2) && (jogadas != 9));

                    if (XouOIA == 1)
                    {
                        matriz[linhaIA, colunaIA] = 1;
                    }
                    else if (XouOIA == 2)
                    {
                        matriz[linhaIA, colunaIA] = 2;
                    }

                    jogadas = jogadas + 1;

                    Console.Write("\nJogo da Velha:\n");

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {

                            if (matriz[i, j] == 1)
                            {
                                Console.Write(" X ");
                            }
                            else if (matriz[i, j] == 2)
                            {
                                Console.Write(" O ");
                            }
                            else
                            {
                                Console.Write("   ");
                            }
                        }

                        Console.Write("\n");
                    }

                    //Horizontal

                    if ((matriz[0, 0] == XouO) && (matriz[0, 1] == XouO) && (matriz[0, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;

                    }
                    else if ((matriz[0, 0] == XouOIA) && (matriz[0, 1] == XouOIA) && (matriz[0, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if ((matriz[1, 0] == XouO) && (matriz[1, 1] == XouO) && (matriz[1, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;

                    }
                    else if ((matriz[1, 0] == XouOIA) && (matriz[1, 1] == XouOIA) && (matriz[1, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if ((matriz[2, 0] == XouO) && (matriz[2, 1] == XouO) && (matriz[2, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;

                    }
                    else if ((matriz[2, 0] == XouOIA) && (matriz[2, 1] == XouOIA) && (matriz[2, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }

                    //Vertical

                    else if ((matriz[0, 0] == XouO) && (matriz[1, 0] == XouO) && (matriz[2, 0] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;
                    }
                    else if ((matriz[0, 0] == XouOIA) && (matriz[1, 0] == XouOIA) && (matriz[2, 0] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if ((matriz[0, 1] == XouO) && (matriz[1, 1] == XouO) && (matriz[2, 1] == XouO))
                    {

                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;
                    }
                    else if ((matriz[0, 1] == XouOIA) && (matriz[1, 1] == XouOIA) && (matriz[1, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if ((matriz[0, 2] == XouO) && (matriz[1, 2] == XouO) && (matriz[2, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;
                    }
                    else if ((matriz[0, 2] == XouOIA) && (matriz[1, 2] == XouOIA) && (matriz[2, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }

                    //Diagonal

                    else if ((matriz[0, 0] == XouO) && (matriz[1, 1] == XouO) && (matriz[2, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;
                    }
                    else if ((matriz[2, 0] == XouO) && (matriz[1, 1] == XouO) && (matriz[0, 2] == XouO))
                    {
                        score++;
                        Console.WriteLine("       \r\n  / _ \\___________/`/\\+-/\\'\\'\\\r\n\\_\\(_)/_/ Vitória -+-    -+-+-\r\n _//o\\\\_          \\'\\/+-\\/`/`/\r\n  /   \\            \\/-+--\\/`/  \n");
                        Console.WriteLine("\nPARABÉNS!\n");
                        break;
                    }
                    else if ((matriz[0, 0] == XouOIA) && (matriz[1, 1] == XouOIA) && (matriz[2, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if ((matriz[2, 0] == XouOIA) && (matriz[1, 1] == XouOIA) && (matriz[0, 2] == XouOIA))
                    {
                        scoreIA++;
                        Console.WriteLine("                  \r\n            o    o\r\n   _Derrota_ )  ( \r\n{(((((((((( ( o_o)\r\n  /\\/\\/\\/\\/\\ `--   \n");
                        Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                        break;
                    }
                    else if (jogadas == 9)
                    {
                        Console.WriteLine("EMPATE!\n");
                    }

                }
                while (jogadas < 9);

                jogadas = 0;

                Console.WriteLine("Seu Score é: {0}", +jogador1.getScore());
                Console.WriteLine("O Score de {0} é: {1}\n", jogador1.getNomeIA(), jogador1.getScoreIA());

                Console.WriteLine("Para encerrar o programa digite '6', caso queira continuar digite qualquer outro numero.");
                loop = int.Parse(Console.ReadLine());

                Array.Clear(matriz, 0, matriz.Length);

            }
            while (loop != 6);
        }
        catch (Exception erro)
        {
            Console.WriteLine("Formato de entrada errado!\n");
            Console.WriteLine("Erro: " + erro.Message);
        }
    }
}
