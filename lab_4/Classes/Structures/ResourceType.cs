using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    struct ResourceType
    {

        public static ResourceType Money = new ResourceType("Гроші");
        public static ResourceType Wood = new ResourceType("Деревина");

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
