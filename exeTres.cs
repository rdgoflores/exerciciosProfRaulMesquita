using System;

namespace rodrigoFlores_15131
{
    public class Exercicio3
    {
        public Exercicio3(){}
        public int n1;
        public int n2;
        public int n3;
        public int index0;
        public int index1;
        public int index2;
        public int maior;
        public int media;
        public char escolha;

        public void exercicio3_A()
        {
            if(n1>n2 && n1>n3)
            {
                maior = n1;
            }else if(n2>n3)
            {
                maior = n2;
            }else{
                maior = n3;
            }
            
            Console.Write($"\n    O maior número é {maior}");
        }

        public void exercicio3_B()
        {
            if(n1>n2 && n1>n3)
            {
                index0 = n1;
            }else if(n2>n3)
            {
                index0 = n2;
            }else{
                index0 = n3;
            }
            
            if(n1<n2 && n1<n3)
            {
                index2 = n1;
            }else if(n2<n3)
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
            
            Console.Write($"\n    {index0} > {index1} > {index2}");
        }

        public void exercicio3_C()
        {
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
            
            Console.Write($"\n    {index0} < {index1} < {index2}");
        }

        public void exercicio3_D()
        {
            media = (n1+n2+n3)/3;

            Console.Write($"\n    Média = {media}");
        }

        public void exercicio3_main()
        {
            Exercicio3 m3 = new Exercicio3();
            
            Console.Clear();
            Console.Write($"    Faça um algoritmo lê três números reais quaisquer e, conforme a seleção de"
                        + "\numa das letras abaixo, além de executar o que está sendo pedido, escreve os"
                        + "\nnúmeros digitados, em sua ordem original, e se for digitada uma letra diferente,"
                        + "\nmostra a mensagem “letra inválida”."
                        + "\n   a) Escreve o maior dos números digitados;"
                        + "\n   b) Escreve os números digitados na ordem decrescente;"
                        + "\n   c) Escreve os números digitados na ordem crescente;"
                        + "\n   d) Calcula a média aritmética dos números."
                        + "\n\n     Tecle 'enter' para continuar...        ");
            Console.ReadKey();
            
            Console.Write("\n\nDefina nº 1: ");
            this.n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Defina nº 2: ");
            this.n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Defina nº 3: ");
            this.n3 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Clear();
                Console.Write(" Escolha:"
                            + "\n\n[a] Imprimir o Maior deles"
                            + "\n[b] Imprimir em Ordem Decrescente"
                            + "\n[C] Imprimir em Ordem Crescente"
                            + "\n[d] Imprimir a Média Aritmética"
                            + "\n\n ");
                
                
                escolha = Convert.ToChar(Console.ReadLine());
                
                if(escolha == 'a' || escolha == 'A')
                {
                    exercicio3_A();
                }else if(escolha == 'b' || escolha == 'B')
                {
                    exercicio3_B();
                }else if (escolha == 'c' || escolha == 'C')
                {
                    exercicio3_C();
                }else{
                    exercicio3_D();
                }

                Console.Write("\n\nEscolher outra opção? [s/n]  ");
                escolha = Convert.ToChar(Console.ReadLine());
                
            }while(escolha == 's' || escolha == 'S');
        }
    }
}