using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int countOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");
                string command = tokens[0];
                string argumend = tokens[1];
                switch (command)
                {
                    case "Edit":
                        article.EditContent(argumend);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argumend);
                        break;
                    case "Rename":
                        article.RenameTitle(argumend);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
        class Article
        {
            public override string ToString()
            {
                string res = $"{Title} - {Content}: {Author}";
                return res;
            }
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public void EditContent(string content)
            {
                Content = content;
            }
            public void ChangeAuthor(string author)
            {
                Author = author;
            }
            public void RenameTitle(string title)
            {
                Title = title;
            }
        }
    }
}
