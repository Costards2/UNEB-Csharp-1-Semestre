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
     this.nome   = nome;
     this.nomeIA = nomeIA;
     this.XouO = XouO;
     this.score = score;
   } 

   //Métodos GET
   public string getNome()
   {
      return(nome);     
   }

   public string getNomeIA()
   {
      return(nomeIA);     
   }
   
    public int getXouO()
    {
        return(XouO);     
    }
    
    public int getScore()
    {
        return(score);     
    }
     public int getScoreIA()
    {
        return(scoreIA);     
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
    
    public static void Main(){
        
        string nome;
        string nomeIA;
        int loop = 0;
        int score = 0, scoreIA = 0;
        int XouO =0 , XouOIA = 0;
        int linha, coluna;
        int[,] matriz = new int[3,3];
        Random numlinha = new Random();
        Random numColuna = new Random();
        int linhaIA, colunaIA; 
        
        try{
            
            Console.Write ("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.Write ("Qual o nome de seu oponente? ");
            nomeIA = Console.ReadLine ();

            Console.Write ("Você quer X ou O (Digite 1 para X ou 2 para 0)? ");
            XouO = int.Parse(Console.ReadLine());
            
            if (XouO == 1)
            {
                XouOIA = 2;
            }
            else if (XouO == 2)
            {
                XouOIA = 1;
            }
            Jogador jogador1 = new Jogador(nome, nomeIA, XouO, score, scoreIA); 
       
            Console.WriteLine("\nO seu nome é: {0}", jogador1.getNome());
            Console.WriteLine("O nome de seu oponente é: {0}", jogador1.getNomeIA()); 
            Console.WriteLine("Você escolheu (X ou O): {0}\n", + jogador1.getXouO());
            Console.WriteLine("Seu Score é: {0}", +jogador1.getScore());
            Console.WriteLine("O Score de {0} é: {1}\n", jogador1.getNomeIA(), jogador1.getScoreIA());
            
            do
            {
            
            for(int jogadas = 0; jogadas < 9; jogadas = 0 + 2 ){
            
            Console.Write("\nQual linha sera sua jogada? ");
            linha = int.Parse(Console.ReadLine());
            
            Console.Write("Qual coluna sera sua jogada? ");
            coluna = int.Parse(Console.ReadLine());
            
            linha--;
            coluna--;
            
            Console.Write("\nJogando...\n");
                    
            if(XouO == 1)
            {
            matriz [linha,coluna] = 1;
            }
            else if (XouO == 2 )
            {
            matriz [linha,coluna] = 2;
            }
            else
            {
            matriz [linha,coluna] = 0;
            }
            
            do
            {
            linhaIA = numlinha.Next(0,2);
            colunaIA = numColuna.Next(0,2);
            }
            while(matriz[linhaIA,colunaIA] != 0);
            
            if(XouOIA == 1)
            {
                matriz [linhaIA,colunaIA] = 1;
            }
            else if (XouOIA == 2 )
            {
                matriz [linhaIA,colunaIA] = 2;
            }
            else
            {
                matriz [linhaIA,colunaIA] = 0;
            }
    
            Console.Write("\nJogo da Velha:\n");
            
            for(int i = 0; i < 3; i++){ 
                for(int j = 0; j < 3; j++){
            
            if(matriz[i,j] == 1)
                {
                    Console.Write(" X ");
                }
                else if(matriz[i,j] == 2)
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
        
        }
        
            Console.WriteLine("Se você ganhou digite '9'.\nSe você perdeu digite '8'.\nPara encerrar o programa digite '7'.");
            loop = int.Parse(Console.ReadLine());
            
            if(loop == 9)()
            {
                Console.WriteLine("\nPARABÉNS PELA VITÓRIA!\n");
                score++;
            }
            else if(loop == 8)
            {
                Console.WriteLine("QUE PENA! MA PRÓXIMA VOCÊ CONSEGUE!\n");
                scoreIA++;
            }
            else if(loop == 7)
            {
                Console.WriteLine("PROGRAMA ENCERRADO!");
                break;
            }
            
            Console.WriteLine("Seu Score é: {0}", score);
            Console.WriteLine("O Score de {0} é: {1}\n", jogador1.getNomeIA(), scoreIA);
        
        }
        while(loop != 7);
        
        }   catch(Exception erro){ 
            Console.WriteLine("Formato de entrada errado!\n");
            Console.WriteLine("Erro: " + erro.Message);
            }
        }
}/*Main*/

}/*Classe*/
