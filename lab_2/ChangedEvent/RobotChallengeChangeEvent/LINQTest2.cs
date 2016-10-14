using System;
using System.Collections.Generic;
using System.Linq;
namespace cmdTestQuestions
{
    public class Cat
    {
        public Int32 Id;
        public String Color;
        public String Owner;
        public String Breed;
    }

    public class Model1
    {
        public List<Cat> CatList
        {
            get
            {
                return new List<Cat>
                {
                    new Cat
                    {
                        Id = 1, Color = "White", Owner = "Nika", Breed = "Ocicat",
                    },

                    new Cat
                    {
                        Id = 20, Color = "Red", Owner = "Braian", Breed = "Cheetoh",
                    },

                    new Cat
                    {
                        Id = 19, Color = "Green", Owner = "Mike", Breed = "Cheetoh",
                    },

                    new Cat
                    {
                        Id = 4, Color = "Red", Owner = "Nika", Breed = "Cheetoh",
                    },

                    new Cat
                    {
                        Id = 3, Color = "Black", Owner = "Ann", Breed = "Bombay",
                    },

                    new Cat
                    {
                        Id = 7, Color = "Black", Owner = "John", Breed = "Persian",
                    },

                    new Cat
                    {
                        Id = 6, Color = "Blue", Owner = "Mike", Breed = "Dwelf",
                    },

                    new Cat
                    {
                        Id = 5, Color = "Black", Owner = "Donna", Breed = "Abyssinian",
                    },

                    new Cat
                    {
                        Id = 17, Color = "Gray", Owner = "Ann", Breed = "Persian",
                    },

                    new Cat
                    {
                        Id = 18, Color = "Blue", Owner = "Nika", Breed = "Abyssinian"
                    }
                };
            }
        }
    }

    internal class MyApplication1
    {
        static void Main()
        {
            var model = new Model1();
            var list = new List<Cat>(model.CatList).Select(m => new {Id = m.Id, Breed = m.Breed, Owner = m.Owner});
            foreach (var el in list)
            {
                Console.WriteLine("{0, -15}	{1, -15}	{2, -15}", el.Id, el.Breed, el.Owner);
            }
        }
    }

}