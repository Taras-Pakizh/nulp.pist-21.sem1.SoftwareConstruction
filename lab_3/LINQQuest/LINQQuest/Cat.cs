using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    partial class Cat
    {
        public String name { get; }
        public Gender gender { get; }
        public List<Cat> children { get; }

        private Cat (String name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
            children = new List<Cat>();
        }

        public override String ToString()
        {
            return "Cat " + name + "(" + (gender == Gender.Male ? "m" : "f") + ")";
        }

        public String childrenToString()
        {
            return children.Aggregate("{ ", (r, c) => r + c + " ") + "}";
        }

    }
}
