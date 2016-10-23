using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static Cat printGetCat()
        {
            var cat = Cat.getCat();
            Console.WriteLine("new cat : " + cat);
            return cat;
        }

        static Cat printLove(Cat a, Cat b)
        {
            var child = a + b;
            Console.WriteLine("love : " + a + " + " + b + " = " + child);
            return child;
        }

        static void printCat(Cat cat)
        {
            Console.WriteLine("cat : " + cat + cat.childrenToString());
        }

        void ListSample()
        {
            List<Cat> list = new List<Cat>();
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++) list.Add(printGetCat());
            Console.WriteLine("\n--- Народження котиків ---");
            var rnd = new Random();
            for (var i = 10; i < 40; i++)
            {
                var cat = printLove(list[rnd.Next() % list.Count], list[rnd.Next() % list.Count]);
                if (cat != null) list.Add(cat);
            }
            Console.WriteLine("\n--- Вивід котиків ---");
            list.ForEach(cat => printCat(cat));
        }

        void DictionarySample()
        {
            Dictionary<String, Cat> dictionary = new Dictionary<String, Cat>();
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++) {
                var cat = printGetCat();
                dictionary.Add(cat.name, cat);
            }
            Console.WriteLine("\n--- Народження котиків ---");
            var rnd = new Random();
            for (var i = 10; i < 40; i++)
            {
                List<Cat> cats = dictionary.Values.ToList();
                var cat = printLove(dictionary[cats[rnd.Next() % cats.Count].name], dictionary[cats[rnd.Next() % cats.Count].name]);
                if (cat != null) dictionary.Add(cat.name, cat);
            }
            Console.WriteLine("\n--- Вивід котиків ---");
            dictionary.Keys.ToList().ForEach(key => printCat(dictionary[key]));
        }
    }
}
