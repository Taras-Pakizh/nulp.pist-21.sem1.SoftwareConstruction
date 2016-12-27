using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Resource
    {

        ResourceType resourceType;
        int count;

        public Resource(ResourceType resourceType, int count)
        {
            this.resourceType = resourceType;
            this.count = count;
        }

        public ResourceType getResourceType()
        {
            return resourceType;
        }

        public int getCount()
        {
            return count;
        }

        public void add(int count)
        {
            this.count += count;
        }

        //TODO: можливо можна видалити
        public bool add(Resource resource)
        {
            if (this.resourceType.Equals(resource.resourceType))
            {
                this.count += resource.count;
                return true;
            }
            return false;
        }
        
        public override String ToString()
        {
            return resourceType.getName() + " : " + count;
        }

    }
}
