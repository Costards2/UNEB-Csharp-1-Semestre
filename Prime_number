using System;
class HelloWorld {
    static void Main() {
        
        /* Escreva um programa que carregue um
        valor N, inteiro, pelo teclado e imprima os N
        primeiros números primos.*/ 
        
        int num = 0, i = 0, j = 0, result = 0, sentinela = 0;
        bool check = false;
        
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
 
        for (i = 1; i <= num ; i++) {
            //sentinela = 0;
            check = false;
            for (j = 2 ; j <= i/2 ; j++){
                result = i % j;
                if (result == 0){
                    //sentinela = 1;
                    check = true;
                    break;
                }
            }
            //if (sentinela == 0 ){
            if (!check /* check == false */){
                Console.WriteLine(" " + i);
            }
        }
    }
}
