namespace HTML
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"<h1>{Environment.NewLine}\t{Console.ReadLine()}{Environment.NewLine}</h1>");
            sb.Append($"{Environment.NewLine}<article>{Environment.NewLine}\t{Console.ReadLine()}{Environment.NewLine}</article>");

            while (true)
            {
                string commnet = Console.ReadLine();

                if (commnet == "end of comments")
                {
                    break;
                }

                sb.Append($"{Environment.NewLine}<div>{Environment.NewLine}\t{commnet}{Environment.NewLine}</div>");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
