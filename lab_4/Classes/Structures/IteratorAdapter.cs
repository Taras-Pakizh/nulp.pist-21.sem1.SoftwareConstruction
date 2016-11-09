using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    struct IteratorAdapter : Iterator
    {

        public IteratorAdapter(MapObject[][] map)
        {

        }
        public abstract bool hasNext();

        public abstract MapObject next();

        public MapObject peek()
        {
            throw new NotImplementedException();
        }

        public MapObject preview()
        {
            throw new NotImplementedException();
        }
    }
}
