namespace Articles
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Article article = CreateArticle();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] splittedInput = Console.ReadLine().Split(": ").ToArray();

                string command = splittedInput[0];

                if (command == "Edit")
                {
                    string newContent = splittedInput[1];

                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = splittedInput[1];

                    article.ChangeAuthor(newAuthor);
                }
                else
                {
                    string newTitle = splittedInput[1];

                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article);
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
