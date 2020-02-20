using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();
            string command = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine(titleOfArticle);
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine(contentOfArticle);
            Console.WriteLine("</article>");
            while (command != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine(command);
                Console.WriteLine("</div>");
                command = Console.ReadLine();
            }
        }
    }
}
