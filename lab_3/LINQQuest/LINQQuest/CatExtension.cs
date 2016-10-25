using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    static class CatExtension
    {

        public static Cat printGetCat()
        {
            var cat = Cat.getCat();
            Console.WriteLine("new cat : " + cat);
            return cat;
        }

        public static Cat printLove(Cat a, Cat b)
        {
            var child = a + b;
            Console.WriteLine("love : " + a + " + " + b + " = " + child);
            return child;
        }

        public static void printCat(Cat cat)
        {
            Console.WriteLine("cat : " + cat + cat.childrenToString());
        }

        public static void giveAllChildrenInOrphanage(this Cat cat)
        {
            cat.children.Clear();
        }

    }
}
