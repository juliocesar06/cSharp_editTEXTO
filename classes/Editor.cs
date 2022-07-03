using System.Text;
using System;
namespace EditorHTML.classes
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("Modo Editor");
            System.Console.WriteLine("---------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Deseja salvar o arquivo?");
            System.Console.WriteLine("1-Sim  ||  2-Não");
            string linha = Console.ReadLine();
            switch (linha)
            {
                case "1":
                    System.Console.WriteLine("salvar");
                    break;
                case "2":
                    System.Console.WriteLine("sair");
                    break;
                default:
                    System.Console.WriteLine("opçao nao valida...");
                    break;
            }
            Viewer.Show(file.ToString());

        }
    }
}