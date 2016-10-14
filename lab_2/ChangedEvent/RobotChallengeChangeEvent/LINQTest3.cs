using System;
using System.Collections.Generic;
using System.Linq;
namespace cmdTestQuestions
{
    public class Student
    {
        public Int32 Id;
        public String LastName;
        public Int32 YearOfStudy;
        public String Group;
    }

    public class Model2
    {
        public List<Student> StudentList
        {
            get
            {
                return new List<Student>
                {
                    new Student
                    {
                        Id = 1, LastName = "Sokolov", YearOfStudy = 3, Group = "PI-35",
                    },

                    new Student
                    {
                        Id = 20, LastName = "Danylo", YearOfStudy = 2, Group = "PI-34",
                    },

                    new Student
                    {
                        Id = 2, LastName = "Danylo", YearOfStudy = 5, Group = "PI-31",
                    },

                    new Student
                    {
                        Id = 4, LastName = "Sokolov", YearOfStudy = 1, Group = "PI-34",
                    },

                    new Student
                    {
                        Id = 19, LastName = "Varanytsia", YearOfStudy = 5, Group = "PI-33",
                    },

                    new Student
                    {
                        Id = 17, LastName = "Blidyi", YearOfStudy = 4, Group = "PI-33",
                    },

                    new Student
                    {
                        Id = 4, LastName = "Varanytsia", YearOfStudy = 5, Group = "PI-31",
                    },

                    new Student
                    {
                        Id = 4, LastName = "Havran", YearOfStudy = 4, Group = "KI-31",
                    },

                    new Student
                    {
                        Id = 2, LastName = "Boiko", YearOfStudy = 1, Group = "ZI-31",
                    },

                    new Student
                    {
                        Id = 8, LastName = "Sekretariuk", YearOfStudy = 1, Group = "PI-33"
                    }
                };
            }
        }
    }

    internal class MyApplication2
    {
        static void Main()
        {
            var model = new Model2();
            var list = new List<Student>(model.StudentList).Where(m => m.LastName == "Havran");
            foreach (var el in list)
            {
                Console.WriteLine("{0, -15}	{1, -15}	{2, -15}	{3, -15}", el.Id, el.LastName, el.YearOfStudy, el.Group);
            }
        }
    }
}