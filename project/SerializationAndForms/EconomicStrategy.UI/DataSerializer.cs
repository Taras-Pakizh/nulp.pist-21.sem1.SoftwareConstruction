using EconomicStrategy.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.UI
{
    public class DataSerializer
    {

        public static void SerializeData(string fileName, MainWindowDataModel data)
        {
            //Create an instance of the type and serializa it.
            var formatter = new DataContractSerializer(typeof(MainWindowDataModel));
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }

        public static MainWindowDataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new DataContractSerializer(typeof(MainWindowDataModel));
            return (MainWindowDataModel)formatter.ReadObject(s);
        }

    }

}
