using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.UI.ViewModel
{
    public class DataViewModel : ViewModelBase
    {
        
        private ObservableCollection<ResourceItemViewModel> _resources;
        public ObservableCollection<ResourceItemViewModel> resources
        {
            get
            {
                return _resources;
            }
            set
            {
                _resources = value;
                OnPropertyChanged("resources");
            }
        }

        private ObservableCollection<string> _builds;
        public ObservableCollection<string> builds
        {
            get
            {
                return _builds;
            }
            set
            {
                _builds = value;
                OnPropertyChanged("builds");
            }
        }

        private ObservableCollection<MapItemViewModel> _map;
        public ObservableCollection<MapItemViewModel> map
        {
            get
            {
                return _map;
            }
            set
            {
                _map = value;
                OnPropertyChanged("map");
            }
        }

    }
}
