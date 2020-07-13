using System;

namespace rodrigoFlores_15131
{
    public class Exercicio1_3
    {
        public Exercicio1_3(){}
        double salario = 1200;
        double c1 = 0;
        double c2 = 0;
        double atraso1 = 0;
        double atraso2 = 0;
        char escolha;

        public void exercicio1_3()
        {   
            Console.Clear();
            Console.Write("3. João recebeu seu salário de R$ 1200,00 (líquido) e precisa pagar duas contas C1 e C2."
                        + "\nComo as contas estão atrasadas, João terá de pagar multa de 2% sobre cada conta,"
                        + "\nmais o percentual de 1/30 avos por dia de atraso considerando juro de mora de 1% ao mês"
                        + "\nFaça um algoritmo que lê o valor de cada uma das contas e quantos dias estão atrasadas." 
                        + "\nCalcule e mostre o valor de cada conta paga e quanto restará do salário do João."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Qual o valor da Conta 1? R$ ");
                c1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write("Qual o valor da Conta 2? R$ ");
                c2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write($"Quantos dias a Conta 1 está atrasada? ");
                atraso1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write($"Quantos dias a Conta 2 está atrasada? ");
                atraso2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                c1 =+ c1 + (((c1*2)/100) + (((c1*1/100)/30)*atraso1));
                c2 =+ c2 + (((c2*2)/100) + (((c2*1/100)/30)*atraso2));

                salario =+ salario-c1-c2;

                Console.Write($"Valor da Conta 1 com juros {c1:c}"
                        +$"\nValor da Conta 2 com juros {c2:c}"
                        +$"\n\nSaldo salário de João {salario:c}");

                Console.Write("\n\ncalcular novamente? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }
    }
}