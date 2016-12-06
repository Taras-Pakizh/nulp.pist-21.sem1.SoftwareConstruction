using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PortableOrganizer.UI.ViewModel
{
    public class DataViewModel : ViewModelBase
    {

        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            CloseTaskCommand = new Command(CloseTask);
        }

        private string _visibleControl = "Tasks";
        public string VisibleControl
        {
            get
            {
                return _visibleControl;
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public ICommand CloseTaskCommand { get; set; }

        public void CloseTask(object args)
        {
            SelectedTask.Status = TaskStatus.Closed;
        }

        private TaskViewModel _selectedTask;

        public TaskViewModel SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                _selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        private ObservableCollection<TaskViewModel> _tasks;
        public ObservableCollection<TaskViewModel> Tasks
        {
            get
            {
                return _tasks;
            }
            set
            {
                _tasks = value;
                OnPropertyChanged("Tasks");
            }
        }

        private ObservableCollection<ProjectViewModel> _projects;
        public ObservableCollection<ProjectViewModel> projects
        {
            get
            {
                return _projects;
            }
            set
            {
                _projects = value;
                OnPropertyChanged("Projects");
            }
        }

        private ObservableCollection<EventViewModel> _events;
        public ObservableCollection<EventViewModel> Events
        {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
                OnPropertyChanged("Events");

            }
        }
    }
}
