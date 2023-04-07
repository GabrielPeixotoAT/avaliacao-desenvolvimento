using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Pergunta2.Entities
{
    public class Student
    {
        public int StudentID { get; private set; }
        public double[] Scores = new double[3];
        public double Average { get; private set; }

        public Student(int studentID, double[] scores)
        {
            StudentID = studentID;
            Scores = scores;
            CalculateAverage();
        }

        void CalculateAverage()
        {
            double higtScore = 0;

            for (int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] > higtScore)
                    higtScore = Scores[i];
            }

            Average = (higtScore * 4 + (Scores.Sum() - higtScore) * 3) / 10;
        }

        public override string ToString()
        {
            return $"Código do Aluno: {StudentID} \n" +
                $"Nota 1: {Scores[0]} \nNota 2: {Scores[1]} \nNota 3: {Scores[2]} \n" +
                $"Média: {Average.ToString("F2")} \n" +
                $"{(Average > 6 ? "APROVADO" : "REPROVADO")}";
        }
    }
}
