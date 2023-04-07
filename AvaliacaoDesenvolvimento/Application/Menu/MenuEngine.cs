using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDesenvolvimento.Application.Menu
{
    public class MenuEngine
    {
        public int ItemMaxLength { get; set; } = 15;
        List<string> menuItems;

        public MenuEngine(List<string> menuItems) 
        {
            this.menuItems = menuItems;
        }

        public int RenderMenu()
        {
            List<string> sb = new List<string>();
            int index = 0;
            ConsoleKeyInfo aws;

            Console.WriteLine("QUESTÕES: \n");

            foreach (string option in menuItems)
            {
                string optionUpper = option.ToUpper();

                for (int i = optionUpper.Length; i < ItemMaxLength; i++)
                {
                    optionUpper += " ";
                }

                sb.Add($" {optionUpper}");
            }

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Clear();

                Console.WriteLine("QUESTÕES: \n");

                for (int i = 0; i < sb.Count; i++)
                {
                    if (i == index)
                    {
                        SelectedOption();
                    }
                    else
                    {
                        NonSelectedOption();
                    }

                    Console.WriteLine(sb[i]);
                }

                aws = Console.ReadKey();

                switch (aws.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < sb.Count - 1)
                            index++;
                        break;
                }
            } while (aws.Key != ConsoleKey.Enter);

            return index;
        }

        void SelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        void NonSelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
