using System;
using EditorHTML.classes;

namespace EditorHTML
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Drawn();
            HandleMenuOption(writeOpt());
        }

        public static void Drawn()
        {
            Console.Write("+");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");


            }
            Console.Write("%");
            Console.Write("\n");

            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int i = 0; i < 40; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");


            }
            Console.Write("%");
            Console.Write("\n");
        }

        public static int writeOpt()
        {
            Console.SetCursorPosition(3, 1);
            System.Console.WriteLine("Editor HTML");
            System.Console.WriteLine("===================================");
            Console.SetCursorPosition(3, 3);
            System.Console.WriteLine("Selecione uma opção abiaxo:");
            Console.SetCursorPosition(3, 5);
            System.Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3, 7);
            System.Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3, 9);
            System.Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
            string txt = Console.ReadLine();
            int opt = Int32.Parse(txt);


            return opt;

        }

        public static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    System.Console.WriteLine("VIEW");
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }

                default: Show(); break;
            }
        }



    }
}