using EconomicStrategy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EconomicStrategy.UI
{

    [DataContract]
    public class MainWindowDataModel
    {

        public static string DataPath = "economic_strategy.dat";

        public static ICommand saveCommand = new Command(Save);

        private static void Save(object obj)
        {
            (obj as MainWindowDataModel).Save();
        }

        public static MainWindowDataModel Load()
        {
            if (File.Exists(DataPath))
            {
                MainWindowDataModel model = DataSerializer.DeserializeItem(DataPath);
                ResourceList list = new ResourceList();
                model.resources.ForEach(r => list.add(new Resource(ResourceType.VALUES.Where(type => type.getName() == r.resource).First(), r.count)));
                Map map = new Map(10, 10);
                model.map.ForEach(item => {
                    MapEnum menum = null;
                    MapObject mobj = null;
                    try
                    {
                        menum = BuildType.VALUES.Where(type => type.getName() == item.build).First();
                        if (menum != null)
                        {
                            mobj = new Build((BuildType)menum);
                            if (item.sleep) mobj.sleep();
                            if (item.recondition) mobj.recondition();
                        }
                    } catch (Exception) { }
                    try {
                        menum = ReliefType.VALUES.Where(type => type.getName() == item.build).First();
                        if (menum != null)
                        {
                            mobj = new Relief((ReliefType)menum);
                        }
                    } catch (Exception) { }
                    
                    if (mobj != null) {
                        map.set(mobj, item.x, item.y);
                    }
                });
                model.game = new Game(map, list);
                return model;
            }
            return new MainWindowDataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

        public MainWindowDataModel()
        {
            resources = new List<ResourceItem>();
            builds = new List<String>();
            map = new List<MapItem>();
            game = new Game(new Map(10, 10));
            step = 1;
        }

        [DataMember]
        public List<ResourceItem> resources { get; set; }

        [DataMember]
        public List<String> builds { get; set; }

        [DataMember]
        public List<MapItem> map { get; set; }

        [DataMember]
        public int step { get; set; }

        public Game game { get; set; }

    }

    [DataContract]
    public class ResourceItem
    {

        [DataMember]
        public String resource { get; set; }

        [DataMember]
        public int count { get; set; }

    }

    [DataContract]
    public class MapItem
    {

        [DataMember]
        public String build { get; set; }

        [DataMember]
        public int level { get; set; }

        [DataMember]
        public bool sleep { get; set; }

        [DataMember]
        public bool recondition { get; set; }

        [DataMember]
        public int x { get; set; }

        [DataMember]
        public int y { get; set; }

    }


}
