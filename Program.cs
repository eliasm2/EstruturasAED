using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas
{
    class Program
    {
        struct Aluno                                // Ou public class Aluno - Toda struct é public
        {
            public int Matrícula;
            public string NomeAluno;
            public string Telefone;
        }

        struct Música
        {
            public string NomeMúsica;
            public string NomeCantor;
            public string TítuloCD;
        }

        struct Data
        {
            public int Dia;
            public string Mês;
            public int Ano;
        }
        
        struct Professor
        {
            public string NomeProfessor;
            public Data DataAdmissão;               // Estrutura Composta
        }
        
        
        
        static void Main(string[] args)
        {
            int i;                                          // Variável Auxiliar

            // --------------------------------------------------------------------------------------------------------------------
            
            Aluno xAluno;                                   // Definição de Tipo. Se Aluno fosse classe, Aluno xAluno = new Aluno()
            
            Console.Clear();                                // Limpa a Tela

            Console.WriteLine("Estruturas");
            Console.WriteLine("==========\n");

            Console.WriteLine("Definição de Estrutura Simples\n");
            
            Console.Write("Matrícula do Aluno..: ");        // Leitura de Dados
            xAluno.Matrícula = int.Parse(Console.ReadLine());

            Console.Write("Nome do Aluno.......: ");
            xAluno.NomeAluno = Console.ReadLine();

            Console.Write("Telefone do Aluno...: ");
            xAluno.Telefone = Console.ReadLine();

            Console.WriteLine("\nO telefone do aluno {0}, que possui a Matrícula {1}, é {2}\n\n", xAluno.NomeAluno, xAluno.Matrícula, xAluno.Telefone);
            Console.ReadKey();

            // --------------------------------------------------------------------------------------------------------------------

            Música[] xMúsica = new Música[3];              // Definição de Tipo - Matriz 

            Console.Clear();                               // Limpa a Tela

            Console.WriteLine("Estruturas");
            Console.WriteLine("==========\n");

            Console.WriteLine("Definição de Matriz de Estruturas");

            for (i = 0; i < 3; i++)
            {
                // Se o Música fosse uma classe, nesse ponto seria necessário 
                // instanciar cada elemento do vetor fazendo:
                //
                // xMúsica[i]=new Música();
                
                Console.Write("\nNome da Música...: ");
                xMúsica[i].NomeMúsica = Console.ReadLine();
                
                Console.Write("Nome do Cantor...: ");
                xMúsica[i].NomeCantor = Console.ReadLine();

                Console.Write("Título do CD.....: ");
                xMúsica[i].TítuloCD = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("\nInformações Registradas:\n");
            
            foreach (var Dado in xMúsica)                   // Coleção de Elementos...
            {
                Console.WriteLine("\tNome da Música...: {0}", Dado.NomeMúsica);
                Console.WriteLine("\tNome do Cantor...: {0}", Dado.NomeCantor);
                Console.WriteLine("\tTítulo do CD.....: {0}\n", Dado.TítuloCD);
            }

            Console.ReadKey();

            // --------------------------------------------------------------------------------------------------------------------

            Professor[] xProfessor = new Professor[3];

            Console.Clear();                               // Limpa a Tela

            Console.WriteLine("Estruturas");
            Console.WriteLine("==========\n");

            Console.WriteLine("Definição de Matriz de Estruturas Compostas");

            for (i = 0; i < 3; i++)
            {
                Console.Write("\nNome do Professor..: ");
                xProfessor[i].NomeProfessor = Console.ReadLine();

                Console.Write("Admissão....... ");
                Console.Write("Dia: ");
                xProfessor[i].DataAdmissão.Dia = int.Parse(Console.ReadLine());         // A Estrutura é Composta...
                Console.Write("\t\tMês: ");
                xProfessor[i].DataAdmissão.Mês = Console.ReadLine();
                Console.Write("\t\tAno: ");
                xProfessor[i].DataAdmissão.Ano = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("\nInformações Registradas:\n");

            foreach (Professor Dado in xProfessor)
            {
                Console.WriteLine("\tProfessor {0} - Data de Admissão: {1} de {2} de {3}"
                    , Dado.NomeProfessor,Dado.DataAdmissão.Dia, Dado.DataAdmissão.Mês,Dado.DataAdmissão.Ano);
            }

            Console.ReadKey();
        }
    }
}
