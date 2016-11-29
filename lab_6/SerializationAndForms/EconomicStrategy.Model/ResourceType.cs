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

        public static List<ResourceType> VALUES = new List<ResourceType>() {
            Money, Wood
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
