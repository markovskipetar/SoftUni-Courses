﻿namespace StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            Engine engine = new Engine(studentSystem);

            engine.Run();
        }
    }
}
