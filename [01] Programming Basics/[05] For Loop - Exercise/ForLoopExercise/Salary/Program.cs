using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int websitesCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            bool isSalaryOver = false;

            for (int i = 0; i < websitesCount; i++)
            {
                string currentWebsite = Console.ReadLine();

                switch (currentWebsite)
                {
                    case "Facebook":
                        salary -= 150;
                        break;

                    case "Instagram":
                        salary -= 100;
                        break;

                    case "Reddit":
                        salary -= 50;
                        break;
                }

                if (salary <= 0)
                {
                    isSalaryOver = true;
                    break;
                }
            }

            if (isSalaryOver)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}

