using System;
using System.Text;

namespace RhombusOfStars
{
    class RhombusAsStringDrawer
    {
        public int Size { get; set; }

        public RhombusAsStringDrawer(int size)
        {
            this.Size = size;
        }

        public void PrintRhombus()
        {
            StringBuilder sb = new StringBuilder();

            PrintUpperPart(this.Size, sb);
            PrintBottomPart(this.Size, sb);

            Console.WriteLine(sb.ToString());
        }

        public void PrintUpperPart(int size, StringBuilder sb)
        {
            for (int i = 1; i <= size; i++)
            {
                sb.Append(new string(' ', size - i));

                DrawLineOfStars(i, sb);

                sb.AppendLine();
            }
        }

        public void PrintBottomPart(int size, StringBuilder sb)
        {
            for (int i = size - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', size - i));

                DrawLineOfStars(i, sb);

                if (i != 1)
                {
                    sb.AppendLine();
                }
            }
        }

        public void DrawLineOfStars(int count, StringBuilder sb)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append("* ");
                }
            }
        }
    }
}
