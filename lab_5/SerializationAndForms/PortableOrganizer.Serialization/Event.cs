using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    //[Serializable]
    [DataContract]
    public class Event
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

    }

}
