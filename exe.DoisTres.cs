using System;

namespace rodrigoFlores_15131
{
    public class Exercicio2_3
    {
        public Exercicio2_3(){}
        char escolha;
        int nota;
        public void exercicio2_3()
        {
            Console.Clear();
            Console.Write("3. Fazer um algoritmo que escreva o conceito de um aluno, dada a sua nota. Considerar,"
                         +"\npara fins de exercício, que as notas sejam sempre inteiras. O critério para conceitos"
                         +"\ndeverá ser:"
                         +"\n   nota inferiores a 3 conceito E"
                         +"\n   nota de 3 a 5 conceito D"
                         +"\n   notas 6 e 7 conceito C"
                         +"\n   notas 8 e 9 conceito B"
                         +"\n   nota 10 conceito A"
                         +"\n\n Pressione 'Enter' para começar     ");
            
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Digite o valor da nota: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if(nota < 3)
                {
                    Console.WriteLine("\nConceito E");
                }else if(nota > 2 && nota < 6)
                {
                    Console.WriteLine("\nConceito D");
                }else if(nota > 5 && nota < 8)
                {
                    Console.WriteLine("\nConceito C");
                }else if(nota > 7 && nota < 10)
                {
                    Console.WriteLine("\nConceito B");
                }else if(nota >= 10)
                {
                    Console.WriteLine("\nConceito A");
                }

                Console.Write("\n\n\nVerificar outra nota? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }
    }
}