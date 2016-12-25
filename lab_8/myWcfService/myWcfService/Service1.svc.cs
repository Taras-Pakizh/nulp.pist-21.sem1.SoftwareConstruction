using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace myWcfService
{
    [ServiceBehavior(IgnoreExtensionDataObject = true)]
    public class Service1 : IService1
    {
        private BookShopEntities entities = new BookShopEntities();
        public List<Author1> ShowAuthors()
        {
            var workers = entities.Author.ToList();

            var listofclients = new List<Author1>();
            for (int i = 0; i < workers.Count; i++)
            {
                listofclients.Add(new Author1(workers[i].ID_Author, workers[i].Surname,
                    workers[i].Name, workers[i].SecondName));
            }
            return listofclients;
        }

        public void DeleteAuthor(int i)
        {
            Author cl = (from e1 in entities.Author
                         where e1.ID_Author == i
                         select e1).First();
            entities.Author.Remove(cl);
            entities.SaveChanges();
        }

        public void InsertAuthor(string Surname, string Name, string SecondName)
        {
            var newID_Author = (entities.Author.Select(p => p.ID_Author).Max() + 1);
            var newc = new Author()
            {
                ID_Author = newID_Author,
                Surname = Surname,
                Name = Name,
                SecondName = SecondName
            };
            entities.Author.Add(newc);
            entities.SaveChanges();
        }

        public void UpdateAuthor(int ID_Author, string Surname, string Name, string SecondName)
        {
            var entities = new BookShopEntities();
            int i = ID_Author;
            Author cl = (from e1 in entities.Author
                         where e1.ID_Author == i
                         select e1).First();
            cl.Surname = Surname;
            cl.Name = Name;
            cl.SecondName = SecondName;
            entities.SaveChanges();
        }
    }
}
