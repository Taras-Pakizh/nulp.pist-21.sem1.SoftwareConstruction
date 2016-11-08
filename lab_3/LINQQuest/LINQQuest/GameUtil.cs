using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    static class GameUtil
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
