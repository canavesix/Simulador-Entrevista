using System;
using System.Collections.Generic;

namespace Entrevista
{
    class Program
    {
        static void Main(string[]args)
        {
            boool loopEntrevista = true;
            int idade = 0;
            string continuarEntrevista = string.Empty;
            string nome = string.Empty;
            string ondeMora = string.Empty;
            string estudo = string.Empty;
            string pontosPositivos = string.Empty;
            string pontosNegativos = string.Empty;
            string porQueDevoContratalo = string.Empty;

            List<entrevista> listaEntrevista = new List<entrevista>();

            do
            {
                Console.Write("Qual seu nome? ");
                nome = Console.ReadLine();

                Console.Write("Qual sua idade? ");
                idade = int.Parse(Console.ReadLine);

                Console.Write("Onde voce mora? ");
                ondeMora = Console.ReadLine();

                Console.Write("O que voce esta cursando? ");
                estudo = Console.ReadLine();

                Console.Write("Pontos positivos? ");
                pontosPositivos = Console.ReadLine();
                
                Console.Write("Pontos negativos? ");
                pontosNegativos = Console.ReadLine();

                Console.Write("Porque devo contratar o " + nome + ":");
                porQueDevoContratalo = Console.ReadLine();

                listaEntrevista.Add 
                (
                    new entrevista
                    {
                        nome = nome,
                        idade = idade,
                        ondeMora = ondeMora,
                        estudo = estudo,
                        pontosPositivos = pontosPositivos,
                        pontosNegativos =  pontosNegativos,
                        porQueDevoContratalo = porQueDevoContratalo
                    }
                );

                Console.WriteLine();
                Console.Write("Deseja continuar a entrevista (s/n): ");
                continuarEntrevista = Console.ReadLine().ToUpper();

                if continuarEntrevista == "N" loopEntrevista = false;

                Console.Clear();

            } while (loopEntrevista == true);

            foreach(entrevista itemLista in listaEntrevista)

            {
                Console.WriteLine("Nome: " + itemLista.nome);
                Console.WriteLine("Idade: " + itemLista.idade);
                Console.WriteLine("Onde mora: " + itemLista.ondeMora);
                Console.WriteLine("Estudo: " + itemLista.estudo);
                Console.WriteLine("Pontos positivos: " + itemLista.pontosPositivos);
                Console.WriteLine("Pontos negativos: " + itemLista.pontosNegativos);
                Console.WriteLine("Por que contratar : " + itemLista.porQueDevoContratalo);

                Console.WriteLine();
                
            }
        }
    }

    class entrevista {
            public boool loopEntrevista = true;
            public int idade;
            public string nome;
            public string;
           public string estudo;
           public string pontosPositivos;
            public string pontosNegativos;
           public string porQueDevoContratalo;
    }
}