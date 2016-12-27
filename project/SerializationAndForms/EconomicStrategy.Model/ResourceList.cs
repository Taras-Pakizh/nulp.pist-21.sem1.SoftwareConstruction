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
            resourceMap.Add(ResourceType.Board, new Resource(ResourceType.Board, 0));
            resourceMap.Add(ResourceType.Bread, new Resource(ResourceType.Bread, 0));
            resourceMap.Add(ResourceType.Fish, new Resource(ResourceType.Fish, 0));
            resourceMap.Add(ResourceType.Grain, new Resource(ResourceType.Grain, 0));
            resourceMap.Add(ResourceType.Meat, new Resource(ResourceType.Meat, 0));
            resourceMap.Add(ResourceType.People, new Resource(ResourceType.People, 0));
            resourceMap.Add(ResourceType.Stone, new Resource(ResourceType.Stone, 0));
            resourceMap.Add(ResourceType.Water, new Resource(ResourceType.Water, 0));
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
