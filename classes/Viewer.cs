using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHTML.classes
{
    public class Viewer
    {
        public static void Show(string txt)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("MODO VISUALIZADOR...");
            System.Console.WriteLine("----------------------------------------");
            Replace(txt);
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
            Menu.Show();

        }

        private static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
                Console.Write(" ");
            }


        }
    }
}