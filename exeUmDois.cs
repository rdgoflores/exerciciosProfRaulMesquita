using System;

namespace rodrigoFlores_15131
{
    public class Exercicio1_2
    {
        public Exercicio1_2(){}
        double n1 = 0;
        double n2 = 0;
        double n3 = 0;
        double medPon = 0;
        char escolha;

        public void exercicio1_2()
        {
            Console.Clear();
            Console.Write("2. Faça um algoritmo para ler as três notas de um aluno em uma disciplina e exibe a sua"
                        + "\nmédia ponderada (as notas tem pesos respectivos de 1, 3 e 5)."
                        + "\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();   
            do
            {
                Console.Clear();
                Console.Write("Nota da Prova 1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota da Prova 2: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota da Prova 3: ");
                n3 = Convert.ToDouble(Console.ReadLine());

                medPon = (n1*1 + n2*3 + n3*5)/9;

                Console.Write($"\n\nMédia Ponderada: {medPon.ToString("0.00")}");
                Console.Write("\n\ncalcular novamente? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }
    }
}