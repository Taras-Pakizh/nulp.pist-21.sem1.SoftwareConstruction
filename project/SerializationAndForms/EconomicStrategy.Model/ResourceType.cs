using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class ResourceType
    {

        public static ResourceType Money = new ResourceType("Гроші");
        public static ResourceType Wood = new ResourceType("Деревина");
        public static ResourceType Water = new ResourceType("Вода");
        public static ResourceType Stone = new ResourceType("Камінь");
        public static ResourceType Board = new ResourceType("Дошка");
        public static ResourceType Bread = new ResourceType("Хліб");
        public static ResourceType Grain = new ResourceType("Зерно");
        public static ResourceType Fish = new ResourceType("Риба");
        public static ResourceType Meat = new ResourceType("М'ясо");
        public static ResourceType People = new ResourceType("Люди");

        public static List<ResourceType> VALUES = new List<ResourceType>() {
            Money, Wood, Water, Stone, Board, Bread, Grain, Fish, Meat, People
        };

        String name;

        private ResourceType(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }


    }
}
