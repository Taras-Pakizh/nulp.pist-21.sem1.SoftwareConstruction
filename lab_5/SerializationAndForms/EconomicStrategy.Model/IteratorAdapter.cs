using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public abstract class IteratorAdapter : Iterator
    {

        public IteratorAdapter(MapObject[][] map)
        {

        }
        public abstract bool hasNext();

        public abstract MapObject next();

        public virtual MapObject peek()
        {
            throw new NotImplementedException();
        }

        public virtual MapObject preview()
        {
            throw new NotImplementedException();
        }
    }
}
