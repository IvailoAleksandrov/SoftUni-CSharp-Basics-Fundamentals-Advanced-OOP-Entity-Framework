using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article1 = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(article1[0], article1[1], article1[2]);

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string action = commands[0];
                string newText = commands[1];

                switch (action)
                {
                    case "Edit":
                        article.Edit(newText);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newText);
                        break;
                    case "Rename":
                        article.Rename(newText);
                        break;
                }
            }
            Console.WriteLine(article);

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

        public void Rename(string title)
        {
            Title = title;
        }
        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author) => Author = author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }




    }
}
