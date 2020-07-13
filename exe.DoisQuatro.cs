using System;

namespace rodrigoFlores_15131
{
    public class Exercicio2_4
    {
        public Exercicio2_4(){}
        long n1 = 0;
        long n2 = 0;
        long n3 = 0;
        long maior = 0;
        char escolha;
        public void exercicio2_4()
        {
            Console.Clear();
            Console.Write("4. Escreva um algoritmo que lê três valores quaisquer e exibe o maior deles."
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

                if(n1>n2 && n1>n3)
                {
                    maior = n1;
                }else if(n2>n3)
                {
                    maior = n2;
                }else{
                    maior = n3;
                }
                
                Console.Write($"\n\nO maior número é {maior}");
                
                Console.Write("\n\n\nVerificar outros números? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');            
        }      
    }
}