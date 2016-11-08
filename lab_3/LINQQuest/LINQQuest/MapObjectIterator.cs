using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    class MapObjectIterator : IteratorAdapter
    {

        MapIterator iterator;

        public MapObjectIterator(MapObject[][] map) : base(map)
        {
            this.iterator = new MapIterator(map);
        }
        
        public override bool hasNext()
        {
            if (iterator.peek() != null)
            {
                return true;
            }
            while (iterator.hasNext())
            {
                if (iterator.next() != null)
                {
                    iterator.preview();
                    return true;
                }
            }
            return false;
        }

        public override MapObject next()
        {
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
