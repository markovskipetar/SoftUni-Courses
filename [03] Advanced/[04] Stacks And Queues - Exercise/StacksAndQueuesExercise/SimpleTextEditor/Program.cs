namespace SimpleTextEditor
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int tasksCount = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            var undo = new Stack<string[]>();

            for (int i = 0; i < tasksCount; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "1")
                {
                    string text = input[1];

                    sb.Append(text);

                    undo.Push(input);
                }
                else if (command == "2")
                {
                    int elementsToErase = int.Parse(input[1]);

                    string removedText = sb.ToString().Substring(sb.Length - elementsToErase, elementsToErase);

                    for (int j = 0; j < elementsToErase; j++)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }

                    input[1] = removedText;

                    undo.Push(input);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]) - 1;

                    Console.WriteLine(sb[index]);
                }
                else if (command == "4")
                {
                    string[] undoCommand = undo.Pop();

                    if (undoCommand[0] == "1")
                    {
                        string text = undoCommand[1];

                        for (int j = 0; j < text.Length; j++)
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                    }
                    else
                    {
                        string removedText = undoCommand[1];
                        sb.Append(removedText);
                    }
                }
            }
        }
    }
}
