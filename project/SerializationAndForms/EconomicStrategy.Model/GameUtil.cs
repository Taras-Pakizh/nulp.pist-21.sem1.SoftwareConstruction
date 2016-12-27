using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public static class GameUtil
    {

        public static string getResources(this Game game)
        {
            return game.getResourceList().ToString();
        }

        public static string getSortedResources(this Game game)
        {
            Dictionary<ResourceType, Resource> resourceMap = game.getResourceList().resourceMap;
            resourceMap.ToList().Sort((entry1, entry2) => String.Compare(entry1.Key.ToString(), entry2.Key.ToString()));
            StringBuilder str = new StringBuilder("ResourceList {\n");
            resourceMap.Keys.Select(key => new { text = "\t" + resourceMap[key] + "\n" }).ToList().ForEach(resource => str.Append(resource.text));
            str.Append("}");
            return str.ToString();
        }

        public static string getMap(this Game game)
        {
            return game.getMap().ToString();
        }

        public static SortedList<String, MapObject> getMapAsSortedList(this Game game)
        {
            var map = game.getMap();
            var result = new SortedList<String, MapObject>();
            for (int i = 0; i < map.width; i++)
            {
                for (int j = 0; j < map.height; j++)
                {
                    result.Add(map.get(i, j).ToString(), map.get(i,j));
                }
            }
            return result;
        }

        public static Queue<MapObject> getMapAsQueue(this Game game)
        {
            var map = game.getMap();
            var result = new Queue<MapObject>();
            for (int i = 0; i < map.width; i++)
            {
                for (int j = 0; j < map.height; j++)
                {
                    result.Enqueue(map.get(i, j));
                }
            }
            return result;
        }

        public static List<MapObject> getSortedMap(this Game game)
        {
            var map = game.getMap();
            var result = new List<MapObject>();
            for (int i = 0; i < map.width; i++)
            {
                for (int j = 0; j < map.height; j++)
                {
                    result.Add(map.get(i, j));
                }
            }
            result.Sort((MapObject a, MapObject b) =>
            {
                if (a.ToString().Length > b.ToString().Length)
                {
                    return 1;
                } else if (a.ToString().Length < b.ToString().Length)
                {
                    return -1;
                }
                return a.ToString()[0] >= b.ToString()[0] ? 1 : -1;
            });
            return result;
        }

        public static void getMapSize(this Game game, out Double[] size)
        {
            size = new Double[] { game.getMap().width, game.getMap().height };
        }

        public static void getMapSize(this Game game, out Int32[] size)
        {
            size = new Int32[] { game.getMap().width, game.getMap().height };
        }

        public static void setMapSize(this Game game, ref Double width, ref Double height)
        {
            game.getMap().width = (Int32) width;
            game.getMap().height = (Int32) height;
        }


        enum MapObjectType
        {
            Tree = 0, Forester = 1, Warehouse = 2
        }

        public static string get()
        {
            MapObjectType type = MapObjectType.Forester;
            type = MapObjectType.Tree | MapObjectType.Warehouse;
            return type.ToString();
        }

    }

}
