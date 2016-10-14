using System;
using System.Collections.Generic;
using System.Linq;

namespace cmdTestQuestions
{
    public class Country
    {
        public Int32 Id;
        public Double Area;
        public String City;
        public String Street;
        public String HomeAddress;
    }

    public class Model
    {
        public List<Country> CountryList
        {
            get
            {
                return new List<Country>
                {
                    new Country
                    {
                        Id = 9,
                        Area = 56558.232,
                        City = "Pekin",
                        Street = "Shevchenko",
                        HomeAddress = "454",
                    },

                    new Country
                    {
                        Id = 1,
                        Area = 32546.3557,
                        City = "Vienna",
                        Street = "Melnychuka",
                        HomeAddress = "123/2",
                    },

                    new Country
                    {
                        Id = 4,
                        Area = 9765.46,
                        City = "London",
                        Street = "I. Franka",
                        HomeAddress = "322",
                    },

                    new Country
                    {
                        Id = 12,
                        Area = 1255.35,
                        City = "Amsterdam",
                        Street = "Khmelnytsky",
                        HomeAddress = "12/3",
                    },

                    new Country
                    {
                        Id = 13,
                        Area = 1268.45,
                        City = "London",
                        Street = "I. Franka",
                        HomeAddress = "1935",
                    },

                    new Country
                    {
                        Id = 2,
                        Area = 67454.7864,
                        City = "Vienna",
                        Street = "Gorodotska",
                        HomeAddress = "123/2",
                    },

                    new Country
                    {
                        Id = 12,
                        Area = 56558.232,
                        City = "Amsterdam",
                        Street = "Basement",
                        HomeAddress = "195",
                    },

                    new Country
                    {
                        Id = 13,
                        Area = 123.896,
                        City = "Berlin",
                        Street = "Sakharova",
                        HomeAddress = "25",
                    },

                    new Country
                    {
                        Id = 6,
                        Area = 123.896,
                        City = "Berlin",
                        Street = "Basement",
                        HomeAddress = "122",
                    },

                    new Country
                    {
                        Id = 7,
                        Area = 124.54,
                        City = "Lviv",
                        Street = "Stryis'ka",
                        HomeAddress = "1935"
                    }
                };
            }
        }
    }

    internal class MyApplication
    {
        static void Main()
        {
            var model = new Model();
            var list = new List<Country>(model.CountryList);
            list.ForEach(m => Console.WriteLine(m.Id + " \t" + m.Area + " \t" + m.City + " \t" + m.Street + " \t" + m.HomeAddress));
        }
    }
}