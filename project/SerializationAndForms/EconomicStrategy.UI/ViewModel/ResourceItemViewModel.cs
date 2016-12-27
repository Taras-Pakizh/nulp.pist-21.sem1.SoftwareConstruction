using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.UI.ViewModel
{
    public class ResourceItemViewModel : ViewModelBase
    {

        private string _resource;
        public string resource
        {
            get
            {
                return _resource;
            }
            set
            {
                _resource = value;
                OnPropertyChanged("resource");
            }
        }

        private int _count;
        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                OnPropertyChanged("count");
            }
        }
    }
}
