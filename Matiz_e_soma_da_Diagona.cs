using System;
using System.Collections.Generic;
using System.Text;
class matriz
    {
        int i, j, m, n;
        int[,] a = new int[20, 20];
        public void get()
        {
            Console.WriteLine("Coloque a quantidade de linhas:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a quantidade de colunas:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque os elementos 1 por 1 :");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void diag()
        {
            int d;
            d = 0;
            if (m == n)
            {
                for (i = 1; i <= m; i++)
                {
 
                    for (j = 1; j <= n; j++)
                    {
                        if (i == j)
                        {
                            d = d + a[i, j];
                        }
 
                    }
                }
                Console.WriteLine("Soma diagonal= {0}", d);
            }
            else
            {
                Console.WriteLine("Não dá para fazer uma soma diagonal");
            }
        }
    class matsum
    {
        static void Main(string[] args)
        {
            matriz ma = new matriz();
            ma.get();
            ma.diag();
            Console.Read();
        }
    }
} 
