using System;

namespace rodrigoFlores_15131
{
    public class Exercicio1_5
    {
        public Exercicio1_5(){}
        string n = " ";
        int valor = 0;
        int valorFinal = 0;
        char escolha;

        public void exercicio1_5()
        {
            Console.Clear();
            Console.Write("5. Escrever um algoritmo que lê um valor em binário (1 byte) e escreve o decimal correspondente."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();   

            do
            {
                Console.Clear();
                Console.Write("Digite o valor binário: ");
                n = Console.ReadLine();

                for(var i = n.Length-1; i >= 0; i--)
                {
                    if(i == n.Length-1){
                        valorFinal += n[i] == '0' ? 0 : 1;
                        valor++;
                    }
                    else{
                        
                        valorFinal += n[i] == '0' ? 0 : valor*2;
                        valor *= 2;
                    }
                }

                Console.WriteLine("\nConvertido para decimal: " + valorFinal);
                Console.Write("\n\n     Converter outro? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());

            }while(escolha == 's' || escolha == 'S');
        }
    }
}