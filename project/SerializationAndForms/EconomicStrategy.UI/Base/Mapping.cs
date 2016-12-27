using AutoMapper;
using EconomicStrategy.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.UI.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<MapItem, MapItemViewModel>();
            Mapper.CreateMap<MapItemViewModel, MapItem>();

            Mapper.CreateMap<ResourceItem, ResourceItemViewModel>();
            Mapper.CreateMap<ResourceItemViewModel, ResourceItem>();

            Mapper.CreateMap<MainWindowDataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, MainWindowDataModel>();

        }

    }
}
