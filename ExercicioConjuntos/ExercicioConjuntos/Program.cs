using System;

namespace ExercicioConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Quantos alunos realizada o curso A: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeA; i++)
            {
                Console.Write("ID do aluno: ");
                int idAluno = int.Parse(Console.ReadLine());
                cursoA.Add(idAluno);
            }

            Console.Write("Quantos alunos realizada o curso B: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeB; i++)
            {
                Console.Write("ID do aluno: ");
                int idAluno = int.Parse(Console.ReadLine());
                cursoB.Add(idAluno);
            }

            Console.Write("Quantos alunos realizada o curso C: ");
            int quantidadeC = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeC; i++)
            {
                Console.Write("ID do aluno: ");
                int idAluno = int.Parse(Console.ReadLine());
                cursoC.Add(idAluno);
            }

            HashSet<int> todosCursos = new HashSet<int>();
            todosCursos.UnionWith(cursoA);
            todosCursos.UnionWith(cursoB);
            todosCursos.UnionWith(cursoC);

            Console.WriteLine();
            Console.Write("Total de alunos inscritos: " + todosCursos.Count);

        }
    }
}