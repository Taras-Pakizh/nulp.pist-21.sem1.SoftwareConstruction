using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    partial class Cat
    {

        private static int count = 0;
        private static Random rnd = new Random();

        public static Cat getCat()
        {
            var name = "cat_" + count++;
            var r = rnd.Next() % 2 == 0;
            var gender = r ? Gender.Male : Gender.Female;
            return new Cat(name, gender);
        }

        public static Cat operator +(Cat parent1, Cat parent2)
        {
            if (parent1.gender == parent2.gender)
            {
                return null;
            }
            var child = getCat();
            parent1.children.Add(child);
            parent2.children.Add(child);
            return child;
        }

    }
}
