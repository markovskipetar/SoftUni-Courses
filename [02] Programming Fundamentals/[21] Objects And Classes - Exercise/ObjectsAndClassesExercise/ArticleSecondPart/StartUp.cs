namespace ArticleSecondPart
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                Article currentArticle = CreateArticle();

                articles.Add(currentArticle);
            }

            string sortCriteria = Console.ReadLine();

            PrintArticles(sortCriteria, articles);
        }

        static void PrintArticles(string sortCriteria, List<Article> articles)
        {
            if (sortCriteria == "title")
            {
                articles = articles.OrderBy(article => article.Title).ToList();
            }
            else if (sortCriteria == "content")
            {
                articles = articles.OrderBy(article => article.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(article => article.Author).ToList();
            }

            Console.WriteLine(String.Join("\n", articles));
        }

        static Article CreateArticle()
        {
            string[] articleInput = Console.ReadLine().Split(", ").ToArray();

            string title = articleInput[0];
            string content = articleInput[1];
            string author = articleInput[2];

            Article article = new Article(title, content, author);

            return article;
        }
    }
}
