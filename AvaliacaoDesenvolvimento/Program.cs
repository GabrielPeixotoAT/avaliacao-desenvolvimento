using AvaliacaoDesenvolvimento.Application;
using AvaliacaoDesenvolvimento.Application.Menu;
using AvaliacaoDesenvolvimento.Pergunta1;
using AvaliacaoDesenvolvimento.Pergunta2;
using AvaliacaoDesenvolvimento.Pergunta3;
using AvaliacaoDesenvolvimento.Pergunta4;

List<string> options = new List<string>();

options.Add("Pergunta 1");
options.Add("Pergunta 2");
options.Add("Pergunta 3");
options.Add("Pergunta 4");

options.Add("Exit");

MenuEngine menu = new MenuEngine(options);

IPergunta pergunta;

int select = 0;
do
{
    select = menu.RenderMenu();
    Console.Clear();

    switch (select)
    {
        case 0:
            pergunta = new Pergunta1();
            pergunta.Execute();
            break;
        case 1:
            pergunta = new Pergunta2();
            pergunta.Execute();
            break;
        case 2:
            pergunta = new Pergunta3();
            pergunta.Execute();
            break;
        case 3:
            pergunta = new Pergunta4();
            pergunta.Execute();
            break;
    }

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;

} while (select != options.Count() - 1);
