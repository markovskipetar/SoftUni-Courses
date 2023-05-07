namespace SoftUniCoursePlanning
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "course start")
                {
                    break;
                }

                string[] input = inputLine
                    .Split(':')
                    .ToArray();

                string command = input[0];
                string lessonTitle = input[1];

                switch (command)
                {
                    case "Add":
                        {
                            AddLesson(lessonTitle, schedule);
                        }
                        break;

                    case "Insert":
                        {
                            int index = int.Parse(input[2]);

                            InsertLesson(index, lessonTitle, schedule);
                        }
                        break;

                    case "Remove":
                        {
                            RemoveLesson(lessonTitle, schedule);
                        }
                        break;

                    case "Swap":
                        {
                            string firstLessonTitle = lessonTitle;
                            string secondLessonTitle = input[2];

                            SwapLessons(firstLessonTitle, secondLessonTitle, schedule);
                        }
                        break;

                    case "Exercise":
                        {
                            string exerciseTitle = $"{lessonTitle}-Exercise";

                            AddExercise(lessonTitle, exerciseTitle, schedule);
                        }
                        break;
                }
            }

            Print(schedule);
        }

        static void Print(List<string> schedule)
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static void SwapLessons(string firstLessonTitle, string secondLessonTitle, List<string> schedule)
        {
            if (!schedule.Contains(firstLessonTitle) || !schedule.Contains(secondLessonTitle))
            {
                return;
            }

            string firstLessonExercise = $"{firstLessonTitle}-Exercise";
            string secondLessonExercise = $"{secondLessonTitle}-Exercise";

            bool isThereFirstExercise = false;
            bool isThereSecondExercise = false;

            if (schedule.Contains(firstLessonExercise))
            {
                schedule.Remove(firstLessonExercise);
                isThereFirstExercise = true;
            }

            if (schedule.Contains(secondLessonExercise))
            {
                schedule.Remove(secondLessonExercise);
                isThereSecondExercise = true;
            }

            int indexOfFirstLesson = schedule.IndexOf(firstLessonTitle);
            int indexOfSecondLesson = schedule.IndexOf(secondLessonTitle);

            schedule[indexOfFirstLesson] = secondLessonTitle;
            schedule[indexOfSecondLesson] = firstLessonTitle;

            if (isThereFirstExercise)
            {
                schedule.Insert(indexOfSecondLesson + 1, firstLessonExercise);
            }

            if (isThereSecondExercise)
            {
                schedule.Insert(indexOfFirstLesson + 1, secondLessonExercise);
            }
        }

        static void AddExercise(string lessonTitle, string exerciseTitle, List<string> schedule)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
                schedule.Add(exerciseTitle);
            }
            else
            {
                if (!schedule.Contains(exerciseTitle))
                {
                    int indexOfLesson = schedule.IndexOf(lessonTitle);
                    int indexOfExercise = indexOfLesson + 1;

                    schedule.Insert(indexOfExercise, exerciseTitle);
                }
            }
        }

        static void RemoveLesson(string lessonTitle, List<string> schedule)
        {
            string exerciseTitle = $"{lessonTitle}-Exercise";

            if (schedule.Contains(lessonTitle))
            {
                schedule.Remove(lessonTitle);

                if (schedule.Contains(exerciseTitle))
                {
                    schedule.Remove(exerciseTitle);
                }
            }
        }

        static void InsertLesson(int index, string lessonTitle, List<string> schedule)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Insert(index, lessonTitle);
            }
        }

        static void AddLesson(string lessonTitle, List<string> schedule)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
        }
    }
}
