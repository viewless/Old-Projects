using System;
using System.Collections.Generic;
using System.Linq;

namespace Random_Author
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> authors = new List<string> { "Алеко Константинов", "Атанас Далчев", "Гео Милев", "Димитър Димов", "Елин Пелин", "Димитър Талев", "Димчо Дебелянов", "Йордан Йовков", "Пейо Яворов", "Елисавета Багряна", "Никола Вапцаров", "Христо Ботев", "Иван Вазов", "Пенчо Славейков", "Христо Смирненски" };

            Random random = new Random();
            int randomAuthor = random.Next(0, 15);

            string author = authors[randomAuthor];

            Console.WriteLine(author);
        }
    }
}
