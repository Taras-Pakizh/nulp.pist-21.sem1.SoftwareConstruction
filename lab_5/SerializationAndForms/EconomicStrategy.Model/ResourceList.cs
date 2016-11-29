using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class ResourceList
    {

        //delete public
        public Dictionary<ResourceType, Resource> resourceMap;

        public ResourceList()
        {
            resourceMap = new Dictionary<ResourceType, Resource>();
            resourceMap.Add(ResourceType.Wood, new Resource(ResourceType.Wood, 0));
            resourceMap.Add(ResourceType.Money, new Resource(ResourceType.Money, 0));
        }

        public ResourceList(Resource[] resource) : this()
        {
            foreach (Resource r in resource)
            {
                add(r);
            }
        }

        public void add(Resource resource)
        {
            resourceMap[resource.getResourceType()].add(resource);
        }

        public void add(ResourceList resource)
        {
            Dictionary< ResourceType, Resource > otherResourceMap = resource.resourceMap;
            otherResourceMap.Keys.Where(res => res != null).ToList().ForEach(res => add(otherResourceMap[res]));
        }

        public IEnumerable<ResourceType> get()
        {
            return resourceMap.Keys;
        }

        public Resource get(ResourceType resourceType)
        {
            return resourceMap[resourceType];
        }
        
        public override String ToString()
        {
            StringBuilder str = new StringBuilder("ResourceList {\n");
            resourceMap.Keys.Select(key => new {text = "\t" + resourceMap[key] + "\n" }).ToList().ForEach(resource => str.Append(resource.text));
            str.Append("}");
            return str.ToString();
        }

    }
}
