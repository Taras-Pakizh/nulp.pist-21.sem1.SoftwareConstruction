using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PortableOrganizer
{

    //[Serializable]
    [DataContract]
    public class DataModel
    {

        [DataMember]
        public IEnumerable<Task> Tasks { get; set; }

        [DataMember]
        public IEnumerable<Project> Projects { get; set; }

        [DataMember]
        public IEnumerable<Event> Events { get; set; }

    }

}
