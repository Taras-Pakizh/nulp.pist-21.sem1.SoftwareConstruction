using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Game
    {
        Map map;
        ResourceList resourceList;
        Prices prices;

        public Game(Map map) : this(map, new ResourceList())
        {
        }

        public Game(Map map, ResourceList resourceList)
        {
            this.map = map;
            this.resourceList = resourceList;
            this.prices = new Prices();
        }

        //user step
        public bool create(MapObject obj, int x, int y)
        {
            if (!isCorrectLocation(x, y))
            {
                return false;
            }
            if (map.get(x, y) != null)
            {
                return false;
            }
            var res = Prices.costMap[obj.getType().getName()][0];
            foreach (var type in res.get())
            {
                if (resourceList.get(type).getCount() < res.get(type).getCount())
                {
                    return false;
                }
            }
            foreach (var type in res.get())
            {
                resourceList.get(type).add(-res.get(type).getCount());
            }
            skip();
            map.set(obj, x, y);
            return true;
        }

        //user step
        public bool destroy(int x, int y)
        {
            if (!isCorrectLocation(x, y))
            {
                return false;
            }
            if (map.get(x, y) == null)
            {
                return false;
            }
            map.set(null, x, y);
            skip();
            return true;
        }

        //user step
        public bool upgrade(int x, int y)
        {
            if (!isCorrectLocation(x, y))
            {
                return false;
            }
            MapObject obj = map.get(x, y);
            if (obj == null)
            {
                return false;
            }
            skip();
            var res = obj.upgrade();
            foreach (var type in res.get())
            {
                if (resourceList.get(type).getCount() < res.get(type).getCount())
                {
                    return false;
                }
            }
            foreach (var type in res.get())
            {
                resourceList.get(type).add(-res.get(type).getCount());
            }
            return true;
        }

        //user step
        public bool recondition(int x, int y)
        {
            if (!isCorrectLocation(x, y))
            {
                return false;
            }
            MapObject obj = map.get(x, y);
            if (obj == null)
            {
                return false;
            }
            skip();
            return obj.recondition();
        }

        //user step
        public bool sleep(int x, int y)
        {
            if (!isCorrectLocation(x, y))
            {
                return false;
            }
            MapObject obj = map.get(x, y);
            if (obj == null)
            {
                return false;
            }
            skip();
            return obj.sleep();
        }

        private bool isCorrectLocation(int x, int y)
        {
            try
            {
                map.get(x, y);
            }
            catch (IndexOutOfRangeException ex)
            {
                return false;
            }
            return true;
        }

        //user step
        public void skip()
        {
            Console.WriteLine("skip");
            for (Iterator iterator = map.iteratorBuild(); iterator.hasNext();)
            {
                Build obj = (Build)iterator.next();
                if (!obj.isSleep()) {
                    ResourceList resource = obj.skip();
                    resourceList.add(resource);
                }
            }
        }

        public ResourceList getResourceList()
        {
            return resourceList;
        }

        public Map getMap()
        {
            return map;
        }

    }
}
