using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.UI.ViewModel
{
    public class MapItemViewModel : ViewModelBase
    {

        private string _build;
        public string build
        {
            get
            {
                return _build;
            }
            set
            {
                _build = value;
                OnPropertyChanged("build");
            }
        }

        private int _x;
        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                OnPropertyChanged("x");
            }
        }

        private int _y;
        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                OnPropertyChanged("y");
            }
        }
    }
}
