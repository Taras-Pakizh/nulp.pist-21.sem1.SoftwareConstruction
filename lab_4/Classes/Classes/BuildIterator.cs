using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BuildIterator : IteratorAdapter
    {

        MapObjectIterator iterator;

        public BuildIterator(MapObject[][] map) : base(map)
        {
            this.iterator = new MapObjectIterator(map);
        }
        
        public override bool hasNext()
        {
            if (iterator.peek() is Build) {
                return true;
            }
            while (iterator.hasNext())
            {
                if (iterator.next() is Build) {
                    iterator.preview();
                    return true;
                }
            }
            return false;
        }
        
        public override MapObject next()
        {
            hasNext();
            return iterator.next();
        }
        
        public override MapObject preview()
        {
            return iterator.preview();
        }
        
        public override MapObject peek()
        {
            return iterator.peek();
        }

    }
}
