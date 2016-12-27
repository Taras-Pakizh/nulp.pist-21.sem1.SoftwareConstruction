using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Prices
    {
        //вартість
        public static Dictionary<String, ResourceList[]> costMap = new Dictionary<String, ResourceList[]>();
        //прибуток
        public static Dictionary<String, ResourceList[]> priceMap = new Dictionary<String, ResourceList[]>();

        static Prices()
        {
            costMap.Add(ReliefType.Tree.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });
            costMap.Add(ReliefType.River.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });
            costMap.Add(ReliefType.Mountain.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });
            costMap.Add(ReliefType.Swamp.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });
            costMap.Add(ReliefType.Sand.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }) });

            costMap.Add(BuildType.Forester.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Warehouse.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 0) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.House.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Sawmill.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Market.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Fisherman.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Hunter.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Mine.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Farmer.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });
            costMap.Add(BuildType.Bakery.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 30) }) });

            priceMap.Add(BuildType.Forester.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Wood, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.Wood, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Wood, 30) })});
            priceMap.Add(BuildType.Warehouse.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 150) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 200) })});
            priceMap.Add(BuildType.House.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.People, 5) }), new ResourceList(new Resource[] { new Resource(ResourceType.People, 10) }), new ResourceList(new Resource[] { new Resource(ResourceType.People, 20) })});
            priceMap.Add(BuildType.Sawmill.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Board, 70) }), new ResourceList(new Resource[] { new Resource(ResourceType.Board, 140) }), new ResourceList(new Resource[] { new Resource(ResourceType.Board, 200) })});
            priceMap.Add(BuildType.Market.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Money, 100) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 200) }), new ResourceList(new Resource[] { new Resource(ResourceType.Money, 500) })});
            priceMap.Add(BuildType.Fisherman.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Fish, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Fish, 40) }), new ResourceList(new Resource[] { new Resource(ResourceType.Fish, 60) })});
            priceMap.Add(BuildType.Hunter.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Meat, 25) }), new ResourceList(new Resource[] { new Resource(ResourceType.Meat, 60) }), new ResourceList(new Resource[] { new Resource(ResourceType.Meat, 100) })});
            priceMap.Add(BuildType.Mine.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Stone, 40) }), new ResourceList(new Resource[] { new Resource(ResourceType.Stone, 55) }), new ResourceList(new Resource[] { new Resource(ResourceType.Stone, 70) })});
            priceMap.Add(BuildType.Farmer.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Grain, 50) }), new ResourceList(new Resource[] { new Resource(ResourceType.Grain, 100) }), new ResourceList(new Resource[] { new Resource(ResourceType.Grain, 150) })});
            priceMap.Add(BuildType.Bakery.getName(), new ResourceList[] { new ResourceList(new Resource[] { new Resource(ResourceType.Bread, 20) }), new ResourceList(new Resource[] { new Resource(ResourceType.Bread, 40) }), new ResourceList(new Resource[] { new Resource(ResourceType.Bread, 60) })});
        }

        public Prices()
        {

        }

    }
}
