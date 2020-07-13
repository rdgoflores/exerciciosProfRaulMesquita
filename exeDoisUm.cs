using System;

namespace rodrigoFlores_15131
{
    public class Exercicio2_1
    {
        public Exercicio2_1(){}
        public void exercicio2_1()
        {
            Console.Clear();
            Console.Write("1. Escreva um algoritmo que escreve os números pares existentes no intervalo de 20 a 30,"
                         +"\nconsiderando também esses números."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();  

            Console.Clear();
            for(int i=20; i<=30; i++)
            {
                int y = i%2;
                if(y == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }      
    }
}