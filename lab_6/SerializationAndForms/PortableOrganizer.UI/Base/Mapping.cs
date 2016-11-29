using AutoMapper;
using PortableOrganizer.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableOrganizer.UI.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<TaskViewModel, Task>();
            Mapper.CreateMap<Task, TaskViewModel>();

            Mapper.CreateMap<EventViewModel, Event>();
            Mapper.CreateMap<Event, EventViewModel>();

            Mapper.CreateMap<ProjectViewModel, Project>();
            Mapper.CreateMap<Project, ProjectViewModel>();
        }
    }
}
