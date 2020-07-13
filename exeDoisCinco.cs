using System;

namespace rodrigoFlores_15131
{
    public class Exercicio2_5
    {
        public Exercicio2_5(){}
        long n1 = 0;
        long n2 = 0;
        long n3 = 0;
        long menor = 0;
        char escolha;
        public void exercicio2_5()
        {
            Console.Clear();
            Console.Write("5. Escreva um algoritmo que lê três valores quaisquer e exibe o menor deles."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();  

            do
            {
                Console.Clear();
                Console.Write("\nDigite o primeiro número...: ");
                n1 = Convert.ToInt64(Console.ReadLine());
                Console.Write("\nDigite o segundo número....: ");
                n2 = Convert.ToInt64(Console.ReadLine());
                Console.Write("\nDigite o terceiro número...: ");
                n3 = Convert.ToInt64(Console.ReadLine());

                if(n1<n2 && n1<n3)
                {
                    menor = n1;
                }else if(n2<n3)
                {
                    menor = n2;
                }else{
                    menor = n3;
                }
                
                Console.Write($"\n\nO menor número é {menor}");
                
                Console.Write("\n\n\nVerificar outros números? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');            
        }      
    }
}