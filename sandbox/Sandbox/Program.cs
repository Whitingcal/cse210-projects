using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the classes
            LessonLoader lessonLoader = new LessonLoader();
            lessonLoader.Load();

            OrdinanceLoader ordinanceLoader = new OrdinanceLoader();
            ordinanceLoader.Load();

            Menu menu = new Menu();
            menu.ShowMenu();
        }
    }
}