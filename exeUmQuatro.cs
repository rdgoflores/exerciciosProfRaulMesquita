using System;

namespace rodrigoFlores_15131
{
    public class Exercicio1_4
    {
        public Exercicio1_4(){}
        public void exercicio1_4()
        {
            Console.Clear();
            Console.Write("4. Escreva um algoritmo que escreve os números pares existentes no intervalo de 20 a 30."
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