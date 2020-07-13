using System;
namespace rodrigoFlores_15131
{
    public class Exercicio2_2
    {
        public Exercicio2_2(){}
        long num;
        char escolha;
        public void exercicio2_2()
        {
            Console.Clear();
            Console.Write("2. Escreva um programa que leia um número inteiro. Se o número lido for positivo, escreva"
                         +"\numa mensagem indicando se ele é par ou ímpar. Se o número for negativo, escreva a"
                         +"\nconsiderando também esses números."
                         +"\nseguinte mensagem “Este número não é positivo”."
                         +"\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Digite um número: ");
                num = Convert.ToInt64(Console.ReadLine());

                if(num > 0)
                {
                    long x =num%2;

                    if(x == 0)
                    {
                        Console.Write($"\nO número {num} é par.");
                    }else{
                        Console.Write($"\nO número {num} é ímpar.");
                    }
                }else if(num == 0)
                {
                    Console.Write("\nPor favor, digite um número maior ou menor que 0");
                }else{
                    Console.Write("\nEsse número não é positívo");
                }

                Console.Write("\n\n\nVerificar outro número? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }
    }
}