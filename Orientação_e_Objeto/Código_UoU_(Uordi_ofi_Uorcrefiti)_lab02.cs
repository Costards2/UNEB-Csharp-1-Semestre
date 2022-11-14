//AINDA ESTA SENDO FEITO
using System;

namespace UoU
{ 

 public class Heroi
 {
    private string nome;
    protected float ptsVida;

    public Heroi (string nome, float ptsVida)
    {
    this.nome = nome;
    this.ptsVida = ptsVida;
    }

   //Métodos GET
    public float getPtsVida()
    {
        return(ptsVida);     
    }
    
    public string getNome()
    {
        return(nome);     
    }

   //Métodos SET
   public void setPtsVida(float PtsVida)
    {
      this.ptsVida = ptsVida;    
    }
    
    public void setNome(string Nome)
    {
        this.nome = nome;    
    }
     
   
   //Métodos Geral
    public virtual void ReduzirVida()
    {
        
    this.ptsVida--;
        
    }
    
    public virtual void AumentarVida() 
    {
        
    this.ptsVida++;
        
    }
    
    public virtual void LancarMagia()
    {
        
    }
    
    public virtual void AtacarComArma()
    {
        
    }

   //Destrutor
    ~Heroi()
    {
     
    } 
    
    public static void Main(){
        
        string nome;
        float ptsVida;
        
        try
        {
            
            Console.Write ("Qual o nome do seu heroi? ");
            nome = Console.ReadLine();

            Console.Write ("Quais são seus pontos de vida? ");
            ptsVida =  int.Parse(Console.ReadLine ());
            
            Heroi Heroi1 = new Heroi (nome, ptsVida); //(Zymmax, 100); 
       
            Console.WriteLine("O nome do heroi é: {0}", Heroi1.getNome());
            Console.WriteLine("O potos de vida de {0}", Heroi1.getNome() + " é: " + Heroi1.getPtsVida()); 
           
            Console.WriteLine("Reduzindo e aumentando Vida...");
            
            Console.WriteLine("A vida aumentou para {0}", Heroi1.AumentarVida()); 
            Console.WriteLine("A vida diminuiu para {0}", Heroi1.ReduzirVida());
        }   
            catch(Exception erro){ 
            Console.WriteLine("Formato de entrada errado!\n");
            Console.WriteLine("Erro: " + erro.Message);
        }
}/*Main*/

}/*Classe*/

}/*UoU*/
