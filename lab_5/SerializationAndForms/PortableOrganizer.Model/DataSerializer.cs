using PortableOrganizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PortableOrganizer
{
    public class DataSerializer
    {

        public static void SerializeData(string fileName, DataModel data)
        {
            //Create an instance of the type and serializa it.
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }

        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new DataContractSerializer(typeof(DataModel));
            return (DataModel)formatter.ReadObject(s);
        }

    }

}
