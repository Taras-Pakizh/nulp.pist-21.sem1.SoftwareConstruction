using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    [Serializable]
    public class DataModel
    {

        public IEnumerable<Task> Tasks { get; set; }

        public IEnumerable<Project> Projects { get; set; }

        public IEnumerable<Event> Events { get; set; }

    }

}
