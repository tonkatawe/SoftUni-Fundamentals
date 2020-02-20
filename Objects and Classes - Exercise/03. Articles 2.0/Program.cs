using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countArticles = int.Parse(Console.ReadLine());
            List<Article> listOtArticles = new List<Article>();
            List<Article> orderList = new List<Article>();
            for (int i = 0; i < countArticles; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                Article article = new Article(tokens[0], tokens[1], tokens[2]);
                listOtArticles.Add(article);
            }
            string commad = Console.ReadLine();
            switch (commad)
            {
                case "title":
                    orderList = listOtArticles.OrderBy(o => o.Title).ToList();
                    PrintList(orderList);
                    break;
                case "content":
                    orderList = listOtArticles.OrderBy(o => o.Content).ToList();
                    PrintList(orderList);
                    break;
                case "author":
                    orderList = listOtArticles.OrderBy(o => o.Author).ToList();
                    PrintList(orderList);
                    break;
                default:
                    break;
            }
            static void PrintList(List<Article> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                }
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
