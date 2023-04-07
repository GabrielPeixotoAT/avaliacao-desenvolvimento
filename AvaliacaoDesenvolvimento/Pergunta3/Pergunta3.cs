using AvaliacaoDesenvolvimento.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Pergunta3
{
    internal class Pergunta3 : IPergunta
    {
        public void Execute()
        {
            Console.WriteLine("A Pergunta 3 se refere a um teste de mesa.\n" +
                "O mesmo se econtra na pasta do projeto, no diretório da solução para\n" +
                " a Pergunta 3 (/AvaliacaoDesenvolvimento/Pergunta3/pergunta3.jpeg).");

            Console.WriteLine("\nPressione qualquer tecla pra continuar...");
            Console.ReadKey();
        }
    }
}
