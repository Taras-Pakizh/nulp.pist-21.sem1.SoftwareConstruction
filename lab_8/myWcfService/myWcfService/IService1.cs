using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace myWcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Author1> ShowAuthors();

        [OperationContract]
        void DeleteAuthor(int i);

        [OperationContract]
        void InsertAuthor(string Surname, string Name, string SecondName);

        [OperationContract]
        void UpdateAuthor(int ID_Author_Author, string Surname, string Name, string SecondName);
    }

    [DataContract]
    public class Author1
    {
        [DataMember]
        public int ID_Author;
        [DataMember]
        public string Surname;
        [DataMember]
        public string Name;
        [DataMember]
        public string SecondName;

        public Author1(int ID_Author, string Surname, string Name, string SecondName)
        {
            this.ID_Author = ID_Author;
            this.Surname = Surname;
            this.Name = Name;
            this.SecondName = SecondName;
        }
    }
}
