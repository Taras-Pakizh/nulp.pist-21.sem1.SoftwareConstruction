using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Map
    {

        MapObject[][] map;
        public int width;
        public int height;

        public Map(int width, int height)
        {
            map = new MapObject[width][];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = new MapObject[height];
            }
            this.width = width;
            this.height = height;
        }

        public MapObject get(int x, int y)
        {
            return map[x][y];
        }

        public void set(MapObject obj, int x, int y)
        {
            map[x][y] = obj;
        }

        public Iterator iteratorBuild()
        {
            return new BuildIterator(map);
        }
        
        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            map.ToList().ForEach(array => {
                array.ToList().ForEach(obj => str.Append(obj == null ? "[ empty ]\t" : "[ " + obj + " ]\t"));
                str.Append("\n");
            });
            return str.ToString();
        }

        public static explicit operator String(Map map)
        {
            //String s = (String) map;
            return map.ToString();
        }

        public static implicit operator MapObject[][] (Map map)
        {
            //MapObject[][] array = map;
            return map.map;
        }

    }
}
