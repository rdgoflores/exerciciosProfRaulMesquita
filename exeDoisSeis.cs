using System;

namespace rodrigoFlores_15131
{
    public class Exercicio2_6
    {
        public Exercicio2_6(){}
        long n1 = 0;
        long n2 = 0;
        long n3 = 0;
        long index0 = 0;
        long index1 = 0;
        long index2 = 0;
        char escolha;
        public void exercicio2_6()
        {
            Console.Clear();
            Console.Write("6. Elabore um algoritmo que lê três valores quaisquer e exibe os três em ordem crescente."
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
                    index0 = n1;
                }else if(n2<n3)
                {
                    index0 = n2;
                }else{
                    index0 = n3;
                }
                
                if(n1>n2 && n1>n3)
                {
                    index2 = n1;
                }else if(n2>n3)
                {
                    index2 = n2;
                }else{
                    index2 = n3;
                }

                if(n1 != index0 && n1 != index2)
                {
                    index1 = n1;
                }else if(n2 != index0 && n2 != index2)
                {
                    index1 = n2;
                }else if((n3 != index0 && n3 != index2))
                {
                    index1 = n3;
                }
                
                Console.Write($"\n\n    {index0} < {index1} < {index2}");
                
                Console.Write("\n\n\nVerificar outros números? [s/n]   ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }      
    }
}