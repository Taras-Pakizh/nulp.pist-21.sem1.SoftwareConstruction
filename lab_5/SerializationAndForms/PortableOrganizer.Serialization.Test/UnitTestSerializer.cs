using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization;
using System.Collections.Generic;

namespace PortableOrganizer.Serialization.Test
{
    [TestClass]
    public class UnitTestSerializer
    {

        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Events = new List<Event>() { new Event() { Name = "День народження Василя", Date = new DateTime(1980, 10, 13) } };
            model.Projects = new List<Project> { new Project() { Name = "Підготовка ВІС" } };
            model.Tasks = new List<Task> { new Task() { Name = "Підготовка лабораторної" }, new Task() { Name = "Hello world" } };
            DataSerializer.SerializeData(@"C:\MyProject\nulp.pist-21.sem1.SoftwareConstruction\lab_5\out\organizer.dat", model);
        }

        [TestMethod]
        public void TestMethodDeSerialize()
        {
            var model = DataSerializer.DeserializeItem(@"C:\MyProject\nulp.pist-21.sem1.SoftwareConstruction\lab_5\out\organizer.dat");
        }

    }

}
