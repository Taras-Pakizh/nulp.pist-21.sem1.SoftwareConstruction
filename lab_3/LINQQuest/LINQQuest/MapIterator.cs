using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    class MapIterator : IteratorAdapter
    {
        MapObject[][] map;
        int currentX;
        int currentY;

        public MapIterator(MapObject[][] map) : base(map)
        {
            this.map = map;
            currentX = 0;
            currentY = 0;
        }

        public override bool hasNext()
        {
            return (currentY < map[0].Length);
        }

        public override MapObject next()
        {
            MapObject obj;
            try
            {
                obj = map[currentX][currentY];
            }
            catch (Exception ex)
            {
                //ex.printStackTrace();
                return null;
            }
            if (currentX == map.Length - 1)
            {
                currentX = 0;
                currentY++;
            }
            else
            {
                currentX++;
            }
            return obj;
        }

        public override MapObject preview()
        {
            if (currentX == 0)
            {
                currentX = map.Length - 1;
                currentY--;
            }
            else
            {
                currentX--;
            }
            if (currentY < 0)
            {
                return null;
            }
            MapObject obj;
            try
            {
                obj = map[currentX][currentY];
            }
            catch (Exception ex)
            {
                //ex.printStackTrace();
                return null;
            }
            return obj;
        }

        public override MapObject peek()
        {
            try
            {
                return map[currentX][currentY];
            }
            catch (IndexOutOfRangeException ex)
            {
                return null;
            }
        }

    }
}
