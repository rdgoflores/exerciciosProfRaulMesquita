// Fundação Escola Técnica Liberato Salzano Vieira da Cunha – NH
// Curso Técnico de Informática em Internet - Algoritmos de Programação
// Prof. Raul F. de Mesquita
// 1o semestre/2020
//
// Aluno: Rodrigo Flores
// Turma: 15131
//
// Lista de exercícios de Algoritmos Sequenciais e com Seleção
//
// Resposta aos 3 anexos enviados até 11/07. 
//
// Exercícios do primeiro anexo - 1.1 a 1.5
// Exercícios do segundo anexo - 2.1 a 2.6
// Exercícios do terceiro anexo - 3

using System;

namespace rodrigoFlores_15131
{
    class mainMenu
    {
        static void Main(string[] args)
        {
            Exercicio1_1 e11 = new Exercicio1_1();
            Exercicio1_2 e12 = new Exercicio1_2();
            Exercicio1_3 e13 = new Exercicio1_3();
            Exercicio1_4 e14 = new Exercicio1_4();
            Exercicio1_5 e15 = new Exercicio1_5();
            Exercicio2_1 e21 = new Exercicio2_1();
            Exercicio2_2 e22 = new Exercicio2_2();
            Exercicio2_3 e23 = new Exercicio2_3();
            Exercicio2_4 e24 = new Exercicio2_4();
            Exercicio2_5 e25 = new Exercicio2_5();
            Exercicio2_6 e26 = new Exercicio2_6();
            Exercicio3 e3 = new Exercicio3();
            
            string escolha;

            do
            {
                Console.Clear();
                Console.Write("\nLista de exercícios de Algoritmos Sequenciais:"
                            + "\n\nExercício 1.1 [a]"
                            + "\nExercício 1.2 [b]"
                            + "\nExercício 1.3 [c]"
                            + "\nExercício 1.4 [d]"
                            + "\nExercício 1.5 [e]"
                            + "\nExercício 2.1 [f]"
                            + "\nExercício 2.2 [g]"
                            + "\nExercício 2.3 [h]"
                            + "\nExercício 2.4 [i]"
                            + "\nExercício 2.5 [j]"
                            + "\nExercício 2.6 [k]"
                            + "\nExercício 3 [l]"
                            + "\n\n"
                            + "Escolha algum exercício da lista: ");
                escolha = Console.ReadLine();

                if(escolha == "a" || escolha == "A")
                {
                    e11.exercicio1_1();
                }else if(escolha == "b" || escolha == "B")
                {
                    e12.exercicio1_2();
                }else if(escolha == "c" || escolha == "C")
                {
                    e13.exercicio1_3();
                }else if(escolha == "d" || escolha == "D")
                {
                    e14.exercicio1_4();
                }else if(escolha == "e" || escolha == "E")
                {
                    e15.exercicio1_5();
                }else if(escolha == "f" || escolha == "F")
                {
                    e21.exercicio2_1();
                }else if(escolha == "g" || escolha == "G")
                {
                    e22.exercicio2_2();
                }else if(escolha == "h" || escolha == "H")
                {
                    e23.exercicio2_3();
                }else if(escolha == "i" || escolha == "I")
                {
                    e24.exercicio2_4();
                }else if(escolha == "j" || escolha == "J")
                {
                    e25.exercicio2_5();
                }else if(escolha == "k" || escolha == "K")
                {
                    e26.exercicio2_6();
                }else{
                    e3.exercicio3_main();
                }

                Console.Write("\nDeseja voltar para a lista de exercícios? [s/n]   ");
                escolha = Console.ReadLine();

            }while(escolha == "s" || escolha == "S");
        }
    }
}