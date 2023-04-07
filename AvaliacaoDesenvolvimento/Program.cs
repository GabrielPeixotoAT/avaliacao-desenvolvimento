using AvaliacaoDesenvolvimento.Application;
using AvaliacaoDesenvolvimento.Application.Menu;
using AvaliacaoDesenvolvimento.Pergunta1;

List<string> options = new List<string>();

options.Add("Pergunta 1");

options.Add("Exit");

MenuEngine menu = new MenuEngine(options);

IPergunta pergunta;

int select = 0;
do
{
    select = menu.RenderMenu();

    switch (select)
    {
        case 0:
            pergunta = new Pergunta1();
            Console.Clear();
            pergunta.Execute();
            break;
    }

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;

} while (select != options.Count() - 1);
