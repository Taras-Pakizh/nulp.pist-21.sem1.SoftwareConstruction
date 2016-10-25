using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQQuest.CatExtension;

namespace LINQQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new Program();
            main.ListSample();
            main.DictionarySample();
            main.SortedListSample();
            main.QueueSample();
            Console.ReadKey();
        }

        void ListSample()
        {
            List<Cat> list = new List<Cat>() { printGetCat(), printGetCat() };
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++) list.Add(printGetCat());
            Console.WriteLine("\n--- Народження котиків ---");
            var rnd = new Random();
            for (var i = 10; i < 40; i++)
            {
                var cat = printLove(list[rnd.Next() % list.Count], list[rnd.Next() % list.Count]);
                if (cat != null) list.Add(cat);
            }
            list.Sort((a, b) => (a.gender != b.gender) ? (a.gender == Gender.Male ? 1 : -1) : (a.children.Count - b.children.Count));
            Console.WriteLine("\n--- Вивід котиків ---");
            list.ForEach(cat => printCat(cat));
            list.Select(c => new { name = c.name }).ToArray().ToList().ForEach(n => Console.WriteLine(String.Format("%s", n.name)));
        }

        void DictionarySample()
        {
            Dictionary<String, Cat> dictionary = new Dictionary<String, Cat>();
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++)
            {
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
            dictionary.Where(c => c.Value.gender == Gender.Female).ToList().ForEach(c => Console.WriteLine(c)); ;
        }

        void SortedListSample()
        {
            SortedList<String, Cat> list = new SortedList<String, Cat>();
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++)
            {
                var cat = printGetCat();
                list.Add(cat.name, cat);
            }
            Console.WriteLine("\n--- Народження котиків ---");
            var rnd = new Random();
            for (var i = 10; i < 40; i++)
            {
                List<Cat> cats = list.Values.ToList();
                var cat = printLove(list[cats[rnd.Next() % cats.Count].name], list[cats[rnd.Next() % cats.Count].name]);
                if (cat != null) list.Add(cat.name, cat);
            }
            Console.WriteLine("\n--- Вивід котиків ---");
            list.Keys.ToList().ForEach(key => printCat(list[key]));
        }

        void QueueSample()
        {
            Queue<Cat> queue = new Queue<Cat>();
            Console.WriteLine("\n--- Створення котиків ---");
            for (var i = 0; i < 10; i++) queue.Enqueue(printGetCat());
            Console.WriteLine("\n--- Народження котиків ---");
            var rnd = new Random();
            for (var i = 10; i < 40; i++)
            {
                var par1 = queue.Dequeue();
                var par2 = queue.Dequeue();
                var cat = printLove(par1, par2);
                queue.Enqueue(par1);
                queue.Enqueue(par2);
                if (cat != null) queue.Enqueue(cat);
            }
            Console.WriteLine("\n--- Вивід котиків ---");
            queue.ToList().ForEach(cat => printCat(cat));
        }
    }
}
