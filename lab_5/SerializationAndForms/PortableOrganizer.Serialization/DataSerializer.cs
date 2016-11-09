using Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class DataSerializer
    {

        public static void SerializeData(string fileName, DataModel data)
        {
            //Create an instance of the type and serializa it.
            var formatter = new BinaryFormatter();
            var s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, data);
            s.Close();
        }

        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (DataModel)formatter.Deserialize(s);
        }

    }

}
