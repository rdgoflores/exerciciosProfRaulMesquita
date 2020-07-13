using System;

namespace rodrigoFlores_15131
{
    public class Exercicio1_1
    {
        public Exercicio1_1(){}
        string nomeFuncionario;
        double valorHora;
        double horasTrab;
        double minutosTrab;
        double numeroFilho;
        double valorReceber;
        char conf;
        char escolha;

        public void exercicio1_1()
        {
            Console.Clear();
            Console.Write("1. Escrever um algoritmo que lê o nome de um funcionário, o número de horas"
                        + "\ntrabalhadas, o valor que recebe por hora e o número de filhos. Com estas informações,"
                        + "\ncalcular o salário deste funcionário, sabendo que para cada filho, o funcionário recebe"
                        + "\n4% a mais, calculado sobre o salário bruto."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();
            do
            {    
                Console.Clear();
                Console.Write("\nNome do Funcionário: ");
                nomeFuncionario = Console.ReadLine();
                Console.Clear();
                Console.Write("\nValor hora R$ ");
                valorHora = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                
                do
                {
                    Console.Write("\nHoras trabalhadas: ");
                    horasTrab = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.Write("\nMinutos trabalhados: ");
                    minutosTrab = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.Write("{0}h{1}m",horasTrab, minutosTrab);
                    Console.Write("\n\nConfirma? (s/n)      ");
                    conf=Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                }while(conf == 'n' || conf == 'N');

                Console.Write("\nQuantos filhos {0} tem?  ", nomeFuncionario);
                numeroFilho = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                valorReceber = (horasTrab + (minutosTrab/60))*valorHora;

                if(numeroFilho > 0)
                {
                    valorReceber = valorReceber+(((valorReceber*4)/100)*numeroFilho);
                }

                Console.Write($"\n Funcionário: {nomeFuncionario}"
                            + $"\n Horas Trabalhadas: {horasTrab}h{minutosTrab}m"
                            + $"\n Valor da Hora R$ {valorHora.ToString("0.00")}"
                            + $"\n Filhos: {numeroFilho}"
                            + $"\n\n TOTAL À RECEBER R$ {valorReceber.ToString("0.00")}\n\n");
                
                Console.Write("Deseja repetir o programa 1? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());

            }while(escolha == 's' || escolha == 'S');
        }
    }
}