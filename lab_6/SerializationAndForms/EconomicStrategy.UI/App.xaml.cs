using EconomicStrategy.Model;
using EconomicStrategy.UI.ViewModel;
using EconomicStrategy.UI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EconomicStrategy.UI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        private MainWindowDataModel model;

        public App()
        {
            model = MainWindowDataModel.Load();
            var window = new MainWindow(model) { DataContext = model };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }

    }
}
