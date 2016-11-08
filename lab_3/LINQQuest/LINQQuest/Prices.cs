using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    class Prices
    {
        //вартість
        //TODO: вартість має бути не в Resources.Groshi
        public static Dictionary<String, int[]> costMap = new Dictionary<String, int[]>();
        //прибуток
        public static Dictionary<String, ResourceList[]> priceMap = new Dictionary<String, ResourceList[]>();

        static Prices()
        {
            costMap.Add(ReliefType.Tree.getName(), new int[100]);
            priceMap.Add(ReliefType.Tree.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Wood, 10) }) });

            costMap.Add(BuildType.Forester.getName(), new int[] { 10 });
            costMap.Add(BuildType.Warehouse.getName(), new int[] { 0 });
            priceMap.Add(BuildType.Forester.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Wood, 10) }) });
            priceMap.Add(BuildType.Warehouse.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });
        }

        public Prices()
        {

        }

    }
}
