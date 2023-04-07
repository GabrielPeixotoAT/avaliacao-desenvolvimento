using AvaliacaoDesenvolvimento.Application;
using AvaliacaoDesenvolvimento.Pergunta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Pergunta2
{
    public class Pergunta2 : IPergunta
    {
        public void Execute()
        {
            int studentID = -1;

            do
            {
                studentID = ReadStudentID();

                if (studentID == 0)
                    break;

                double[] scores = ReadStudentScores(studentID);

                Student student = new Student(studentID, scores);

                PrintStudent(student);

            } while (studentID != 0);
        }

        void PrintStudent(Student student)
        {
            Console.Clear();
            Console.WriteLine(" - - - - - - - Dados do aluno - - - - - - -");
            Console.WriteLine(student);

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        int ReadStudentID()
        {
            Console.Write("Código do Aluno: ");
            int id = int.Parse(Console.ReadLine());

            return id;
        }

        double[] ReadStudentScores(int id)
        {
            Console.Write("Nota 1: ");
            double score1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double score2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double score3 = double.Parse(Console.ReadLine());

            return new double[] { score1, score2, score3 };
        }
    }
}
