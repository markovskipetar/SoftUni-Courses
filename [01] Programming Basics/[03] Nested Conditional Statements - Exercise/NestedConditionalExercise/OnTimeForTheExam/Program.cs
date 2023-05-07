using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arravingHour = int.Parse(Console.ReadLine());
            int arravingMinutes = int.Parse(Console.ReadLine());

            int examInMins = examHour * 60 + examMinutes;
            int arravingInMins = arravingHour * 60 + arravingMinutes;

            string command = String.Empty;
            string difference = String.Empty;
            bool isOnTime = false;

            if (examHour == arravingHour)
            {
                if (arravingMinutes > examMinutes)
                {
                    command = "Late";
                    difference = $"{arravingMinutes - examMinutes} minutes after the start";
                }
                else if (arravingMinutes == examMinutes)
                {
                    command = "On time";
                    isOnTime = true;
                }
                else if (examMinutes - arravingMinutes <= 30)
                {
                    command = "On time";
                    difference = $"{examMinutes - arravingMinutes} minutes before the start";
                }
                else
                {
                    command = "Early";
                    difference = $"{examMinutes - arravingMinutes} minutes before the start";
                }
            }
            else if (arravingHour > examHour)
            {
                command = "Late";

                if (arravingInMins - examInMins < 60)
                {
                    difference = $"{arravingInMins - examInMins:d} minutes after the start";
                }
                else
                {
                    difference = $"{(arravingInMins - examInMins) / 60}:{(arravingInMins - examInMins) % 60:d2} hours after the start";
                }
            }
            else
            {
                if (examInMins - arravingInMins <= 30)
                {
                    command = "On time";
                    difference = $"{examInMins - arravingInMins} minutes before the start";
                }
                else
                {
                    if (examInMins - arravingInMins < 60)
                    {
                        command = "Early";
                        difference = $"{examInMins - arravingInMins} minutes before the start";
                    }
                    else
                    {
                        command = "Early";
                        difference = $"{(examInMins - arravingInMins) / 60}:{(examInMins - arravingInMins) % 60:d2} hours before the start";
                    }
                }
            }

            if (isOnTime)
            {
                Console.WriteLine(command);
            }
            else
            {
                Console.WriteLine(command);
                Console.WriteLine(difference);
            }
        }
    }
}
