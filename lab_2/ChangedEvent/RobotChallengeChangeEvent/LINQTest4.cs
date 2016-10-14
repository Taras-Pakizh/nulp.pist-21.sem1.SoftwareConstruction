using System;
using System.Collections.Generic;
using System.Linq;

namespace cmdTestQuestions
{
    public class Country3
    {
        public Int32 Id;
        public Double Area;
        public String City;
        public String Street;
        public String HomeAddress;
    }

    public class Model3
    {
        public List<Country3> CountryList
        {
            get
            {
                return new List<Country3>
                {
                    new Country3
                    {
                        Id = 18,
                        Area = 56558.232,
                        City = "Pekin",
                        Street = "Khmelnytsky",
                        HomeAddress = "85",
                    },

                    new Country3
                    {
                    Id = 13,
                    Area = 9765.46,
                    City = "Tokio",
                    Street = "Sakharova",
                    HomeAddress = "13",
                },

                new Country3
                {
                    Id = 19,
                    Area = 56558.232,
                    City = "London",
                    Street = "Sakharova",
                    HomeAddress = "2/83",
                },

                new Country3
                {
                    Id = 12,
                    Area = 32546.3557,
                    City = "Chop",
                    Street = "Gorodotska",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 6,
                    Area = 21435.676,
                    City = "Kyiv",
                    Street = "Shevchenko",
                    HomeAddress = "122",
                },

                new Country3
                {
                    Id = 14,
                    Area = 9765.46,
                    City = "Berlin",
                    Street = "Basement",
                    HomeAddress = "454",
                },

                new Country3
                {
                    Id = 17,
                    Area = 32546.3557,
                    City = "Tokio",
                    Street = "Melnychuka",
                    HomeAddress = "145",
                },

                new Country3
                {
                    Id = 6,
                    Area = 843.57,
                    City = "Tokio",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "122",
                },

                new Country3
                {
                    Id = 5,
                    Area = 124.54,
                    City = "Tokio",
                    Street = "Basement",
                    HomeAddress = "12",
                },

                new Country3
                {
                    Id = 2,
                    Area = 9765.46,
                    City = "Lviv",
                    Street = "Kopenika",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 15,
                    Area = 9765.46,
                    City = "Drohobych",
                    Street = "Siajvo",
                    HomeAddress = "232",
                },

                new Country3
                {
                    Id = 20,
                    Area = 1255.35,
                    City = "Pekin",
                    Street = "Khmelnytsky",
                    HomeAddress = "43",
                },

                new Country3
                {
                    Id = 6,
                    Area = 843.57,
                    City = "Lviv",
                    Street = "Lucas",
                    HomeAddress = "12",
                },

                new Country3
                {
                    Id = 3,
                    Area = 21435.676,
                    City = "Pekin",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "123",
                },

                new Country3
                {
                    Id = 20,
                    Area = 3246.6757,
                    City = "Pekin",
                    Street = "Stryis'ka",
                    HomeAddress = "2/83",
                },

                new Country3
                {
                    Id = 5,
                    Area = 124.54,
                    City = "Chop",
                    Street = "Basement",
                    HomeAddress = "454",
                },

                new Country3
                {
                    Id = 6,
                    Area = 1268.45,
                    City = "Pekin",
                    Street = "Gorodotska",
                    HomeAddress = "12/3",
                },

                new Country3
                {
                    Id = 9,
                    Area = 843.57,
                    City = "London",
                    Street = "Kopenika",
                    HomeAddress = "145",
                },

                new Country3
                {
                    Id = 15,
                    Area = 56558.232,
                    City = "Kyiv",
                    Street = "Stryis'ka",
                    HomeAddress = "12/3",
                },

                new Country3
                {
                    Id = 13,
                    Area = 3246.6757,
                    City = "Vienna",
                    Street = "Lucas",
                    HomeAddress = "12/3",
                },

                new Country3
                {
                    Id = 4,
                    Area = 1255.35,
                    City = "London",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "122",
                },

                new Country3
                {
                    Id = 16,
                    Area = 1255.35,
                    City = "Tokio",
                    Street = "Melnychuka",
                    HomeAddress = "122",
                },

                new Country3
                {
                    Id = 19,
                    Area = 343.546,
                    City = "Kyiv",
                    Street = "Gorodotska",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 20,
                    Area = 67454.7864,
                    City = "Amsterdam",
                    Street = "Sakharova",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 11,
                    Area = 9765.46,
                    City = "New York",
                    Street = "Khmelnytsky",
                    HomeAddress = "2/83",
                },

                new Country3
                {
                    Id = 6,
                    Area = 32546.3557,
                    City = "London",
                    Street = "Siajvo",
                    HomeAddress = "642",
                },

                new Country3
                {
                    Id = 5,
                    Area = 56558.232,
                    City = "New York",
                    Street = "Khmelnytsky",
                    HomeAddress = "232",
                },

                new Country3
                {
                    Id = 16,
                    Area = 32546.3557,
                    City = "Vienna",
                    Street = "Kopenika",
                    HomeAddress = "123",
                },

                new Country3
                {
                    Id = 17,
                    Area = 67454.7864,
                    City = "New York",
                    Street = "Lucas",
                    HomeAddress = "454",
                },

                new Country3
                {
                    Id = 12,
                    Area = 843.57,
                    City = "Amsterdam",
                    Street = "Lucas",
                    HomeAddress = "43",
                },

                new Country3
                {
                    Id = 18,
                    Area = 67454.7864,
                    City = "Lviv",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "4/2",
                },

                new Country3
                {
                    Id = 16,
                    Area = 1255.35,
                    City = "Tokio",
                    Street = "Gorodotska",
                    HomeAddress = "232",
                },

                new Country3
                {
                    Id = 19,
                    Area = 343.546,
                    City = "Paris",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "2445",
                },

                new Country3
                {
                    Id = 6,
                    Area = 5634.32,
                    City = "Chop",
                    Street = "Lesi Ukrainku",
                    HomeAddress = "12/3",
                },

                new Country3
                {
                    Id = 4,
                    Area = 9765.46,
                    City = "Vienna",
                    Street = "Kopenika",
                    HomeAddress = "12/4",
                },

                new Country3
                {
                    Id = 15,
                    Area = 738.783,
                    City = "London",
                    Street = "Gorodotska",
                    HomeAddress = "642",
                },

                new Country3
                {
                    Id = 14,
                    Area = 1255.35,
                    City = "Lviv",
                    Street = "I. Franka",
                    HomeAddress = "12/3",
                },

                new Country3
                {
                    Id = 10,
                    Area = 843.57,
                    City = "Chop",
                    Street = "Shevchenko",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 4,
                    Area = 3246.6757,
                    City = "London",
                    Street = "Lesi Ukrainku",
                    HomeAddress = "195",
                },

                new Country3
                {
                    Id = 16,
                    Area = 123.896,
                    City = "Chop",
                    Street = "Siajvo",
                    HomeAddress = "4/2",
                },

                new Country3
                {
                    Id = 9,
                    Area = 5634.32,
                    City = "Kyiv",
                    Street = "Sakharova",
                    HomeAddress = "1935",
                },

                new Country3
                {
                    Id = 10,
                    Area = 9765.46,
                    City = "Kyiv",
                    Street = "Krushel'nytskoi",
                    HomeAddress = "85",
                },

                new Country3
                {
                    Id = 8,
                    Area = 124.54,
                    City = "New York",
                    Street = "Basement",
                    HomeAddress = "12/4",
                },

                new Country3
                {
                    Id = 8,
                    Area = 124.54,
                    City = "London",
                    Street = "Stryis'ka",
                    HomeAddress = "25",
                },

                new Country3
                {
                    Id = 14,
                    Area = 67454.7864,
                    City = "Chop",
                    Street = "Siajvo",
                    HomeAddress = "122",
                },

                new Country3
                {
                    Id = 5,
                    Area = 21435.676,
                    City = "Drohobych",
                    Street = "Lucas",
                    HomeAddress = "12",
                },

                new Country3
                {
                    Id = 11,
                    Area = 124.54,
                    City = "Amsterdam",
                    Street = "Siajvo",
                    HomeAddress = "2/83",
                },

                new Country3
                {
                    Id = 11,
                    Area = 738.783,
                    City = "Berlin",
                    Street = "I. Franka",
                    HomeAddress = "232",
                },

                new Country3
                {
                    Id = 3,
                    Area = 738.783,
                    City = "Pekin",
                    Street = "Lesi Ukrainku",
                    HomeAddress = "452/23",
                },

                new Country3
                {
                    Id = 4,
                    Area = 3246.6757,
                    City = "Berlin",
                    Street = "Lesi Ukrainku",
                    HomeAddress = "13"
                }
                }
                ;
            }
        }
    }

    internal class MyApplication3
    {
        static void Main()
        {
            var model = new Model3();

            var list = new List<Country3>(model.CountryList).GroupBy(m => m.Id, o => o.City).All(g =>
            {
                new List<Country3>(model.CountryList).ForEach(a => Console.WriteLine(a.Id + " \t" + a.City));
                return true;
            });

        }
    }
}